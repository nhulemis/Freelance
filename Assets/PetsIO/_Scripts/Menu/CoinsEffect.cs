using UnityEngine;

namespace PetsIO._Scripts.Menu
{
    public class CoinsEffect : MonoBehaviour
    {
        public string nameGameObject;
        private GameObject mainGoldIco;

        private float timer;
        // Start is called before the first frame update
        void Start()
        {
            mainGoldIco = GameObject.Find(nameGameObject);
        
            transform.Translate(new Vector3(Random.Range(-0.09f,0.09f),Random.Range(-0.09f,0.09f),0 ));
            timer = Random.Range(0, 0.5f);
        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                transform.position =
                    Vector3.Lerp(transform.position, mainGoldIco.transform.position, Time.deltaTime * 4);
            }

            if (timer < -1.5f)
            {
                Destroy(gameObject);
            }
        }
    }
}
