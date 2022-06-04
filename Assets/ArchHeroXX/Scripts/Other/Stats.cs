using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class Stats : MonoBehaviour
    {

        public float speed;

        public float hp;
        public float curHp;
        public float damage;
        public float atkSpeed;
        public float weaponFlySpeed;

        public float critChance;//0-100
        public float exp;
        public float gold;
        public int chanceDrop; // 0-100

        private GameObject healthBar;

        public GameObject deathParticle;
        // Start is called before the first frame update
        void Start()
        {
            curHp = hp;
            if (chanceDrop == 0) chanceDrop = 1;
        }

        void DoDamage(float dmg)
        {
            curHp -= dmg;
            healthBar.SendMessage("SetHealthBar");
            if (curHp < 0)
            {
                if (gameObject.tag == "Enemy")
                {
                    GameObject.Find("mainConfig").SendMessage("SetExp", exp);
                    GameObject.Find("mainConfig").SendMessage("SetGold", gold);
                    Instantiate(GameObject.Find("dropItems"), transform.position, transform.rotation).SendMessage("DropItems", chanceDrop);

                }
                else
                {
                    GameObject.Find("mainConfig").SendMessage("Defeat");
                }
                Instantiate(deathParticle, transform.position, deathParticle.transform.rotation);
                Destroy(gameObject);
            }


        }

        void SetHealthBar(GameObject gg)
        {
            healthBar = gg;
        }
    }
}
