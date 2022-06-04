using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class CharacterOutfitManager : MonoBehaviour
    {
        //Private Data
        public string conceptName;
        //Outfit Score
        private int outfitScoreVal;

        //Serialized Data
   
        [SerializeField]
        private NightClubOutfitController nightClubOutfitS;

        [SerializeField]
        private SportOutfitController sportOutfitS;
        [SerializeField]
        private GalaOutfitController galaOutfitS;
        [SerializeField]
        private FormalOutfitController formalOutfitS;
        [SerializeField]
        private DateOutfitController dateOutfitS;
        [SerializeField]
        private BeachOutfitController beachOutfitS;
        [SerializeField]
        private EightySOutfitController _80SOutfitS;


        //References
        public static CharacterOutfitManager instance;


        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            outfitScoreVal = 0;
            currentOufitIndex = -1;
            conceptName = LevelManager.instance.getConceptName();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private int currentOufitIndex;
        public void changeOutfit(int index,int avataIndex)
        {
            currentOufitIndex = index;
            //Check for conceptName
            if (conceptName == "Sport")
            {
                print("yESSSSSS CHANGING oUTFIRS");
                print("First Child " + index);
                print("in First Child " + avataIndex);
                if (avataIndex == 0)
                {
                    print("Select Tshirt Outfit");
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    sportOutfitS.selectTshirtOutfits(index, avataIndex);

                }
                if (avataIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    sportOutfitS.selectShoeOutfits(index, avataIndex);

                }
                else if (avataIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    sportOutfitS.selectDressOutfits(index, avataIndex);

                }
                else if (avataIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    sportOutfitS.selectHairOutfits(index, avataIndex);

                }
                else if (avataIndex == 4)
                {
                    sportOutfitS.selectBottomOutfits(index, avataIndex);

                }
                else if (avataIndex == 5) {


                }

                // nightClubOutfitChanger(index,avataIndex);
            }
            if (conceptName == "NightClub")
            {
                print("yESSSSSS CHANGING oUTFIRS");
                print("First Child " + index);
                print("in First Child " + avataIndex);
                if (avataIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    nightClubOutfitS.selectTshirtOutfits(index, avataIndex);

                }
                if (avataIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    nightClubOutfitS.selectShoeOutfits(index, avataIndex);

                }
                else if (avataIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    nightClubOutfitS.selectDressOutfits(index, avataIndex);

                }
                else if (avataIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    nightClubOutfitS.selectHairOutfits(index, avataIndex);

                }
                else if (avataIndex == 4)
                {
                    sportOutfitS.selectBottomOutfits(index, avataIndex);

                }
                else if (avataIndex == 5)
                {


                }

                // nightClubOutfitChanger(index,avataIndex);
            }

            if (conceptName == "Gala")
            {
           

                if (avataIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    galaOutfitS.selectTshirtOutfits(index, avataIndex);

                }
                if (avataIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    galaOutfitS.selectShoeOutfits(index, avataIndex);

                }
                else if (avataIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    galaOutfitS.selectDressOutfits(index, avataIndex);

                }
                else if (avataIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    galaOutfitS.selectHairOutfits(index, avataIndex);

                }
                else if (avataIndex == 4)
                {
                    sportOutfitS.selectBottomOutfits(index, avataIndex);

                }
                else if (avataIndex == 5)
                {


                }
                else if (avataIndex == 7)
                {
                    galaOutfitS.selectGlovesOutfits(index, avataIndex);


                }
                // nightClubOutfitChanger(index,avataIndex);
            }
            if (conceptName == "Formal")
            {


                if (avataIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    formalOutfitS.selectTshirtOutfits(index, avataIndex);

                }
                if (avataIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    formalOutfitS.selectShoeOutfits(index, avataIndex);

                }
                else if (avataIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    formalOutfitS.selectDressOutfits(index, avataIndex);

                }
                else if (avataIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    formalOutfitS.selectHairOutfits(index, avataIndex);

                }
                else if (avataIndex == 4)
                {
                    formalOutfitS.selectBottomOutfits(index, avataIndex);

                }
                else if (avataIndex == 5)
                {


                }
                else if (avataIndex == 7)
                {
                    formalOutfitS.selectGlovesOutfits(index, avataIndex);


                }
                // nightClubOutfitChanger(index,avataIndex);
            }
            if (conceptName == "Date")
            {


                if (avataIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    dateOutfitS.selectTshirtOutfits(index, avataIndex);

                }
                if (avataIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    dateOutfitS.selectShoeOutfits(index, avataIndex);

                }
                else if (avataIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    dateOutfitS.selectDressOutfits(index, avataIndex);

                }
                else if (avataIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    dateOutfitS.selectHairOutfits(index, avataIndex);

                }
                else if (avataIndex == 4)
                {
                    dateOutfitS.selectBottomOutfits(index, avataIndex);

                }
                else if (avataIndex == 5)
                {


                }
                else if (avataIndex == 7)
                {
                    dateOutfitS.selectGlovesOutfits(index, avataIndex);


                }
                // nightClubOutfitChanger(index,avataIndex);
            }
            if (conceptName == "Beach")
            {


                if (avataIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    beachOutfitS.selectTshirtOutfits(index, avataIndex);

                }
                if (avataIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    beachOutfitS.selectShoeOutfits(index, avataIndex);

                }
                else if (avataIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    beachOutfitS.selectDressOutfits(index, avataIndex);

                }
                else if (avataIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    beachOutfitS.selectHairOutfits(index, avataIndex);

                }
                else if (avataIndex == 4)
                {
                    beachOutfitS.selectBottomOutfits(index, avataIndex);

                }
                else if (avataIndex == 5)
                {

                    beachOutfitS.selectGlassesOutfits(index, avataIndex);

                }
                else if (avataIndex == 7)
                {
                    beachOutfitS.selectGlovesOutfits(index, avataIndex);


                }
                // nightClubOutfitChanger(index,avataIndex);
            }
            if (conceptName == "80S")
            {


                if (avataIndex == 0)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    _80SOutfitS.selectTshirtOutfits(index, avataIndex);

                }
                if (avataIndex == 1)
                {
                    //NpcOutfitController.instance.changeOutfit(avataIndex);
                    _80SOutfitS.selectShoeOutfits(index, avataIndex);

                }
                else if (avataIndex == 2)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    _80SOutfitS.selectDressOutfits(index, avataIndex);

                }
                else if (avataIndex == 3)
                {
                    // NpcOutfitController.instance.changeOutfit(avataIndex);

                    _80SOutfitS.selectHairOutfits(index, avataIndex);

                }
                else if (avataIndex == 4)
                {
                    _80SOutfitS.selectBottomOutfits(index, avataIndex);

                }
                else if (avataIndex == 5)
                {

                    _80SOutfitS.selectGlassesOutfits(index, avataIndex);

                }
                else if (avataIndex == 7)
                {
                    _80SOutfitS.selectGlovesOutfits(index, avataIndex);

                }
                // nightClubOutfitChanger(index,avataIndex);
            }
        }
        public void nightClubOutfitChanger(int index,int avatarI)
        {
            //int levelIndex = LevelManager.instance.getCurrentLevelIndex();
            // Transform parent = nightClubOutfit.GetChild(levelIndex);
            //parent.GetChild(index).GetChild(avatarI).gameObject.SetActive(true);
        }
        public void updatePlayerFeedbackProgress()
        {
            if (currentOufitIndex == 1 || currentOufitIndex == 0)
            {
                PlayerOutfitFeedbackController.instance.updateFeedbackProgress();
                outfitScoreVal+=2;
                currentOufitIndex = -1;
            }
        }
        public int getScorevalue()
        {
            return outfitScoreVal;
        }
        public void npcKicked()
        {

        }

    }
}
