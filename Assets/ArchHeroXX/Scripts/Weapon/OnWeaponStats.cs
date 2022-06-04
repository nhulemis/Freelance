using ArchHeroXX.Scripts.Hero;
using ArchHeroXX.Scripts.Other;
using UnityEngine;

namespace ArchHeroXX.Scripts.Weapon
{
    public class OnWeaponStats : MonoBehaviour
    {
        // Start is called before the first frame update

        public float damage;
        public float speed;
        public float backHit;

        public bool massHit;
        private int hitted;
        private bool crit;

        private bool poisonBullet;

        public GameObject hitParticle;
        void SetDamage(float dmg)
        {
            damage = dmg;
        }
        void SetCrit(bool crt)
        {
            crit = crt;
        }


        void SetSpeed(float spd)
        {
            speed = spd;
            Destroy(gameObject, 10);
        }


        void Update()
        {
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }

        // Update is called once per frame
        private void OnTriggerEnter(Collider hit)
        {
            if (hit.gameObject.tag == "Enemy" || hit.gameObject.tag == "Hero")
            {
                if (hitted == 0)
                {
                    hitted = 1;
                    if (massHit) hitted = 0;
                    if (hit.gameObject.GetComponent<Stats>()) hit.gameObject.SendMessage("DoDamage", damage);
                    if (hit.tag == "Enemy")
                    {
                        if (GameObject.Find("Hero").GetComponent<Control>().poisonAtk == true)
                        {
                            if (!hit.gameObject.GetComponent<poisonOnMob>())  hit.gameObject.AddComponent<poisonOnMob>().damage = damage/3f;
                        }
                    }
                    if (backHit > 0)
                    {
                        var rotZ = hit.gameObject.transform.rotation;
                        hit.gameObject.transform.LookAt(gameObject.transform);
                        hit.gameObject.transform.Translate(-Vector3.forward * backHit);
                        hit.gameObject.transform.rotation = rotZ;
                    }
                }

                var td = Instantiate(GameObject.Find("textDmg"), hit.transform.position+new Vector3(0,1,0), GameObject.Find("textDmg").transform.rotation);
                if (crit)
                {
                    td.GetComponent<TextMesh>().color = new Color(1f,0.1f,0.1f);
                    td.GetComponent<TextMesh>().text = "-" + Mathf.Round(damage)+"!";
                }
                else
                {
                    td.GetComponent<TextMesh>().text = "-" + Mathf.Round(damage);
                }
                td.GetComponent<onTextDamage>().enabled = true;
            }

            Instantiate(hitParticle, transform.position, hitParticle.transform.rotation);
            Destroy(gameObject);
        }


    }
}
