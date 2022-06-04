using ArchHeroXX.Scripts.Other;
using UnityEngine;

namespace ArchHeroXX.Scripts.Enemy
{
    public class RangeAttack : MonoBehaviour
    {
        private GameObject hero;
        public GameObject bullet;
    
        public bool lootToHero;
        
        private float timer2;
        private float weaponFlySpeed;
        // Start is called before the first frame update
    
        Animator m_Animator;
    
        void Start()
        {
            hero = GameObject.Find("Hero");
            m_Animator = gameObject.GetComponent<Animator>();
            weaponFlySpeed = GetComponent<Stats>().weaponFlySpeed;
        }

        // Update is called once per frame
        void Update()
        {
            timer2 += Time.deltaTime;
            if (timer2 > 0.25)
            {
                m_Animator.SetBool("attack", false);
            }
        }

        void DoAttack(float damage)
        {
            if (lootToHero) transform.LookAt(hero.transform);
        
            GameObject w = Instantiate(bullet, transform.position, bullet.transform.rotation);
            w.layer = gameObject.layer;
            w.transform.LookAt(hero.transform);
            w.SendMessage("SetSpeed", weaponFlySpeed);
            w.SendMessage("SetDamage", damage);
        
            m_Animator.SetBool("attack", true);
        }
    }
}
