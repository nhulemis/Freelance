using UnityEngine;

namespace Game.Scripts
{
    public class Rotator : MonoBehaviour
    {
        public class ANCXUA
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
        public class ANCXUAHCuskawo
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
        }
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
