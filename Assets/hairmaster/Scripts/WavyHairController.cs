using UnityEngine;

namespace hairmaster.Scripts
{
    public class WavyHairController : MonoBehaviour
    {
        private SkinnedMeshRenderer[] skinnedMesh;

        // Start is called before the first frame update
        void Awake()
        {
            skinnedMesh = this.transform.GetComponentsInChildren<SkinnedMeshRenderer>();

        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void changeColor(Material newMaterial)
        {
            foreach (SkinnedMeshRenderer skinedMeshChild in skinnedMesh)
            {
                
                
                skinedMeshChild.material = newMaterial;
            }
        }
    }
}
