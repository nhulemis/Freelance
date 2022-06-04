using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UiManager : MonoBehaviour
{
    //Serialized Data
    [Header("Ui Panels")]
    [SerializeField]
    private GameObject playUi;
    [SerializeField]
    private GameObject winUi;
    [SerializeField]
    private GameObject looseUi;
    [SerializeField]
    private GameObject coinadder;
    [SerializeField]
    private CoinManager coinM;
    [SerializeField]
    private  TextMeshProUGUI totalCoinText;
    [SerializeField]
    private TextMeshProUGUI toClainCoinText;
    [SerializeField]
    private TextMeshProUGUI toClainRewadCoinText;

    [Header("Arrow Panel")]
    [SerializeField]
    private TextMeshProUGUI arrowPanelevelText;
    [SerializeField]
    private TextMeshProUGUI arrowPanelMultiplyPrice;


    //Private Data
    private int currentCollectedCoin;
    

    /// <summary>
    /// Private Data
    /// </summary>
    public static UiManager instance;

    private void Awake()
    {
        if (!instance) instance = this;
        if (instance != this) Destroy(this.gameObject);
        if (SceneManager.GetActiveScene().buildIndex != getCurrentLevel())
        SceneManager.LoadScene(getCurrentLevel());
    }
    // Start is called before the first frame update
    void Start()
    {
        assignTotalCoinText();
        assignPanelArrowText();
        assignCur1rentLevelPrice();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    public void startPlay()
    {
        playUi.SetActive(false);
        Gameplay.Instance.startPlay();
        PlayerController.instance.Init();
    }
    public void win()
    {
        winUi.SetActive(true);
        updateCurrentLevel();
        assignEndCoinText();
    }
    public void updateCurrentLevel()
    {
        int levelIndex = getCurrentLevel();
        if (levelIndex < 9)
        {
            levelIndex++;
        }
        else
        {
            levelIndex = 0;
        }
        PlayerPrefs.SetInt("CurrentLevel", levelIndex);
    }
    public void loose()
    {
        looseUi.SetActive(true);
    }
     IEnumerator nextLevel()
    {
        yield return new WaitForSeconds(1f);
            
        SceneManager.LoadScene("1");
    }
    public void next()
    {
        StartCoroutine(nextLevel());
    }
    public void claimColletedCoin()
    {
        coinM.updateCurrentCollectedCoin(currentCollectedCoin);
        assignTotalCoinText();
        StartCoroutine(nextLevel());
        
    }
    public void claimCollectedCoinReward()
    {
    }
    public void retry()
    {
        
        
        
        
        
    }
    public void newCollected(Vector3 pos,float value)
    {
        Vector3 newPos = Camera.main.WorldToScreenPoint(pos);
        GameObject newMulti= Instantiate(coinadder, newPos,Quaternion.identity,this.transform);
        
        
        newMulti.GetComponent<MultiTextController>().setData(value);
    }
    private int getCurrentLevel()
    {
        return PlayerPrefs.GetInt("CurrentLevel");
    }

    public void skip()
    {
    }
    public void assignCurrentCollectedCoin(int val)
    {
        currentCollectedCoin = val;
    }
    public void assignTotalCoinText()
    {
        totalCoinText.text = coinM.getCurrentCollectedCoin()+"";
    }
    public void rewardCoinClaimed()
    {
        coinM.updateCurrentCollectedCoin(currentCollectedCoin*2);
        assignTotalCoinText();
    }
    public void assignEndCoinText()
    {
        toClainCoinText.text = currentCollectedCoin + "";
        toClainRewadCoinText.text = currentCollectedCoin*2 + "";

    }
    public void addArrow()
    {
        if (getArrowPanelLevel1() < getCurrentLevel())
        {
            int requiredCoinValue = getArrowPanelLevel1() * 250;
            if (coinM.haveEnoughCoin(requiredCoinValue))
            {
                print("Chrot Agreed");
                coinM.updateCurrentCollectedCoin(-requiredCoinValue);
                assignTotalCoinText();
                updateCurrentPanelLevel();
                assignCur1rentLevelPrice();
                assignPanelArrowText();
                ArrowsController.instance.addByCommand(getArrowPanelLevel1());
            }
        }
        print("Addd More Arrow");
    }
    private void assignPanelArrowText()
    {
        arrowPanelevelText.text = "Level " + getArrowPanelLevel1();
    }
    private void assignCur1rentLevelPrice()
    {
        
        
        
        
        arrowPanelMultiplyPrice.text = getArrowPanelLevel1()* 250+"";
    }
    private int getArrowPanelLevel1()
    {
        return PlayerPrefs.GetInt("ArrowCurrentLevelIndex")+1;
    }
    private void updateCurrentPanelLevel()
    {
        int index = getArrowPanelLevel1();
        
        
        
        
        
        
        
        index++;
        PlayerPrefs.SetInt("ArrowCurrentLevelIndex",index);

    }
    

}
