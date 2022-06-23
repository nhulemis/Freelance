using UnityEngine;

namespace Arrow.Script
{
    public class BossController : MonoBehaviour
    {
        private Rigidbody rb;
        public Rigidbody[] childrb;
        private bool kiled = false;
        public Animator anim;
        public Transform target;
        // Start is called before the first frame update
        void Start()
        {
            childrb = this.GetComponentsInChildren<Rigidbody>();
            rb = this.GetComponent<Rigidbody>();
            rb.isKinematic = false;

        }

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
        class HSUvokaowmbnvxc5
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
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
        class Kkxcjoasdic9mas
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }
        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnTriggerExit(Collider other)
        {
        
        }
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Arrow"))
            {
                if (!kiled)
                {

                    Destroy(other.gameObject);
                    print("Yoooo Arrow Trigger");
                    enableRagdoll();

                }

                ///.rb.velocity=(Vector3.right);

            }
        }
        private void enableRagdoll()
        {
            anim.enabled = false;
            kiled = true;
            rb.isKinematic = true;
            foreach (Rigidbody rbChild in childrb)
            {
                rbChild.isKinematic = false;
            }

        }
        public Transform getTarget()
        {
            return target;
        }
    }
}
