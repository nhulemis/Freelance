using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    //Panel
    [SerializeField]
    GameObject winPanel;
    [SerializeField]
    GameObject loosePanel;
    [SerializeField]
    GameObject startPanel;
    [SerializeField]
    GameObject inGamePanel;
    [SerializeField]
    Text totalCoinText;
    [SerializeField]
    Text inGameCollectedCoinText;
    [SerializeField]
    Text currentLevelText;
    [SerializeField]
    Text winCollectedCoinText;
    [SerializeField]
    Text levelCompletedCollectedCoinText;
    [SerializeField]
    GameObject popUpText;
    [SerializeField]
    Transform  winCollectedCoinStartAnimation;
    private int totalCollectedCoin;
    private int currentCollectedCoin;
    private int currentLevelIndex;
    private void Awake()
    {
        if (!instance) instance = this;
        else if (instance != this) Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
       
        currentCollectedCoin = 0;
        setLevelText();
        if (SceneManager.GetActiveScene().buildIndex != currentLevelIndex)
        {
           SceneManager.LoadScene(currentLevelIndex);
        }
            setTotalCoinText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void winLevel()
    {
        inGamePanel.SetActive(false);
        updateTotalCollectedCoins();
        winPanel.SetActive(true);
        Invoke("setWinCollectedCoinText", 2f);
    }
    public void nextLevel()
    {
        AudioController.instance.buttonClick();
        updateLevelIndex();
        SceneManager.LoadScene(currentLevelIndex);
    }
    public void retryLevel()
    {
        AudioController.instance.buttonClick();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void startPlay()
    {
        AudioController.instance.buttonClick();

        inGamePanel.SetActive(true);
        startPanel.SetActive(false);
        GameManager.instance.startPlay();
    }
    public void looseLevel()
    {
        
        Invoke("DelayLoosePanel",1f);
    }
    private void DelayLoosePanel()
    {
        inGamePanel.SetActive(false);
        loosePanel.SetActive(true);
    }
    private void setTotalCoinText()
    {
        totalCollectedCoin = PlayerPrefs.GetInt("TotalCoins");
        totalCoinText.text = totalCollectedCoin + "";
    }
    public void updateCurrentCollectedCoins()
    {
        currentCollectedCoin++;
        inGameCollectedCoinText.text = currentCollectedCoin + "";

    }
    private void updateTotalCollectedCoins()
    {
        totalCollectedCoin += currentCollectedCoin;
        PlayerPrefs.SetInt("TotalCoins", totalCollectedCoin);
    }
    private void setLevelText()
    {
        currentLevelIndex = PlayerPrefs.GetInt("LevelIndex");
        currentLevelText.text = "Level : "+ (currentLevelIndex + 1);
    }
    private void updateLevelIndex() {
        currentLevelIndex++;
        if (currentLevelIndex >= 19)
        {
            currentLevelIndex = 0;
        } 
            PlayerPrefs.SetInt("LevelIndex", currentLevelIndex);       

    }
    private void setWinCollectedCoinText()
    {
        CoinManger.instance.animate(winCollectedCoinStartAnimation.position,5);
        winCollectedCoinText.text = currentCollectedCoin + "";
        levelCompletedCollectedCoinText.text = "0";

    }
    public void enablePopUp(Vector3 popUpstartPos)
    {
        popUpstartPos = Camera.main.WorldToScreenPoint(popUpstartPos);
        Instantiate(popUpText,popUpstartPos,Quaternion.identity,this.transform);
    }

}
