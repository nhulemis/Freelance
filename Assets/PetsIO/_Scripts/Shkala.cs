using UnityEngine;

namespace PetsIO._Scripts
{
    public class Shkala : MonoBehaviour
    {
        public float fixS;
        private float timer;
        // Start is called before the first frame update
        void SetScore(int s)
        {
            fixS = s / 100f;
            timer = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (timer < 3)
            {
                timer += Time.deltaTime;
                transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(fixS, 1, 1), Time.deltaTime * 10);
            }
        }
    }
}
