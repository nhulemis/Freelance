using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class SportOutfitController : MonoBehaviour
    {
        //Serialized Data
        public LevelConceptsController[] sportLevels;
        [SerializeField]
        public GameObject bikinniTop;
        [SerializeField]
        public GameObject bikinniBottom;
        // Start is called before the first frame update
        void Start()
        {
            sportLevels = this.GetComponentsInChildren<LevelConceptsController>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void selectTshirtOutfits1(int levelIndex, int hairIndex)
        {
            disableTopOutfit();
            
            
            
            
            print("Changing Sport Hair levele index : " + levelIndex + " & selected hair is :" + hairIndex);
            sportLevels[0].selectTshirtItem(levelIndex);
        }
        public void selectHairOutfits(int levelIndex, int hairIndex)
        {
            print("Changing Sport Hair levele index : " + levelIndex + " & selected hair is :" + hairIndex);
            sportLevels[0].selectHairItem(levelIndex);
            
            
            
            
            
        }
        public void selectShoeOutfits(int levelIndex, int hairIndex)
        {
            print("Changing Sport Shoe levele index : " + levelIndex + " & selected shoe is :" + hairIndex);

            sportLevels[0].selectShoeItem(levelIndex);
        }
        public void selectDressOutfits(int levelIndex, int hairIndex)
        {
            disableBottomOutfit();
            disableTopOutfit();
            print("Changing Sport Dress levele index : " + levelIndex + " & selected Dress is :" + hairIndex);
            sportLevels[0].selectDressItem(levelIndex);
        }
        public void selectBottomOutfits(int levelIndex, int hairIndex)
        {
            print("Changing Sport Shoe levele index : " + levelIndex + " & selected shoe is :" + hairIndex);
            disableBottomOutfit();
            sportLevels[0].selectBottomItem(levelIndex);
        }
        private void disableBottomOutfit()
        {
            bikinniBottom.SetActive(false);
        }
        private void disableTopOutfit()
        {
            bikinniTop.SetActive(false);

        }

    }
}
