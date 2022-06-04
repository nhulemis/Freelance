using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class CameraMovement : MonoBehaviour
    {
        // Start is called before the first frame update
        public float speed;

        public float minZ;
    
        private GameObject hero;
        void Start()
        {
            hero = GameObject.Find("Hero");
        
        }

        // Update is called once per frame
        void Update()
        {
            if (hero) transform.position = Vector3.Lerp(transform.position, hero.transform.position+new Vector3(0, 10, -5.5f), Time.deltaTime*speed);
          
            transform.position = new Vector3(0,10,transform.position.z);

            if (transform.position.z < minZ)
            {
                transform.position = new Vector3(0,10,minZ);
            }
          
        }
    }
}
