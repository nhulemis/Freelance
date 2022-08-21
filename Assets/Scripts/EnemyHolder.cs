using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHolder : MonoBehaviour
{
     public Transform rightTrans;
     public Transform leftTrans;
     public GameObject crown;
     private Transform target;
     private Rigidbody rb;
     public float rotationSpeed=3f;
     public float forwardSpeed=.1f;
     private bool dead;
     public static EnemyHolder instance;
    void Awake(){
        if(instance==null){
            instance=this;
        }else if(instance!=this){
            Destroy(this.gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
       // target=GameObject.FindWithTag("Player").transform;
        rb=this.GetComponent<Rigidbody>();
        target=GameObject.FindWithTag("Player").transform;
        EnnemySelector.instance.selectEnemy();
        CanvasDraw.instance.addWings(this);
        crashpeed+=PlayerPrefs.GetFloat("EnemyCrashForceUpdate");
        rb.drag+=PlayerPrefs.GetFloat("EnemyDrag");
        forwardSpeed+=PlayerPrefs.GetFloat("EnemyforwardSpeed");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch(GameManager.instance.currentSatate){
        	case GameManager.GameState.play :
        	   followTraget();

        	  break;
            case GameManager.GameState.end :
            if(dead)
            rb.AddForce(rb.position-target.position);
               else{
                   stop();
                   crown.SetActive(true);
               }
             

            break;
        }
    }
    void followTraget(){
    	if(target!=null&&!crash)// when the target enemy is not num and no crash 
		{
    	transform.Translate(Vector3.forward * forwardSpeed);// move to firword direction 
			Vector3 direction = (Vector3) target.position -  rb.position; // calculat the tow position to convet them to rotation 
			direction.Normalize();// normalisation 
			Vector3 angle = Vector3.Cross(direction, transform.forward).normalized;
			rb.angularVelocity = -rotationSpeed *angle;// withe rigidbody 

			// anglr to follow the specific enemy to foloow the target enemy

      }
    }
    bool crash;
    public float crashpeed=450;
    string check="";
    void OnCollisionEnter(Collision other) {
		 
     check=other.gameObject.tag;
		 if (check == "Player")
		 {

         crash=true;
		 StartCoroutine(delaicrash());			
         print(" Enemmy Shoooooooooooot");     
         var force = transform.position - other.transform.position;// calculate the distance between theour enemy and other how crash it 
    
         force.Normalize();// nomalisation 
         other.gameObject.GetComponent<Rigidbody>().AddForce(-force * Random.Range(crashpeed,crashpeed+200));// move oway how crash our specific enemy far opposit dirction

		 }
		 
		
	}
	IEnumerator delaicrash()//wait to end the crash 
    {  
		 yield return new WaitForSeconds(0.5f);
	     crash=false;// desable the crash bool 
	}
   public Vector3 right(){
      return rightTrans.localPosition;
    }public Vector3 left(){
      return leftTrans.localPosition;
    }
    void stop(){
      rb.velocity=Vector3.zero;
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.CompareTag("DeadArea")){
           if(!dead){
            dead=true;
            print("Enemy Dead");
            upgradeEnemyForce();
            GameManager.instance.endRound(false);
            Destroy(this.gameObject,1f);
           }
            
        }
    }
    private void upgradeEnemyForce(){
        float currentForce=PlayerPrefs.GetFloat("EnemyCrashForceUpdate");
        currentForce+=5f;
        PlayerPrefs.SetFloat("EnemyCrashForceUpdate",currentForce);

    }
    public void setWings(ref Transform rightWing,ref Transform leftWing){
        rightTrans=rightWing;
        leftTrans=leftWing;

    }
    public void upgradePower(ennemyPowerManager newPower){
        this.crashpeed+=newPower.crashSpeed;
        this.forwardSpeed+=newPower.forwardSpeed;
        this.rb.drag+=newPower.dragForce;

    }
   
}
