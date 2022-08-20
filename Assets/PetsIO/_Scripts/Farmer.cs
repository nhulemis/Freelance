using UnityEngine;

namespace PetsIO._Scripts
{
    public class Farmer : MonoBehaviour
    {
        // Start is called before the first frame update
        private float timer;
        private GameObject Hero;
        Animator m_Animator;
	
        private Vector3 startPos;
        public float speedRotate;
        public bool notTurnAtk;

        public bool noActive;
    
        void OnBecameInvisible()
        {
            if (!noActive)
            {
                timer = 5;
                noActive = true;
            }
        }

        // ...and enable it again when it becomes visible.
        void OnBecameVisible()
        {
            enabled = true;
            if (!notTurnAtk)
            {
                transform.LookAt(Hero.transform);
                GetComponent<AudioSource>().Play();
            }
        
        
            timer = 9999;
            noActive = false;
        }

        void Awake()
        {
            if (speedRotate == 0) speedRotate = 8;
            m_Animator = gameObject.GetComponent<Animator>();
            Hero = GameObject.Find("Hero");
            //enabled = false;
            timer = -1;
            startPos = transform.position;
            enabled = false;
        
        }
        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                transform.position = startPos;
                enabled = false;
            }

            if (Hero) LookAtXZ(Hero.transform.position, speedRotate);
            transform.Translate(Vector3.forward*1.3f*Time.deltaTime);
        }
    
        void LookAtXZ(Vector3 point, float speed)
        {
            var direction = (point - transform.position).normalized;
            direction.y = 0f;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), speed*Time.deltaTime*10);
        }
    
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Minion")
            {
            
                GameObject.Find("_MainSystem").SendMessage("SetPos", collision.gameObject.transform.position + new Vector3(0,0.5f,0));
                GameObject.Find("_MainSystem").SendMessage("ClonePart", 1);
                collision.gameObject.GetComponent<Minion>().minusPet();
            
                collision.gameObject.GetComponent<Minion>().DestroyMinion();
            }
            if (collision.gameObject.tag == "MainMinion")
            {
                GameObject.Find("_MainSystem").SendMessage("SetPos", collision.gameObject.transform.position + new Vector3(0,0.5f,0));
                GameObject.Find("_MainSystem").SendMessage("ClonePart", 1);
                if (collision.collider.name == "Hero")
                {
                    GameObject.Find("_MainSystem").SendMessage("GameFinished");
                }

                if (collision.gameObject.name == "Hero")
                {
                    GameObject.Find("DefeatSound").GetComponent<AudioSource>().Play();
                    GameObject.Find("Music").GetComponent<AudioSource>().Stop();
                    GameObject.Find("EndLevel").GetComponent<AudioSource>().Stop();
                    AppMetrica.Instance.ReportEvent("gp_farmerKill");
                }
                Destroy(collision.gameObject);
            }
        
        }
    }
}
