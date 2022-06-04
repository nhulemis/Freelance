using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace hairmaster.Scripts
{
    public class ReviveTimeController : MonoBehaviour
    {
        [SerializeField]
        private Image outlineFiller;
        [SerializeField]
        private TextMeshProUGUI timeText;
        [SerializeField]
        private GameObject reviveButton;
        float fillvalue;
        // Start is called before the first frame update
        void Start()
        {
            fillvalue = 5;
        }

        // Update is called once per frame
        void Update()
        {
            if (fillvalue > 0)
            {
            
                fillvalue -=Time.deltaTime;
                
                
                
                int timevalue = (int)fillvalue;
                timeText.text = (int)timevalue+"";
                outlineFiller.fillAmount = (fillvalue/5);

            }
            else
            {
                
                
                reviveButton.SetActive(false);
                
            }
        
        }
    }
}
