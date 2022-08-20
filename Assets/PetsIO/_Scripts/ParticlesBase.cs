using UnityEngine;

namespace PetsIO._Scripts
{
    public class ParticlesBase : MonoBehaviour
    {
        public GameObject[] particles;
        public GameObject paren;

        private Vector3 pos;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        void SetPos(Vector3 p)
        {
            pos = p;
        }
    
        void SetParent(GameObject p)
        {
            paren = p;
        }
    
        void ClonePart(int v)
        {
            var gg = Instantiate(particles[v], pos, particles[v].transform.rotation);
            if (paren != null)
            {
                gg.transform.parent = paren.transform;
            }

            paren = null;
        }
    
    }
}
