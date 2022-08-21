using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class BeybladeController : MonoBehaviour
{
     public Transform rightTrans;
     public Transform leftTrans;
     public Transform playerFirstPos;
     public static BeybladeController instance;
     public FloatingJoystick joystick;
     public float speed;
     private Rigidbody rb;
     public Transform idle;
     public GameObject crashEffect;
     public bool idleMode=true;
    void Awake(){
    	if(instance==null)
    	 instance=this;
    	 else if(instance!=this){
    	 	Destroy(this.gameObject);
    	 }

    }
    // Start is called before the first frame update
    void Start()
    {
       rb=this.GetComponent<Rigidbody>();
    }
    void Update(){
        
    }
    // Update is called once per frame
   
    Vector2 positionOnScreen;
    void FixedUpdate(){
      switch(GameManager.instance.currentSatate){
      	case GameManager.GameState.play :
           move();

      	break;
      }
     if(idleMode){
        gooIdle();
     }
          
    }
   void move(){
         resetAngles();
         if( (joystick.Horizontal!=0 || joystick.Vertical!=0) ){              
            // rb.velocity=new Vector3(joystick.Horizontal,0,joystick.Vertical)*Time.deltaTime*speed;
            Vector3 joystickDirection=new Vector3(joystick.Horizontal,0,joystick.Vertical)*Time.deltaTime*speed;
             Vector3 mTowards=Vector3.MoveTowards(rb.velocity,joystickDirection,.7f);
             rb.velocity=Vector3.Lerp(rb.velocity,joystickDirection,1f);          // transform.rotation=Quaternion.LookRotation(rb.velocity*Time.deltaTime);     
        }

    }
    void resetAngles(){
        this.transform.eulerAngles=new Vector3(0,transform.eulerAngles.y,0);
    }
 
    public Vector3 right(){
    	return rightTrans.localPosition;
    }public Vector3 left(){
    	return leftTrans.localPosition;
    }
    private string check=null;
    public float crashpeed=300f;
    public bool crash=false;
    void OnCollisionEnter(Collision other) {
         
     check=other.gameObject.tag;// simplification of the name of how is hit our specific enemy 
         if (check == "Enemy")
         {
         crash=true;// now the crash is happen
          //take the name of other enmy that we crash it maybe it be killer of our specific enemy
         // take the first char because i name all the player include all  enemy (0player,1enem,2enemy,3enemy,4enemy,5enemy)
         StartCoroutine(delaicrash());// wait to finnis the hit consequence
             ContactPoint[] contacts=new ContactPoint[3];
            other.GetContacts(contacts);
            Instantiate(crashEffect,contacts[0].point,Quaternion.identity);

           // print("Collision At"+contacts[0].point);
        print(" PLayer Shoooooooooooot");
        AudioManager.instance.playCrashSound();
    if(Random.Range(0,15)==3){
         CameraController.instance.enableShaker();

             CameraShaker.Instance.ShakeOnce(3f,3f,.1f,.9f);


    }
     
     var force = transform.position - other.transform.position;// calculate the distance between theour enemy and other how crash it 
     force.Normalize();// nomalisation 
     print("force Speed"+crashpeed);
     other.gameObject.GetComponent<Rigidbody>().AddForce(-force * Random.Range(crashpeed,crashpeed+150) );// move oway how crash our specific enemy far opposit dirction

         }         
        
    }
    IEnumerator delaicrash(){
         crashpeed/=2;
        yield return new WaitForSeconds(.6f);
        crash=false;
    }
    public void clear(){
    	foreach(Transform trans in rightTrans){
    		Destroy(trans.gameObject);
    	}foreach(Transform trans in leftTrans){
    		Destroy(trans.gameObject);
    	}
    }
    public void place(){
     this.transform.position=playerFirstPos.position;
     rb.isKinematic=false;
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.CompareTag("DeadArea")){

            print("Player Dead");
            Vector3 forceDirection=rb.position-other.gameObject.transform.position;
            rb.AddForce(forceDirection*10);
            Invoke("endRoundDelay",1f);
            
        }
    }
    private void endRoundDelay(){
        GameManager.instance.endRound(true);

    }
    private bool canControll(){
    	return Physics.Raycast(this.transform.position,-Vector3.up,1f);
    }public void gooIdle(){
        rb.isKinematic=true;
        transform.position=Vector3.Lerp(this.transform.position,idle.position,0.1f);
    }
    public void assignWings(ref Transform rightW, ref Transform leftW){
          rightTrans=rightW;
          leftTrans=leftW;
    }

}
