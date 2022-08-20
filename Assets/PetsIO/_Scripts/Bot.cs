using UnityEngine;

namespace PetsIO._Scripts
{
    public class Bot : MonoBehaviour
    {
        private float timer;

        private Vector3 target;
        private GameObject Hero;
        public GameObject Arrow;

        private bool activ;
        // Start is called before the first frame update
        void Start()
        {
            Hero = GameObject.Find("Hero");
            timer = Random.Range(-0.74f, 1.43f);
            var a = Instantiate(Arrow, transform.position, Arrow.transform.rotation);
            foreach (Transform child in a.transform)
            {
                child.GetComponent<ArrowGUI>().Bot = gameObject;
            }
            // activ = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (Hero)
            {
                timer += Time.deltaTime;

                if (timer > 2.3f)
                {
                    var dist = Vector3.Distance(transform.position, Hero.transform.position);
                    if (dist > 26)
                    {
                        if (GameObject.Find(gameObject.name + "Main")) Destroy(GameObject.Find(gameObject.name + "Main"));
                        activ = false;
                        tag = "Untagged";
                    }

                    if (dist < 24 && activ == false)
                    {
                        tag = "MainMinion";
                        this.gameObject.GetComponent<Controll>().StartCreateMinion();
                        activ = true;
                    }
                }
            }
        }
    
    }
}
