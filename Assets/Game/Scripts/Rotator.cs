using UnityEngine;

namespace Game.Scripts
{
    public class Rotator : MonoBehaviour
    {
        public Vector3 rotation;
        public float speed;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(rotation*speed);
        }
    }
}
