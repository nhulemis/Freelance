using UnityEngine;

namespace Samurai.Scripts
{
    public class Rotator : MonoBehaviour
    {
        public float speed;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up,Time.deltaTime*speed);
        }
    }
}
