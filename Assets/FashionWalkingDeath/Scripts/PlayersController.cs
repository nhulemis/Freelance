using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class PlayersController : MonoBehaviour
    {
        [SerializeField]
        private GameObject mainCharacterObject;
        [SerializeField]
        private GameObject aiCharacterObject;
        [SerializeField]
        private Transform mainCharacterPos;
        [SerializeField]
        private Transform aiCharacterPos;
        [SerializeField]
        private Transform playerMainStartPos;
        // Start is called before the first frame update
        void Awake()
        {
            makeMainCharacter();
            makeAiCharacte1r();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void makeMainCharacter()
        {
            GameObject playerObject = Instantiate(mainCharacterObject, Vector3.zero, Quaternion.identity);
            playerObject.GetComponent<CharacterManager>().setMainStartPos(playerMainStartPos);
            playerObject.transform.position = mainCharacterPos.position;
        }
        private void makeAiCharacte1r() {

            GameObject aiObject = Instantiate(aiCharacterObject, Vector3.zero, Quaternion.identity);
            
            
            
            aiObject.transform.position = aiCharacterPos.position;


        }

    }
}
