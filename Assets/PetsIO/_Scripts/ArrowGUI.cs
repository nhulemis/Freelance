using UnityEngine;

namespace PetsIO._Scripts
{
    public class ArrowGUI : MonoBehaviour
    {
        private GameObject Hero;
        public GameObject Bot;
        public GameObject metka;
        public GameObject sprite;

        private float timer;
        // Start is called before the first frame update
    
        void Start()
        {
            timer = Random.Range(-0.99f, 1.12f);
            Hero = GameObject.Find("Hero");
            metka.transform.position = Hero.transform.position;
            metka.transform.parent = Hero.transform;
        
            transform.parent.position = Camera.main.transform.position;
            transform.parent.transform.parent = Camera.main.transform;
            transform.parent.transform.localEulerAngles = new Vector3(0,0,0);

            float c1 = Random.Range(0.01f, 0.79f);
            float c2 = Random.Range(0.01f, 0.79f);
            float c3 = Random.Range(0.01f, 0.79f);
            sprite.GetComponent<SpriteRenderer>().color = new Color(c1,c2,c3, 0.82f);
        
            Bot.SendMessage("SetColorPets", new Color(c1,c2,c3, 0.7f));
        }

        // Update is called once per frame
        void Update()
        {
            if (metka)
            {
                if (!Bot) Destroy(transform.parent.gameObject);
                //transform.rotation = Quaternion.Lerp(Bot.transform.rotation, Hero.transform.rotation, Time.deltaTime * 100);
                metka.transform.LookAt(Bot.transform);
                transform.localEulerAngles = new Vector3(0, 0, -metka.transform.eulerAngles.y);

                timer += Time.deltaTime;
                if (timer > 2.2f)
                {
                    if (Vector3.Distance(Hero.transform.position, Bot.transform.position) < 6.5f)
                    {
                        transform.parent.transform.localPosition = new Vector3(0, 999, 0);
                    }
                    else
                    {
                        transform.parent.transform.localPosition = new Vector3(0, 0, 0);
                    }
                }
            }
        }
    }
}
