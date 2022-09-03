using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RushStair.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public enum GameState{play,stop};
        public GameState state=GameState.stop;
        public GameObject win;
        public GameObject loose;
        public GameObject play;
        public GameObject InGameUi;
        //UI Text
        public Text currentLevlText;
        public Text currentCollectedCoinText;
        public Text totalCollectedCoinText;
        int currentLevel;
        //Reference
        public static GameManager instance;
        void Awake(){
            if(instance==null){
                instance=this;
            }else if(instance!=this)Destroy(this.gameObject);

        }
        // Start is called before the first frame update
     
        public class bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP
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

        public bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP()
        {
            
        }
        public bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP GetbwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP(){
        var clasx = new bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP();
        return  clasx;
    }

    public string RandomStringbwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
        {
            GameItemManager.Instance.SetUpColor();
            currentLevel=PlayerPrefs.GetInt("current_level",1);
            if(SceneManager.GetActiveScene().buildIndex!=currentLevel){
                //SceneManager.LoadScene(currentLevel);
            }
            updateCurrentCollectedCoin(0);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void gameStart(){
            state=GameState.play;
        }
        public void gameStop(){
            state=GameState.stop;
        }
        public bool gameIsplaying(){
            if(state==GameState.play)
                return true;
            else 
                return false;
        }
        public void startPlay(){

            play.SetActive(false);
            InGameUi.SetActive(true);
            setLevelText();
            gameStart();
            PlayerController.instance.startanim();
        }
        public void winLevel(){
            win.SetActive(true);

        }public void looseLevel(){
            loose.SetActive(true);
        }
        public void next(){

            if(currentLevel<30){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
                currentLevel++;
                PlayerPrefs.SetInt("current_level",currentLevel);
            }else{
                currentLevel=1;
                PlayerPrefs.SetInt("current_level",currentLevel);
                SceneManager.LoadScene(currentLevel);


            }
        }
        public void reload(){
            SceneManager.LoadScene(currentLevel);
        }
       
        public class OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK
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

        public OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK()
        {
            
        }
        public OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK GetOhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK(){
        var clasx = new OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK();
        return  clasx;
    }

    public string RandomStringOhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void setLevelText(){
            currentLevlText.text="Level"+(currentLevel+1);

        }
        public void updateCurrentCollectedCoin(int n){
            currentCollectedCoinText.text=n+"";
        }public void setTotalCoin(int n){
            totalCollectedCoinText.text=n+"";

        }

    }
}
