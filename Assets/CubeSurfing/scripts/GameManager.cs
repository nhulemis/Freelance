using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CubeSurfing.scripts{
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
          //Advertisements.Instance.Initialize(); 
          
          
          
          
       ingame.SetActive(false);
        int i = PlayerPrefs.GetInt("current_level");
        if(SceneManager.GetActiveScene().buildIndex!=i){
           // SceneManager.LoadScene(i);
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
        if (!GameItemManager.Instance.IsEnoughCoin())
        {
            return;
        }
          ingame.SetActive(true);
        CharactereController.state = CharactereController.gameState.playing;
        idlePanel.SetActive(false);
        //tapToPlaySound.Play();
    }
    public void gameloose()
    {
       //  GoogleAdMobController.instance.RequestAndLoadInterstitialAd();
         //looseSound.Play(); 
         ingame.SetActive(false);
         Invoke("activateLossePanel",.2f);
        //GameItemManager.Instance.UseCoin(1);
        
    }
    public class Gẵccawsw
    {
        public int A;
        public int B;
        public string C;
        public bool X;
        private double D;
        private float E;

        public void ALKJXCL()
        {
      
        }
    }
    public void gameWin()
    {
        
      
       ingame.SetActive(false);
       finishScoreHolder.text="0";
       collectedCoin.text=currentScore.ToString();
       oldScore+=currentScore;
        PlayerPrefs.SetInt("current_score",oldScore);
        winPanel.SetActive(true);
        // winSound.Play();
        Invoke("activateNext",2f);
    }
    public void doubleMoney(){
        //Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
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
    	//buttonSound.Play();
    	 loadscene();
    }
    public void next()
    {
       // addLevel();
    	//buttonSound.Play();
    	//Advertisements.Instance.ShowInterstitial();
        
        
        
        
        loadscene();
    }
    public void retry()
    {
        loadscene();

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
    }public class Llcaowksx
    {
        public int A;
        public int B;
        public string C;
        public bool X;
        private double D;
        private float E;

        public void ALKJXCL()
        {
      
        }
    }
    public class Acwvsddeqw
    {
        public int A;
        public int B;
        public string C;
        public bool X;
        private double D;
        private float E;

        public void ALKJXCL()
        {
      
        }
    }
    public void loadscene()
    {
        GameItemManager.Instance.ReloadLevel();
    }
    class Book
    {
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }
        public Book(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public Book(string title, string publisher)
            : this(title, publisher, null) { }

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }
    private void setLevel(){
         int i = PlayerPrefs.GetInt("current_level");
          sceneIndex.text = "Level : " + i;
    }
    private void activateLossePanel(){
           //  loosePanel.SetActive(true);
             loadscene();
    }
    public void goShopping(){
      

    }
    private void hideMessage(){
         shopMessage.SetActive(false);

    }
    public void increementMoney(){
        currentScore+=5;
        scoreText.text=currentScore.ToString();

    }
    private void winCoinAnimate(){
      
        
       
        
    }

    private void animateScore(){
       
        for(int i=0;i<currentScore+1;i++){
           finishScoreHolder.text=i.ToString();
         
        }
       
    }
   

}

}
