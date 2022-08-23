using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RoofRails_template.Scripts
{
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

        public class ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh()
        {
            
        }
        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh GetERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(){
        var clasx = new ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh();
        return  clasx;
    }

    public string RandomStringERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {
       

            PlayerPrefs.SetInt("PLAYERLEVEL",0);
            GameItemManager.Instance.SetUpColor();


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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            loosePanel.SetActive(true);
        }
        public void play(){
            playPanel.SetActive(false);
            inGamePanel.SetActive(true);





            CharacterController.instance.startPlay();
        }
       
        public class etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV()
        {
            
        }
        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV GetetYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(){
        var clasx = new etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV();
        return  clasx;
    }

    public string RandomStringetYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(int length)
    {
        string chars = string.Empty;
        return chars;
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
        public void next()
        {
            int level = PlayerPrefs.GetInt("PLAYERLEVEL", 0);
            level++;
            if (level > 19)
            {
                level = 0;
            }
            PlayerPrefs.SetInt("PLAYERLEVEL",level);
            SceneManager.LoadScene(level);
    	
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
}
