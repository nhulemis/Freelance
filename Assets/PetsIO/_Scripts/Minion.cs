using UnityEngine;

namespace PetsIO._Scripts
{
    public class Minion : MonoBehaviour
    {
        public GameObject Hero;

        private float speed;

        private float timer;

        private bool tagged;

        public void SetHero(GameObject h)
        {
            Hero = h;
            speed = Hero.GetComponent<Controll>().speed;
            gameObject.tag = "Untagged";
            enabled = true;
        }

        public void DestroyMinion()
        {
            transform.position = Vector3.up*999f;
            enabled = false;
            Destroy(this.gameObject, Random.Range(0.5f, 2.8f));
        
        }

        void Update()
        {
            var delt = Time.deltaTime;
            if (Hero)
            {
                transform.Translate(Vector3.forward * speed * 0.5f * delt);
                transform.position = Vector3.Lerp(transform.position, Hero.transform.position, delt * speed * 0.2f);
                transform.rotation = Quaternion.Lerp(transform.rotation, Hero.transform.rotation, delt * speed * 1f);
            
                if (timer < 1)
                {
                    timer += delt;
                }
                else
                {
                    if (tagged == false)
                    {
                        gameObject.tag = "Minion";
                        tagged = true;
                    }
                }
            }
            else
            {
                timer += delt;
                if (timer >= 1)
                {
                    GameObject MainSystem = GameObject.Find("_MainSystem");
                    MainSystem.SendMessage("SetPos", transform.position + new Vector3(0,0.5f,0));
                    MainSystem.SendMessage("ClonePart", 1);
                    DestroyMinion();
                    //Destroy(gameObject);
                }
            }

        }


        public void minusPet()
        {
            Hero.GetComponent<Controll>().MinusPet();
        }

        public void EatFood()
        {
            Hero.GetComponent<Controll>().SetScore(20); 
            var t = Instantiate(GameObject.Find("textCountPet"), transform.position + new Vector3(0, 1.5f, 0),
                GameObject.Find("textCountPet").transform.rotation);
            t.SendMessage("startText", "+1");
        }
    }
}
