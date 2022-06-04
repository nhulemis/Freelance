using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class NpcNightClubOutfitController : MonoBehaviour
    {
        //Serialized Data
        public LevelConceptsController[] nightClubLevels;
        [SerializeField]
        public GameObject bikinniTop;
        [SerializeField]
        public GameObject bikinniBottom;
        //Private Data
        private int playerSelectedOutfit;
        // Start is called before the first frame update
        void Start()
        {
            nightClubLevels = this.GetComponentsInChildren<LevelConceptsController>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void selectHairOutfits(int levelIndex, int hairIndex)
        {
            print("Changing Hair levele index : " + levelIndex + " & selected hair is :" + hairIndex);
            int hairIndexT = Random.Range(0, 3);
            playerSelectedOutfit = hairIndexT;
            nightClubLevels[0].selectHairItem(hairIndexT);
        }
        public void selectShoeOutfits(int levelIndex, int hairIndex)
        {
            print("Changing Shoe levele index : " + levelIndex + " & selected shoe is :" + hairIndex);
            int shoeIndexT = Random.Range(0, 3);
            playerSelectedOutfit = shoeIndexT;

            nightClubLevels[0].selectShoeItem(shoeIndexT);
        }
        public void selectDressOutfits(int levelIndex, int hairIndex)
        {
            print("Changing Dress levele index : " + levelIndex + " & selected Dress is :" + hairIndex);
            bikinniBottom.SetActive(false);
            bikinniTop.SetActive(false);
            int dressUpT = Random.Range(0, 3);
            playerSelectedOutfit = dressUpT;

            nightClubLevels[0].selectDressItem(dressUpT);
        }
    }
}
