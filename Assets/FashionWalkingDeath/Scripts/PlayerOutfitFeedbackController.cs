using UnityEngine;
using UnityEngine.UI;

namespace FashionWalkingDeath.Scripts
{
    public class PlayerOutfitFeedbackController : MonoBehaviour
    {
        //Serialized
        [SerializeField]
        private Image progressFill;
        //References
        public static PlayerOutfitFeedbackController instance;

        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void updateFeedbackProgress()
        {
            print("Update Player Feedback Ui");
            float filled = progressFill.fillAmount;
            if (filled < 1f)
            {
                progressFill.fillAmount += .2f;
            }
        }
    }
}
