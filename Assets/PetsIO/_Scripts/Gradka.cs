using UnityEngine;

namespace PetsIO._Scripts
{
    public class Gradka : MonoBehaviour
    {

        public GameObject[] food;

        private GameObject grad;

        private bool cleared = true;
        private bool startTimer;

        private float timer;
        // Start is called before the first frame update
        void Start()
        {
            // name = "gradkaEmpty";
            foreach (Transform child in transform)
            {
                grad = child.gameObject;
            }
            //transform.Translate(Vector3.up * -2);
            // Debug.Log(gameObject.name);
        
        }

        void Update()
        {
            if (startTimer)
            {
                timer += Time.deltaTime;
                if (timer > 10){
                    cleared = true;
                    foreach (Transform child in grad.transform)
                    {
                        Destroy(child.gameObject);
                    }

                    startTimer = false;
                }
            }
        }
        void OnBecameInvisible()
        {
            if (cleared == false)
            {
                startTimer = true;
          
            }
        }

        // ...and enable it again when it becomes visible.
        void OnBecameVisible()
        {
            startTimer = false;
            timer = 0;
        
            if (cleared == true)
            {
                int rnd = Random.Range(0, 3);
                var fd = Instantiate(food[rnd], transform.position, food[rnd].transform.rotation);
                fd.transform.parent = grad.transform;
                rnd = Random.Range(0, 4);
                fd.transform.Rotate(Vector3.up * (rnd*90));
                cleared = false;
            }

        }
    }
}
