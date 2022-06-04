using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class drakkar : MonoBehaviour
    {
        private float timer;

        private int step;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void ActivateDrakkar()
        {
            if (step == 0) step = 1;
        }
    
        void Update()
        {
            if (step == 1)
            {
            
                transform.Translate(Vector3.right*Time.deltaTime*5);
                if (transform.position.x > 0)
                {
                    step = 1;
                    transform.position = new Vector3(0,transform.position.y, transform.position.z );
                }
            }
            if (step == 2)
            {
            
                transform.Translate(Vector3.right*Time.deltaTime*5);
                if (transform.position.x > 5)
                {
                    step = 2;
                    GameObject.Find("Hero").transform.parent = null;
                    DontDestroyOnLoad( GameObject.Find("Hero"));
                    GameObject.Find("mainConfig").SendMessage("FinishLevel");
                }
            }
        }
    
        private void OnTriggerEnter(Collider her)
        {
            if (her.tag == "Hero")
            {
                step = 2;
                her.transform.parent = transform;
                GameObject.Find("Canvas").active = false;
            }
        }
    }
}
