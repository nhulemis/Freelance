using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{
    [SerializeField]
    GameObject winPanel;
    [SerializeField]
    GameObject loosePanel;
    [SerializeField]
    GameObject inGamePanel;
    [SerializeField]
    GameObject playPanel;
    [SerializeField]
    GameObject scorepopup;
    
    
    [Header("Text")]
    [SerializeField]
    Text currentLevlText;
    [SerializeField]
    Text totalCoinText;
    [SerializeField]
    Text currentCollectedCoinText;



    private int currentLevel;
    private int totalcoin;
    private int currentCollectedCoin;
    //Reference
    public static UiManager instance;

    void Awake(){
    	if(instance==null)instance=this;
    	else if(instance!=this)Destroy(this.gameObject);




    }
    // Start is called before the first frame update
    void Start()
    {
       





        currentCollectedCoinText.text="0";
        assignTotalCoinText();
        assignLevelText();
       // Advertisements.Instance.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void winLevel(){


       // Advertisements.Instance.ShowInterstitial();

        upateTotalCoin(currentCollectedCoin);
    	currentLevel++;

    	PlayerPrefs.SetInt("Current_Level",currentLevel);
    	winPanel.SetActive(true);
    }
    
    
    public void looseLevel(){
       // Advertisements.Instance.ShowInterstitial();
          SceneManager.LoadScene("1");

        loosePanel.SetActive(true);
    }
    public void play(){
    	playPanel.SetActive(false);
    	inGamePanel.SetActive(true);





    	CharacterController.instance.startPlay();
    }
    private void assignLevelText(){
    	currentLevlText.text="Level"+currentLevel;

    }
    private void assignTotalCoinText(){
    	totalCoinText.text=""+totalcoin;
    }
    private void upateTotalCoin(int n){


    	totalcoin+=n;
    	PlayerPrefs.SetInt("Total_Coin",totalcoin);
    }
    public void next(){
    	
          SceneManager.LoadScene("1");
    	
    }
    public void replay(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
       public void addScore(Vector3 position)
    {
        Instantiate(scorepopup, Camera.main.WorldToScreenPoint(position), Quaternion.identity,this.transform);
    }
       public void updateCurrentCollectedCoin()
    {
        currentCollectedCoin++;
        currentCollectedCoinText.text=currentCollectedCoin+"";
    }
    public void open(){

    }
    public void gooShoping(){
        SceneManager.LoadScene("CharactersShop");

    }


}
