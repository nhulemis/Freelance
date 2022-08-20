using PetsIO._Scripts.other;
using UnityEngine;
using UnityEngine.UI;

namespace PetsIO._Scripts.Menu
{
    public class MainMenu : MonoBehaviour
    {
        private float timer;

        private GameObject btnName;
        private int ShowedSkn;
        private int showSkin;

        public GameObject goldEffect;
        public GameObject skinEffect;
        // Start is called before the first frame update
        void Awake()
        {
            AppMetrica.Instance.ReportEvent("MenuScene");
            //GameObject.Find("ADS").SendMessage("HideBanner");
            //PlayerPrefs.SetInt("showSkin", 2);
            showSkin = PlayerPrefs.GetInt("showSkin");
        
            timer = -9999;
        
            if (PlayerPrefs.GetInt("instBtn") != 0) Destroy(GameObject.Find("b_instagram"));
        
            int curDay = (int)System.DateTime.Now.Day;
            int oldDay = PlayerPrefs.GetInt("newDay");
        
            //PlayerPrefs.SetInt("firstStart", 0);
            if (curDay != oldDay && PlayerPrefs.GetInt("weeklyStart") == 1)
            {
                Camera.main.transform.position = new Vector3(400, 3.86f, -10f);
            }
        
        
        
            if (PlayerPrefs.GetInt("firstStart") == 0)
            {
                StartSetting();
            }
        
            informerUpdate();
            SkillSet(0);

            GameObject.Find("InputField").GetComponent<InputField>().text = PlayerPrefs.GetString("Nickname");
            GameObject.Find("t_score").GetComponent<TextMesh>().text = PlayerPrefs.GetInt("maxPet")+"";
            SetGold(0);
            StartSkin();
        
       

            
        
        }

        void StartSetting()
        {
            PlayerPrefs.SetInt("giftDay",999);
            Destroy(GameObject.Find("b_video"));
            Destroy(GameObject.Find("b_instagram"));
            GameObject.Find("b_shopmode").transform.Translate(Vector3.up*-999f);
            GameObject.Find("b_shopmode1").transform.Translate(Vector3.up*-999f);
            GameObject.Find("b_daily").transform.Translate(Vector3.up*0.72f);
            GameObject.Find("downPanel").transform.Translate(Vector3.right*-0.22f);
        
        
        
            PlayerPrefs.SetString("Nickname", "Player"+Random.Range(1321,7543));
        
            PlayerPrefs.SetInt("newDay", 999);
            PlayerPrefs.SetInt("weekDay", 1);
            
            PlayerPrefs.SetInt("firstStart", 1);
            PlayerPrefs.SetInt("gold", 3950);
            PlayerPrefs.SetInt("skill1", 1);
            PlayerPrefs.SetInt("skill2", 1);
            PlayerPrefs.SetInt("skill3", 1);
            PlayerPrefs.SetInt("skill4", 1);
        
            PlayerPrefs.SetInt("skin0", 1);

            PlayerPrefs.SetInt("instBtn", 0);
        }
    
        void informerUpdate()
        {

            if (PlayerPrefs.GetInt("showSkin") != PlayerPrefs.GetInt("curSkin"))
            {
                GameObject.Find("i_skinmode").transform.localPosition = new Vector3(0,0,0);
            }
            else
            {
                GameObject.Find("i_skinmode").transform.localPosition = new Vector3(0,999,0);
            }
        
            if (PlayerPrefs.GetInt("gold") >= 4000)
            {
                GameObject.Find("i_upgrade").transform.localPosition = new Vector3(0,0,0);
            }
            else
            {
                GameObject.Find("i_upgrade").transform.localPosition = new Vector3(0,999,0);
            }
        }
        // Update is called once per frame
        void Update()
        {
            if (GameObject.Find ("InputField").GetComponent<InputField> ().text != PlayerPrefs.GetString("Nickname") && GameObject.Find ("InputField").GetComponent<InputField> ().text != "")
            {
                PlayerPrefs.SetString("Nickname", GameObject.Find("InputField").GetComponent<InputField>().text);
            }
        
        
            if (Input.GetMouseButtonDown(0))
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
#if UNITY_ANDROID
                ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
#endif
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (hit.collider.tag == "Button")
                    {
                        GetComponent<AudioSource>().Play();
                        timer = 0.25f;
                        btnName = hit.collider.gameObject;
                        btnName.AddComponent<ButtonClickEffect>();
                        //if (hit.collider.name == "b_left" || hit.collider.name == "b_right") timer = -0.2f;
                    }

                    if (hit.collider.tag == "ButtonNoEffect")
                    {
                        GetComponent<AudioSource>().Play();
                        timer = -0.2f;
                        btnName = hit.collider.gameObject;
                    }
                }
            }

