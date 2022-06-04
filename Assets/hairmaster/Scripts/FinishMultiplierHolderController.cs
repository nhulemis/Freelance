using UnityEngine;

namespace hairmaster.Scripts
{
    public class FinishMultiplierHolderController : MonoBehaviour
    {
        [HideInInspector]
        public FinishMultiplierController finisMultiplierController;


        //References
        public static FinishMultiplierHolderController instance;

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
        public void setNewMat()
        {
            finisMultiplierController.setMaterial();
        }
        public void setUpFinishShowStage()
        {
            int i = 0;
            foreach(Transform finishMulti in this.transform)
            {
                int value = i * 10;
                if (finishMulti != null)
                {
                    finishMulti.GetComponent<FinishMultiplierController>().setRewardValue(value);
                    
                    
                    
                    
                    finishMulti.GetComponent<FinishMultiplierController>().setRewardText();
                }
            
                i++;
            }
        }
    }
}
