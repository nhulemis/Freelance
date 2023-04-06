using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Sirenix.OdinInspector;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
#endif

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Color = UnityEngine.Color;
using Debug = UnityEngine.Debug;
using Image = UnityEngine.UI.Image;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;


public class GameItemManager : MonoBehaviour
{
    //[SerializeField] private ColorManager colorManager;


    [FoldoutGroup("Material")] [SerializeField]
    private TextMeshProUGUI gameTitle;

    [FoldoutGroup("Material")] [SerializeField]
    private UserCoin coin;

    [FoldoutGroup("Material")] [SerializeField]
    private GameObject gameOver;

    [FoldoutGroup("Material")] [Space] [SerializeField]
    private bool m_emission;

    [FoldoutGroup("Material")] [SerializeField]
    private List<Material> materials;

    [FoldoutGroup("Material")] [Space] [SerializeField]
    private bool n_emission;

    [FoldoutGroup("Material")] [SerializeField]
    private List<Material> negativeMaterials;

    [FoldoutGroup("Material")] [Space] [SerializeField]
    private bool p_emission;

    [FoldoutGroup("Material")] [SerializeField]
    private List<Material> positiveMaterials;

    [FoldoutGroup("Material")] [Space] [SerializeField]
    private List<SpriteRenderer> sprites;

    [FoldoutGroup("Material")] [SerializeField]
    private List<Image> uiSprite;

    [FoldoutGroup("Material")] [SerializeField]
    private List<Image> uiSpriteFront;

    [SerializeField] private Color white;
    [ReadOnly] [SerializeField] private Color color;
    [SerializeField] private Camera sky;

    [ReadOnly] [Range(-1, 1)] [SerializeField]
    private float colorDelta;

    public static GameItemManager Instance { get; set; }

    [SerializeField] private bool customCamera;

    [ReadOnly] public Color negative, half, plus;

    [FoldoutGroup("Sprites")] [Space] [Space] [Header("Store background Shape")] [SerializeField]
    private List<Sprite> StoreShape;

    [FoldoutGroup("Sprites")] [SerializeField]
    private Image storeBG;

    [FoldoutGroup("Sprites")] [SerializeField]
    private Image newsBG;

    [FoldoutGroup("Sprites")] [Header("Store Icon mainScreen")] [Space] [Space] [SerializeField]
    private List<Sprite> storeIcon;

    [FoldoutGroup("Sprites")] [SerializeField]
    private List<Image> iconChange;

    [FoldoutGroup("Sprites")] [Space] [Header("StoreInit")]
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
            SceneManager.LoadScene(1, LoadSceneMode.Additive);

            PlayerPrefs.SetInt("PLAYERLEVEL", 0);
            DontDestroyOnLoad(this);
        }

#if DebugLog
        //SceneManager.LoadScene("Mobile Console/Assets/LogConsole", LoadSceneMode.Additive);
