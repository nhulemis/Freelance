using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace hairmaster.Scripts
{
    public class UiManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject inGamePanel;
        [SerializeField]
        private GameObject winPanel;
        [SerializeField]
        private GameObject loosePanel;
        [SerializeField]
        private Text currentCollectedCoinText;
        [SerializeField]
        private Text totalCollectedCoinText;
        [SerializeField]
        private Text currentCollectedCoinsText;
        [SerializeField]
        private Transform startPos;
        [SerializeField]
        private CoinManger coinM;
 
        //Private Data
        private int currentLevel;
        public int currentCollectedCoins;
        //References
        public static UiManager instance;
        private void Awake()
        {
            if (!instance)
                instance = this;
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            currentLevel = PlayerPrefs.GetInt("CurrentLevelIndex");
            
            setTotalCollectedCoinText();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void startGame()
        {
            
            
            inGamePanel.SetActive(false);
            GameManager.instance.startPlay();       
        }
        public void playerWin()
        {
            coinM.animate(startPos.position, 20);
            winPanel.SetActive(true);
            
            
            
            currentCollectedCoinsText.text = currentCollectedCoins + "";

            //Advertisements.Instance.ShowInterstitial();

        }
        public void playerLoose()
        {
            retryLevel();
        }
        public void nextLevel()
        {
            updateTotalCollectedCoin(currentCollectedCoins);

            updateCurrentLevel();
            int cuurentLevelIndex = getCurrentLevel();
            if (cuurentLevelIndex > 29)
                cuurentLevelIndex = 0;

            loadScene(cuurentLevelIndex);
        }
        private void updateCurrentLevel(int val=1)
        {
            currentLevel+=val;
            PlayerPrefs.SetInt("CurrentLevelIndex", currentLevel);
        }
        private int getCurrentLevel() {

            return PlayerPrefs.GetInt("CurrentLevelIndex");
        }
        public void retryLevel()
        {
            loadScene(currentLevel);
        }
        private void loadScene(int sceneIndex)
        {
            SceneManager.LoadScene("Level 16");
        }
        public void setCurrentCollectedCoin(int value)
        {
            currentCollectedCoins = value;

            setCurrentCollectedCoinText();
        }
        public void updateTotalCollectedCoin(int newCollected)
        {
            int te = getTotalCollectedCoin() + newCollected;
            PlayerPrefs.SetInt("Total_Coin", te);
        }
        public void setCurrentCollectedCoinText()
        {
            currentCollectedCoinText.text = "$" + currentCollectedCoins;

        }
        public void revive()
        {
        }
        public void gooShopping()
        {
        }
        
        
        private void CompleteMethod(bool completed, string advertiser)
        {
            Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
            if (completed == true)
            {
                //give the reward
                loosePanel.SetActive(false);
                CharacterMovementController.instance.revive();

            }
            else
            {
                //no reward
            }
        }
        private void setTotalCollectedCoinText()
        {
            totalCollectedCoinText.text = getTotalCollectedCoin() + "";
        }
        private int getTotalCollectedCoin()
        {
            return PlayerPrefs.GetInt("Total_Coin");
        }

    }
}
