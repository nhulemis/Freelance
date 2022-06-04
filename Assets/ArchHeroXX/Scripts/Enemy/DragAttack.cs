using UnityEngine;

namespace ArchHeroXX.Scripts.Enemy
{
    public class DragAttack : MonoBehaviour
    {
        private GameObject hero;
        public GameObject trailEffect;
    
        private float timer;
        private float timer2;
        // Start is called before the first frame update
    
        private float dmg;
        Animator m_Animator;

        public float jumpDist;
        public float delayAttack;
    
        void Start()
        {
            hero = GameObject.Find("Hero");
            m_Animator = gameObject.GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            timer2 += Time.deltaTime;
            if (dmg != 0) timer += Time.deltaTime;
        
            if (timer2 > 0.25)
            {
                m_Animator.SetBool("attack", false);
                timer2 = 0;
            }

            if (timer > delayAttack)
            {
            
                Vector3 fwd = transform.TransformDirection(Vector3.forward); //
                RaycastHit hit;

                int layerMask = 1 << 10;
                layerMask = ~layerMask;

                if (Physics.Raycast(transform.position, fwd, out hit, jumpDist, layerMask))
                {
                    if (hit.collider.name == "Hero")
                    {
                        hero.SendMessage("DoDamage", dmg);
                    }
                    transform.Translate(Vector3.forward * Vector3.Distance(transform.position, hit.point));
                }
                else
                {
                    transform.Translate(Vector3.forward * jumpDist);
                }

            

           

                dmg = 0;
                timer = 0;
                // Destroy(this);
            }
        }

        void DoAttack(float damage)
        {
        
            var te = Instantiate(trailEffect, transform.position, trailEffect.transform.rotation);
            te.transform.parent = transform;
            Destroy(te, delayAttack+0.5f);
        
            dmg = damage;
            transform.LookAt(hero.transform);
            m_Animator.SetBool("attack", true);
        }
    }
}
