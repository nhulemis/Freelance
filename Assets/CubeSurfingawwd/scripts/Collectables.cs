using UnityEngine;

namespace CubeSurfingawwd.scripts
{
    public class Collectables : MonoBehaviour
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
            if (collision.gameObject.tag == "Barriere"  )
            {
                this.transform.parent = null;
            }else if ( collision.gameObject.tag == "water")
            {
                this.gameObject.SetActive(false);
            }
            else if (collision.gameObject.tag == "Finish" )
            {
                this.transform.parent = null;
                Destroy(this.gameObject, .2f);
            }
            
        }
   
    }
}
