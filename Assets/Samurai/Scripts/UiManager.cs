using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
     //win item
    [Header("Ui Panel")]
    public GameObject playUi;
    public GameObject winUi;
    public GameObject nextButton;
    public GameObject failUi;
    public GameObject happyUi;
    public GameObject collectedCoin;
    public GameObject xCoinButton;
    public Animator totalCollectedCoinAnim;
    public Text winCollectedCoin;
    public Text currentLevelText;
    private  int currentLevel;
    public static UiManager instance;
    public Text totalCoinText;
    private int totalCoin;
    public GameObject shopNotification;
    public CoinManger coinM;
    public Transform coinSP;
    private void Awake(){
    	if(instance==null){
    		instance=this;
    	}else if(instance!=this){
    		Destroy(this.gameObject);
    	}
    }
    // Start is called before the first frame update
    void Start()
    {
         currentLevel=PlayerPrefs.GetInt("Current_Level",0);
         //if(SceneManager.GetActiveScene().buildIndex!=currentLevel)
           //  SceneManager.LoadScene(currentLevel);
        totalCoin=PlayerPrefs.GetInt("Total_Coin",0);
        if(totalCoin>1000)
        shopNotification.SetActive(true);
        else
         shopNotification.SetActive(false);
         setTotalCoinText();

       
        setLevelText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void dragToPlay(){
    	GameManager.instance.enablePlayMode();
    	startPlayMode();
    }
    public void startPlayMode(){
    	playUi.SetActive(false);

    }
    public void win(){
        
    	winUi.SetActive(true);
        StartCoroutine("panelsDelay",.5f);
    } 
    IEnumerator panelsDelay(){
         happyUi.SetActive(true);
        yield return new WaitForSeconds(2f);
        collectedCoin.SetActive(true);
       
        StartCoroutine("coinTextIncremetorDelay");
        xCoinButton.SetActive(true);

    }
    int tempCoin=0;
    IEnumerator coinTextIncremetorDelay(){
          coinM.animate(coinSP.position,1);
        yield return new WaitForSeconds(.00001f);
        if(tempCoin<200){
            tempCoin++;
            winCollectedCoin.text=tempCoin+"";
          StartCoroutine("coinTextIncremetorDelay");
        }else{
            totalCollectedCoinAnim.enabled=false;
            nextButton.SetActive(true);
            totalCoin+=200;
            PlayerPrefs.SetInt("Total_Coin",totalCoin);
        }
       



    }
    public void levelFail(){
        
        failUi.SetActive(true);
    }
    public void retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }
    public void skipLevel(){      
       gooNextLevel();
    }
    public void gooNextLevel(){
        currentLevel++;
        if(currentLevel>21)
        PlayerPrefs.SetInt("Current_Level",0);
        else
        PlayerPrefs.SetInt("Current_Level",currentLevel);

        SceneManager.LoadScene(currentLevel);
    }
    public void gooShopping(){
        SceneManager.LoadScene("Shop");
    }
    private void setLevelText(){
        currentLevelText.text="level:"+currentLevel;

    }
    
    private void setTotalCoinText(){
        totalCoinText.text=totalCoin+"";
    }
}
