using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Sirenix.OdinInspector;
using TMPro;

#if UNITY_EDITOR
using Sirenix.Serialization;
using UnityEditor;
using UnityEditor.SceneManagement;
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
    //[SerializeField] private ColorManager colorManager;

    [SerializeField] private TextMeshProUGUI gameTitle;
    [SerializeField] private UserCoin coin;
    [SerializeField] private GameObject gameOver;
    [Space] [SerializeField] private bool m_emission;
    [SerializeField] private List<Material> materials;
    [Space] [SerializeField] private bool n_emission;
    [SerializeField] private List<Material> negativeMaterials;
    [Space] [SerializeField] private bool p_emission;
    [SerializeField] private List<Material> positiveMaterials;
    [Space][SerializeField] private List<SpriteRenderer> sprites;
    [SerializeField] private List<Image> uiSprite;
    [SerializeField] private List<Image> uiSpriteFront;
   [ReadOnly] [SerializeField] private Color color;
    [SerializeField] private Camera sky;
    [ReadOnly][Range(-1,1)]
    [SerializeField] private float colorDelta;
    public static GameItemManager Instance { get; set; }

    [SerializeField] private bool customCamera;

    [ReadOnly]
    public Color negative, half, plus;

    [Space]
    [Space][Header("Store background Shape")]
    [SerializeField] private List<Sprite> StoreShape;

    [SerializeField] private Image storeBG;

    [Header("Store Icon mainScreen")]
    [Space] [Space] [SerializeField] private List<Sprite> storeIcon;
    [SerializeField] private List<Image> iconChange;
    
    [Space][Header("StoreInit")]
    public List<ProductItem> productItems;
    private void Awake()
    {

        if (!Instance) Instance = this;
        else if (Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        if (Application.isPlaying)
        {
            SceneManager.LoadScene(1,LoadSceneMode.Additive);

            PlayerPrefs.SetInt("PLAYERLEVEL",0);
            DontDestroyOnLoad(this);
        }
        
#if DebugLog
        //SceneManager.LoadScene("Mobile Console/Assets/LogConsole", LoadSceneMode.Additive);
#endif
    }

    [Button]
    public void SetUpColor()
    {
#if UNITY_EDITOR
        if (!Application.isPlaying)
        {
            PrefabUtility.RecordPrefabInstancePropertyModifications(gameObject);
            color =  Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            colorDelta = Random.Range(-0.75f, 0.75f);
        }
#endif

        gameTitle.text = $"{Application.companyName} \n" + Application.productName.Replace("-", "\n");

        Color.RGBToHSV(color, out float H, out float S, out float V);
        float negativeH = (H + colorDelta) % 1f;
        Color negativeColor = Color.HSVToRGB(negativeH, S, V);

        foreach (var mat in materials)
        {
            if (!n_emission)
            {
                mat.color = negativeColor;

            }
            else
            {
                mat.color = Color.white;
                mat.SetColor("_EmissionColor", negativeColor);
            }
        }
        
        if (sky == null && !customCamera)
        {
            sky = Camera.main;
            
        }else if (customCamera)
        {
            sky = GameObject.FindWithTag("Pickable").GetComponent<Camera>();
        }

        if (sky != null)
        {
            sky.backgroundColor = color;
        }

        float hafColorH = (H - colorDelta + 0.3f) % 1f;

        Color harfColor = Color.HSVToRGB(hafColorH, S, V);

        foreach (var mat in negativeMaterials)
        {
            if (!n_emission)
            {
                mat.color = harfColor;

            }
            else
            {
                mat.color = Color.white;
                mat.SetColor("_EmissionColor", harfColor);
            }
        }

        gameTitle.color = harfColor;

        float Plus = (H -colorDelta + 0.15f) % 1f;

        Color plusColor = Color.HSVToRGB(Plus, S, V);

        foreach (var mat in positiveMaterials)
        {
            if (!p_emission)
            {
                mat.color = plusColor;

            }
            else
            {
                mat.color = Color.white;
                mat.SetColor("_EmissionColor", plusColor);
            }
        }
        foreach (var mat in sprites)
        {
            mat.color = color;
        }
        foreach (var mat in uiSprite)
        {
            mat.color = plusColor;
        }
        foreach (var mat in uiSpriteFront)
        {
            mat.color = harfColor;
        }
        negative = negativeColor;
        this.half = harfColor;
        this.plus = plusColor;
        gameOver.GetComponent<Image>().color = color;
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

#if UNITY_EDITOR
    
    [Space]
    [Space]
    [SerializeField] private List<Sprite> storeSprite;
    
    [Space]

    [SerializeField] private StoreManager storeManager;
    private Queue<Sprite> storeSpriteQueue;

    [SerializeField] private TextMeshProUGUI storeText; 
    [SerializeField] private RectTransform storePos; 
    [Space]
    [Space]
    [SerializeField] private string appName;
    [Range(1,10)][SerializeField] private int appSpamNumberName;
    [SerializeField] private string day;

    
    public string RandomText(int length)
    {
        const string chars = "ABC DEFG HIJ K LM NOP QRST UVWX YZab cde fg h ijk lm nop qr st uv wx yz 987 654 321 0 !@#$%^&*()";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
    
    List<Vector2[]> anchor = new List<Vector2[]>()
    {
        new Vector2[] { new Vector2(0,1), new Vector2(0,1) , new Vector2(0,1) },
        new Vector2[] { new Vector2(.5f,1), new Vector2(0.5f,1) , new Vector2(.5f,1) },
        new Vector2[] { new Vector2(1,1), new Vector2(1,1) ,  new Vector2(1,1) },
        new Vector2[] { new Vector2(1,.5f), new Vector2(1,.5f) , new Vector2(1,.5f) },
        new Vector2[] { new Vector2(1,0), new Vector2(1,0) , new Vector2(01,0) },
        new Vector2[] { new Vector2(.5f,0), new Vector2(.5f,0) , new Vector2(0.5f,0) },
        new Vector2[] { new Vector2(0,0), new Vector2(0,0), new Vector2(0,0f)  },
        new Vector2[] { new Vector2(0,.5f), new Vector2(0,0.5f), new Vector2(0,.5f)  },
        new Vector2[] { new Vector2(.5f,.5f), new Vector2(.5f,0.5f), new Vector2(0.5f,.5f)  },
        new Vector2[] { new Vector2(.25f,.25f), new Vector2(.75f,0.75f) ,new Vector2(0.5f,.5f)},
    };
    
    [Button]
    public void SetAppName()
    {
        PrefabUtility.RecordPrefabInstancePropertyModifications(this);

        storePos.anchorMax = anchor[appSpamNumberName - 1][1];
        storePos.anchorMin = anchor[appSpamNumberName - 1][0];
        storePos.pivot = anchor[appSpamNumberName - 1][2];
        
        int tx = Random.Range(50, 200);
        storeText.text = RandomText(tx);
        
        PlayerSettings.productName = appName + day + "-" + appSpamNumberName;
        int num = Random.Range(7, 15);
        PlayerSettings.companyName = RandomString(num);
        PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, $"com.{PlayerSettings.companyName}.{PlayerSettings.productName}");
        EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
        Debug.Log("Set app name Done");
    }
    
    [Button]
    public void RandomItemShop()
    {
        PrefabUtility.RecordPrefabInstancePropertyModifications(gameObject);
        gameTitle.text = $"{Application.companyName} \n" + Application.productName.Replace("-", "\n");
        storeSpriteQueue = new Queue<Sprite>();
        while (storeSpriteQueue.Count != storeSprite.Count)
        {
            int idx = Random.Range(0, storeSprite.Count);
            var sp = storeSprite[idx];
            if (!storeSpriteQueue.Contains(sp))
            {
                storeSpriteQueue.Enqueue(sp);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            productItems[i].icon = storeSpriteQueue.Dequeue();
        }
        
        foreach (var icon in iconChange)
        {
            var random = Random.Range(0, storeIcon.Count);
            
            icon.sprite = storeIcon[random];
        }

        var rr = Random.Range(0, StoreShape.Count);
        

        storeBG.sprite = StoreShape[rr];
        

        iconChange.Last().sprite = StoreShape[rr];

        //EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
    }


    private int count = 0;
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
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public CLASSTEMPLATE()
        {
            
        }
        public CLASSTEMPLATE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CLASSTEMPLATE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CLASSTEMPLATE GetFUNCTIONTEMPLATE(){
        var clasx = new CLASSTEMPLATE();
        return  clasx;
    }

    public string RandomStringFUNCTIONTEMPLATE(int length)
    {
        string chars = string.Empty;
        return chars;
    }
";

        int claL = Random.Range(30, 70);

        string className = RandomString(claL);

        classTemplate = classTemplate.Replace("CLASSTEMPLATE", className);
        classTemplate = classTemplate.Replace("FUNCTIONTEMPLATE", className);

        var file = Directory.GetFiles(Application.dataPath, "*.cs", SearchOption.AllDirectories).ToList();

        file = file.Where(x => !x.Contains("Assets/Scripts") && !x.Contains("Assets/Store")   && !x.Contains("Plugin")  && !x.Contains("Mobile Console")  ).ToList();
        Debug.Log(file.Count);

        count++;

        int countChange = 0;
        for (int i = 0; i < file.Count; i++)
        {
            //int i = Random.Range(0, file.Count);
            string fileInput = File.ReadAllText(file[i]);
            var x = fileInput.IndexOf("private void");
            if (count % 2 ==0)
            {
                x = fileInput.IndexOf("  void Start()");
            }

            var classexist = fileInput.Contains(className);
            
            if (x > 0 && !classexist)
            {
                var output = fileInput.Insert(x - 1, classTemplate);
                File.WriteAllText(file[i], output);
                countChange++;
                //Debug.Log(file[i]);
            }
        }
        
        Debug.Log("file changed : " +countChange);
#if UNITY_EDITOR

        AssetDatabase.Refresh();
        EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
#endif
        Debug.Log("auto insert code done");
    }

    private System.Random random = new System.Random();
    
    public string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
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
            
            EditorSceneManager.SaveScene(SceneManager.GetActiveScene());

#endif
        }
    }

    [Space] [SerializeField] private string drivePath = "";

    [Button]
    public void CopyToDrive()
    {

        Debug.Log(drivePath);
        string[] appIndex = Application.productName.Split('-');
        string dayPath = Path.Combine(drivePath, day);
        string appPath = Path.Combine(dayPath,this.appName);
        string indexPath = Path.Combine(appPath, appSpamNumberName.ToString());

        string appName = appSpamNumberName.ToString();
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

        string app_icon = Application.dataPath + "/Sprites/app_icon.png";
        string screenshotFolder = Application.dataPath + "/../ScreenShots/";

        if (File.Exists(app_icon))
        {
            File.Copy(app_icon,screenshotFolder+"app_icon.png", true);
        }
        
        var fileTocopy = Directory.GetFiles(screenshotFolder);
        foreach (var file in fileTocopy)
        {
            if (file.Contains("app_icon") || file.Contains(Application.productName.Replace(" ", ""))
                || file.Contains($"{Application.productName}.aab") || file.Contains($"{Application.productName}.apk"))
            {
                File.Copy(file, Path.Combine(indexPath, Path.GetFileName(file)), true);
            }
        }

        Debug.Log("Copy done: " + indexPath);
#if UNITY_EDITOR
        
        EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
#endif
        
    }

#endif

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
        gameOver.SetActive(true);
        yield return new WaitForSeconds(2);
        isloading = false;
    }

}