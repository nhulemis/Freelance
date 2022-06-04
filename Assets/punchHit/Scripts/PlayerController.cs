using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;
public class PlayerController : MonoBehaviour
{
    [Header("GamePlay Data")]
    [SerializeField] float playerSpeed=1;
    [SerializeField] float punchSpeed=1;
    [SerializeField] float maxElastics=20;
    [SerializeField] Animator anim;
    [SerializeField] Transform targetPlace;
    //small distance between the pc & npc
    public float acuracy=.1f;
    [Header("Boxer Glove")]
    //Right boxer Gloves
    [SerializeField] GameObject rightOutGlove;
    [SerializeField] GameObject rightInGlove;
    //left boxer Gloves
     [SerializeField] GameObject leftOutGlove;
    [SerializeField] GameObject leftInGlove;
    /*** Tube Gnerator Data ***/
    [Header("Elastic Tube Data")]
    //Right Component Data
    [SerializeField] SplineComputer rightSplineComp;
    [SerializeField] TubeGenerator rightTubeGeneratorObj;
    [SerializeField] SplinePositioner boxerRightHand;
     //Left Component Data
    [SerializeField] SplineComputer LeftSplineComp;
    [SerializeField] TubeGenerator leftTubeGeneratorObj;
    [SerializeField] SplinePositioner boxerLeftHand;
    
    /*** GamePlay ***/

    //Store a reference to the target Transform 
    Transform enemyTraget;
    //Hold the joystick mouvement data 
    private float verticalRotation;
    private float horizontalRotation; 
    //controll the player state
    [HideInInspector] 
    public bool inRunMoode=true;   
    bool  startExpand=false;
	[HideInInspector]
	public bool isDraging=false;
    double clipValue=0;
    bool hasReachedDestination=true;
    //Store a reference to the joystick GameObject 
    GameObject joyObj;
    //Dragging Data 
    Vector3 firstouch=Vector3.zero;
    //joystick mouvement controller 
    Joystick joyStick=null;
    //glove to punxh with
    bool rightGlovePunch;
    bool isAlive;
    float elasticsMultiplier=1.2f;
	
	/*** Script Reference ***/
    public static PlayerController instance;
   
    /*********************************************/

