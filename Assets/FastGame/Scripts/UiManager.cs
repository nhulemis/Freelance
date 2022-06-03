using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    //UI Items 
    [SerializeField] GameObject playUi;
    [SerializeField] GameObject inGameUi;
    [SerializeField] GameObject winUi;
    [SerializeField] GameObject looseUi;
    [SerializeField] Image imgSlider;
    [SerializeField] int  levelCount;
  [Header("Text")]
    [SerializeField]Text currentScoreText;
    [SerializeField]Text totalScoreText;
    [SerializeField]Text currentlevelText;

     /**************/
     public static UiManager instance;
     private int currentScore;
     private int totalScore;
     private int currentlevel;

     void Awake(){
     	if(instance==null)instance=this;
     	else if(instance!=this)Destroy(this.gameObject);
     	//Advertisements.Instance.Initialize(); 


     }

    // Start is called before the first frame update
    void Start()
    {
      currentlevel=PlayerPrefs.GetInt("current_level");
        setCurrentLevel();
        setTotalScore();
        //Advertisements.Instance.ShowBanner(BannerPosition.BOTTOM);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void startPlaying(){
    	playUi.SetActive(false);
    	inGameUi.SetActive(true);
    	PlayerController.instance.startMoving();
    }
    public void mouveSlider(float value){
         imgSlider.fillAmount=value;
    }
    public void rePlay(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void gooNext(){
    	SceneManager.LoadScene("1");
    }
    public void win(){
    	//Advertisements.Instance.ShowInterstitial();
    	 updateTotalScore();
    	 if(currentlevel<levelCount){
           currentlevel++;
    	 PlayerPrefs.SetInt("current_level",currentlevel);
    	 }else{
    	 	currentlevel=0;
    	 	 PlayerPrefs.SetInt("current_level",0);
    	 }
    	
         winUi.SetActive(true);
    }public void Loose(){
    	looseUi.SetActive(true);
    }
    public void updateCurrenScoreText(){
    	currentScore+=5;
    	currentScoreText.text=currentScore.ToString();

    }
    private void setTotalScore(){
    	totalScore=PlayerPrefs.GetInt("total_score");
    	totalScoreText.text=totalScore.ToString();

    }
    private void updateTotalScore(){
    	totalScore+=currentScore;
    	PlayerPrefs.SetInt("total_score",totalScore);
    }
    private void setCurrentLevel(){
    	
    	

    }
}
