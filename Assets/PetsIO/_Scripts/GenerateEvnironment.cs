using UnityEngine;

namespace PetsIO._Scripts
{
    public class GenerateEvnironment : MonoBehaviour
    {

        public GameObject[] Objects;

        private float timer;

        private bool doit;

        public bool miniEnv;
        public float timerGenerate;
        // Start is called before the first frame update
        void Start()
        {
            timer = 999f;
            //timer = Random.Range(0.00f, 0.98f);

            if (timerGenerate == 0) timerGenerate = 0.7f;
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;

            if (timer > timerGenerate)
            {
                timer = 0;
                if (doit == true)
                {
                    Generate();
                    doit = false;
                }
                else
                {
                    doit = true;
                }

            }
        }
    
        void OnTriggerStay(Collider other)
        {
            doit = false;
       
        }

        void Generate()
        {
            
            int rnd;
            
            rnd = Random.Range(0, 2);
            if (miniEnv) rnd = Random.Range(0, 5);

            if (rnd != 0)
            {
                rnd = Random.Range(1, Objects.Length);
            }

            var obj = Instantiate(Objects[rnd], transform.position, Objects[rnd].transform.rotation);
            obj.transform.position = obj.transform.position + new Vector3(0, 2, 0);
            
        }
    
    }
}
