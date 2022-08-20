using UnityEngine;

namespace PetsIO._Scripts
{
    public class textCountPet : MonoBehaviour
    {
        private float timer;

        private bool textGo;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        void startText(string t)
        {
            GetComponent<TextMesh>().text = t;
            textGo = true;
            timer = 1.3f;
        }
        // Update is called once per frame
        void Update()
        {

            if (textGo)
            {
                timer -= Time.deltaTime;
                if (timer < 0)
                {
                    Destroy(this.gameObject);
                }
                else
                {
                    if (timer < 1) GetComponent<TextMesh>().color = new Color(1f, 0.7f, 0, timer);
                }
            }
        }
    }
}
