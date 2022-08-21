using UnityEngine;

namespace PetsIO._Scripts.other
{
    public class YourPlace : MonoBehaviour
    {
        private GameObject Hero;

        private string ss;
        // Start is called before the first frame update
        void Awake()
        {
            //GetComponent<TextMesh>().text = ss;
            // if (GameObject.Find("Hero"))
            // {
       
        
        }

        // Update is called once per frame
        void Update()
        {
            float pos = GameObject.Find("numHero").transform.localPosition.y;

            ss = "-";
        
            if (GameObject.Find("Hero"))
            {
                if (pos == -2.5)
                {
                    ss = "6th";
                    Debug.Log("ASFASF");
                }

                if (pos == -2)
                {
                    ss = "5th";
                    Debug.Log("ASFASF");
                }

                if (pos == -1.5)
                {
                    ss = "4th";
                }

                if (pos == -1)
                {
                    ss = "3rd";
                }

                if (pos == -0.5)
                {
                    ss = "2nd";
                }

                if (pos == 0)
                {
                    ss = "1st";
                }
            }
        
            AppMetrica.AppMetrica.Instance.ReportEvent("gp_ss"+"-place");
            GetComponent<TextMesh>().text = ss;
            Destroy((this));
        }
    }
}