    void Awake(){
    	if(instance==null)instance=this;
    	else if (instance!=this)Destroy(this.gameObject); 
    }
    void Start(){
    	//Initialization
    	  enemyTraget=GameObject.FindGameObjectWithTag("Npc").gameObject.transform.GetChild(0).gameObject.transform;
        joyObj=GameObject.FindGameObjectWithTag("joystick").gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
        //Boxer Idle state On
   	    anim.SetBool("Punch",false);
    	anim.SetBool("Idle",true);
       
        //Spline Points Check #debuging purpose 
       List<Vector3> points=new List <Vector3>();
       points=LeftSplineComp.getPointsPositon();       
     for(int i=0;i<points.Count;i++){
       // print("Left Ponint "+i+" Position = "+points[i]);
     }
     //Local Position Points : 
    SplinePoint[] localPointsc=rightSplineComp.GetPointsLocal();
     for(int i=0;i<localPointsc.Length;i++){
        print("right Point "+i+" Position = "+localPointsc[i].position);
     }
      //adjustRightPointsPosition(enemyTraget.position);
     //rightSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.z,enemyTraget.position.y,enemyTraget.position.z));
     //Spine Points Check #debuging purpose 
      points=rightSplineComp.getPointsPositon();
    for(int i=0;i<points.Count;i++){
      //print("Right Ponint "+i+" Position = "+points[i]);
    }
    maxElastics=distanceToTarget()/elasticsMultiplier;

    print("the distance to target is :"+distanceToTarget());
       if(distanceToTarget()<=maxElastics){
              adjustRightPointsPosition(enemyTraget.position);
              adjustLeftPointsPosition(enemyTraget.position);
        }
            else{
                   
                    adjustRightPointsPosition(new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z-2));
                    adjustLeftPointsPosition(new Vector3(enemyTraget.position.x+1,enemyTraget.position.y,enemyTraget.position.z-2));

                  }
    isAlive=true;
      elasticTraceHide();
}

    bool canRepeat=true;

    void FixedUpdate(){
      
     
       Vector3 lookToTarget=new Vector3(enemyTraget.position.x,this.transform.position.y,enemyTraget.position.z);
       transform.LookAt(lookToTarget);
       checkForMouve();
      if(isDraging){
      	    if(clipValue>=1)
                startExpand=false;
                if(rightGlovePunch)
                rightGlovePunchChoise();
                else {
                	leftGlovePunchChoise();
                }      

    }
}
    private void rightGlovePunchChoise(){
    	
        if(startExpand && clipValue<1 && rightGlovePunch){
          
            clipValue+=(Time.deltaTime*punchSpeed);
            float temp=(float)clipValue;
            temp=Mathf.Clamp(temp,0,1f);
            clipValue=(double)temp;
            rightTubeGeneratorObj.updateClipRange(0,clipValue);
            boxerRightHand.updateClipRange(clipValue,1);
      }else if(!startExpand && clipValue>0 && rightGlovePunch){
      	    canRepeat=false;
      	    clipValue-=(Time.deltaTime*punchSpeed*2.3f);
      	    rightTubeGeneratorObj.updateClipRange(0,clipValue);
      	    boxerRightHand.updateClipRange(clipValue,1);

      }else {
          if(distanceToTarget()<=maxElastics){
                     adjustRightPointsPosition(enemyTraget.position);
          }
             else{
                                       
                    adjustRightPointsPosition(new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z-2));
                  }
             // adjustRightPointsPosition(enemyTraget.position);
      	    //rightSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z));
      	    //Return to Idle state
             elasticTraceHide(); 
      	    isDraging=false;
            rightInGlove.SetActive(true);
      	    rightOutGlove.SetActive(false);
      }
    } 
      private void leftGlovePunchChoise(){
    	
        if(startExpand && clipValue<1 ){

            clipValue+=(Time.deltaTime*punchSpeed);
            float temp=(float)clipValue;
            temp=Mathf.Clamp(temp,0,1f);
            clipValue=(double)temp;
            leftTubeGeneratorObj.updateClipRange(0,clipValue);
            boxerLeftHand.updateClipRange(clipValue,1);
      }else if(!startExpand && clipValue>0 ){
      	    canRepeat=false;
      	    clipValue-=(Time.deltaTime*punchSpeed*2.3f);
      	    leftTubeGeneratorObj.updateClipRange(0,clipValue);
      	    boxerLeftHand.updateClipRange(clipValue,1);

      }else {

             if(distanceToTarget()<=maxElastics){
                    adjustLeftPointsPosition(enemyTraget.position);
            }                 
             else{
                   
                    adjustLeftPointsPosition(new Vector3(enemyTraget.position.x+1,enemyTraget.position.y,enemyTraget.position.z-2));
                  }

            //adjustLeftPointsPosition(enemyTraget.position);
      	    //rightSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z));
      	    //Return to Idle state 
                  elasticTraceHide();
      	    isDraging=false;
            leftInGlove.SetActive(true);
      	    leftOutGlove.SetActive(false);
      }
    }
    private void rightPunchAnimate(){
        //Start Punch
        anim.SetBool("Punch",true);
        anim.SetBool("Idle",false);    	
    	Invoke("rightDePunch",.2f);
}
 private void leftPunchAnimate(){
        //Start Punch
        anim.SetBool("Left_Punch",true);
        anim.SetBool("Idle",false);    	
    	Invoke("LeftDePunch",.2f);
}
    private void rightDePunch(){
    	anim.SetBool("Punch",false);
}
 private void LeftDePunch(){
 	
    	anim.SetBool("Left_Punch",false);
}
	 void checkForMouve(){
	 	 movePlayer();
	 	//check the joystick state
	 	if(horizontalRotation==0 && verticalRotation==0 && isAlive){
	 	if(Input.GetMouseButtonDown(0)){
	 		 firstouch=new Vector3(Input.mousePosition.x,Input.mousePosition.y,0);
	 		 startExpand=false;
	 		 //Check if the Glove Reach the Destination 	 		
	 		if(hasReachedDestination){
	 			hasReachedDestination=false;
	 		}
	 	}
	 	else if(Input.GetMouseButton(0)){
	 		Vector3 currentTouch=new Vector3(Input.mousePosition.x,Input.mousePosition.y,0);
	 		float distance=Vector3.Distance(currentTouch,firstouch);
	 		//#Debuging Purpose
	 		print("First Touch : "+firstouch);
	 		print("current Touch : "+currentTouch);	 		
	 		print("the distance between both touches : "+distance);
	 		if(distance>45){
	 			elasticTraceEnable();
	 			if(currentTouch.x<Screen.width/2 )
	 			rightGlovePunch=false;
	 			else 
	 			 rightGlovePunch=true;
	 			 
	 			 startExpand=true;
              	 
              	if(rightGlovePunch){
              		rightPunchAnimate();
            if(distanceToTarget()<=maxElastics){
                    adjustRightPointsPosition(enemyTraget.position);
            }                 
             else{
                   
                    adjustRightPointsPosition(new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z-2));
                  }
              		//rightSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z));
	 			        
                  leftOutGlove.SetActive(false);
              		rightInGlove.SetActive(false);
	 			          rightOutGlove.SetActive(true);
                 
              	}else{

              		leftPunchAnimate();
             if(distanceToTarget()<=maxElastics){
                    adjustLeftPointsPosition(enemyTraget.position);
            }                 
             else{
                   
                    adjustLeftPointsPosition(new Vector3(enemyTraget.position.x+1,enemyTraget.position.y,enemyTraget.position.z-2));
                  }

                 // adjustLeftPointsPosition(enemyTraget.position);
              		//LeftSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z));
              	
                  rightOutGlove.SetActive(false);
              		leftInGlove.SetActive(false);
	 			          leftOutGlove.SetActive(true);
              	}
	 			
	 		    isDraging=true;               
	 		}
	 			firstouch=currentTouch;
	 			      
	    }
	 		
	    else if(Input.GetMouseButtonUp(0)){

	 	     firstouch=Vector3.zero;	 		
	 	}
	}
}

    private void movePlayer(){
        //assign rotation data comming from joystick
    	verticalRotation=joyObj.GetComponent<FixedJoystick>().Vertical;
    	horizontalRotation=joyObj.GetComponent<FixedJoystick>().Horizontal;
    	//check the distance between the player and the npc
    	if(Vector3.Distance(this.transform.position,enemyTraget.position)>acuracy && isAlive)
    	transform.position+=(transform.forward*verticalRotation+transform.right*horizontalRotation) *Time.deltaTime*playerSpeed;
    	//Debuging Purpose
  	    print("Vertical Value"+verticalRotation+"horizontal Value"+horizontalRotation);
  	    if(isAlive){
  	    	if(verticalRotation==0 && horizontalRotation==0){
    		if(!isDraging && isAlive)
    		anim.SetBool("Idle",true);
    	  anim.SetBool("Left_Run",false);
          anim.SetBool("Right_Run",false);
          anim.SetBool("Run_Backwards",false);
          anim.SetBool("Run_Forward",false);
    	}
         if(verticalRotation>0 && verticalRotation>horizontalRotation && (horizontalRotation>=0|| Mathf.Abs(horizontalRotation)<verticalRotation)){
    		inRunMoode=true;
          anim.SetBool("Idle",false);
          anim.SetBool("Left_Run",false);
          anim.SetBool("Right_Run",false);
          anim.SetBool("Run_Backwards",false);
          anim.SetBool("Run_Forward",true);

    	}else if(verticalRotation<0 && verticalRotation<horizontalRotation && (horizontalRotation<=0 || Mathf.Abs(verticalRotation)>horizontalRotation) ){
    		inRunMoode=true;
    	  anim.SetBool("Idle",false);
          anim.SetBool("Run_Forward",false);
          anim.SetBool("Left_Run",false);
          anim.SetBool("Right_Run",false);
          anim.SetBool("Run_Backwards",true);

    	}
    	else if(horizontalRotation>0 ){
    		inRunMoode=true;
    	  anim.SetBool("Idle",false);
          anim.SetBool("Run_Forward",false);
          anim.SetBool("Left_Run",false);
          anim.SetBool("Run_Backwards",false);
          anim.SetBool("Right_Run",true);
          

    	}
    	else if(horizontalRotation<0){
    		inRunMoode=true;
    	  anim.SetBool("Idle",false);
          anim.SetBool("Run_Forward",false);        
          anim.SetBool("Run_Backwards",false);
          anim.SetBool("Right_Run",false);
          anim.SetBool("Left_Run",true);
        }

  	    }
    	
}
    public void animateOff(){
    	   anim.SetBool("Idle",false);
           anim.SetBool("Run_Forward",false);        
           anim.SetBool("Run_Backwards",false);
           anim.SetBool("Right_Run",false);
           anim.SetBool("Left_Run",false);
    	   anim.SetBool("Fall_Back",true);
           
           isAlive=false;
    	//anim.enabled=false;
    } public void animateOn(){
    	anim.enabled=true;
    }
    public void elastickBack(float zPoint){
    	   startExpand=false;
         Vector3 newTragetPosClamp=new Vector3(enemyTraget.position.x,enemyTraget.position.y,zPoint);
         rightSplineComp.SetPointPosition(2,newTragetPosClamp);
         LeftSplineComp.SetPointPosition(2,newTragetPosClamp);
         adjustLeftPointsPosition(newTragetPosClamp);
         adjustRightPointsPosition(newTragetPosClamp);
    }
      public void pcLoose(){
      elasticTraceHide();
      
      //boxerRightHand.removeTrace();
      //boxerLeftHand.removeTrace();
    }
    public void retry(){
    	 isAlive=true;


    	 anim.SetBool("Fall_Back",false);
    	 anim.SetBool("Idle",true);
    	 Invoke("elasticTraceEnable",1f);
    	    	 

    }
    private void elasticTraceEnable(){
         leftTubeGeneratorObj.show();
         rightTubeGeneratorObj.show();
    }
     private void elasticTraceHide(){
         leftTubeGeneratorObj.hide();
        rightTubeGeneratorObj.hide();
    }
    private void adjustRightPointsPosition(Vector3 targetPosRightSide){
            List<Vector3> points=new List <Vector3>();
            rightSplineComp.SetPointPosition(2,new Vector3(targetPosRightSide.x,targetPosRightSide.y,targetPosRightSide.z));
            points=rightSplineComp.getPointsPositon();
            float splinePoint1=points[0].z;
            float splinePoint3=points[2].z;
            float splinePoint2=(splinePoint3+splinePoint1)/2;
            rightSplineComp.SetPointPosition(1,new Vector3(points[1].x ,targetPosRightSide.y,splinePoint2));

    }
    private void adjustLeftPointsPosition(Vector3 targetPosLeftSide){
            List<Vector3> points=new List <Vector3>();
            LeftSplineComp.SetPointPosition(2,new Vector3(targetPosLeftSide.x,targetPosLeftSide.y,targetPosLeftSide.z));
            points=LeftSplineComp.getPointsPositon();
            float splinePoint1=points[0].z;
            float splinePoint3=points[2].z;
            float splinePoint2=(splinePoint3+splinePoint1)/2;
            LeftSplineComp.SetPointPosition(1,new Vector3(points[1].x,targetPosLeftSide.y,splinePoint2));

    }
    private float distanceToTarget(){
        return Vector3.Distance(this.transform.position,enemyTraget.position);
    }
    public void addElastics(float i){
      elasticsMultiplier=i;
    }
    public Transform getTarget(){
      return targetPlace;
    }
}
