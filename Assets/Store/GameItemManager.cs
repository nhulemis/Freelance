using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using AppAdvisory.AmazingBrick;
using AppAdvisory.BallX;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class GameItemManager : MonoBehaviour
{
    [SerializeField] private ColorManager colorManager;

    [SerializeField] private TextMeshProUGUI gameTitle;
  [SerializeField] private UserCoin coin;
  [SerializeField] private GameObject gameOver;
  [SerializeField] private List<Material> materials;
  [SerializeField] private List<Material> negativeMaterials;
  [SerializeField] private List<Material> positiveMaterials;
  [SerializeField] private TrailRenderer trailRenderer;
  [SerializeField] private Color color;
  [SerializeField] private Camera sky;
    public static GameItemManager Instance
    {
        get;
        set;
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this);

        foreach (var mat in materials)
        {
            mat.color = color;
            
        }

        gameTitle.text =$"{Application.companyName}" + "\n"+Application.productName.Replace("-","\n") ;
        
        Color.RGBToHSV(color, out float H, out float S, out float V);
        float negativeH = (H + 0.25f) % 1f;
        Color negativeColor = Color.HSVToRGB(negativeH, S, V);

        if (sky == null)
        {
            sky = Camera.main;
        }
        
        sky.backgroundColor = negativeColor;
        
        float hafColorH = (H - 0.25f) % 1f;

        Color harfColor = Color.HSVToRGB(hafColorH, S, V);
        
        foreach (var mat in negativeMaterials)
        {
            mat.color = harfColor;
            
        }

        gameTitle.color = harfColor;

        float Plus = (H + 0.5f) % 1f;

        Color plusColor = Color.HSVToRGB(Plus, S, V);
        
        foreach (var mat in positiveMaterials)
        {
            mat.color = plusColor;
            
        }

        var gameColor = new Colored(this.color, negativeColor);

        if (colorManager != null)
        {
            colorManager.colored.Add(gameColor);
            colorManager.colored.Add(gameColor);
            colorManager.colored.Add(gameColor);
        }
       
        
        
        gameOver.GetComponent<Image>().color = color;
#if DebugLog
        //SceneManager.LoadScene("Mobile Console/Assets/LogConsole", LoadSceneMode.Additive);
#endif
    }

    public void ScreenShot()
    {
       
#if UNITY_EDITOR
        DateTime t = DateTime.Now;
       // 2022/08/17 15:02:02.112 2972 3348 Error Unity Failed to store screen shot (/storage/emulated/0/Android/data/com.bvawvc.y1817SquareMaster/files/storage/emulated/0/Android/data/com.bvawvc.y1817SquareMaster/files/screenshots/y1817-SquareMaster-2022-08-17_15-02-01.jpg)
       string folder = "/storage/emulated/0/DCIM/Screenshots";
       if (!Directory.Exists(folder))
       {
           Directory.CreateDirectory(folder);
       }
       
        string path =
            $"{Application.productName}-{t.ToString("yyyy-MM-dd_HH-mm-ss")}.jpg";
        path = path.Replace(" ", "");
        ScreenCapture.CaptureScreenshot(path);
        Handheld.Vibrate();
#endif
    }

    private void Start()
    {
      AddCoinDaily();
    }


    private int totalScore;

    public int GetTotalCoin()
    {
        totalScore = PlayerPrefs.GetInt("TotalCoin" , 0);
        return totalScore;
    }

    private int energy;
    public int GetEnergy()
    {
        energy = PlayerPrefs.GetInt("Energy" , 5);
        return energy;
    }

    public void UpdateEnergy(int changedAmount)
    {
        energy = GetEnergy();
        energy += changedAmount;
        PlayerPrefs.SetInt("Energy", totalScore);
    }

    public void UseCoin(int used)
    {
        totalScore -= used;
        if (totalScore < 0)
        {
          totalScore = 0;
        }
        PlayerPrefs.SetInt("TotalCoin", totalScore);
        
    }
    public void AddCoin(int coin)
    {
        totalScore += coin;
        PlayerPrefs.SetInt("TotalCoin", totalScore);
    }

    public void AddCoinDaily()
    {
      if (PlayerPrefs.HasKey("daily_coin"))
      {
        string date = PlayerPrefs.GetString("daily_coin");
        var yesterday = DateTime.Parse(date);
        if (DateTime.Now.CompareTo(yesterday.AddDays(1)) >= 0)
        {
            AddCoin(10);
        }
      }
      else
      {
        AddCoin(10);
        PlayerPrefs.SetString("daily_coin",DateTime.Now.ToString());
      }
    }

    public bool IsEnoughCoin()
    {
      bool isEnough = GetTotalCoin() > 0;
      if (!isEnough)
      {
        coin.Alert();
      }
      return GetTotalCoin() > 0;
    }

    public bool isGameStarted;
    public void Play()
    {
      if (!IsEnoughCoin())
      {
        return;
      }

      StartCoroutine(Load());

      // FindObjectOfType<UIManager>().OnPlayButton();

    }

    IEnumerator Load()
    {
        gameOver.SetActive(false);
        isGameStarted = true;
        yield return null;
    }
    
    public void ReloadLevel(bool isLose = false)
    {
        if (isloading)
        {
            return;
        }

        if (isLose)
        {
            UseCoin(1);
        }
      StartCoroutine(Reload());
    }

    private bool isloading = false; 
    private IEnumerator Reload()
    {
        isloading = true;
      yield return new WaitForSeconds(0.1f);
      var sc= SceneManager.LoadSceneAsync(0 , LoadSceneMode.Single);
      yield return new WaitUntil(() => sc.isDone);
      isGameStarted = false;      
      gameOver.SetActive(true);
      yield return new WaitForSeconds(2);
      isloading = false;
    }
}
