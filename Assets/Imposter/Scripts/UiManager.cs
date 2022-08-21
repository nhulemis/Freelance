using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Imposter.Scripts
{
    public class UiManager : MonoBehaviour
    {
        public static UiManager instance;
        public  GameObject winPanel;
        public  GameObject startPanel;
        public  GameObject loosePanel;
        public Text currentLevelText;
        public Text totalCoinText;
        private int currentLevelIndex;
        public CoinManager coinM;
        public Transform target;
        private int totalCoin;
   
        void Awake(){
            if(!instance)
                instance=this;
            else if(instance!=this){
                Destroy(this.gameObject);
            }
        } 
        // Start is called before the first frame update

        public class khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj
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

        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj()
        {
            
        }
        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj GetkhsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(){
        var clasx = new khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj();
        return  clasx;
    }

    public string RandomStringkhsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {
            totalCoin=PlayerPrefs.GetInt("Total_Coin");
            currentLevelIndex=PlayerPrefs.GetInt("CurrentLevel");
            totalCoinText.text=totalCoin+"";
            if(SceneManager.GetActiveScene().buildIndex!=currentLevelIndex){
                //SceneManager.LoadScene(currentLevelIndex);
            }
            currentLevelText.text = "level : " + (currentLevelIndex+1);
            Advertisements.Instance.Initialize();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void play(){
            GameManager.instance.startGame();
            startPanel.SetActive(false);
        }
        public void win(){
            winPanel.SetActive(true);
            GameManager.instance.endGame();
            coinM.animate(target.position,10);
            Advertisements.Instance.ShowInterstitial();


        }
        public void loose(){
            Advertisements.Instance.ShowInterstitial();

            //loosePanel.SetActive(true);
            GameManager.instance.endGame();
            SceneManager.LoadScene("EjectScene");
        }
        public void nextLevel(){
            addCoin(100);
            currentLevelIndex++;
            if(currentLevelIndex>29)
                currentLevelIndex=0;
            PlayerPrefs.SetInt("CurrentLevel",currentLevelIndex);
            SceneManager.LoadScene(currentLevelIndex);

        }
        public void enableReportScene(){
            SceneManager.LoadScene("ReportScene");
        }
       
        public class eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr
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

        public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr()
        {
            
        }
        public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr GeteBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(){
        var clasx = new eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr();
        return  clasx;
    }

    public string RandomStringeBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void addCoin(int value){
            totalCoin=PlayerPrefs.GetInt("Total_Coin");
            totalCoin+=value;
            PlayerPrefs.SetInt("Total_Coin", totalCoin);


        }
        public void nextWithReward(){
            Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
        }
        private void CompleteMethod(bool completed, string advertiser) {
            Debug.Log("Closed rewarded from: "+advertiser+" -> Completed " + completed);
            if(completed == true) {
                addCoin(100);
                nextLevel();
                //give the reward 
            }
            else {
                //no reward 
            }
        }
        public void gooShoping(){
            SceneManager.LoadScene("Shop");

        }

    }
}
