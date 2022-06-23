using UnityEngine;

namespace Arrow.Script
{
    public class StageController : MonoBehaviour
    {
        public BossController[] boss;
        // Start is called before the first frame update
        void Start()
        {
            boss = this.GetComponentsInChildren<BossController>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        class CHusjxoacm6x
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }
        public BossController[] getBosses()
        {
            return boss;
        }

    }
}
