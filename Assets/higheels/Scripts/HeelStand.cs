using UnityEngine;

namespace higheels.Scripts
{
    public class HeelStand : MonoBehaviour
    {
        public int childIndex;
        [SerializeField]
        GameObject effect;
        GameObject effectHolder;
        Vector3 effectLocalPosition;
        // Start is called before the first frame update
        void Start()
        {
            effectLocalPosition = new Vector3(0, -.9f, .12f);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnTriggerEnter(Collider other)
        {
            //effectHolder.SetActive(true);
            
            
            
            //effectHolder.transform.position = other.transform.position;
            if (other.gameObject.CompareTag("Bridge Slide"))
            {
                
                
                
                createSlidesEffect();
            }
            if (other.gameObject.CompareTag("End"))
            {
                if (effectHolder)
                {
                    Destroy(effectHolder);
                }
            }
        }
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Bridge Slide"))
            {
                //effectHolder.transform.position = other.contacts[0].point;
                if(effectHolder)
                    effectHolder.transform.localPosition =effectLocalPosition ;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Bridge Slide"))
            {
                if(effectHolder)
                    Destroy(effectHolder);
            }

        }
        private void createSlidesEffect()
        {
            effectHolder = Instantiate(effect, Vector3.zero, Quaternion.identity, this.transform);

        }

    }
}
