using System.Collections;
using Imposter.Joystick_Pack.Scripts.Joysticks;
using UnityEngine;

namespace Imposter.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public FloatingJoystick joystick;
        private Rigidbody rb;
        public float speed=1;
        private Animator anim;
        public static PlayerController instance;
        void Awake(){
            if(!instance){
                instance=this;
            }else if(instance!=this){
                Destroy(this.gameObject);
            }
        }
        // Start is called before the first frame update

        public class khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj()
        {
            
        }
        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj GetkhsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(){
        var clasx = new khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj();
        return  clasx;
    }

    public string RandomStringkhsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {
            rb=this.GetComponent<Rigidbody>(); 
            anim=this.GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        void FixedUpdate(){
            switch(GameManager.instance.currentState){
                case GameManager.GameState.play :
                    move();
                    break;
                case GameManager.GameState.end:
                    anim.SetFloat("Speed",-1f);
                    break;

            }
    	
        }

       
        public class eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr()
        {
            
        }
        public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr GeteBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(){
        var clasx = new eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr();
        return  clasx;
    }

    public string RandomStringeBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void move(){
        
            if(joystick.Horizontal!=0 || joystick.Vertical!=0){
            
                //anim.SetBool("Run",true);
                //anim.SetFloat("Speed",.6f);
                float x=joystick.Horizontal;
                float y=joystick.Vertical;
                anim.SetFloat("Speed",1f);
                rb.velocity=new Vector3(x,0,y)*Time.deltaTime*speed;
                transform.rotation=Quaternion.LookRotation(rb.velocity*Time.deltaTime);  
                //  print("Joystick Vertical Value "+joystick.Vertical);
            }else{
                rb.velocity=Vector3.zero;
                anim.SetFloat("Speed",-.01f);
            }

        }
        public IEnumerator startAttack(Transform target){

            while(Vector3.Distance(this.transform.position,target.position)>1){
                anim.SetFloat("Speed",1f);
                this.transform.position=Vector3.Lerp(this.transform.position,target.position,.1f);
                yield return null;
            } 
            anim.SetTrigger("Attack");
            HandController.instance.performAttack();
            target.gameObject.GetComponent<NpcController>().performDead();

        }
        public Transform getReference(){
            return this.transform;
        }
        public void performDance(){
            anim.SetTrigger("Surprise");
        }
    }
}
