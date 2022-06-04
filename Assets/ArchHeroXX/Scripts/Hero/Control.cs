using ArchHeroXX.Scripts.Other;
using CnControls;
using UnityEngine;

namespace ArchHeroXX.Scripts.Hero
{
    public class Control : MonoBehaviour
    {
        private bool move;
        public bool attack;

        private GameObject planeHero;
        private GameObject vectorHero;

        private GameObject JoystickBase;
        private GameObject Stick;

        public GameObject weapon;
        public GameObject targetEnemy;
        private GameObject targetEnemyPlane;

        Animator m_Animator;

        public float speed;
        public float atkSpeed;
        public float damage;
        private float timerAtkSpeed;
        public float weaponFlySpeed;

        public float critChance;

        public bool poisonAtk;
        public bool dobleAtk;
        public bool treeBullets;

        public GameObject stepCloud;
        private float stepTimer;


        //==================================================================================================================
        //=================================   SETUP STATISTICS   ===========================================================
        void setupStats()
        {
            speed = GetComponent<Stats>().speed;
            atkSpeed = GetComponent<Stats>().atkSpeed;
            damage = GetComponent<Stats>().damage;
            weaponFlySpeed = GetComponent<Stats>().weaponFlySpeed;
            critChance = GetComponent<Stats>().critChance;//0-100
        }
        //==================================================================================================================
        //==================================================================================================================
        void FixStats()
        {
            if (atkSpeed < 0.2f) atkSpeed = 0.2f;
            if (critChance > 80) critChance = 80;
        }

        void Start()
        {
            /*
        PlayerPrefs.SetInt("exp", 0);
        PlayerPrefs.SetInt("level", 0);
        PlayerPrefs.SetFloat("levelBar", 0);
        PlayerPrefs.SetInt("goldTemp", 0);
        PlayerPrefs.SetInt("keyTemp", 0);*/

            DontDestroyOnLoad(this.gameObject);

            move = true;
            planeHero = GameObject.Find("plane_hero");
            vectorHero = GameObject.Find("vectorHero");
            JoystickBase = GameObject.Find("JoystickBase");
            Stick = GameObject.Find("Stick");
            targetEnemyPlane = GameObject.Find("targetEnemyPlane");

            m_Animator = gameObject.GetComponent<Animator>();
            setupStats();
        }

        // Update is called once per frame
        void Update()
        {
            if (!HomeMenu.isGameStart)
            {
                return;
            }
            FixStats();
            timerAtkSpeed += Time.deltaTime;

            if ( CnInputManager.GetAxis("Horizontal") != 0 || CnInputManager.GetAxis("Vertical") != 0 )
            {
                Time.timeScale = 1;
                move = true;
                m_Animator.SetBool("run", true);
                m_Animator.SetBool("attack", false);
                attack = false;

                stepTimer += Time.deltaTime;
                if (stepTimer > 0.5f)
                {
                    Instantiate(stepCloud, transform.position+new Vector3(0,0.15f,0), stepCloud.transform.rotation);
                    stepTimer = 0;
                }
            }
            else
            {
                if (move)
                {
                    SetTargetEnemy();
                    m_Animator.SetBool("run", false);
                    move = false;
                    vectorHero.transform.position = new Vector3(0,0,100);
                }

                if (targetEnemy) attack = true;
            }

            planeHero.transform.position = transform.position;


            if (move) Movement();
            if (attack && timerAtkSpeed > atkSpeed && targetEnemy) Attack();

            if (targetEnemy) targetEnemyPlane.transform.position = targetEnemy.transform.position;
            if (targetEnemy == null){ targetEnemyPlane.transform.position = new Vector3(0,0,999); SetTargetEnemy();}
        }

        void Attack()
        {
            attack = false;
            transform.LookAt(targetEnemy.transform);

            GameObject w = Instantiate(weapon, transform.position, weapon.transform.rotation);
            w.layer = gameObject.layer;
            w.transform.LookAt(targetEnemy.transform);
            w.SendMessage("SetSpeed", weaponFlySpeed);
            float dmg = damage * Random.Range(0.87f,1.13f);
            if (critChance > Random.Range(0, 101))
            {
                dmg = dmg * 2.5f;
                w.SendMessage("SetCrit", true);
            }


            w.SendMessage("SetDamage", dmg);

            m_Animator.SetBool("attack", true);

            if (dobleAtk)
            {
                w.transform.Translate(Vector3.forward*-0.15f);
                w = Instantiate(w, transform.position, w.transform.rotation);
                w.transform.Translate(Vector3.forward*0.35f);
                w.transform.localScale = new Vector3(-1,1,1);
            }

            if (treeBullets)
            {
                w = Instantiate(w, transform.position, w.transform.rotation);
                w.transform.Rotate(Vector3.up*45);
                w.transform.localScale = new Vector3(-1,1,1);

                w = Instantiate(w, transform.position, w.transform.rotation);
                w.transform.Rotate(Vector3.up*-90);
            }
            timerAtkSpeed = 0;
        }

        void SetDobleAtk()
        {
            dobleAtk = true;
        }
        void SetTreeBullets()
        {
            treeBullets = true;
        }
        void SetPoisonAtk()
        {
            poisonAtk = true;
        }

        void Movement()
        {

            transform.LookAt(vectorHero.transform);
            vectorHero.transform.localPosition = (JoystickBase.transform.position - Stick.transform.position)*-0.04f;

            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }

        void SetTargetEnemy()
        {
            GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
            float dist;
            if (targetEnemy)
            {
                dist = Vector3.Distance(transform.position, targetEnemy.transform.position);
            }
            else
            {
                dist = 999;
            }

            float dist2;
            foreach (GameObject enem in enemys)
            {
                // Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation);
                dist2 = Vector3.Distance(transform.position, enem.transform.position);
                if (dist > dist2)
                {
                    targetEnemy = enem;
                    dist = dist2;
                }
            }
        }
    }
}
