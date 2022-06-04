using UnityEngine;

namespace ArchHeroXX.Scripts.Enemy
{
    public class MeelieAttack : MonoBehaviour
    {
        private GameObject hero;
    
        private float timer2;
        // Start is called before the first frame update
    
        Animator m_Animator;
    
        void Start()
        {
            hero = GameObject.Find("Hero");
            m_Animator = gameObject.GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            timer2 += Time.deltaTime;
            if (timer2 > 0.05)
            {
                m_Animator.SetBool("attack", false);
                timer2 = 0;
            }
        }

        void DoAttack(float damage)
        {
            transform.LookAt(hero.transform);
            hero.SendMessage("DoDamage", damage);
            m_Animator.SetBool("attack", true);
        }
    }
}
