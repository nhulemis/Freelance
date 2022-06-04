using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class NpcController : Character
    {
        public static NpcController instance;

        private void Awake()
        {
            if (!instance)
                instance = this;
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            anim = this.GetComponentInChildren<Animator>();
            anim.SetFloat("time", 0f);

        }

        // Update is called once per frame
        void Update()
        {
            move();
        }
        public void enableRunAnimto()
        {
            enableRunAnimation();

        }
        public void setEndP()
        {
            this.anim.SetBool("final_idle", true);

            //setEndPos(this.transform.position);
        }
        public void changeOutfit()
        {

        }
        public void kicked()
        {

            anim.SetBool("get_kick", true);
        }
        public void finalIdle()
        {
            anim.SetBool("final_idle", true);

        }
        public void cry()
        {
            anim.SetTrigger("Cry");

        }
        public void mirrored()
        {
            this.transform.eulerAngles = new Vector3(0, 80, 0);
        }
    }
}
