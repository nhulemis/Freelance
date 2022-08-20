using UnityEngine;

namespace PetsIO._Scripts
{
    public class DestroyFar : MonoBehaviour
    {
        private float timer;

        private GameObject hero;
        // Start is called before the first frame update
        void Start()
        {
            hero = GameObject.Find("Hero");
            int rnd = Random.Range(0, 4);
            transform.Rotate(Vector3.up * 45);
            transform.Rotate(Vector3.up * (rnd*90));
            timer = Random.Range(0, 3.17f);
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;

            if (timer > 5)
            {
                timer = 0;
                if (Vector3.Distance(transform.position, hero.transform.position) > 40)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
