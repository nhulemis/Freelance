using UnityEngine;

namespace CubeSurfing.scripts
{
    public class CrashDetector : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "up")
            {
                CharactereController.state = CharactereController.gameState.stop;
            
            }
          
        }
    
    }
}
