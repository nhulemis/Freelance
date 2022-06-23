using UnityEngine;

namespace Arrow.Script
{
    public class ArrowChildManager : MonoBehaviour
    {
        private bool canShoot;
        public Transform target;
        private float speed=15f;
   
        class HSUQOXkkoaw1
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class HSUQOXkzkockosa2
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class HSUcjiaojxjsi3
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class HSUckvoawopvp4
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class CHusjkjzoskc7c
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (canShoot)
            {
                Vector3 direction = target.position - this.transform.position;
                this.transform.position += direction.normalized * Time.deltaTime * speed;
            }
        }
        public void shoot(Transform target)
        {

            this.transform.parent = null;
            this.target = target;
            canShoot = true;
            Destroy(this.gameObject,1f);

        }
    
    }
}
