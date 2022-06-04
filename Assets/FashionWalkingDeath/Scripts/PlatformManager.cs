using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class PlatformManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject platformPartObj;
        [SerializeField]
        private Transform platformStartPos;
        [SerializeField]
        private GameObject endPlatformObj ;


        //Private Data
        private int platformCount=3;
        private Vector3 currentPlatformPos=Vector3.zero;
        private Vector3 platformChildOffset=new Vector3(0,0,15f);
        private MidPlatformController[] midPlatformController;
        // Start is called before the first frame update
        void Start()
        {
            currentPlatformPos = platformStartPos.position;
            currentPlatformPos = Vector3.zero;
            
            makePlatforms();
            midPlatformController = GetComponentsInChildren<MidPlatformController>();
            setUpMidPlatdromData();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void makePlatforms()
        {
            Cards items = LevelManager.instance.getCurrentLevelData();
            platformCount = items.items.Length;
            for (int i = 0; i < platformCount; i++)
            {
                makeNewPlatform();
            }
            makeEndPlatform();
        }
        private void makeNewPlatform()
        {
            GameObject childPlatform = Instantiate(platformPartObj,currentPlatformPos,Quaternion.Euler(new Vector3(0,180,0)),this.transform);
            childPlatform.transform.localPosition = currentPlatformPos;
            currentPlatformPos += platformChildOffset;
        
        }
        private void makeEndPlatform()
        {
            GameObject endPlatform = Instantiate(endPlatformObj, currentPlatformPos, Quaternion.Euler(new Vector3(0, 180, 0)));
            endPlatform.transform.localPosition = currentPlatformPos+Vector3.forward*3.2f+Vector3.up*.2f;

        }
        private void setUpMidPlatdromData()
        {
            Cards items = LevelManager.instance.getCurrentLevelData();
            int[] itemsCount = items.items;
            for (int i = 0; i < itemsCount.Length; i++)
            {
                print("Enabled pLACK child : " + itemsCount[i]);
                midPlatformController[i].setAvatar(itemsCount[i]);
            }
        }
    }
}
