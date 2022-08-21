using PetsIO._Scripts.other;
using PetsIO.Standard_Assets.CNControls.Scripts.CnInputSystem;
using UnityEngine;
using Random = UnityEngine.Random;

namespace PetsIO._Scripts
{
    public class Controll : MonoBehaviour
    {
        // Start is called before the first frame update
        //Animator m_Animator;
        public string names;
        public bool bot;
    
        public int score;
        public int scoreAll;
    
        public GameObject JoystickBase;
        public GameObject Stick;
    
        public float speed;
    
        private int wohooCount;
        private float voiceTimer;
        private float timer;
        private GameObject MainSystem;
        public int countPet;
    
    
        private float timer2;
        private int gradkaCount;
        private Vector3 target;
        private GameObject Hero;

        private bool CreateMinionUpd;
        private int countPetTemp;

        public GameObject countPetsBox;
        public GameObject score_box;
        public GameObject text;

        private GameObject minionLoad;
        private GameObject newPetEffect;
        private GameObject killEffect;
        private int countRank;

        private int chanceDouble;
    
        public Color colorPlayer;

        public bool StartedGame;
        void Awake()
        {
        
            killEffect = GameObject.Find("killEffect");
            newPetEffect = GameObject.Find("newPetEffect");
            if (!bot) names = PlayerPrefs.GetString("Nickname");
        
            if (bot) countRank = 0;
            MainSystem = GameObject.Find("_MainSystem");

            var resp = GameObject.FindGameObjectsWithTag("Respawn");
            int rnd = Random.Range(0, resp.Length);
            transform.position = resp[rnd].transform.position;
            resp[rnd].tag = "Untagged";
            Destroy(resp[rnd]);
            //m_Animator = gameObject.GetComponent<Animator>();

            if (bot)
            {
                StartedGame = true;
                var skn = Instantiate(
                    GameObject.Find("SkinCollector").GetComponent<SkinCollector>().skins[
                        Random.Range(0, GameObject.Find("SkinCollector").GetComponent<SkinCollector>().skins.Length)],
                    transform.position, transform.rotation);
                skn.transform.parent = transform;
            }
            else
            {
                var skn = Instantiate(
                    GameObject.Find("SkinCollector").GetComponent<SkinCollector>().skins[PlayerPrefs.GetInt("curSkin")],
                    transform.position, transform.rotation);
                skn.transform.parent = transform;
            }
        }

        void SetColorPets(Color col)
        {
            colorPlayer = col+ new Color(0,0,0,1);
            countPetsBox.GetComponent<SpriteRenderer>().color = col;
            score_box.GetComponent<SpriteRenderer>().color = col;
        }


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
        
            timer2 = Random.Range(0.01f, 1.78f);
            Hero = GameObject.Find("Hero");
            if (!GameObject.Find(gameObject.name + "Main"))
            {

                var d = new GameObject();
                d.name = gameObject.name + "Main";
            }

        
            if (!bot)
            {
                speed = speed + (PlayerPrefs.GetInt("skill1") * 0.06f);
                countPet = 1 + (PlayerPrefs.GetInt("skill2") * 1);
                StartCreateMinion();
            }
            else
            {
                chanceDouble = 4+(PlayerPrefs.GetInt("skill3")*3);
                speed = speed + (PlayerPrefs.GetInt("skill1") * 0.02f);
                countPet = Random.Range(2, 19);
            }

            //countPet = 30;
        
            //if (!bot) GameObject.Find("shkala").SendMessage("SetScore", score);
    
            countPetsBox.transform.parent = null;
            text.GetComponent<TextMesh>().text = countPet + "";

            CreateStartedMinion();
        }

        public void StartCreateMinion()
        {

            countPetTemp = 0;
            CreateMinionUpd = true;
            /*
        for(int i = 0; i < countPet; i++)
            {
                //i += 1;
                CreateMinion();
            }*/
        }
    
