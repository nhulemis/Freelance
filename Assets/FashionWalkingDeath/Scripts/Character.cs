using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class Character : MonoBehaviour
    {
        //Private Data
        private float movementSpeed=3f;
        private bool isStartShow;
        private Vector3 showPos;
        [SerializeField]
        public Vector3 endPos;
        private bool showEnded;
        //Protected Data 
        protected static bool canWalk=false;
        protected Animator anim;

    

        private void Awake()
        {       

        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        protected void move1()
        {
            if (canWalk)
            {
                
                
                
                this.transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
            }
            else if (isStartShow)
            {
                Vector3 direction = showPos - this.transform.position;
                this.transform.Translate(direction* Time.deltaTime * movementSpeed/2);
            

            }else if (showEnded)
            {
                Vector3 direction = endPos - this.transform.position;
                this.transform.Translate(direction * Time.deltaTime * movementSpeed / 2);
                this.anim.SetTrigger("Grading");

            }
        }
        public void startWalking()
        {
            canWalk = true;
        }
        public void stopWalking()
        {
            canWalk = false;
        }
        protected void enableRunAnimation()
        {
            anim.SetFloat("time", 1.0f);

            anim.SetBool("runDefault", true);
        }
        public void startShowPos()
        {
            this.anim.SetTrigger("Grading");
        
        }
        public void stopShow()
        {
            isStartShow = false;
            showEnded = true;

        }
        public void setEndPos(Vector3 endP)
        {
            endPos = endP;

        }

    }
}
