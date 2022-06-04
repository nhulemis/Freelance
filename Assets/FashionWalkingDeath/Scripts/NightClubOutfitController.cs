using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class NightClubOutfitController : MonoBehaviour
    {
        //Serialized Data
        public  LevelConceptsController[] nightClubLevels;
        [SerializeField]
        public GameObject bikinniTop;
        [SerializeField]
        public GameObject bikinniBottom;
        // Start is called before the first frame update
        void Start()
        {
            nightClubLevels = this.GetComponentsInChildren<LevelConceptsController>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }


        public void selectTshirtOutfits(int levelIndex, int hairIndex)
        {
            print("Changing Hair levele index : " + levelIndex + " & selected hair is :" + hairIndex);
            nightClubLevels[0].selectTopDressItem(levelIndex);
        }
        public void selectHairOutfits(int levelIndex,int hairIndex)
        {
            print("Changing Hair levele index : " + levelIndex + " & selected hair is :" + hairIndex);
            nightClubLevels[0].selectHairItem(levelIndex);
        }
        public void selectShoeOutfits(int levelIndex, int hairIndex)
        {
            print("Changing Shoe levele index : " + levelIndex + " & selected shoe is :" + hairIndex);

            nightClubLevels[0].selectShoeItem(levelIndex);
        }
        public void selectDressOutfits(int levelIndex, int hairIndex)
        {
            print("Changing Dress levele index : " + levelIndex + " & selected Dress is :" + hairIndex);
            bikinniBottom.SetActive(false);
            bikinniTop.SetActive(false);

            nightClubLevels[0].selectDressItem(levelIndex);
        }
    }
}
