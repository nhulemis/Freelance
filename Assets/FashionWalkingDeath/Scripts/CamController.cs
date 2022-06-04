//using System.Collections;

using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class CamController : MonoBehaviour
    {
        //Private Data
        private Transform playerTarget;
        private Vector3 offset;
        private bool followingMode;
        private bool isShowMode;
        public Transform selectedModel;
        private int selectedCharacterIndex;
        private Vector3 selectedCharacterPos;
        //Serialized Data
        [SerializeField]
        private Vector3 aiEndPos;
        [SerializeField]
        private Vector3 playerPos;


        //Reference
        public static CamController instance;

        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);

        }
        // Start is called before the first frame update
        void Start()
        {
            followingMode = true;
            while (playerTarget == null)
            {
                playerTarget = GameObject.FindWithTag("Player").transform;

            }
            offset = playerTarget.position - this.transform.position;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            if(followingMode)
                followTarget();
            else if (isShowMode)
            {
                showMode();
            }
        }
        private void followTarget()
        {
            Vector3 newPos = playerTarget.position - offset;
            this.transform.position = newPos;
        }
        public void enableShowMode()
        {
            followingMode = false;
            isShowMode = true;
        }
        private void showMode()
        {
            Vector3 camPos = this.transform.position;
            camPos.x = selectedCharacterPos.x;
            camPos.z = selectedCharacterPos.z;

            transform.position =Vector3.Lerp(this.transform.position, Vector3.MoveTowards(this.transform.position, camPos, 1f),1f);
            //this.transform.LookAt(selectedModel);
        }
        public void selecteModel(Transform modelTrans)
        {
            enableShowMode();
            this.transform.eulerAngles = modelTrans.localEulerAngles;
            if (selectedCharacterIndex == 0)
            {
                selectedCharacterPos = aiEndPos;
                selectedCharacterPos.z = (FinishPlatformController.instance.getMyPos().z + 2.5f);

            }
            else if (selectedCharacterIndex == 1)
            {
                selectedCharacterPos = playerPos;
                selectedCharacterPos.z = (FinishPlatformController.instance.getMyPos().z + 2f);

            }

            selectedCharacterIndex++;
            // selectedModel = modelTrans;
        }
        public void moveBack()
        {
            isShowMode = false;
            followingMode = false;
            Vector3 myPos = this.transform.position;
            myPos.z += 3f;
            this.transform.position = myPos;
        }

   
    }
}
