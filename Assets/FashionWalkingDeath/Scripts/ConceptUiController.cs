using UnityEngine;
using UnityEngine.UI;

namespace FashionWalkingDeath.Scripts
{
    public class ConceptUiController : MonoBehaviour
    {
        //Serialized Data
        [SerializeField]
        private Text conceptName;
        // Start is called before the first frame update
        void Start()
        {
            
            
            
            
            setCurrentConceptName();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void setCurrentConceptName()
        {
            string conceptN = LevelManager.instance.getConceptName();

            conceptName.text = conceptN;
        }
    }
}
