using System;
using System.Collections;
using AppAdvisory.BallX;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

public class GameItemManager : MonoBehaviour
{

  [SerializeField] private UserCoin coin;
  [SerializeField] private GameObject gameOver;
    public static GameItemManager Instance
    {
        get;
        set;
    }

    private void Awake()
    {
        Object.DontDestroyOnLoad(this);
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            UnityEngine.Object.Destroy(base.gameObject);
        }

#if DebugLog
      //SceneManager.LoadScene("Mobile Console/Assets/LogConsole", LoadSceneMode.Additive);
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
        
        gameOver.SetActive(true);
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
    public bool Play()
    {
      if (!IsEnoughCoin())
      {
        return false;
      }
      gameOver.SetActive(false);
      isGameStarted = true;
      return true;
      // FindObjectOfType<UIManager>().OnPlayButton();

    }

    public void ReloadLevel()
    {
      
      UseCoin(1);
      

      StartCoroutine(Reload());
    }

    private IEnumerator Reload()
    {
      yield return new WaitForSeconds(0.1f);
      SceneManager.LoadScene(0);
      isGameStarted = false;      
      gameOver.SetActive(true);

    }
}
