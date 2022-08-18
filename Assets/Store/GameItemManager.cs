using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using AppAdvisory.AmazingBrick;
using AppAdvisory.BallX;
using Sirenix.OdinInspector;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Color = UnityEngine.Color;
using Image = UnityEngine.UI.Image;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class GameItemManager : MonoBehaviour
{
    [SerializeField] private ColorManager colorManager;

    [SerializeField] private TextMeshProUGUI gameTitle;
    [SerializeField] private UserCoin coin;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private List<Material> materials;
    [SerializeField] private List<Material> negativeMaterials;
    [SerializeField] private List<Material> positiveMaterials;
    [SerializeField] private List<SpriteRenderer> sprites;
    [SerializeField] private List<Image> uiSprite;
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] private Color color;
    [SerializeField] private Camera sky;
    [Range(-1,1)]
    [SerializeField] private float colorDelta;
    public static GameItemManager Instance { get; set; }

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

        gameTitle.text = $"{Application.companyName}" + Application.productName.Replace("-", "\n");

        Color.RGBToHSV(color, out float H, out float S, out float V);
        float negativeH = (H + colorDelta) % 1f;
        Color negativeColor = Color.HSVToRGB(negativeH, S, V);

        if (sky == null)
        {
            sky = Camera.main;
        }

        sky.backgroundColor = color;

        float hafColorH = (H - colorDelta) % 1f;

        Color harfColor = Color.HSVToRGB(hafColorH, S, V);

        foreach (var mat in negativeMaterials)
        {
            mat.color = harfColor;
        }

        gameTitle.color = harfColor;

        float Plus = (H + 0.25f) % 1f;

        Color plusColor = Color.HSVToRGB(Plus, S, V);

        foreach (var mat in positiveMaterials)
        {
            mat.color = plusColor;
        }
        foreach (var mat in sprites)
        {
            mat.color = color;
        }
        foreach (var mat in uiSprite)
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
        DateTime t = DateTime.Now;
        //storage/emulated/0/Android/data/com.bvawvc.y1817SquareMaster/files/storage/emulated/0/Android/data/com.bvawvc.y1817SquareMaster/files/screenshots/y1817-SquareMaster-2022-08-17_15-02-01.jpg)
        string folder = "Assets/../ScreenShots";
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }

        //Debug.Log( Directory.GetDirectories(folder) );
        string path =
            $"{folder}/{Application.productName}-{t.ToString("yyyy-MM-dd_HH-mm-ss")}.jpg";
        path = path.Replace(" ", "");
        ScreenCapture.CaptureScreenshot(path);
        Handheld.Vibrate();
    }

    public static Texture2D resizeImage(string filename)
    {
        //string filename = "Assets/Resources/Heightmaps/filename.png";
        var rawData = System.IO.File.ReadAllBytes(filename);
        Texture2D tex = new Texture2D(500, 500); // Create an empty Texture; size doesn't matter (she said)
        tex.LoadImage(rawData);

        var startX = Random.Range(0, tex.width - 1000);
        var startY = Random.Range(0, tex.height - 1000);


        Color[] c = tex.GetPixels(startX, startY, 1000, 1000);
        Texture2D m2Texture = new Texture2D(1000, 1000);
        m2Texture.SetPixels(c);
        m2Texture.Apply();
        return m2Texture;
    }

    [Button]
    public void AutoInsertCode()
    {
        string classTemplate = @"
        public class CLASSTEMPLATE
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}
";
        int claL = Random.Range(10, 35);

        string className = RandomString(claL);

        classTemplate = classTemplate.Replace("CLASSTEMPLATE", className);

        var file = Directory.GetFiles(Application.dataPath, "*.cs", SearchOption.AllDirectories).ToList();

        file = file.Where(x => !x.Contains("Assets/Scripts") && !x.Contains("Assets/Store")   && !x.Contains("Plugin")  && !x.Contains("Mobile Console")  ).ToList();
        Debug.Log(file.Count);
        int cout = 0;
        while (cout < claL)
        {
            int i = Random.Range(0, file.Count);
            string fileInput = File.ReadAllText(file[i]);
            var x = fileInput.IndexOf("  private");

            var classexist = fileInput.Contains(className);
            
            if (x > 0 && !classexist)
            {
                var output = fileInput.Insert(x - 1, classTemplate);
                File.WriteAllText(file[i], output);
                Debug.Log(file[i]);
                cout++;
            }
        }
#if UNITY_EDITOR

        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
#endif
        Debug.Log("auto insert code done");
    }

    private System.Random random = new System.Random();

    public string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    [Button]
    public void TakeAppIcon()
    {
        string screenshotFolder = Path.Combine(Application.dataPath, "../ScreenShots");
        var image = Directory.GetFiles(screenshotFolder).ToList();
        image = image.Where(x => x.Contains(Application.productName.Replace(" ", ""))).ToList();
        if (image.Count > 0)
        {
            var random = Random.Range(0, image.Count);

            string path = image[random];
            var texture2D = resizeImage(path);


            byte[] bytes = texture2D.EncodeToPNG();
            var dirPath = Application.dataPath + "/Sprites/";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            string file = Path.Combine(dirPath, "app_icon.png");
            File.WriteAllBytes(file, bytes);
            File.Copy(file, screenshotFolder, true);
            Debug.Log("done");
#if UNITY_EDITOR
            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();

#endif
        }
    }

    [Space] [SerializeField] private string drivePath = "";

    [Button]
    public void CopyToDrive()
    {

        Debug.Log(drivePath);
        string[] appIndex = Application.productName.Split('-');
        string dayPath = Path.Combine(drivePath, appIndex[1].Split(' ')[1]);
        string appPath = Path.Combine(dayPath, appIndex[2]);
        string indexPath = Path.Combine(appPath, appIndex[1].Split(' ')[0]);

        string appName = Application.productName.Split('-')[1].Split(" ")[0];
        if (!Directory.Exists(dayPath))
        {
            Directory.CreateDirectory(dayPath);
        }


        if (!Directory.Exists(appPath))
        {
            Directory.CreateDirectory(appPath);
        }


        if (!Directory.Exists(indexPath))
        {
            Directory.CreateDirectory(indexPath);
        }

        string screenshotFolder = Application.dataPath + "/../ScreenShots/";
        var fileTocopy = Directory.GetFiles(screenshotFolder);
        foreach (var file in fileTocopy)
        {
            if (file.Contains("app_icon") || file.Contains(Application.productName.Replace(" ", ""))
                || file.Contains($"{appName}.aab") || file.Contains($"{appName}.apk"))
            {
                File.Copy(file, Path.Combine(indexPath, Path.GetFileName(file)), true);
            }
        }

        Debug.Log("Copy done: " + indexPath);
#if UNITY_EDITOR
        AssetDatabase.SaveAssets();
#endif
        
    }


    private void Start()
    {
        AddCoinDaily();
    }


    private int totalScore;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            ScreenShot();
        }
    }

    public int GetTotalCoin()
    {
        totalScore = PlayerPrefs.GetInt("TotalCoin", 0);
        return totalScore;
    }

    private int energy;

    public int GetEnergy()
    {
        energy = PlayerPrefs.GetInt("Energy", 5);
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
            PlayerPrefs.SetString("daily_coin", DateTime.Now.ToString());
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
        var sc = SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
        yield return new WaitUntil(() => sc.isDone);
        isGameStarted = false;
        gameOver.SetActive(true);
        yield return new WaitForSeconds(2);
        isloading = false;
    }
}