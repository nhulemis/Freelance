using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class onTextDamage : MonoBehaviour
    {
        private float scale;
        private float scCur;
        private float maxScale;

        private int step;

        private float timer;
        // Start is called before the first frame update
        void Start()
        {
            maxScale = 1.3f;
            scale = transform.localScale.x;
        
            scCur = scale * 0.8f;
        
            transform.localScale = new Vector3(scCur,scCur,scCur);
        
            transform.position = new Vector3(transform.position.x+Random.Range(-0.20f,0.20f),transform.position.y+Random.Range(-0.20f,0.20f),transform.position.z);
        }

        // Update is called once per frame
        void Update()
        {
        
        

            if (step == 0)
            {
                scCur += Time.deltaTime;
                if (scCur > scale * maxScale)
                {
                    scCur = scale * maxScale;
                    step = 1;
                
                }
            }
        
            if (step == 1)
            {
                scCur -= Time.deltaTime;
                if (scCur < scale)
                {
                    step = 2;
                }
            }

            if (step == 2)
            {
                timer += Time.deltaTime;
                if (timer > 0.2)
                {
                    scCur -= Time.deltaTime*0.5f;
                    if (scCur < 0.1f) Destroy(gameObject);
                
                }
                else
                {
                    scCur -= Time.deltaTime * 0.05f;
                }
            }
    
        
            transform.localScale = new Vector3(scCur,scCur,scCur);
        }
    }
}
