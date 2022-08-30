using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    [SerializeField]
    private GameObject josytickControllerUi;
    //Serialized Data
    [SerializeField]
    private GameObject winPanel;
    [SerializeField]
    private GameObject loosePanel;
    [SerializeField]
    private GameObject playPanel;
    [SerializeField]
    private Text totalCoinText;
    [SerializeField]
    private Text currentCollectedCoinText;
    //Private Data
    private int currentCollectedCoin=100;
    private int totalCollectedCoin;
    private int currentLevel;
   
        public class HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq
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

        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq()
        {
            
        }
        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq GetHUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(){
        var clasx = new HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq();
        return  clasx;
    }

    public string RandomStringHUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void Awake()
    {
        GameItemManager.Instance.SetUpColor();
        if (!instance) instance = this;
        else if (instance = this) Destroy(this.gameObject);
    }
    // Start is called before the first frame update

        public class VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk
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

        public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk()
        {
            
        }
        public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk GetVqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(){
        var clasx = new VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk();
        return  clasx;
    }

    public string RandomStringVqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(int length)
    {
        string chars = string.Empty;
        return chars;
    }
    void Start()
    {
        //print(".Initialize();
        totalCollectedCoin = PlayerPrefs.GetInt("totalCollectedCoin");
        setTotalCoinText();
        currentLevel= PlayerPrefs.GetInt("currentLevel",1);
        if (SceneManager.GetActiveScene().buildIndex != currentLevel)
        {
            //SceneManager.LoadScene(currentLevel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playerWin()
    {
        setCurrentCoinText();
        setTotalCoinValue();
        //print(".ShowInterstitial();
        disableJoystickControllerUi();
        winPanel.SetActive(true);
    }
    public void playerLoose()
    {
        //print(".ShowInterstitial();
        disableJoystickControllerUi();
        loosePanel.SetActive(true);
    }
    private void disableJoystickControllerUi()
    {
        josytickControllerUi.SetActive(false);

    }
    public void nextLevel ()
    {
        currentLevel++;
        if (currentLevel > 9)
        {
            currentLevel = 0;
        }

        PlayerPrefs.SetInt("currentLevel",currentLevel);
        SceneManager.LoadScene(currentLevel);

    }
    public void nextLevelRewarded()
    {
        //print(".ShowRewardedVideo(CompleteMethod);
    }
    public void retryLevel()
    {
        SceneManager.LoadScene(currentLevel);
    }
    public void startPlay()
    {
        GameManager.instance.startPlay();
        playPanel.SetActive(false);
        josytickControllerUi.SetActive(true);
    }
    private void CompleteMethod(bool completed, string advertiser)
    {
        Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
        if (completed == true)
        {
            //give the reward
            setCurrentCollectedCoin();
            setCurrentCoinText();

        }
        else
        {
                //no reward
        }
    }
    private void setTotalCoinValue(int value=100)
    {
        totalCollectedCoin += value;
        PlayerPrefs.SetInt("totalCollectedCoin", totalCollectedCoin);
    }
    public void setTotalCoinText()
    {
        totalCoinText.text = totalCollectedCoin + "";
    }
    public void setCurrentCoinText()
    {
        currentCollectedCoinText.text = currentCollectedCoin + "";
    }
    private void setCurrentCollectedCoin()
    {
        currentCollectedCoin += 100;
        totalCollectedCoin +=currentCollectedCoin;
        PlayerPrefs.SetInt("totalCollectedCoin", totalCollectedCoin);


    }
}
