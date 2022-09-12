using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private Rigidbody rb;
    public float speed=1;
    public float rotationSpeed=1;
    public bool faceforward=true;
    public FloatingJoystick joystick;
    public Animator anim;
    public bool onGround=true;
    public float jumpForce=590f;
    public float forwardJumpForce=4;
    public float upJumpForce=5;
    public static CharacterManager instance;
    void Awake(){
        if(instance==null){
            instance=this;

        }else if(instance!=this){
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
 
        public class PBCCRefbinLCauOxoodUttlvaWcxQpp
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

        public PBCCRefbinLCauOxoodUttlvaWcxQpp()
        {
            
        }
        public PBCCRefbinLCauOxoodUttlvaWcxQpp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PBCCRefbinLCauOxoodUttlvaWcxQpp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PBCCRefbinLCauOxoodUttlvaWcxQpp GetPBCCRefbinLCauOxoodUttlvaWcxQpp(){
        var clasx = new PBCCRefbinLCauOxoodUttlvaWcxQpp();
        return  clasx;
    }

    public string RandomStringPBCCRefbinLCauOxoodUttlvaWcxQpp(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
    {
       rb=GetComponent<Rigidbody>();
       selectCharactere(); 
    }

    // Update is called once per frame
    void Update()
    {
      switch(GameManager.instance.currentState){
        case GameManager.GameState.play :
        timeScaler();
        Debug.DrawLine(transform.localPosition,-Vector3.up,Color.green);      
       if(isOnGround()){
            print("On onGround");
            onGround=true;
           
       }else{
        if(onGround){
            onGround=false;
            jump();
        }else if(!onGround){
            rb.velocity=rb.velocity+Vector3.down*Time.deltaTime;
        }
       }
        break;
        case GameManager.GameState.end :
        characterStop();
        break ;

      }
      

    }

    void FixedUpdate(){
        switch(GameManager.instance.currentState){
            case GameManager.GameState.play :
            if(onGround){
            anim.SetBool("inAir",false);
           
           
        }
        
        else{
            print("not On onGround");
            anim.SetBool("inAir",true);

        }
         move();
         break;

        }
        
         
    }
   
        public class qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn
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

        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn()
        {
            
        }
        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn GetqKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(){
        var clasx = new qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn();
        return  clasx;
    }

    public string RandomStringqKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void move(){
        
    if(joystick.Horizontal!=0 || joystick.Vertical!=0){
            if(onGround){
                anim.SetBool("Run",true);
              anim.SetFloat("Speed",.6f);
              rb.velocity=new Vector3(joystick.Horizontal,0,joystick.Vertical)*Time.deltaTime*speed;
              transform.rotation=Quaternion.LookRotation(rb.velocity*Time.deltaTime);  

    }else{
        // rb.velocity=new Vector3(joystick.Horizontal,-Time.deltaTime*10,Time.deltaTime*50)*Time.deltaTime*speed;  
        rb.MovePosition(transform.position+new Vector3(joystick.Horizontal,0,0)*Time.deltaTime*10); 
         
    }
              
          //  print("Joystick Vertical Value "+joystick.Vertical);
            
        }else{
            if(onGround)
           rb.velocity=Vector3.zero;
            anim.SetBool("Run",false);
        }

    }
    private void jump(){
        print("Jump");
        rb.AddForce((transform.forward*forwardJumpForce+Vector3.up*upJumpForce)*jumpForce);
    }
    private bool isOnGround(){
        return Physics.Raycast(transform.localPosition, -Vector3.up,.1f);
    }
     private  float UnwrapAngle(float angle)
        {
            if(angle >=0)
                return angle;
 
            angle = -angle%360;
 
            return 360-angle;
        }
         private  float WrapAngle(float angle)
        {
            angle%=360;
            if(angle >180)
                return angle - 360;
 
            return angle;
        }

        //Collissions
        private void OnCollisionEnter(Collision other){
            if(other.gameObject.CompareTag("Finish")){
                //
                print("Level ended");
                GameManager.instance.enableEndyMode();
            } if(other.gameObject.CompareTag("Bullet")){
                //

                GameManager.instance.enableWaitMode();
                anim.SetBool("Run",false);
                print("Level ended");
                anim.SetBool("Dead",true);
                CameraController.instance.stopFollowing();
                Invoke("levelFailDelay",2f);
                
            } 
        } 
        private void levelFailDelay(){
            UiManager.instance.levelFail();

        }
        private void OnTriggerEnter(Collider other){
            if(other.gameObject.CompareTag("DeadArea")){
                //
                print("Level ended");
               CameraController.instance.stopFollowing();
               UiManager.instance.levelFail();
            } 
        } 
        private void selectCharactere(){
            int currentSelectedCharaceterIndex=PlayerPrefs.GetInt("SelectedCharactere",0);
            foreach(Transform child in this.transform){
                child.gameObject.SetActive(false);
            }
            if(currentSelectedCharaceterIndex>transform.childCount){
                currentSelectedCharaceterIndex=0;
            }
            Transform activated=transform.GetChild(currentSelectedCharaceterIndex);
            activated.gameObject.SetActive(true);
            anim=activated.GetComponent<Animator>();

        }
        private void characterStop(){
             rb.velocity=Vector3.zero;
            anim.SetBool("Run",false);
            anim.SetBool("Win",true);
            CameraController.instance.startRotating();


        }
        private void timeScaler(){
            if(Input.GetMouseButtonDown(0)){
                Time.timeScale=1;
            } if(Input.GetMouseButtonUp(0)){
                if(onGround){
                  Time.timeScale=0f;
                anim.SetBool("Run",false);
                }
                


            }
        }
        public void upgradeJumpForce(float forwardJumpForc=4,float upJumpForc=5){
                this.forwardJumpForce+=forwardJumpForc;
                this.upJumpForce+=upJumpForc;

        }

}
