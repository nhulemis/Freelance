using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class dropEffectAndScale : MonoBehaviour
    {
        private  GameObject sdw;
        private int step;

        private float timer;
        // Start is called before the first frame update
        void Start()
        {
        
            foreach (Transform child in transform)
            {
                if (child.name == "sdw") sdw = child.gameObject;
            }
            sdw.transform.parent = null;
        }

        // Update is called once per frame
        void Update()
        {

            if (step == 0)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 5);
                if (transform.position.y > 1f)
                {
                    step = 1;
                }
            }
            if (step == 1)
            {
                transform.Translate(-Vector3.up * Time.deltaTime * 5);
                if (transform.position.y < 0)
                {
                    transform.position = new Vector3(transform.position.x, 0, transform.position.z);
                    step = 2;
                    timer = 0;
                }
            }
            if (step == 2)
            {
           
                timer += Time.deltaTime;
                if (timer > 2)
                {
                    timer = 1;
                    step = 3;
                }
            }
        
            if (step == 3)
            {
           
                timer -= Time.deltaTime*1.5f;
                transform.localScale = new Vector3(timer,timer,timer);
                if (timer < 0)
                {
                
                    Destroy(sdw);
                    Destroy(gameObject);
                }
            }
        }
    }
}
