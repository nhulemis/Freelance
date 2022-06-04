using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace match3D.Scripts
{
    public class UiManager : MonoBehaviour
    {
        [Header("Panels")]
        public GameObject inGamePanel;
        public GameObject playPanel;
        public GameObject winPanel;
        public GameObject loosePanel;
    
    

        [Header("Text")]
        public Text currentMatchedObjects;
        public Text currentTimeText;
        public Text inGameLevelText;
        public Text playLevelText;

        public Text totalCoinText;
        public Text totalCoinText2;
        public Text completeTimeText;




        public CoinManger coinM;
        public static UiManager instance;
        //Private Variables
        private int currentMatchedValue;
        private int minute;
        private int secondes;
        private int totalObjectToMatch;
        private int totalCoin;
        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            currentMatchedValue = 0;
            setTime();
            assignTotalObjects();
            setMtachedObject();
            setTotalCoin();
            setIngameLevelText();
            int tt = PlayerPrefs.GetInt("CurrentLevelIndex");
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void matchedObject(int value=1)
        {
            currentMatchedValue += value;
            setMtachedObject();
        }
        private void setMtachedObject()
        {
            currentMatchedObjects.text = currentMatchedValue.ToString() + "/" + totalObjectToMatch;

        }
        private void setTime(){
            float totalTimeInSecondes = LevelsManager.instance.getLevelTime();
            float m =totalTimeInSecondes / 60;
            minute = (int)m;
        
            secondes = (int)(m - minute);
            setTimeText();


        }
        private void setTimeText(){
            if (secondes < 10)
                currentTimeText.text = minute + ":0" + secondes;
            else
                currentTimeText.text = minute + ":" + secondes;


        }

        public void startPlay(){
            AudioManager.instance.playButtonClick();
            playPanel.SetActive(false);
            inGamePanel.SetActive(true);
            LevelsManager.instance.enablePhysics();
            GameManager.instance.startPlay();
            StartCoroutine("StartTiming");
            
            
            
            

        }
        IEnumerator StartTiming(){

            
            
            
            yield return new WaitForSeconds(1f);
            switch (GameManager.instance.currentState)
            {

                case GameManager.GameState.play:
                    if (minute >= 0)
                    {
                        if (secondes > 0)
                        {
                            secondes--;
                            setTimeText();

                        }
                        else
                        {
                            minute--;
                            secondes = 59;
                            if(minute!=-1)
                                setTimeText();

                        }
                        StartCoroutine("StartTiming");

                    }
                    else
                    {
                        loose();
                        GameManager.instance.endPlay();
                        StopAllCoroutines();
                        print("game end Looooose");
                    }

                    break;

            }





        }
        public void winGame()
        {
            LevelsManager.instance.nextLevel();

            StopAllCoroutines();
            setCompleteTimeText();
            
            
            
            updateTotalCoin(totalObjectToMatch);
            Invoke("winPanelDelay", 2f);
            GameManager.instance.endPlay();

        }
        private void winPanelDelay()
        {
            inGamePanel.SetActive(false);

            winPanel.SetActive(true);

        }
        private void loose(){
            next();
            inGamePanel.SetActive(false);
            
            
            
            loosePanel.SetActive(true);

        }
        public void retry()
        {
            AudioManager.instance.playButtonClick();
            
            
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void next() {
            SceneManager.LoadScene("main");

        }
        public void nextWithReward()
        {
        }
        private void CompleteMethod2(bool completed, string advertiser)
        {
            Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
            if (completed == true)
                
                
                
            {
                //give the reward
                updateTotalCoin(totalObjectToMatch);
                next();
            }
            else
            {
                //no reward
            }
        }

        public void animateCoin(Transform startplace)
        {
            Vector3 startAnimpos = Camera.main.WorldToScreenPoint(startplace.position);
            coinM.animate(startAnimpos,5);
        }
        private void setIngameLevelText(){
            int leveIndex = PlayerPrefs.GetInt("CurrentLevelIndex");
            leveIndex += 1;
            
            
            
            inGameLevelText.text = "level : " +leveIndex;
            playLevelText.text = "level : " +leveIndex;


        }
        public void assignTotalObjects()
        {
            totalObjectToMatch = LevelsManager.instance.getTotalObject();

        }
        public void addExtraTime()
        {
            if (totalCoin >= 100)
            {
                
                
                updateTotalCoin(-100);
                setTotalCoin();
                addTime();
            }
        
        
        }
        private void addTime()
        {
            StopAllCoroutines();
            minute += 1;
            GameManager.instance.startPlay();
            
            
            
            StartCoroutine("StartTiming");
            loosePanel.SetActive(false);
            inGamePanel.SetActive(true);
            
            
        }
        public void addExtraTimeReward()
        {
            StopAllCoroutines();
        }
        private void setTotalCoin()
        {
            totalCoin = PlayerPrefs.GetInt("Total_Coin");
            totalCoinText.text = totalCoin + "";
            totalCoinText2.text = totalCoin+"";
        }
        private void updateTotalCoin(int value)
        {
            totalCoin += value;
            PlayerPrefs.SetInt("Total_Coin",totalCoin);

        }
        private void CompleteMethod(bool completed, string advertiser)
        {
            Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
            if (completed == true)
            {
                print("yooooo");
                //give the reward
                addTime();
            }
            else
            {
                //no reward
            }
        }
        private void setCompleteTimeText()
        {
            completeTimeText.text = minute + " : " + secondes;
        }
    

    }
}