#endif
    }

    [HideInInspector] public List<Image> AddSprites = null;

    [SerializeField] private GameObject HORI, VERTI;

    [Button]
    public void SetUpColor()
    {
#if UNITY_EDITOR
        if (!Application.isPlaying)
        {
            PrefabUtility.RecordPrefabInstancePropertyModifications(gameObject);
            color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            colorDelta = Random.Range(-0.75f, 0.75f);
        }
#endif

        if (AddSprites != null)
        {
            foreach (var icon in AddSprites)
            {
                var random = Random.Range(0, storeIcon.Count);

                icon.sprite = storeIcon[random];
            }
        }

        gameTitle.text = $"{Application.companyName} \n" + Application.productName.Replace("-", "\n");

        Color.RGBToHSV(color, out float H, out float S, out float V);
        float negativeH = (H + colorDelta) % 1f;
        Color negativeColor = Color.HSVToRGB(negativeH, S, V) + white;

        foreach (var mat in materials)
        {
            if (!m_emission)
            {
                mat.color = negativeColor;
                mat.DisableKeyword("_EMISSION");
            }
            else
            {
                mat.color = Color.white;
                mat.EnableKeyword("_EMISSION");
                mat.SetColor("_EmissionColor", negativeColor * 2);
            }
        }

        if (sky == null && !customCamera)
        {
            sky = Camera.main;
        }
        else if (customCamera)
        {
            sky = GameObject.FindWithTag("Pickable").GetComponent<Camera>();
        }

        if (sky != null)
        {
            sky.clearFlags = CameraClearFlags.SolidColor;
            sky.backgroundColor = color;
        }

        float hafColorH = (H - colorDelta + 0.3f) % 1f;

        Color harfColor = Color.HSVToRGB(hafColorH, S, V) + white;

        foreach (var mat in negativeMaterials)
        {
            if (!n_emission)
            {
                mat.color = harfColor;

                mat.DisableKeyword("_EMISSION");
            }
            else
            {
                mat.color = Color.white;
                mat.EnableKeyword("_EMISSION");
                mat.SetColor("_EmissionColor", harfColor);
            }
        }

        gameTitle.color = harfColor;

        float Plus = (H - colorDelta + 0.15f) % 1f;

        Color plusColor = Color.HSVToRGB(Plus, S, V) + white;

        foreach (var mat in positiveMaterials)
        {
            if (!p_emission)
            {
                mat.color = plusColor;

                mat.DisableKeyword("_EMISSION");
            }
            else
            {
                mat.color = Color.white;
                mat.EnableKeyword("_EMISSION");
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

    [FoldoutGroup("Sprites")] [Space] [Space] [SerializeField]
    private List<Sprite> storeSprite;

    [FoldoutGroup("Sprites")] [Space] [SerializeField]
    private StoreManager storeManager;

    private Queue<Sprite> storeSpriteQueue;

    [FoldoutGroup("Sprites")] [SerializeField]
    private TextMeshProUGUI storeText;

    [FoldoutGroup("Sprites")] [SerializeField]
    private TextMeshProUGUI newsText;

    [FoldoutGroup("Sprites")] [SerializeField]
    private RectTransform storePos;

    [Space] [Space] [SerializeField] private string appName;
    [Range(1, 10)] [SerializeField] private int appSpamNumberName;
    [SerializeField] private string day;


    public string RandomText(int length)
    {
        const string chars =
            "ABC DEFG HIJ K LM NOP QRST UVWX YZab cde fg h ijk lm nop qr st uv wx yz 987 654 321 0";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    List<Vector2[]> anchor = new List<Vector2[]>()
    {
        new Vector2[] { new Vector2(0, 1), new Vector2(0, 1), new Vector2(0, 1) },
        new Vector2[] { new Vector2(.5f, 1), new Vector2(0.5f, 1), new Vector2(.5f, 1) },
        new Vector2[] { new Vector2(1, 1), new Vector2(1, 1), new Vector2(1, 1) },
        new Vector2[] { new Vector2(1, .5f), new Vector2(1, .5f), new Vector2(1, .5f) },
        new Vector2[] { new Vector2(1, 0), new Vector2(1, 0), new Vector2(01, 0) },
        new Vector2[] { new Vector2(.5f, 0), new Vector2(.5f, 0), new Vector2(0.5f, 0) },
        new Vector2[] { new Vector2(0, 0), new Vector2(0, 0), new Vector2(0, 0f) },
        new Vector2[] { new Vector2(0, .5f), new Vector2(0, 0.5f), new Vector2(0, .5f) },
        new Vector2[] { new Vector2(.5f, .5f), new Vector2(.5f, 0.5f), new Vector2(0.5f, .5f) },
        new Vector2[] { new Vector2(.25f, .25f), new Vector2(.75f, 0.75f), new Vector2(0.5f, .5f) },
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
        newsText.text = RandomText(tx);
        
        
        int app = Random.Range(4, 15);
        appName = RandomText(app);

        PlayerSettings.productName = appName + day + "-" + appSpamNumberName;
        int num = Random.Range(7, 15);
        PlayerSettings.companyName = RandomString(num);
        PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android,
            $"com.{PlayerSettings.companyName}.{PlayerSettings.productName}");
        EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
        Debug.Log("Set app name Done");
    }

    private void ResetAppName()
    {
        PrefabUtility.RecordPrefabInstancePropertyModifications(this);

        storePos.anchorMax = anchor[appSpamNumberName - 1][1];
        storePos.anchorMin = anchor[appSpamNumberName - 1][0];
        storePos.pivot = anchor[appSpamNumberName - 1][2];

        int tx = Random.Range(50, 200);
        storeText.text = RandomText(tx);
        newsText.text = RandomText(tx);
        PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android,
            $"com.{PlayerSettings.companyName}.{PlayerSettings.productName}");
        EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
        Debug.Log("Set app name Done");
    }
    

    [Button]
    public void RandomScene()
    {
        var scenes = EditorBuildSettings.scenes.ToList();
        var output = new List<EditorBuildSettingsScene>();

        output.Add(scenes.FirstOrDefault());

        while (output.Count < scenes.Count)
        {
            int rd = Random.Range(1, scenes.Count);
            if (!output.Contains(scenes[rd]))
            {
                output.Add(scenes[rd]);
            }
        }

        EditorBuildSettings.scenes = output.ToArray();
    }

    [Button]
    public void RandomItemShop()
    {
        PrefabUtility.RecordPrefabInstancePropertyModifications(gameObject);
        gameTitle.text = $"{Application.companyName} \n" + Application.productName.Replace("-", "\n");
        storeSpriteQueue = new Queue<Sprite>();

        storeSprite.Shuffle();

        for (int i = 0; i < productItems.Count; i++)
        {
            productItems[i].icon = storeSprite[i];
        }

        foreach (var icon in iconChange)
        {
            var random = Random.Range(0, storeIcon.Count);

            icon.sprite = storeIcon[random];
        }

        var rr = Random.Range(0, StoreShape.Count);

        StoreShape.Shuffle();
        storeBG.sprite = StoreShape[0];
        newsBG.sprite = StoreShape[1];

        int VorH = Random.Range(0, 100);
        if (VorH % 2 == 0)
        {
            float x = Random.Range(-446f, 446f);

           var pos = HORI.GetComponent<RectTransform>().anchoredPosition;
           pos.x = x;
           HORI.GetComponent<RectTransform>().anchoredPosition = pos;
            
            HORI.SetActive(true);
            VERTI.SetActive(false);
        }
        else
        {
            float y = Random.Range(-1000f, 1000f);

            var pos = VERTI.GetComponent<RectTransform>().anchoredPosition;
            pos.y = y;
            VERTI.GetComponent<RectTransform>().anchoredPosition = pos;
            
            HORI.SetActive(false);
            VERTI.SetActive(true);
        }


        iconChange.Last().sprite = StoreShape[rr];

        //EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
    }


    private int count = 0;

    [Button]
    public void AutoInsertCode()
    {
        InsertCode();
        InsertCode();
    }

    private void InsertCode()
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

        file = file.Where(x =>
            !x.Contains("Assets/Scripts") && !x.Contains("Assets/Store") && !x.Contains("Plugin") &&
            !x.Contains("Mobile Console")).ToList();
        Debug.Log(file.Count);

        count++;

        int countChange = 0;
        for (int i = 0; i < file.Count; i++)
        {
            //int i = Random.Range(0, file.Count);
            string fileInput = File.ReadAllText(file[i]);
            var x = fileInput.IndexOf("private void");
            if (count % 2 == 0)
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

        Debug.Log("file changed : " + countChange);
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
        string indexPath = Path.Combine(dayPath, $"{appSpamNumberName.ToString()}_com.{PlayerSettings.companyName}.{PlayerSettings.productName}");

        string appName = appSpamNumberName.ToString();
        if (!Directory.Exists(dayPath))
        {
            Directory.CreateDirectory(dayPath);
        }

        if (!Directory.Exists(indexPath))
        {
            Directory.CreateDirectory(indexPath);
        }

        string app_icon = Application.dataPath + "/Sprites/app_icon.png";
        string screenshotFolder = Application.dataPath + "/../ScreenShots/";

        if (File.Exists(app_icon))
        {
            File.Copy(app_icon, screenshotFolder + "app_icon.png", true);
        }

        var fileTocopy = Directory.GetFiles(screenshotFolder);
        foreach (var file in fileTocopy)
        {
            if (file.Contains("app_icon") || file.Contains(Application.productName.Replace(" ", ""))
                                          || file.Contains($"{Application.productName}.aab") ||
                                          file.Contains($"{Application.productName}.apk"))
            {
                File.Copy(file, Path.Combine(indexPath, Path.GetFileName(file)), true);
            }
        }

        Debug.Log("Copy done: " + indexPath);
#if UNITY_EDITOR

        EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
#endif
    }
    //
    // [Button]
    // public void CommitToGit()
    // {
    //     string directory = Path.Combine(Application.dataPath, "../"); // directory of the git repository
    //     ProcessStartInfo startInfo = new ProcessStartInfo()
    //     {
    //         FileName = directory + "/commit.sh",
    //         //Arguments = "",
    //     };
    //     Process proc = new Process()
    //     {
    //         StartInfo = startInfo,
    //     };
    //     proc.Start();
    //
    //
    //     Debug.Log("Commit done " + directory);
    // }

    [Button]
    public void SetupPass(string pass = "Abc123!@#")
    {
        PlayerSettings.keystorePass = pass;
        PlayerSettings.keyaliasPass = pass;
        Debug.Log("Set password done");
    }

    [Button]
    public void Build()
    {
        var buildname = "game0";
        var buildDir = Application.dataPath + "/../Build";
        var buildPath = buildDir + "/" + buildname + ".aab";


        if (!Directory.Exists(buildDir))
            Directory.CreateDirectory(buildDir);


        // PlayerSettings.Android.buildApkPerCpuArchitecture= false:
        var scenes = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
        var target = BuildTarget.Android;
        var options = BuildOptions.None;

        BuildPipeline.BuildPlayer(scenes, buildPath, target, options);
    }


    [SerializeField] private string pathRebuild;
    
    [Button]
    public void ReSetupBuild()
    {
        var files = Directory.GetFiles(pathRebuild,"*.*",SearchOption.AllDirectories).ToList();

        string findIcon = "app_icon.png";
        string findF = PlayerSettings.productName =appName + day + "-" + appSpamNumberName;
        files = files.Where(x => x.Contains(findF)).ToList();
        string icon = files.Find(x => x.Contains(findIcon));

        var dirs = icon.Split("/").FirstOrDefault(x => x.Contains("_com."));
        string company = dirs.Split(".")[1];
        Debug.Log(company);
        PlayerSettings.companyName = company;

        SetUpColor();
        ResetAppName();
        RandomScene();
        RandomItemShop();
        CopyIcon(icon);
        AutoInsertCode();
    }

    private void CopyIcon(string icon)
    {
        var dirPath = Application.dataPath + "/Sprites/";
        string file = Path.Combine(dirPath, "app_icon.png");
        File.Copy(icon,file,overwrite:true);
    }
#endif

    private void Start()
    {
        AddCoinDaily();
    }


    private int totalScore;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonDown(1))
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

public static class ListExtension
{
    public static void Shuffle<T>(this IList<T> ts)
    {
        var count = ts.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i)
        {
            var r = UnityEngine.Random.Range(i, count);
            (ts[i], ts[r]) = (ts[r], ts[i]);
        }
    }
}