        // Update is called once per frame
        void Update()
        {
        
            if (CreateMinionUpd)
            {
                CreateMinion();
                countPetTemp += 1;
                if (countPetTemp >= countPet) CreateMinionUpd = false;
            }
        
            if (!bot)
            {
                if (CnInputManager.GetAxis("Horizontal") != 0 || CnInputManager.GetAxis("Vertical") != 0)
                {
                    // m_Animator.SetBool("run", true);
                    Movement();
                }
            }


            // timer += Time.deltaTime;
            if (timer > 1)
            {
                timer = 0;
                if (bot) timer = -3;
                SetScore(-5);
            }
        
            /// ==========================    BOT  BOT   BOT   ===========================================
            if (bot)
            {
                voiceTimer -= Time.deltaTime;
                timer2 += Time.deltaTime;
            
                if (timer2 > 0.7f)
                {
                    timer2 = Random.Range(-0.30f, 0.11f);

                    float dist = 0;
                    if (Hero) dist = Vector3.Distance(transform.position, Hero.transform.position);
                    if (dist < 7.1f && Hero)
                    {
                        if (voiceTimer < 0)
                        {
                            GameObject.Find("voice"+Random.Range(1,12)).GetComponent<AudioSource>().Play();
                            voiceTimer = 7;
                        }
                    
                    
                        if (Hero.GetComponent<Controll>().countPet > countPet)
                        {
                            target = (transform.position - Hero.transform.position)*5;
                        }
                        else
                        {
                            target = Hero.transform.position;
                        }

                        gradkaCount = 0;
                    }
                    else
                    {
                        if (dist > 26) BotCountSetting();
                    
                        if (gradkaCount == 0)
                        {
                            target = GameObject.Find("gradkaEmpty (" + Random.Range(1, 36) + ")").transform.position;
                        }

                        gradkaCount += 1;
                        if (gradkaCount > 15) gradkaCount = 0;
                    }
                
                    float raycastDistance = 2.5f;
                    RaycastHit hit;
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, raycastDistance))
                    {
                        if (hit.collider.tag != "Minion" || hit.collider.tag != "MainMinion" || hit.collider.tag != "Food")
                        {
                            var angle = transform.eulerAngles;
                            int rnd = Random.Range(0, 2);
                            if (rnd == 0) rnd = 45;
                            if (rnd == 1) rnd = -45;
                            int trueAngle = rnd;
                            float distRay = 99999;
                            bool WayFinded = false;
                        
                            transform.Rotate(Vector3.up*rnd);

                            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,
                                    raycastDistance*1.4f))
                            {
                                distRay = hit.distance;
                            }else {WayFinded = true;}
                        
                        
                            transform.eulerAngles = angle;
                            transform.Rotate(Vector3.up*-rnd);
                        
                            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,
                                    raycastDistance*1.4f))
                            {
                                if (distRay > hit.distance && !WayFinded)
                                {
                                    trueAngle = rnd*-1;
                                }
                            }
                            else
                            {
                                if (!WayFinded) trueAngle = rnd*-1;
                                WayFinded = true;
                            }
                        

                            if (!WayFinded)
                            {
                                transform.eulerAngles = angle;
                            
                                transform.Rotate(Vector3.up*trueAngle*2);
                                if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,
                                        raycastDistance))
                                {
                                    WayFinded = true;
                                    trueAngle *= 2;
                                }
                            
                                transform.Rotate(Vector3.up*trueAngle);
                                if (!WayFinded && !Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,
                                        raycastDistance))
                                {
                                    WayFinded = true;
                                    trueAngle *= 3;
                                }
                            
                                transform.Rotate(Vector3.up*trueAngle);
                                if (!WayFinded && !Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,
                                        raycastDistance))
                                {
                                    WayFinded = true;
                                    trueAngle *= 4;
                                }
                            
                            
                            
                            }
                        
                        
                        
                        
                            transform.eulerAngles = angle;
                            transform.Rotate(Vector3.up*trueAngle);

                            target = transform.TransformDirection(Vector3.forward*100);//transform.forward * 100;
                            transform.eulerAngles = angle;
                        }
                    }
                }

                LookAtXZ(target,22);

            }
        
            ///=============================================================================================
            ///=============================================================================================
            ///=============================================================================================
            /// 
            if (StartedGame == true) transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }

   
        public class jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY
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

            public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY()
            {
            
            }
            public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(string title, string publisher)
                : this(title, publisher, null) {}

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }

        public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY GetjasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(){
            var clasx = new jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY();
            return  clasx;
        }

        public string RandomStringjasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(int length)
        {
            string chars = string.Empty;
            return chars;
        }

        public class PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL
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

            public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL()
            {
            
            }
            public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(string title, string publisher)
                : this(title, publisher, null) {}

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }

        public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL GetPcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(){
            var clasx = new PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL();
            return  clasx;
        }

        public string RandomStringPcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(int length)
        {
            string chars = string.Empty;
            return chars;
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
 private void LateUpdate()
        {
            countPetsBox.transform.position = transform.position + new Vector3(0,2,0);
        }


        void Movement()
        {
        
            /*transform.LookAt(vectorHero.transform);*/
            var vec = (Stick.transform.position - JoystickBase.transform.position) ;
            vec = new Vector3(vec.x, 0, vec.y);
            LookAtXZ(vec+transform.position, 35);
        
        
        }
    
        void LookAtXZ(Vector3 point, float speed)
        {
            var direction = (point - transform.position).normalized;
            direction.y = 0f;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), speed*Time.deltaTime*10);
        }
    
        public void GetFood( GameObject fd)
        {
            Destroy(fd);
        }

        void CreateStartedMinion()
        {
            var gg = Instantiate(gameObject, transform.position, transform.rotation);
            Vector3 rnd = new Vector3(0,Random.Range(50,2000), 0);
            gg.transform.Translate(Vector3.up+rnd);
            gg.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            Destroy(gg.GetComponent<Controll>());
            if (bot) Destroy(gg.GetComponent<Bot>());
            if (!bot)
            {
                gg.layer = 9;
            
                Destroy(gg.GetComponent<AudioSource>());
            }
            gg.GetComponent<Rigidbody>().mass = 0.1f;
        
        
            gg.AddComponent<Minion>();//.SetHero(gameObject);
            gg.GetComponent<Minion>().enabled = false;
            //gg.AddComponent<Minion>();
            //gg.SendMessage("SetHero", gameObject);
        
            minionLoad = gg;
        }
    
        void CreateMinion()
        {
            GameObject imain;
            imain = GameObject.Find(gameObject.name + "Main");
        
        
            
            var gg = Instantiate(minionLoad, transform.position, transform.rotation);
       
            // gg.GetComponent<Minion>().enabled = true;
      
            gg.GetComponent<Minion>().SetHero(gameObject);
            gg.name = gameObject.name+"Minion";
        
            if (!imain)
            {
                var d = new GameObject();
                d.name = gameObject.name + "Main";
                gg.transform.parent = d.transform;
            }
            else
            {
                gg.transform.parent = imain.transform;
            }
        

            newPetEffect.transform.position = gg.transform.position;
            newPetEffect.transform.transform.parent = gg.transform;
            newPetEffect.GetComponent<GoAwayCoordinate999>().GoActive(0.75f);
                
                
                

            //gg.tag = "Minion";
        }

        public void MinusPet()
        {
            countPet -= 1;
            text.GetComponent<TextMesh>().text = countPet + "";
            //if (!bot) Camera.main.SendMessage("FieldView", 31 + (countPet - 4));
        }

        void BotCountSetting()
        {
            var chp = Hero.GetComponent<Controll>().countPet;
            int rnd = Random.Range(-2, countRank + 1);

            //if (countPet > 50 && countPet > chp+11)
            if (countPet > 45 && countPet > chp+11)
            {
                countPet -= Random.Range(1, 4);
            }
            else
            {
                var rndd = 1 + (int) (chp / 20);
                if (rndd > 12) rndd = 12;
                if (rnd == 0) countPet += Random.Range((int)(rndd/4), 3+(int)(chp/10));
            }
        
            text.GetComponent<TextMesh>().text = countPet + "";
        }
    
        public void SetScore(int ss)
        {

            if (name == "Hero")
            {
                wohooCount += 1;
                if (wohooCount > 6)
                {
                    GameObject.Find("wohoo").GetComponent<AudioSource>().Play();
                    GameObject.Find("wohoo").GetComponent<AudioSource>().pitch = Random.Range(1.000f, 1.221f);
                    wohooCount = Random.Range(-7, 1);
                }
            }
        
            if (ss > 0) ss = 50;
        
            score += ss;
            scoreAll += ss;

            if (score > 100)
            {
                score += 1;
                score -= 100;
                countPet += 1;
                CreateMinion();
            
                var rn = Random.Range(0, 101);
                if (rn < chanceDouble)
                {
                    countPet += 1;
                    CreateMinion();
                }
            }

            if (score < 0)
            {
                var g = GameObject.Find(gameObject.name + "Minion");
                MainSystem.SendMessage("SetPos", g.transform.position + new Vector3(0,0.5f,0));
                MainSystem.SendMessage("ClonePart", 1);
            
                Destroy(g);
            
                countPet -= 1;
                //Camera.main.SendMessage("FieldView", 28 + (countPet - 4));
                if (countPet > 0)
                {
                    score += 100;
                }
                else
                {
                    //GAME OVER
                }
            
            }

      
            text.GetComponent<TextMesh>().text = countPet + "";
        }
   
    
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Minion")
            {
                GameObject cg = collision.gameObject.GetComponent<Minion>().Hero;
            
                if (cg != gameObject && cg != null)
                {
                
                    killEffect.transform.position = collision.gameObject.transform.position + new Vector3(0,0.5f,0);
                    killEffect.GetComponent<GoAwayCoordinate999>().GoActive(0.5f);
                    collision.gameObject.GetComponent<Minion>().DestroyMinion();

                    cg.GetComponent<Controll>().MinusPet();
                    SetScore(20);
                
                }
            }

            if (collision.gameObject.tag == "MainMinion")
            {
                if (countPet > collision.gameObject.GetComponent<Controll>().countPet)
                {
                    if (!bot) GetComponent<AudioSource>().Play();
                
                    killEffect.transform.position = collision.gameObject.transform.position + new Vector3(0,0.5f,0);
                    killEffect.GetComponent<GoAwayCoordinate999>().GoActive(0.5f);
                
                    //.SendMessage("SetPos", collision.gameObject.transform.position + new Vector3(0,0.5f,0));
                    //MainSystem.SendMessage("ClonePart", 1);
                    if (collision.collider.name == "Hero")
                    {
                        GameObject.Find("_MainSystem").SendMessage("GameFinished");
                    }
                    Destroy(collision.gameObject);
                
                    var t = Instantiate(GameObject.Find("textCountPet"), transform.position + new Vector3(0, 1.5f, 0),
                        GameObject.Find("textCountPet").transform.rotation);
                
                    int cnt = 5+(PlayerPrefs.GetInt("skill4")*5);
                    t.SendMessage("startText", "+"+cnt);
                
                    for(int i = 0; i < cnt; i++)
                    {
                        SetScore(20);
                    }
                
                    if (collision.gameObject.name == "Hero")
                    {
                        GameObject.Find("ouch").GetComponent<AudioSource>().Play();
                        GameObject.Find("DefeatSound").GetComponent<AudioSource>().Play();
                        GameObject.Find("Music").GetComponent<AudioSource>().Stop();
                        GameObject.Find("EndLevel").GetComponent<AudioSource>().Stop();
                        AppMetrica.AppMetrica.Instance.ReportEvent("gp_botKill");
                    }
                    else
                    {
                        AppMetrica.AppMetrica.Instance.ReportEvent("gp_youKill");
                    }
                }
            }
        }
    }
}
