using UnityEngine;

namespace Game.Scripts
{
    public class BrickController : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Invoke("enablePhysics",1f);
        }
        private void enablePhysics(){
            this.GetComponent<Rigidbody>().useGravity=true;
            this.GetComponent<Rigidbody>().isKinematic=false;

        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
