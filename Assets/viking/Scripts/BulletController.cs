using UnityEngine;

namespace viking.Scripts
{
    public class BulletController : MonoBehaviour
    {
        private Rigidbody rb;
        GameObject obj;
        // Start is called before the first frame update
        void Start()
        {
            obj=GameObject.FindWithTag("AttackSlicer");

            rb=GetComponent<Rigidbody>();
            
            
            Destroy(this.gameObject,4f);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        private void OnCollisionEnter(Collision other){
            if(other.gameObject.CompareTag("Sword")){
                
                
                print("Sword and Bullet Collsion");
                rb.velocity=Vector3.zero;
            }




        }
    }
}
