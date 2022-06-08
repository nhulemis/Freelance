using UnityEngine;

namespace CubeSurfing.scripts
{
    public class MagnetToolManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public class MyClass
        {
            public void SomeMethod(int firstParam, float secondParam)
            {
				
            }

        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "towerbuild")
            {
                TowerBuilder.instance.addToBuilding(other.gameObject);
            }
        }
    }
}
