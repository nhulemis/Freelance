using TMPro;
using UnityEngine;

namespace Arrow.Script
{
    public class MultiTextController : MonoBehaviour
    {
        public Color32 subsData;
        public TextMeshProUGUI text;
        public Color32 positData;
        // Start is called before the first frame update
        void Start()
        {
            Destroy(this.gameObject,1f);
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.Translate(Vector3.up * 3+Vector3.right*3f);
        }
        public void setData(float value)
        
        
        
        {
            if (value > 0)
            {
                
                
                
                
                
                
                int collectedVal = Random.Range(20, 50);
                text.text = "+" + collectedVal + "$";
                //  text.color = positData;
            }
            else
            {
                int collectedVal = Random.Range(-50, -20);
                text.text =  collectedVal + "$";
                text.faceColor = subsData;

            }

        }
    }
}
