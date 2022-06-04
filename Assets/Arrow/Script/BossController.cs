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
