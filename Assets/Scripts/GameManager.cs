using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace cuber{
public class GameManager : MonoBehaviour
{
    public GameObject idlePanel;
    public GameObject loosePanel;
    public GameObject winPanel;
    public static GameManager Instance;
    public GameObject scorepopup;
    public Text sceneIndex;
    public GameObject ingame;
    public GameObject shopMessage;
    public Text scoreText;
    public GameObject nextButton;
    public Text globalScore ;
     public Text finishScoreHolder ;

    [Header(" Button Sounds")]
    [SerializeField] AudioSource tapToPlaySound;
    [SerializeField] AudioSource buttonSound;
    [SerializeField] AudioSource winSound;
    [SerializeField] AudioSource looseSound;
    [SerializeField] AudioSource coinGetSound;
    private int currentScore;
    [Header("Game End")]
    [SerializeField] CoinManger coinM;
    [SerializeField] Transform coinT;
    [SerializeField] Text collectedCoin;      
    int oldScore;
    // Start is called before the first frame update
    void Start()
    {
      
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            if (Instance != this)
                Destroy(this);
        }
       //GoogleAdMobController.instance.RequestAndLoadInterstitialAd();
          Advertisements.Instance.Initialize(); 
       ingame.SetActive(false);
        int i = PlayerPrefs.GetInt("current_level");
        if(SceneManager.GetActiveScene().buildIndex!=i){
            //SceneManager.LoadScene(i);
        }
          setLevel();
           oldScore=PlayerPrefs.GetInt("current_score");
           globalScore.text=oldScore.ToString();
           scoreText.text="0";
          
      //  loadscene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameStart()
    {
    	
          ingame.SetActive(true);
        CharactereController.state = CharactereController.gameState.playing;
        idlePanel.SetActive(false);
        tapToPlaySound.Play();
    }
    public void gameloose()
    {
       //  GoogleAdMobController.instance.RequestAndLoadInterstitialAd();
         looseSound.Play(); 
         ingame.SetActive(false);
         Invoke("activateLossePanel",.2f);
     
        
    }
    public void gameWin()
    {
        
      
       ingame.SetActive(false);
       finishScoreHolder.text="0";
       collectedCoin.text=currentScore.ToString();
       oldScore+=currentScore;
        PlayerPrefs.SetInt("current_score",oldScore);
        winPanel.SetActive(true);
         winSound.Play();
        Invoke("activateNext",2f);
        
       
    }
    public void doubleMoney(){
        Advertisements.Instance.ShowRewardedVideo(CompleteMethod);

       
    }
   
        public class HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb
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

        public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb()
        {
            
        }
        public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb GetHqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(){
        var clasx = new HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb();
        return  clasx;
    }

    public string RandomStringHqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void CompleteMethod(bool completed, string advertiser)
    {
      Debug.Log("Closed rewarded from: "+advertiser+" -> Completed " + completed);
    if(completed == true)
    {
        oldScore*=2;
        PlayerPrefs.SetInt("current_score",oldScore);
        next01();
    }
     else
    {
       //no reward
    }
    }
    private void activateNext(){
        winCoinAnimate();
        animateScore();
        nextButton.SetActive(true);
    }
    public void next01(){
    	buttonSound.Play();
    	 loadscene();
    }
    public void next()
    {
       // addLevel();
    	buttonSound.Play();
    	Advertisements.Instance.ShowInterstitial();
        loadscene();
    }
    public void retry()
    {  
       

      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
       
    }
    public void addScore(Vector3 position)
    {
        Instantiate(scorepopup, Camera.main.WorldToScreenPoint(position), Quaternion.identity,this.transform);
    }
    public void addLevel()
    {
        int i = PlayerPrefs.GetInt("current_level",0);
        i++; 
        PlayerPrefs.SetInt("current_level", i);
    }
    public void loadscene()
    {
        int i = PlayerPrefs.GetInt("current_level");
        if (SceneManager.GetActiveScene().buildIndex < 30)
        {
            SceneManager.LoadScene(i);
           // sceneIndex.text = "Level : " + i;
        }else
        {
            PlayerPrefs.SetInt("current_level",0);
            int s = PlayerPrefs.GetInt("current_level");

            SceneManager.LoadScene(s + "");


        }
       
    }
    private void setLevel(){
         int i = PlayerPrefs.GetInt("current_level");
          sceneIndex.text = "Level : " + i;
    }private void activateLossePanel(){
             loosePanel.SetActive(true);
    }
    public void goShopping(){
       /// shopMessage.SetActive(true);
        ///Invoke("hideMessage",1f);
        buttonSound.Play();
        SceneManager.LoadScene("Shop");

    }
    private void hideMessage(){
         shopMessage.SetActive(false);

    }
    public void increementMoney(){
        currentScore+=5;
        scoreText.text=currentScore.ToString();

    }
    private void winCoinAnimate(){
        coinGetSound.Play();
        coinM.animate(coinT.position,20);
    }

    private void animateScore(){
       
        for(int i=0;i<currentScore+1;i++){
           finishScoreHolder.text=i.ToString();
         
        }
       
    }
   

}

}
