using UnityEngine;
using UnityEngine.SceneManagement;

namespace ArchHeroXX.Scripts.Other
{
    public class mainConfig : MonoBehaviour
    {
        public GameObject hero;
        private GameObject skalaLevel;
        private GameObject t_level;

        private int countEnemy; // количество врагов в сцене

        private int level;
        private int exp;
        private int curExp;
        private int oldExp;
        private float skalExp;
        private float scaler;
        private bool finished;

        private int gold;
        private int keys;

        void Awake()
        {

            GameObject.Find("generationLevel").SendMessage("StartGenerate");
            GameObject.Find("generationMobs").SendMessage("StartGenerate");

            if (GameObject.Find("Hero"))
            {
                GameObject.Find("Hero").transform.position = new Vector3(0, 0, -3.5f);
                GameObject.Find("Hero").SendMessage("Start");
            }
            else
            {
                var g = Instantiate(hero, new Vector3(0, 0, -3.5f), hero.transform.rotation);
                g.name = "Hero";
            }

        }
        void Start()
        {
            exp = PlayerPrefs.GetInt("exp");
            level = PlayerPrefs.GetInt("level");

            if (level > 1) GameObject.Find("Hero").GetComponent<Stats>().curHp = PlayerPrefs.GetFloat("CurHp");

            skalaLevel = GameObject.Find("skalaLevel");
            if (level == 0) level = 1;
            GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
            countEnemy = enemys.Length;

            SetLevelBarStart();

            GameObject.Find("t_gold").GetComponent<TextMesh>().text = PlayerPrefs.GetInt("goldTemp")+"";
        }

        void SetExp(int ex)
        {
            ex = Mathf.CeilToInt((ex * (1f + (level * 0.25f))));
            curExp += ex;
            countEnemy -= 1;
        }

        void SetGold(int gd)
        {
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold")+gd);
            PlayerPrefs.SetInt("goldTemp", PlayerPrefs.GetInt("goldTemp")+gd);
            GameObject.Find("t_gold").GetComponent<TextMesh>().text = PlayerPrefs.GetInt("goldTemp")+"";
            //gold += gd;
        }


        void SetKeys()
        {
            PlayerPrefs.SetInt("keyTemp", PlayerPrefs.GetInt("keyTemp")+1);
        }

        void SetLevelBarStart()
        {
            skalaLevel.transform.localScale = new Vector3(PlayerPrefs.GetFloat("levelBar"), 1, 1);
            GameObject.Find("t_level").GetComponent<TextMesh>().text = "lv." + level;
        }

        void enemyKilled()
        {
            oldExp = exp;
            if (curExp != 0)
            {
                exp += curExp;
                skalExp = skalaLevel.transform.localScale.x;
                curExp = 0;
            }

            float coef = 1f;
            float scl = exp / (100 * (level * coef));
            scl -= 0.5f*(level-1);

            skalExp += Time.deltaTime * 2f;



            if (skalExp > 1)
            {
                level += 1;
                skalExp -= 1;
                oldExp = exp;
                //scaler += 0.5f;
                GameObject.Find("t_level").GetComponent<TextMesh>().text = "lv." + level;
                GameObject.Find("skillCollector").SendMessage("showThreeSkills");
            }
            else
            {// ==========================   WHEN LEVELBAR ENDED  ===============
                if (skalExp > scl)
                {
                    skalExp = scl;
                    finished = true;
                    PlayerPrefs.SetInt("exp", exp);
                    PlayerPrefs.SetInt("level", level);
                    PlayerPrefs.SetFloat("levelBar", skalaLevel.transform.localScale.x);
                }
            }//// ================================================================
            if (skalExp > scl)
            {
                skalExp = scl;
            }
            skalaLevel.transform.localScale = new Vector3(skalExp,1,1);
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (hit.collider.tag == "SkillGUI")
                    {
                        hit.collider.gameObject.SendMessage("ActivateSkill");
                    }
                }
            }

            if (finished == false)
            {
                if (countEnemy < 1)
                {
                    enemyKilled();
                }
            }
            else
            {
                EnemyDeath();
            }

        }

        void EnemyDeath()
        {
            GameObject.Find("drakkar").SendMessage("ActivateDrakkar");
        }
        void FinishLevel()
        {
            SceneManager.LoadScene("game");

        }

        public void Defeat(){
            // if (GameObject.Find("ADS")) GameObject.Find("ADS").SendMessage("ShowInterstitial");
            //
            // if (PlayerPrefs.GetInt("stageMax") < PlayerPrefs.GetInt("stage"))  PlayerPrefs.SetInt("stageMax", PlayerPrefs.GetInt("stage"));
            //
            //   PlayerPrefs.SetInt("exp", 0);
            //   PlayerPrefs.SetInt("level", 0);
            //   PlayerPrefs.SetFloat("levelBar", 0);
            //   PlayerPrefs.SetInt("goldTemp", 0);
            //   PlayerPrefs.SetInt("keyTemp", 0);
            //   PlayerPrefs.SetInt("stage", 1);
            HomeMenu.isGameStart = false;
            SceneManager.LoadScene("game");
        }
    }
}
