using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    [Header("Ui Panels")]
    [SerializeField]
    private GameObject playUi;
    [SerializeField]
    private GameObject winUi;
    [SerializeField]
    private GameObject looseUi;

    [SerializeField]
    private GameObject coinadder;

    /// <summary>
    /// Private Data
    /// </summary>
    public static UiManager instance;

    private void Awake()
    {
        if (!instance) instance = this;
        if (instance != this) Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startPlay()
    {
        AdManager.instance.showBanner();
        playUi.SetActive(false);
        Gameplay.Instance.startPlay();
        PlayerController.instance.Init();
    }
    public void win()
    {
        AdManager.instance.showInter();

        winUi.SetActive(true);
    }
    public void loose()
    {
        AdManager.instance.showInter();
        looseUi.SetActive(true);
    }
    public void next()
    {
        int levelIndex = getCurrentLevel();
        if (levelIndex < 28)
        {
            levelIndex++;
        }
        else
        {
            levelIndex = 0;
        }
        PlayerPrefs.SetInt("CurrentLevel", levelIndex);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void retry()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
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
}
