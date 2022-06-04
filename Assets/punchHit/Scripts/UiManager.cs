using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField]GameObject joystick;
    [SerializeField]Transform joystickT;
    /********************UI Panel***************/
    [SerializeField] GameObject playPanel;
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject loosePanel;
    /************** Ui Level Text *******************/
    [SerializeField] Text levelBuyMoreElastics;
    [SerializeField] Text levelBuyMoreLife;
    [SerializeField] Text currentLevel;
    [SerializeField] Text winTotalScoreText;
    /******************* Coin Animation **********/
    [Header("Coin Animation")]
    [SerializeField] CoinManger coinM;
    [SerializeField] Transform coinT;
    [SerializeField] Text totalScroreText;
    /***************** Sounds ********************/
    [Header("Audio")]
    [SerializeField] AudioSource buttonClick;
    [SerializeField] AudioSource winReward;
    [SerializeField] AudioSource fail;

    /******************* Private Fields ************/
    private int currentSold=0;



    public static UiManager instance;
    void Awake(){
    	if(instance==null)
    	{
    		instance=this;
    	}
    	else if(instance!=this){
    		Destroy(this.gameObject);
        }
    }
    private void Start()
    {
         
        //Advertisements.Instance.Initialize(); 
      joystick.SetActive(false);
      playPanel.SetActive(true);
      winPanel.SetActive(false);
      loosePanel.SetActive(false);
      currentSold=PlayerPrefs.GetInt("currentSold",0);
      updateTotalSoldText();
      setLevelElastics();
      setLevelForLife();
      setLevel();


    }
    void Update(){
        if(Input.GetMouseButtonDown(0)){
           
          //joystickT.position=Input.mousePosition;
        } if(Input.GetMouseButtonUp(0)){
           
        }
    	
    }
    public void play(){ 
      buttonClick.Play();   
      GameManager.instance.inPlayMode();
      playPanel.SetActive(false);
      joystick.SetActive(true);
    }
    public void win(){
     // Advertisements.Instance.ShowInterstitial();
      winTotalScoreFill();
      GameManager.instance.inStopMode();
      winPanel.SetActive(true);
      winReward.Play();
      coinM.animate(coinT.position,20);
      updateTotalSoldText();
      setSold(+50);
      winTotalScoreFill();
    }
    private void winTotalScoreFill(){
        winTotalScoreText.text=currentSold.ToString();
    }
    public void loose(bool t){
          fail.Play();
          Invoke("tempPuaseMode",.5f);
     if(t){
      //  GameManager.instance.inStopMode();
      loosePanel.SetActive(true);
     }else {
        loosePanel.SetActive(false);
     }
      
     
    }
    public void next(){ 
            GameManager.instance.inStopMode();
           buttonClick.Play();
           updateLevel();
           setLevel();          
           LevelGenerator.instance.nextLevel();
           LevelGenerator.instance.genarateLevel(1,5.6f);
           winPanel.SetActive(false);
           playPanel.SetActive(true);



       //SceneManager.LoadScene("Main");
    }
    public void retry(){
        buttonClick.Play();
        Invoke("prepareNpc",.5f);
        loosePanel.SetActive(false);
        PlayerController.instance.retry();


    }
    private void tempPuaseMode(){
         GameManager.instance.inStopMode();
          
    }private void prepareNpc(){
            GameManager.instance.inPlayMode();
    }
    public void buyMoreElastics(int currency){
      int levelBuyLife=PlayerPrefs.GetInt("Elastics_level_Text",0);
       if(levelBuyLife<=getCurrentLevel())
      if(currentSold>=currency){
        //retreive money
         setSold(-currency);
         updateTotalSoldText();
        //buy more elastics
         if(levelBuyLife<=10){
        /// +1 Life 
        PlayerController.instance.addElastics(2.1f);
        
      }else if(levelBuyLife>10 && levelBuyLife<=20){
        /// +2 Life 
         PlayerController.instance.addElastics(1.5f);
      }else if(levelBuyLife>20 && levelBuyLife<=30){
        /// +3 Life 
         PlayerController.instance.addElastics(1.2f);
      }else{
        /// +5 Life
         PlayerController.instance.addElastics(1);
      }
       updateLevelElastics();
      setLevelElastics();
    
      }

    }
     public void buyMoreLife(int currency){
      int levelBuyLife=PlayerPrefs.GetInt("Life_level_Text",0);
      if(levelBuyLife<=getCurrentLevel())
      if(currentSold>=currency){
        //retreive money 
        setSold(-currency);
        updateTotalSoldText();
        // buy more life 
         if(levelBuyLife<=10){
        /// +1 Life 
        PcBoxerHeadController.instance.addLifeToPc(1);
      }else if(levelBuyLife>10 && levelBuyLife<=20){
        /// +2 Life 
         PcBoxerHeadController.instance.addLifeToPc(2);
      }else if(levelBuyLife>20 && levelBuyLife<=30){
        /// +3 Life 
         PcBoxerHeadController.instance.addLifeToPc(3);
      }else{
        /// +5 Life
         PcBoxerHeadController.instance.addLifeToPc(5);
      }
      updateLevelForLife();
      setLevelForLife();
      }
      
    }
    public void setLevel(){
      int currentLevelText=PlayerPrefs.GetInt("current_level_Text",0);
      currentLevel.text="Level"+currentLevelText;
     
    }
    public void updateLevel(){
      int currentLevelText=PlayerPrefs.GetInt("current_level_Text",0);
      currentLevelText++;
     PlayerPrefs.SetInt("current_level_Text",currentLevelText);
     
    }private int getCurrentLevel(){
      return PlayerPrefs.GetInt("current_level_Text",0);

    }

    public void setLevelElastics(){
      int levelBuyElastics=PlayerPrefs.GetInt("Elastics_level_Text",0);
      levelBuyMoreElastics.text="Level"+levelBuyElastics;
    }
    public void updateLevelElastics(){
      int levelBuyElastics=PlayerPrefs.GetInt("Elastics_level_Text",0);
      levelBuyElastics++;
      levelBuyMoreElastics.text="Level"+levelBuyElastics;
      PlayerPrefs.SetInt("Elastics_level_Text",levelBuyElastics);
    }
    public void setLevelForLife(){
      int levelBuyLife=PlayerPrefs.GetInt("Life_level_Text",0);
      levelBuyMoreLife.text="Level"+levelBuyLife;
    } 
    public void updateLevelForLife(){
      int levelBuyLife=PlayerPrefs.GetInt("Life_level_Text",0);
      levelBuyLife++;
      levelBuyMoreLife.text="Level"+levelBuyLife;
      PlayerPrefs.SetInt("Life_level_Text",levelBuyLife);

    }
    private void setSold(int amount){
      currentSold+=amount;
      PlayerPrefs.SetInt("currentSold",currentSold);
    }private void updateTotalSoldText(){
      totalScroreText.text=currentSold.ToString();
    }
    
}
