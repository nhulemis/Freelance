using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class rotateZ : MonoBehaviour
    {
        public float speed;
        // Start is called before the first frame update
        void Start()
        {
            if (speed == 0) speed = 999;
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up*Time.deltaTime*-speed);
        }
    }
}
