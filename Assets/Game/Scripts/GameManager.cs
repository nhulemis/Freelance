using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public class ANCXUA
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
	
        public class Kcisjhuwkakxc
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
        public class Fsacvbsfgh
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
        public class hxjiaJXiakw
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
        public class hcizxjjHUAw
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
        public class Kxijaicuas
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
        public class KJCiajkx
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
        public class CHuaix
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
            public class KJCiajkx
            {
                private int buaquadi;
                private string chusx;
                public float gmac;
                private double mciajx;

                public int getX()
                {
                    return buaquadi;
                }
            }
        }
        public class ANCXUAHCuskawo
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
        public class ANCXUAchuskwjkax
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
        public class ANlxclpakcv4kaoxc
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
        public class OjkcisjKc5
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
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
        void Start()
        {
       
            currentLevel=PlayerPrefs.GetInt("current_level",0);
            if(SceneManager.GetActiveScene().buildIndex!=currentLevel){
               // SceneManager.LoadScene(currentLevel);
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

                SceneManager.LoadScene(0);
        }
        public void reload(){
            next();
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
