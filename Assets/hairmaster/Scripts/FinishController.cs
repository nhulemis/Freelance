using UnityEngine;

namespace hairmaster.Scripts
{
    public class FinishController : MonoBehaviour
    {
        [SerializeField]
        private Transform finishTarget;
        [SerializeField]
        private Transform finishLookAtTarget;
        [SerializeField]
        private Transform[] finishCamPos;
        [SerializeField]
        private Transform endCamLookTarget;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public Transform getFinishTarget()
        {
            return finishTarget;
        }
        public Transform getFinishLookAtTarget()
        {
            return finishLookAtTarget;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                FinishMultiplierHolderController.instance.setUpFinishShowStage();
                CameraController.instance.setCamEndTarget(finishCamPos, endCamLookTarget); ;
            }
        }
    }
}
