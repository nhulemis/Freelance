using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class OptionController : MonoBehaviour
    {
        public int currentIndex=0;
        public int index;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void optionSelected()
        {
            print("Yoooo Buttob=n clicked");
            CharacterOutfitManager.instance.changeOutfit(index,currentIndex);
        }
        public void setCurrentIndex(int value)
        {
            currentIndex = value;
        }
    }
}
