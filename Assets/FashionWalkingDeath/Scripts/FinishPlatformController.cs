using System.Collections;
using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class FinishPlatformController : MonoBehaviour
    {
        //Serlaized Data
        [SerializeField]
        private Transform showpPos;
        [SerializeField]
        private Transform[] characterPos;
        private SignsManager signManager;
        
        
        
        

        //Private Data
        private Character[] characterModel;
        private int passedCharacter;

        //References
        public static FinishPlatformController instance;

        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            characterModel = FindObjectsOfType<Character>();
            signManager = this.GetComponentInChildren<SignsManager>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void startShow()
        {
            StartCoroutine("selectedCharacterForShow");
            int npcOutfitScore=NpcOutfitController.instance.getOutfitScore();
            signManager.showUpSigns(npcOutfitScore);
        }
        IEnumerator selectedCharacterForShow()
        {
            if (passedCharacter < 2)
            {
                if (passedCharacter == 1)
                {
                    signManager.changePosToPlayerPos();
                }
                characterModel[passedCharacter].startShowPos();
           
                CamController.instance.selecteModel(characterPos[passedCharacter]);

            }
            yield return new WaitForSeconds(5f);
            //characterModel[passedCharacter].stopShow();

            passedCharacter++;
            if (passedCharacter <= 1)
            {
                if (passedCharacter == 1)
                {
                    signManager.resetChildPos();
                }
                print("Current Character is : " + passedCharacter);
                StartCoroutine("selectedCharacterForShow");

            }
            else
            {
                chooseWinner();
                // UiManager.instance.reloadLevel();
                //Let the winner Kick the looser
            }
        }
        public Vector3 getMyPos()
        {
            return this.transform.position;
        }
        private void chooseWinner()
        {
            int playerOutfitScore=CharacterOutfitManager.instance.getScorevalue();
            int npcOutfitScore = NpcOutfitController.instance.getOutfitScore();
            if (playerOutfitScore >= npcOutfitScore)
            {
                NpcController.instance.cry();
                CharacterManager.instance.kick();
                signManager.transform.gameObject.SetActive(false);
                CamController.instance.moveBack();
                print("Yooo Player Win");
            }
            else
            {
                signManager.transform.gameObject.SetActive(false);
                CamController.instance.moveBack();
                CharacterManager.instance.cry();


            }
        }


    }
}
