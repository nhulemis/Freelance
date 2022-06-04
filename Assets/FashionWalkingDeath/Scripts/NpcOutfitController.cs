using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class NpcOutfitController : MonoBehaviour
    {
        //Serialized Data
        [SerializeField]
        private NpcNightClubOutfitController npcNightClubOutfitController;

        [SerializeField]
        private NpcSportOutfitController sportOutfitS;
        [SerializeField]
        private NpcGalaOutfitController galaOutfitS;
        [SerializeField]
        private NpcFormalOutfitController formalOutfitS;
        [SerializeField]
        private NpcDateOutfitController dateOutfitS;
        [SerializeField]
        private NpcBeachOutfitController beachOutfitS;
        [SerializeField]
        private Npc80SOutfitController _80SOutfitS;
        //Reference
        public static NpcOutfitController instance;
        //Private Data
        private string conceptName;
        private int currentLevel;
        private int itemIndex;
        private int outfitScore;
        private int selectedItem;
        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            initializeOutfitData();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void changeOutfit(int itemIndex)
        {
            selectedItem = itemIndex;
            if (conceptName == "NightClub")
            {
                if (itemIndex == 1)
                {
                    npcNightClubOutfitController.selectShoeOutfits(itemIndex, itemIndex);
                }
                else if (itemIndex == 2)
                {
                    npcNightClubOutfitController.selectDressOutfits(itemIndex, itemIndex);
                }
                if (itemIndex == 3)
                {
                    npcNightClubOutfitController.selectHairOutfits(itemIndex, itemIndex);
                }
            }
            if (conceptName == "Sport")
            {


                if (itemIndex == 0)
                {
                    print("Select Tshirt Outfit");
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    sportOutfitS.selectTshirtOutfits(itemIndex, itemIndex);

                }
                if (itemIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    sportOutfitS.selectShoeOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    sportOutfitS.selectDressOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    sportOutfitS.selectHairOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 4)
                {
                    sportOutfitS.selectBottomOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 5) {


                }

                // nightClubOutfitChanger(index,avataIndex);
            }
            if (conceptName == "Gala")
            {


                if (itemIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    galaOutfitS.selectTshirtOutfits(itemIndex, itemIndex);

                }
                if (itemIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    galaOutfitS.selectShoeOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    galaOutfitS.selectDressOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    galaOutfitS.selectHairOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 4)
                {
                    sportOutfitS.selectBottomOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 5)
                {


                }
                else if (itemIndex == 7)
                {
                    galaOutfitS.selectGlovesOutfits(itemIndex, itemIndex);


                }
            }
            if (conceptName == "Formal")
            {


                if (itemIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    formalOutfitS.selectTshirtOutfits(itemIndex, itemIndex);

                }
                if (itemIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    formalOutfitS.selectShoeOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    formalOutfitS.selectDressOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    formalOutfitS.selectHairOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 4)
                {
                    sportOutfitS.selectBottomOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 5)
                {


                }
                else if (itemIndex == 7)
                {
                    formalOutfitS.selectGlovesOutfits(itemIndex, itemIndex);


                }
            }
            if (conceptName == "Date")
            {


                if (itemIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    dateOutfitS.selectTshirtOutfits(itemIndex, itemIndex);

                }
                if (itemIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    dateOutfitS.selectShoeOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    dateOutfitS.selectDressOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    dateOutfitS.selectHairOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 4)
                {
                    dateOutfitS.selectBottomOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 5)
                {


                }
                else if (itemIndex == 7)
                {
                    dateOutfitS.selectGlovesOutfits(itemIndex, itemIndex);


                }
            }
            if (conceptName == "Beach")
            {


                if (itemIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    beachOutfitS.selectTshirtOutfits(itemIndex, itemIndex);

                }
                if (itemIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    beachOutfitS.selectShoeOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    beachOutfitS.selectDressOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    beachOutfitS.selectHairOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 4)
                {
                    beachOutfitS.selectBottomOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 5)
                {

                    beachOutfitS.selectGlassOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 7)
                {
                    beachOutfitS.selectGlovesOutfits(itemIndex, itemIndex);


                }
            }
            if (conceptName == "80S")
            {


                if (itemIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    _80SOutfitS.selectTshirtOutfits(itemIndex, itemIndex);

                }
                if (itemIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    _80SOutfitS.selectShoeOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    _80SOutfitS.selectDressOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    _80SOutfitS.selectHairOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 4)
                {
                    _80SOutfitS.selectBottomOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 5)
                {

                    _80SOutfitS.selectGlassOutfits(itemIndex, itemIndex);

                }
                else if (itemIndex == 7)
                {
                    _80SOutfitS.selectGlovesOutfits(itemIndex, itemIndex);


                }
            }
        }
        private void initializeOutfitData()
        {
            conceptName = LevelManager.instance.getConceptName();
            currentLevel = LevelManager.instance.getCurrentLevelIndex();
        
        }
        public int getOutfitScore()
        {
            return outfitScore;
        }
        public void updateNpcOutfitProgress()
        {
            if (selectedItem == 1 || selectedItem == 2)
            {
                NpcOutfitFeedbackController.instance.updateFeedbackProgress();
                outfitScore += 2;
            }
        }
        
    }
}
