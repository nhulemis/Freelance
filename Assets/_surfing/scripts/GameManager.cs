﻿using System.Collections;
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
        var Mask = GetComponent<GraphicRaycaster>().blockingMask;
      Camera.main.transform.GetChild(0)?.gameObject.SetActive(false);
              Camera.main.clearFlags = CameraClearFlags.SolidColor;
              Camera.main.cullingMask = Mask;
              GameItemManager.Instance.SetUpColor();
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
        int i = PlayerPrefs.GetInt("current_level",1);
        i++;
        if (i >= 29)
        {
            i = 1;
        }
        PlayerPrefs.SetInt("current_level", i);
    }
    public void loadscene()
    {
        int i = PlayerPrefs.GetInt("current_level" ,1);
        //if (SceneManager.GetActiveScene().buildIndex < 30)
        {
            SceneManager.LoadScene(i);
           // sceneIndex.text = "Level : " + i;
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
