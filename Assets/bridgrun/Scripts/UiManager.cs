using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace bridgrun.Scripts
{
    public class UiManager : MonoBehaviour
    {
        public static UiManager instance;
        [SerializeField]
        private GameObject josytickControllerUi;
        //Serialized Data
        [SerializeField]
        private GameObject winPanel;
        [SerializeField]
        private GameObject loosePanel;
        [SerializeField]
        private GameObject playPanel;
        [SerializeField]
        private Text totalCoinText;
        [SerializeField]
        private Text currentCollectedCoinText;
        //Private Data
        private int currentCollectedCoin=100;
        private int totalCollectedCoin;
        private int currentLevel;
        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance = this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            //

        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void playerWin()
        {
            setCurrentCoinText();
            setTotalCoinValue();
            //Advertisements.Instance.ShowInterstitial();
            disableJoystickControllerUi();
            winPanel.SetActive(true);




        }
        public void playerLoose()
        {
            //Advertisements.Instance.ShowInterstitial();
            disableJoystickControllerUi();
            nextLevel1();


            loosePanel.SetActive(true);
        }
        private void disableJoystickControllerUi()
        {




            josytickControllerUi.SetActive(false);

        }
        public void nextLevel1 ()
        {



            SceneManager.LoadScene("1");

        }
        public void nextLevelRewarded()
        {
            //Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
        }
        public void retryLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void startPlay()
        {
            GameManager.instance.startPlay();
            playPanel.SetActive(false);



            josytickControllerUi.SetActive(true);
        }
        private void CompleteMethod(bool completed, string advertiser)
        {
            //
        }
        private void setTotalCoinValue(int value=100)
        {
            totalCollectedCoin += value;
            PlayerPrefs.SetInt("totalCollectedCoin", totalCollectedCoin);
        }
        public void setTotalCoinText()
        {
            totalCoinText.text = totalCollectedCoin + "";
        }
        public void setCurrentCoinText()
        {
            currentCollectedCoinText.text = currentCollectedCoin + "";
        }
        private void setCurrentCollectedCoin()
        {
            currentCollectedCoin += 100;
            totalCollectedCoin +=currentCollectedCoin;
            //  PlayerPrefs.SetInt("totalCollectedCoin", totalCollectedCoin);


        }
    }
}
