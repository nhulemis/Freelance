using PetsIO._Scripts.other;
using UnityEngine;

namespace PetsIO._Scripts.Menu
{
    public class WeekReward : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            if (name == "b_day" + PlayerPrefs.GetInt("weekDay"))
            {
                GetComponent<SpriteRenderer>().color = new Color(0,1,0,1f);
                gameObject.AddComponent<ButtonZfix>();
            }
            else
            {
                GetComponent<SpriteRenderer>().color = new Color(1,1,1,0.3f);
                if (int.Parse(name[5].ToString()) < PlayerPrefs.GetInt("weekDay"))
                {
                    GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0.3f);
                }

                tag = "Untagged";
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
