using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{
    public GameObject playUi;
    public GameObject looseUi;
    public GameObject winUi;
    public GameObject rewardPanel;

    public GameObject challengesPanel;
    public GameObject dragToPlay;
    public Text totalCoinText;
    public Text LeagueText;
    public Text rewardCollectedText;
    public Text winCollectedCoin;
    public CoinManger coinM;
    public Transform coinAnimationStartpoint;
    public static UiManager instance;
    private int totalCoin;
    int roundIndex;
    void Awake(){
        if(instance==null){
            instance=this;
        }else if(instance!=this){
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        totalCoin=PlayerPrefs.GetInt("Total_Coin");
        roundIndex=1;
        setTotalCoinText();
        setLeagueText();
        //Advertisements.Instance.Initialize();
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play(){
         
        StaduimSelector.instance.selectStaduim();
        BeybladeController.instance.idleMode=false;
     
    	 BeybladeController.instance.place();
         CameraController.instance.gooidle=false;
    	CameraController.instance.focus=true;

        playUi.SetActive(false);
        GameManager.instance.startPlay();
 

    }
    public void loose(){
        looseUi.SetActive(true);

    }public void win(){
        CameraController.instance.disableShaker();


        winUi.SetActive(true);
        Invoke ("animateCoin",.5f);
        //coinM.instance.animate(coinAnimationStartpoint,20);
        StartCoroutine(coinTextIncremetorDelay() );
         Invoke("showAdsDelayed",1.2f);
          addCoin();



    }
    private void showAdsDelayed(){
          //Advertisements.Instance.ShowInterstitial();
//
    }
    int tempCoin=0;
    int maxCoin=100;
    int rewardcollectdAmount;

    IEnumerator coinTextIncremetorDelay(bool winText=true){
        bool wint=winText;
        if(winText)
          coinM.animate(coinAnimationStartpoint.position,1);
        yield return new WaitForSeconds(.00001f);
        if(tempCoin<maxCoin){
            tempCoin++;
            if(winText)
            winCollectedCoin.text=tempCoin+"";
            else{
                maxCoin=rewardcollectdAmount;
             rewardCollectedText.text=tempCoin+"";
            }
          StartCoroutine(coinTextIncremetorDelay(wint));
        }

       maxCoin=100;



    }
    private void addCoin(int value=100){
        int currentcoin=PlayerPrefs.GetInt("Total_Coin");
        currentcoin+=value;
        PlayerPrefs.SetInt("Total_Coin",currentcoin);
        totalCoin=PlayerPrefs.GetInt("Total_Coin");

    }
    private void animateCoin(){

    }
    public void next(){
      setTotalCoinText();
      WorldManager.instance.selectWorld();
        CameraController.instance.focus=false;
        CameraController.instance.gooidle=true;
         BeybladeController.instance.idleMode=true;
        winUi.SetActive(false);
        playUi.SetActive(true);
        upgradeEnemyPower();
        if(roundIndex==1){
            OlympiaManager.instance.firstRoundComplete();
            roundIndex++;
        }else if(roundIndex==2){
            OlympiaManager.instance.secondeRoundComplete();
            roundIndex++;

        }else if(roundIndex==3){
            OlympiaManager.instance.thirdRoundComplete();
            int leagueIndex=PlayerPrefs.GetInt("leagueIndex");
            leagueIndex++;
             PlayerPrefs.SetInt("leagueIndex",leagueIndex);
             int challengeWinIndex=PlayerPrefs.GetInt("ChallengeIndex");
        challengeWinIndex++;
        PlayerPrefs.SetInt("ChallengeIndex",challengeWinIndex);
            rewardPanel.SetActive(true);

        }
        //update the champion ui
    }
    public void replay(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void nextWithReward(){
        
        //show ads
        //add double collected coins
        //Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
        
        //playUi.SetActive(true);
    }
    private void CompleteMethod(bool completed, string advertiser) {
     Debug.Log("Closed rewarded from: "+advertiser+" -> Completed " + completed);
   if(completed == true) {
    addCoin(200);
        winUi.SetActive(false);
        upgradeEnemyPower();

        next();

//give the reward 
}
else {
//no reward 
}
}
    public void showPlayButton(){
        dragToPlay.SetActive(true);
    }
    public void gooShopping(){
        SceneManager.LoadScene("Shop");
    }private void setTotalCoinText(){
        totalCoin=PlayerPrefs.GetInt("Total_Coin");
        totalCoinText.text=totalCoin+"";
    }
    public void enableChallengesPanel(){
        challengesPanel.SetActive(true);
        MissionSelector.instance.selectMission();
    }public void disableChallengesPanel(){
        challengesPanel.SetActive(false);

    }
    public void challengeWinNext(){
        
     

        SceneManager.LoadScene("League");
    }
     public void challengeWinNextReward(){
       SceneManager.LoadScene("League");
    }
    bool rewardChoosed=false;

    public void chestCoinManager(Transform startAnimation){
        if(!rewardChoosed){
                setLeagueText();

          coinM.animate(startAnimation.position,6);
          maxCoin=Random.Range(100,150);
         StartCoroutine(coinTextIncremetorDelay(false));
         rewardChoosed=true;
        }
       Invoke("disableRewardPanel",2f);

    }
   private void disableRewardPanel(){
      rewardPanel.SetActive(false);
      enableChallengesPanel();
   }
   public void challengesSceneNextButton(){

   }
   public void gooToChallengesScene(){
        SceneManager.LoadScene("Challenges");
   }
   private void setLeagueText(){
    int leagueIndex=PlayerPrefs.GetInt("leagueIndex");
    if(LeagueText!=null)
    LeagueText.text="League : "+leagueIndex;
   }
   private void upgradeEnemyPower(){
       float Ecrashpeed=PlayerPrefs.GetFloat("EnemyCrashForceUpdate");
       float Edrag=PlayerPrefs.GetFloat("EnemyDrag");
       float  EforwardSpeed=PlayerPrefs.GetFloat("EnemyforwardSpeed");
       Ecrashpeed+=15;
       Edrag+=0.005f;
       EforwardSpeed+=0.05f;
       PlayerPrefs.SetFloat("EnemyCrashForceUpdate",Ecrashpeed);
       PlayerPrefs.SetFloat("EnemyDrag",Edrag);
       PlayerPrefs.SetFloat("EnemyforwardSpeed",EforwardSpeed);
   }

}
