using UnityEngine;

namespace PetsIO._Scripts.Menu
{
    public class FirstScene : MonoBehaviour
    {
        private float timer;
        // Start is called before the first frame update
        void Start()
        {
            AppMetrica.Instance.ReportEvent("firstScene");
            if (PlayerPrefs.GetInt("firstStart") == 0)
            {
                timer = 2.5f;
            }
            else
            {
                timer = 1.5F;
            }
        
     
        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                Application.LoadLevel("menu");
                timer = 9999f;
            }
        }
    }
}
