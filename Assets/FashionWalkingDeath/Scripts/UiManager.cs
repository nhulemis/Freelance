using UnityEngine;
using UnityEngine.SceneManagement;

namespace FashionWalkingDeath.Scripts
{
    public class UiManager : MonoBehaviour
    {
        //Serialized Data
        [SerializeField]
        private GameObject mainMenuUi;
        [SerializeField]
        private GameObject combiSelectorUi;
        [SerializeField]
        private GameObject outFitFeedbackUi;
    
        [SerializeField]
        private GameObject completedLevelUi;
        [SerializeField]
        private GameObject looseLevelUi;
        [SerializeField]
        private GameObject conceptLevelUi;


        //References
        public static UiManager instance;

        private void Awake()
        {
            if (!instance) instance = this;
            
            
            
            
            else if (instance != this) Destroy(this.gameObject);
        }

        // Start is called before the first frame update
        void Start()
        {

            combiSelectorUi.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void enableCombiSelectorUi1(int avatarI)
        {
            combiSelectorUi.SetActive(true);
            
            
            
            
            combiSelectorUi.GetComponent<CombineUiController>().resetData(avatarI);
        }
        public void disableCombiSelectorUi1()
        {
            combiSelectorUi.SetActive(false);
        }
        public void startToPlay()
        {
            GameObject.FindObjectOfType<CharacterManager>().startRun();
            mainMenuUi.SetActive(false);
            GameManager.instance.startPlay();
            
            
            
            
            outFitFeedbackUi.SetActive(true);
        }
        public void ReloadLevel()
        {
            SceneManager.LoadScene("FashionWalkingDeath/Scenes/Scenes/MainScene");
        }
        public void looseLevel1()
        {
            ReloadLevel();
        }
        public void completeLevel1()
        {

            completedLevelUi.SetActive(true);
            
            
            
            
            outFitFeedbackUi.SetActive(false);
            conceptLevelUi.SetActive(false);


        }
        public void nextLevel()
        {
            print("nEXT lEVEV");
            int currentLevel=PlayerPrefs.GetInt("CurrentLevelIndex");
            if (currentLevel < 5)
            {
                currentLevel++;

            }
            else
                currentLevel = 0;
            PlayerPrefs.SetInt("CurrentLevelIndex", currentLevel);

            ReloadLevel();

        }
        public void enableConceptUi1()
        {
            conceptLevelUi.SetActive(true);
        }

    }
}
