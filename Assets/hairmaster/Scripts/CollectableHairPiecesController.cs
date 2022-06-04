using UnityEngine;

namespace hairmaster.Scripts
{
    public class CollectableHairPiecesController : MonoBehaviour
    {
        private Material mat;
        // Start is called before the first frame update
        void Start()
        {
            mat = this.GetComponentInChildren<MeshRenderer>().material;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player")) {

                HairController.instance.growHairBones(ref mat);
                
                
                
                
                
                
                Destroy(this.gameObject);
            }

        }
    }
}
