using UnityEngine;

namespace hairmaster.Scripts
{
    public class FinishMultiplierController : MonoBehaviour
    {
        public Material glossyMaterial;
        private bool passed;
        public TextMesh rewardText;
        private int rewardTextValue;
        private Transform firstChild;
        // Start is called before the first frame update
        void Start()
        {
            rewardTextValue = 0;
            firstChild = this.transform.GetChild(0);
            rewardText = firstChild.GetComponent<TextMesh>();
            firstChild.gameObject.SetActive(false);       
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnTriggerEnter(Collider other)
        {
            
            
            
            
            
            
            
            
            if (other.gameObject.CompareTag("HairBone") && !passed)
            {
                passed = true;
                this.transform.parent.GetComponent<FinishMultiplierHolderController>().finisMultiplierController = this;
            }
        }
        public void setMaterial()
        {
       
            UiManager.instance.setCurrentCollectedCoin(rewardTextValue);
            
            
            
            
            
            
            
            
            
            this.transform.GetChild(3).GetComponent<MeshRenderer>().material = glossyMaterial;
        }
        public void setRewardValue(int value)
        {
            rewardTextValue = value;
        }
        public void setRewardText()
        {
            firstChild.gameObject.SetActive(true);
            
            
            rewardText.text = "$"+ rewardTextValue ;
        }
    }
}
