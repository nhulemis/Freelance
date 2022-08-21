using PetsIO._Scripts.other;
using UnityEngine;
using UnityEngine.UI;

namespace PetsIO._Scripts
{
    public class MainSystem : MonoBehaviour
    {
        public GameObject halfTimeGo;
        public GameObject tapToContinue;
        public GameObject EndLevel;
        public GameObject ExtraTime;
    
        public float gameTimer;
        private float halfTime;
        private int receiveGold;
        private float timer;
        private GameObject Hero;
        private GameObject t_timer;
        private int stepGame;
        private int ht;

        private int tutorBool;
        private float timer22;
        private int rewa;

        private int firstGame;

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
            AppMetrica.AppMetrica.Instance.ReportEvent("gameScene");
            Hero = GameObject.Find("Hero");
            halfTime = gameTimer * 0.5f;
            timer = 1;
            t_timer = GameObject.Find("t_timer");
            // gameTimer = 67;
            GameObject.Find("extraTime").transform.Translate(Vector3.up*9999);
       
            //
            firstGame = PlayerPrefs.GetInt("firstGame");
            if (firstGame < 4)
            {
                PlayerPrefs.SetInt("firstGame", PlayerPrefs.GetInt("firstGame") + 1);
            }

            //timer = 5.113f;
            //if (firstGame > 2) 
            //GameObject.Find("ADS").SendMessage("ShowBanner");
        }