            timer -= Time.deltaTime;
            if (timer < 0 && timer > -100)
            {
                timer = -999;
                ButtonClicked();
            }
        }

        void ButtonClicked()
        {
            string nam = btnName.name;
        
            // **********************************************  1. PLAYMODE  *********************************


            if (nam != "b_left" || nam != "b_right")
            {
                AppMetrica.Instance.ReportEvent("mn_" + nam);
            }

            if (nam == "b_info")
            {
                DownPanelReset();
                Camera.main.transform.position = new Vector3(600, 3.86f, -10f);
            }
            if (nam == "b_policy")
            {
                Application.OpenURL("http://xn---35-5cda2d8ba.xn--p1ai/1/privacy_policy.html");
            }
            if (nam == "b_inst")
            {
                Application.OpenURL("https://www.instagram.com/evgeny.dev/");
            }
            if (nam == "b_vk")
            {
                Application.OpenURL("https://vk.com/svegames");
            }
            if (nam == "b_play")
            {
                Destroy(btnName);
                transform.Translate(Vector3.forward * 999);
                PlayerPrefs.SetInt("weeklyStart", 1);
                Application.LoadLevel("game");
            }
            if (nam == "b_sound")
            {
                AudioListener.volume = 1 - AudioListener.volume;

                if (AudioListener.volume == 1)
                {
                    btnName.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
                }
                else
                {
                    btnName.GetComponent<SpriteRenderer>().color = new Color(1,1,1,0.6f);
                }
            }
            if (nam == "b_video")
            {
                // SHOW REWARD VIDEO
                //GameObject.Find("ADS").SendMessage("ShowRewarded", 3);
            }
        
            if (nam == "b_achiv")
            {
                // SHOW REWARD VIDEO
                Camera.main.transform.position = new Vector3(500, 3.86f, -10f);
            }
        
            if (nam == "b_daily")
            {
                PlayerPrefs.SetInt("giftDay", (int)System.DateTime.Now.Day);
                SetGold(7000);
                Destroy(btnName);
                Instantiate(goldEffect, btnName.transform.position, goldEffect.transform.rotation);
            }
        
            if (nam == "b_instagram")
            {
            
            }
        
            // **********************************************  2. SHOP  *********************************
            if (nam == "b_buy1")
            {
                ////GameObject.Find("IAP").SendMessage("BuyProductID", "gold20000");
            }
            if (nam == "b_buy2")
            {
                //GameObject.Find("IAP").SendMessage("BuyProductID", "gold100000");
            }
            if (nam == "b_disableADS")
            {
                //GameObject.Find("IAP").SendMessage("BuyProductID", "gp_no_ads");
            }
            if (nam == "b_buyskin")
            {
                //GameObject.Find("IAP").SendMessage("BuyProductID", "randomskin");
            }
        
            // **********************************************  3. UPGRADE  **********************************
            int cost = 999999;
        
            if (nam == "b_speed")
            {
                foreach (Transform child in btnName.transform)
                {
                    if (child.name == "T_COST") cost = int.Parse(child.GetComponent<TextMesh>().text);
                }

                if (cost <= PlayerPrefs.GetInt("gold"))
                {
                    SetGold(-cost);
                    SkillSet(1);
                }
            }
            if (nam == "b_pets")
            {
                foreach (Transform child in btnName.transform)
                {
                    if (child.name == "T_COST") cost = int.Parse(child.GetComponent<TextMesh>().text);
                }

                if (cost <= PlayerPrefs.GetInt("gold"))
                {
                    SetGold(-cost);
                    SkillSet(2);
                }
            }
            if (nam == "b_chance2pets")
            {
                foreach (Transform child in btnName.transform)
                {
                    if (child.name == "T_COST") cost = int.Parse(child.GetComponent<TextMesh>().text);
                }

                if (cost <= PlayerPrefs.GetInt("gold"))
                {
                    SetGold(-cost);
                    SkillSet(3);
                }
            }
            if (nam == "b_bonusPets")
            {
                foreach (Transform child in btnName.transform)
                {
                    if (child.name == "T_COST") cost = int.Parse(child.GetComponent<TextMesh>().text);
                }

                if (cost <= PlayerPrefs.GetInt("gold"))
                {
                    SetGold(-cost);
                    SkillSet(4);
                }
            }
        
            // **********************************************  4. SKIN SELECT  **********************************
            if (nam == "b_left")
            {
                SkinShow(-1);
            }
            if (nam == "b_right")
            {
                SkinShow(1);
            }
        
            if (nam == "b_select")
            {
                PlayerPrefs.SetInt("curSkin", showSkin);
                PlayerPrefs.SetInt("showSkin", PlayerPrefs.GetInt("curSkin"));
            
            
                DownPanelReset();
                GameObject.Find("b_playmode").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                Camera.main.transform.position = new Vector3(0, 3.86f, -10f);

                StartSkin();

            }
            if (nam == "b_buy")
            {
                int cos = int.Parse(GameObject.Find("t_costPet").GetComponent<TextMesh>().text);
                if (cos <= PlayerPrefs.GetInt("gold")){
                    SetGold(-cos);
                    PlayerPrefs.SetInt("skin"+showSkin, 1);
                    PlayerPrefs.SetInt("curSkin", showSkin);
                    PlayerPrefs.SetInt("showSkin", PlayerPrefs.GetInt("curSkin"));
                    SkinShow(0);
                    StartSkin();
                }
            }
            // **********************************************  5. WEEK REWARD  **********************************
        
            if (nam == "b_day1")
            {
                PlayerPrefs.SetInt("weekDay", PlayerPrefs.GetInt("weekDay") + 1);
                int rndSkn = Random.Range(5, 9);
                PlayerPrefs.SetInt("showSkin", rndSkn);
                showSkin = PlayerPrefs.GetInt("showSkin");
                PlayerPrefs.SetInt("skin"+rndSkn, 1);
                Instantiate(skinEffect, GameObject.Find("GUI").transform.position, goldEffect.transform.rotation);
            
                Camera.main.transform.position = new Vector3(0, 3.86f, -10f);
                PlayerPrefs.SetInt("newDay", (int)System.DateTime.Now.Day);
            }
            if (nam == "b_day2")
            {
                PlayerPrefs.SetInt("weekDay", PlayerPrefs.GetInt("weekDay") + 1);
                SetGold(2000);
                Camera.main.transform.position = new Vector3(0, 3.86f, -10f);
                PlayerPrefs.SetInt("newDay", (int)System.DateTime.Now.Day);
                Instantiate(goldEffect, GameObject.Find("GUI").transform.position, goldEffect.transform.rotation);
            }
            if (nam == "b_day3")
            {
                PlayerPrefs.SetInt("weekDay", PlayerPrefs.GetInt("weekDay") + 1);
                int rndSkn = Random.Range(1, 45);
                PlayerPrefs.SetInt("showSkin", rndSkn);
                showSkin = PlayerPrefs.GetInt("showSkin");
                PlayerPrefs.SetInt("skin"+rndSkn, 1);
                Instantiate(skinEffect, GameObject.Find("GUI").transform.position, goldEffect.transform.rotation);
            
                Camera.main.transform.position = new Vector3(0, 3.86f, -10f);
                PlayerPrefs.SetInt("newDay", (int)System.DateTime.Now.Day);
            }
            if (nam == "b_day4")
            {
                PlayerPrefs.SetInt("weekDay", PlayerPrefs.GetInt("weekDay") + 1);
                SetGold(5000);
                Camera.main.transform.position = new Vector3(0, 3.86f, -10f);
                PlayerPrefs.SetInt("newDay", (int)System.DateTime.Now.Day);
                Instantiate(goldEffect, GameObject.Find("GUI").transform.position, goldEffect.transform.rotation);
            }
            if (nam == "b_day5")
            {
                PlayerPrefs.SetInt("weekDay", PlayerPrefs.GetInt("weekDay") + 1);
                SetGold(7000);
                Camera.main.transform.position = new Vector3(0, 3.86f, -10f);
                PlayerPrefs.SetInt("newDay", (int)System.DateTime.Now.Day);
                Instantiate(goldEffect, GameObject.Find("GUI").transform.position, goldEffect.transform.rotation);
            }
        
            if (nam == "b_day6")
            {
                PlayerPrefs.SetInt("weekDay", PlayerPrefs.GetInt("weekDay") + 1);
                int rndSkn = Random.Range(1, 45);
                PlayerPrefs.SetInt("showSkin", rndSkn);
                showSkin = PlayerPrefs.GetInt("showSkin");
                PlayerPrefs.SetInt("skin"+rndSkn, 1);
                Instantiate(skinEffect, GameObject.Find("GUI").transform.position, goldEffect.transform.rotation);
            
                Camera.main.transform.position = new Vector3(0, 3.86f, -10f);
                PlayerPrefs.SetInt("newDay", (int)System.DateTime.Now.Day);
            }
            if (nam == "b_day7")
            {
                PlayerPrefs.SetInt("weekDay", 1);
                SetGold(70000);
                Camera.main.transform.position = new Vector3(0, 3.86f, -10f);
                PlayerPrefs.SetInt("newDay", (int)System.DateTime.Now.Day);
                Instantiate(goldEffect, GameObject.Find("GUI").transform.position, goldEffect.transform.rotation);
                Instantiate(goldEffect, GameObject.Find("GUI").transform.position, goldEffect.transform.rotation);
            }
        
            // **********************************************  6.  ACHIEVEMENTS  **********************************
            if (nam == "b_ach1" || nam == "b_ach2" || nam == "b_ach3" || nam == "b_ach4" || nam == "b_ach5" || nam == "b_ach6" || nam == "b_ach7" || nam == "b_ach8" || nam == "b_ach9" )
            {
                btnName.SendMessage("SetAchiveActive");
                Instantiate(goldEffect, btnName.transform.position, goldEffect.transform.rotation);
            }



            if (nam == "b_playmode")
            {
                DownPanelReset();
                btnName.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                Camera.main.transform.position = new Vector3(0, 3.86f, -10f);
                if (ShowedSkn == 1)
                {
                    PlayerPrefs.SetInt("showSkin", PlayerPrefs.GetInt("curSkin"));
                    showSkin = PlayerPrefs.GetInt("showSkin");
                }
                StoreManager.Instance.HideStore();
            }

            if (nam == "b_shopmode" || nam == "b_shopmode1")
            {
                DownPanelReset();
                btnName.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                Camera.main.transform.position = new Vector3(100, 3.86f, -10f);
                if (ShowedSkn == 1)
                {
                    PlayerPrefs.SetInt("showSkin", PlayerPrefs.GetInt("curSkin"));
                    showSkin = PlayerPrefs.GetInt("showSkin");
                }
                StoreManager.Instance.ShowStore();
            }

            if (nam == "b_upgrademode")
            {
                DownPanelReset();
                btnName.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                Camera.main.transform.position = new Vector3(200, 3.86f, -10f);
                if (ShowedSkn == 1)
                {
                    PlayerPrefs.SetInt("showSkin", PlayerPrefs.GetInt("curSkin"));
                    showSkin = PlayerPrefs.GetInt("showSkin");
                }
                StoreManager.Instance.HideStore();

            }

            if (nam == "b_skinmode")
            {
                ShowedSkn = 1;
                DownPanelReset();
                btnName.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                Camera.main.transform.position = new Vector3(300, 3.86f, -10f);
            
                PlayerPrefs.SetInt("showSkin", PlayerPrefs.GetInt("curSkin"));
                GameObject.Find("i_skinmode").transform.Translate(Vector3.up*999);
                SkinShow(0);
                StoreManager.Instance.HideStore();

            }
            if (nam == "b_skinchose" )
            {
                ShowedSkn = 1;
                DownPanelReset();
                GameObject.Find("b_skinmode").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                Camera.main.transform.position = new Vector3(300, 3.86f, -10f);
            
                PlayerPrefs.SetInt("showSkin", PlayerPrefs.GetInt("curSkin"));
                GameObject.Find("i_skinmode").transform.Translate(Vector3.up*999);
                SkinShow(0);
            }
            informerUpdate();
        }

        void StartSkin()
        {
            var sp = GameObject.Find("startSkin");
        
            foreach (Transform child in sp.transform)
            {
                Destroy(child.gameObject);
            }
        
            var gs = GameObject.Find("SkinCollector").GetComponent<SkinCollector>().skins;
            var ns = Instantiate(gs[PlayerPrefs.GetInt("curSkin")], sp.transform.position, sp.transform.rotation);
            ns.transform.parent = sp.transform;
            ns.transform.localScale *= 1.3154f;
        }

        void SkinShow(int skn)
        {
            showSkin += skn;
        
            var sp = GameObject.Find("skinPlace");
        
            foreach (Transform child in sp.transform)
            {
                Destroy(child.gameObject);
            }

            var gs = GameObject.Find("SkinCollector").GetComponent<SkinCollector>().skins;

            if (showSkin >= gs.Length) showSkin = 0;
            if (showSkin < 0) showSkin = gs.Length-1;
        
            var ns = Instantiate(gs[showSkin], sp.transform.position, sp.transform.rotation);
            ns.transform.parent = sp.transform;
            ns.transform.localScale *= 0.66f;

            GameObject.Find("t_numSkin").GetComponent<TextMesh>().text = (showSkin + 1) + " / " + (gs.Length);
        
            GameObject.Find("skinGoldBg").transform.localPosition = new Vector3(0,0,0);
            
            if (PlayerPrefs.GetInt("skin" + showSkin.ToString()) == 1)
            {
                GameObject.Find("buyPlane").transform.localPosition = new Vector3(0,999,0);
            }
            else
            {
                GameObject.Find("battonBuyHere").transform.localPosition = new Vector3(0,0,0);
                GameObject.Find("buyPlane").transform.localPosition = new Vector3(0,0,0);

                int cost = 0;

                if (showSkin > 0) cost = 10000;
                if (showSkin > 4) cost = 15000;
                if (showSkin > 9) cost = 20000;
                if (showSkin > 14) cost = 20000;
                if (showSkin > 19) cost = 30000;
                if (showSkin > 24) cost = 30000;
                if (showSkin > 29) cost = 35000;
                if (showSkin > 34) cost = 40000;
                if (showSkin > 39) cost = 50000;
                GameObject.Find("t_costPet").GetComponent<TextMesh>().text = cost + "";
                
                if (showSkin == 45)
                {
                    GameObject.Find("battonBuyHere").transform.localPosition = new Vector3(0,999,0);
                    GameObject.Find("skinGoldBg").transform.localPosition = new Vector3(0,999,0);
                    GameObject.Find("t_costPet").GetComponent<TextMesh>().text = "FIND IN GIFTS  ";
                }
                

                if (cost <= PlayerPrefs.GetInt("gold"))
                {
                    GameObject.Find("b_buy").GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
                    GameObject.Find("b_buy").tag = "Button";
                }
                else
                {
                    GameObject.Find("b_buy").GetComponent<SpriteRenderer>().color = new Color(1,1,1,0.2f);
                    GameObject.Find("b_buy").tag = "Untagged";
                }
            }
            
            
        }
    
        void DownPanelReset()
        {
            GameObject.Find("b_playmode").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.12f);
            GameObject.Find("b_shopmode").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.12f);
            GameObject.Find("b_upgrademode").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.12f);
            GameObject.Find("b_skinmode").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.12f);
        }
    
        void SkillSet(int skill)
        {
            PlayerPrefs.SetInt("skill" + skill.ToString(), PlayerPrefs.GetInt("skill" + skill.ToString()) + 1);

        
        }

        void SetGold(int gd)
        {
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold") + gd);
            GameObject.Find("t_coins").GetComponent<TextMesh>().text = PlayerPrefs.GetInt("gold") + "";

        }
        void GoldEffect()
        {
            Instantiate(goldEffect, GameObject.Find("GUI").transform.position, goldEffect.transform.rotation);
        }

        void RandomSkin(int minSkin)
        {
            int rndSkn = Random.Range(minSkin, 46);
            PlayerPrefs.SetInt("showSkin", rndSkn);
            showSkin = PlayerPrefs.GetInt("showSkin");
            PlayerPrefs.SetInt("skin"+rndSkn, 1);
            Instantiate(skinEffect, GameObject.Find("GUI").transform.position, goldEffect.transform.rotation);
            
            Camera.main.transform.position = new Vector3(0, 3.86f, -10f);
        }
    }
}