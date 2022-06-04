using ArchHeroXX.Scripts.Other;
using UnityEngine;

namespace ArchHeroXX.Scripts.Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        private GameObject hero;

        public float timeLookAt;
        public float timeMovement;
    
        private float speed;
        private float weaponFlySpeed;

    
        private float timer;
        private float timer2;
        private float timer3;

        private Vector3 lookTo;

        private bool seeHero;
        // Start is called before the first frame update
    
    
        public float atkDistance;
        public float atkPauseNoMove;
        public bool atkWhenSee;
    
        private float atkSpeed;
        private float damage;
        private float timerAtkSpeed;
        private float timer4;
        private float atkpnm;

    
        //==================================================================================================================
        //=================================   SETUP STATISTICS   ===========================================================
        void setupStats()
        {
            speed = GetComponent<Stats>().speed;
            weaponFlySpeed = GetComponent<Stats>().weaponFlySpeed;
            atkSpeed = GetComponent<Stats>().atkSpeed;
            damage = GetComponent<Stats>().damage;
        }
        //==================================================================================================================
        //==================================================================================================================

        void Start()
        {
            hero = GameObject.Find("Hero");
            lookTo = hero.transform.position;

            setupStats();
            atkpnm = atkPauseNoMove;
        }

        // Update is called once per frame
        void Update()
        {
            if (!HomeMenu.isGameStart)
            {
                return;
            }
            //***************************************   MOVEMENT   *********************************************************
            timer += Time.deltaTime;
            timer2 += Time.deltaTime;
            timer3 += Time.deltaTime;
            atkpnm -= Time.deltaTime;

            if (atkpnm < 0)
            {

                if (timer > timeLookAt)
                {
                    timer = 0;
                    var rotY = transform.rotation;
                    transform.LookAt(hero.transform);

                    Vector3 fwd = transform.TransformDirection(Vector3.forward); //
                    RaycastHit hit;

                    int layerMask = 1 << 10;
                    layerMask = ~layerMask;

                    if (Physics.Raycast(transform.position, fwd, out hit, 100, layerMask))
                    {
                        if (hit.collider.name == "Hero")
                        {
                            seeHero = true;
                            lookTo = hero.transform.position;
                        }
                        else
                        {
                            seeHero = false;
                            //CheckRaySides();
                        }
                    }

                    transform.rotation = rotY;

                }

                if (!seeHero)
                {
                    if (timer2 > timeMovement)
                    {
                        timer2 = Random.Range(-1.5f, 0);
                        CheckRaySides();
                    }
                }

                LookAtXZ(lookTo, 25);
                if (timer2 > 0)
                {
                    if (atkWhenSee)
                    {
                        if (!seeHero) transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    }
                    else
                    {
                        transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    }
                }
            }

            ///=====================================    ATTACK    ==========================================================
            timerAtkSpeed += Time.deltaTime;
            timer4 += Time.deltaTime;
        
            if (timer4 > 0.22 && atkpnm < 0)
            {
                timer4 = 0;
                if (hero == null )
                {
                    return;
                }
                var dist = Vector3.Distance(transform.position, hero.transform.position);
                if (dist < atkDistance)
                {
                    atkpnm = atkPauseNoMove;
                    if (atkWhenSee){
                        if (timerAtkSpeed > atkSpeed && seeHero)
                        {
                            atkpnm = atkPauseNoMove;
                            gameObject.SendMessage("DoAttack", damage);
                            timerAtkSpeed = 0;
                        }
                    }
                    else
                    {
                        if (timerAtkSpeed > atkSpeed)
                        {
                            atkpnm = atkPauseNoMove;
                            gameObject.SendMessage("DoAttack", damage);
                            timerAtkSpeed = 0;
                        }
                    }
                }
            }
            ///=============================================================================================================
        
       
       
        }
        
        
        void LookAtXZ(Vector3 point, float speed)
        {
            var direction = (point - transform.position).normalized;
            direction.y = 0f;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), speed*Time.deltaTime*10);
        }

        void CheckRaySides()
        {
            // =========================   FIND RANDOM WAY TO MOVE   ==========================================
            Vector3 fw;
            int rndSide;
            rndSide = Random.Range(1, 5);
            int layerMask = 1 << 10;
            layerMask = ~layerMask;
        
            RaycastHit hit2;

            if (rndSide == 1)
            {
                fw = transform.position+ new Vector3(0,0,0.5f);
                if (Physics.Raycast(fw, transform.position + new Vector3(0, 0, 1), out hit2, 0.5f, layerMask))
                {
                
                }
                else
                {
                    lookTo = transform.position + new Vector3(0, 0, 1) * 100;
                    return;
                }
            
                rndSide += 1;
            }

            if (rndSide == 2)
            {
                fw = transform.position + new Vector3(0, 0, -0.5f);
                if (Physics.Raycast(fw, transform.position + new Vector3(0, 0, -1), out hit2, 0.5f, layerMask))
                {
               
                }
                else
                {
                    lookTo = transform.position + new Vector3(0, 0, -1) * 100;
                    return;
                }
                rndSide += 1;
            }
            if (rndSide == 3)
            {
                fw = transform.position + new Vector3(0.5f, 0, 0);
                if (Physics.Raycast(fw, transform.position + new Vector3(1, 0, 0), out hit2, 0.5f, layerMask))
                {
               
                }
                else
                {
                    lookTo = transform.position + new Vector3(1, 0, 0) * 100;
                    return;
                }
                rndSide += 1;
            }
        
            if (rndSide == 4)
            {
                fw = transform.position + new Vector3(-0.5f, 0, 0);
                if (Physics.Raycast(fw, transform.position + new Vector3(-1, 0, 0), out hit2, 0.5f, layerMask))
                {
              
                }
                else
                {
                    lookTo = transform.position + new Vector3(-1, 0, 0) * 100;
                    return;
                }
                rndSide += 1;
            }
        }
    }
}