        void TimeConvert()
        {
            int min = (int)Mathf.Floor(gameTimer / 60);
            int sec = (int)Mathf.Floor(gameTimer)-(min*60);
            string zero = "";
            if (sec < 10) zero = "0";
            t_timer.GetComponent<TextMesh>().text = min + ":" + zero + sec;
        }


        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (tutorBool == 0)
                {
                    GameObject.Find("Hero").GetComponent<Controll>().StartedGame = true;
                    Destroy(GameObject.Find("tutorial"), 1.5f);
                    tutorBool = 1;
                }
            }

            if (transform.position.y == 5)
            {
                transform.position = new Vector3(0,0,0);
                Reward2x();
            }
        
            gameTimer -= Time.deltaTime;
            TimeConvert();

            if (stepGame == 0 && gameTimer < halfTime+5)
            {
                if (ht == 0)
                {
                    var g = Instantiate(halfTimeGo, Camera.main.transform.position, halfTimeGo.transform.rotation);
                    g.transform.parent = Camera.main.transform;
                    g.transform.localEulerAngles = new Vector3(0,0,0);
                    ht = 1;
                    g.name = "halfTimerGobj";
                }
                int min = (int)Mathf.Floor(gameTimer / 60);
                if (ht != 2) GameObject.Find("t_timerHalf").GetComponent<TextMesh>().text = (int)Mathf.Floor(gameTimer)-(min*60) +" sec";
            }
        
            if (gameTimer < halfTime && stepGame == 0)
            {
                Time.timeScale = 0;
                if (ht == 1){
                    var s = Instantiate(tapToContinue, Camera.main.transform.position, tapToContinue.transform.rotation);
                    s.transform.parent = Camera.main.transform;
                    s.transform.localEulerAngles = new Vector3(0,0,0);
                    s.name = "tapToContinue";
                
                    AppMetrica.AppMetrica.Instance.ReportEvent("halftimeStart");
                    Destroy(GameObject.Find("halfTimerGobj"));
                    ht = 2;
                }
                
                if (Input.GetMouseButtonDown(0))
                {
                    //HALF TIME - SHOW ADS
                    if (firstGame > 1) //GameObject.Find("ADS").SendMessage("ShowInterstitial");
                        Time.timeScale = 1;
                    stepGame = 1;
                    timer = 5.113f;
                    AppMetrica.AppMetrica.Instance.ReportEvent("halftimeEnd");
                    Destroy(GameObject.Find("tapToContinue"));
                }
            }
        
            if (gameTimer < 0 && stepGame > 0)
            {
                if (timer == 5.113f)
                {
                    Time.timeScale = 0;
                
                    GameObject.Find("extraTime").transform.Translate(Vector3.up*-9999);
                    var tt = Instantiate(ExtraTime,  GameObject.Find("GUI").transform.position, EndLevel.transform.rotation);
                    tt.transform.parent = GameObject.Find("GUI").transform;
                    tt.transform.localEulerAngles = new Vector3(0,0,0);
                    tt.name = "ExtraTime";

                }
            
                if (timer < 5f)
                {
                    GameObject.Find("circleGI").GetComponent<Image>().fillAmount = timer/5;
                }

                timer -= Time.unscaledDeltaTime;
                if (timer < 0 || stepGame == 2)
                {
                
                    AppMetrica.AppMetrica.Instance.ReportEvent("finishedTime");
                    GameFinished();
                }
            
                //END GAME - OR REWARD AND PLAY NEXT
                if (transform.position.y == 1)
                {
                
                    Time.timeScale = 1;
                    stepGame = 2;
                    gameTimer = halfTime;
                    GameObject.Find("extraTime").transform.Translate(Vector3.up*9999);
                    Destroy(GameObject.Find("ExtraTime"));
                    transform.position = -Vector3.up;
                }
            
            
            }
        
        
        
            //////////////////////////////////////////////////////////////////   INPUT MOUSE  //////////////////////////
            if (Input.GetMouseButtonDown(0) && timer != 5.11f)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    GameObject hitObj = hit.collider.gameObject;
                    string gname = hitObj.name;
                    if (hitObj.tag == "Button")
                    {
                        hitObj.AddComponent<ButtonClickEffect>();
                        GetComponent<AudioSource>().Play();
                        if (gname == "b_nothx")
                        {
                            GameFinished();
                        }
                        if (gname == "b_getit")
                        {
                            AppMetrica.AppMetrica.Instance.ReportEvent("gp_b_getIt");
                            timer = 9999f;
                            //GameObject.Find("ADS").SendMessage("ShowRewarded", 1);
                            //transform.position = Vector3.up;
                        }
                        if (gname == "b_toMainMenu")
                        {
                            AppMetrica.AppMetrica.Instance.ReportEvent("gp_b_mainmenu");
                            //GameObject.Find("ADS").SendMessage("ShowInterstitial");
                            Time.timeScale = 1;
                            Application.LoadLevel("menu");
                        }
                        if (gname == "b_receivex2")
                        {
                            AppMetrica.AppMetrica.Instance.ReportEvent("gp_b_receivex2");
                            timer = 9999f;
                            //GameObject.Find("ADS").SendMessage("ShowRewarded", 2);
                            //Time.timeScale = 1;
                            //Application.LoadLevel("menu");
                        }
                    
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        void GetFood( GameObject fd)
        {
            Destroy(fd);
        }

        void GameFinished()
        {
            Time.timeScale = 0;
            if (GameObject.Find("extraTime")) Destroy(GameObject.Find("extraTime"));
            if (GameObject.Find("ExtraTime")) Destroy(GameObject.Find("ExtraTime"));
            var tt = Instantiate(EndLevel, GameObject.Find("GUI").transform.position, EndLevel.transform.rotation);
            tt.transform.parent = GameObject.Find("GUI").transform;
            tt.transform.localEulerAngles = new Vector3(0, 0, 0);
            tt.name = "EndLevel";

            receiveGold = (int) (GameObject.Find("Hero").GetComponent<Controll>().scoreAll * 0.5f);
            GameObject.Find("t_yourCoins").GetComponent<TextMesh>().text = receiveGold + "";

            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold") + receiveGold);

            if (GameObject.Find("Hero").GetComponent<Controll>().countPet > PlayerPrefs.GetInt("maxPet"))
            {
                PlayerPrefs.SetInt("maxPet", GameObject.Find("Hero").GetComponent<Controll>().countPet);
            }

            GameObject.Find("t_timer").transform.Translate(Vector3.up * 999);
            stepGame = 3;
            timer = 9999f;
        }

        void Reward2x()
        {
            Time.timeScale = 1;
            //receiveGold = (int)(GameObject.Find("Hero").GetComponent<Controll>().scoreAll * 0.5f);
            GameObject.Find("t_yourCoins").GetComponent<TextMesh>().text = (receiveGold*2) + "";
        
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold") + receiveGold);
            
            Application.LoadLevel("menu");
        }
    
    
    
    
    }
}
