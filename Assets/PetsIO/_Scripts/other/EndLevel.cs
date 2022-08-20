using UnityEngine;

namespace PetsIO._Scripts.other
{
    public class EndLevel : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            if (GameObject.Find("Hero"))
            {
                if (GameObject.Find("numHero").transform.localPosition.y < 1.5f)
                {

                }
                else
                {
                    Destroy(GameObject.Find("numHero"));
                }
            }
            else
            {
                Destroy(GameObject.Find("numHero"));
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
