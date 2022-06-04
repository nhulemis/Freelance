using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using   Dreamteck.Splines;
public class NpcController : MonoBehaviour
{
   
    [Header("GamePlay Data")]
    [SerializeField] float playerSpeed=1;
    [SerializeField] float punchSpeed=1;
    [SerializeField] Animator anim;
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
    bool isAlive=true;
    bool shootnow=true;
    bool changeTarget=true;
    bool moveNpc;
    float x,y=0;
    public bool inPlayMode=false;
  
  /*** Script Reference ***/
    public static NpcController instance;
   
    /*********************************************/

    void Awake(){
      if(instance==null)instance=this;
      else if (instance!=this)Destroy(this.gameObject); 
    }
    void Start(){
      //Initialization
    //  enemyTraget=GameObject.FindGameObjectWithTag("Player").gameObject.transform.GetChild(5).gameObject.transform;
      enemyTraget=PlayerController.instance.getTarget();
      
        joyObj=GameObject.FindGameObjectWithTag("joystick").gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
        //Boxer Idle state On
        anim.SetBool("Punch",false);
      anim.SetBool("Idle",true);
       
        //Spline Points Check #debuging purpose 
       List<Vector3> points=new List <Vector3>();
       points=rightSplineComp.getPointsPositon();       
     for(int i=0;i<points.Count;i++){
        print("Ponint "+i+" Position = "+points[i]);
     }
     rightSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.z,enemyTraget.position.y,enemyTraget.position.z));
     //Spine Points Check #debuging purpose 
      points=rightSplineComp.getPointsPositon();
    for(int i=0;i<points.Count;i++){
      print("Ponint "+i+" Position = "+points[i]);
    }
    StartCoroutine("TrackTarget",3f);

}

private IEnumerator TrackTarget(){
  if(inPlayMode){
         changeTarget=false;
         Vector3 npcPos=this.transform.position;
         Vector3 pos=enemyTraget.position;
         float waitTime=Random.Range(1f,5f);
         //Track The Player Location
         // rightSplineComp.SetPointPosition(2,new Vector3(pos.x,pos.y,pos.z));
        // LeftSplineComp.SetPointPosition(2,new Vector3(pos.x,pos.y,pos.z));
         //In Mouve State 
          if(waitTime>=3 && waitTime<=4){
           doMove();
          }
         yield return new WaitForSeconds(waitTime);
         if(pos.x>npcPos.x){
          rightGlovePunch=true;
           List<Vector3> points=new List <Vector3>();
         /// rightSplineComp.SetPointPosition(1,new Vector3(pos.x,pos.y,middlez/));
           rightSplineComp.SetPointPosition(2,new Vector3(pos.x,pos.y,pos.z));
           points=rightSplineComp.getPointsPositon();
           float splinePoint1=points[0].z;
           float splinePoint3=points[2].z;
           float splinePoint2=(splinePoint3+splinePoint1)/2;
           rightSplineComp.SetPointPosition(1,new Vector3(points[1].x ,pos.y,splinePoint2));
         }
        
         else {
          rightGlovePunch=false;
            List<Vector3> points=new List <Vector3>();
            LeftSplineComp.SetPointPosition(2,new Vector3(pos.x,pos.y,pos.z));
            points=LeftSplineComp.getPointsPositon();
            float splinePoint1=points[0].z;
            float splinePoint3=points[2].z;
            float splinePoint2=(splinePoint3+splinePoint1)/2;
            LeftSplineComp.SetPointPosition(1,new Vector3(points[1].x ,pos.y,splinePoint2));
         }
         
         moveNpc=false;
         //In Punch State 
         changeTarget=true;
         shootnow=true;
  }
         
         
}
private void doMove(){
  moveNpc=true;
   x=Random.Range(-1f,1.1f);
   y=Random.Range(-1f,1.1f);

 
}

    bool canRepeat=true;

    void FixedUpdate(){
      
     
       if(inPlayMode){
          Vector3 lookToTarget=new Vector3(enemyTraget.position.x,this.transform.position.y,enemyTraget.position.z);
       if(!changeTarget)
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

    }if(!startExpand &&  clipValue<=0 && changeTarget){
      changeTarget=false;
      if(inPlayMode)
          punch();
    }

       }
     
    
}
    private void rightGlovePunchChoise(){
        
           if(startExpand && clipValue<1 && rightGlovePunch){
          changeTarget=false;
            clipValue+=(Time.deltaTime*punchSpeed);
            float temp=(float)clipValue;
            temp=Mathf.Clamp(temp,0,1f);
            clipValue=(double)temp;
            rightTubeGeneratorObj.updateClipRange(0,clipValue);
            boxerRightHand.updateClipRange(clipValue,1);
      }else if(!startExpand && clipValue>0 && rightGlovePunch){
        changeTarget=false;
            canRepeat=false;
            clipValue-=(Time.deltaTime*punchSpeed*2.3f);
            rightTubeGeneratorObj.updateClipRange(0,clipValue);
            boxerRightHand.updateClipRange(clipValue,1);

      }else {
            //rightSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z));
            //Return to Idle state
               if(!startExpand && clipValue<=0 && shootnow){

               StartCoroutine("TrackTarget",0f);
               shootnow=false;
              }
            
            isDraging=false;
            rightInGlove.SetActive(true);
            rightOutGlove.SetActive(false);
      }
         
       
    } 
      private void leftGlovePunchChoise(){
        
           if(startExpand && clipValue<1 ){
          changeTarget=false;
            clipValue+=(Time.deltaTime*punchSpeed);
            float temp=(float)clipValue;
            temp=Mathf.Clamp(temp,0,1f);
            clipValue=(double)temp;
            leftTubeGeneratorObj.updateClipRange(0,clipValue);
            boxerLeftHand.updateClipRange(clipValue,1);
      }else if(!startExpand && clipValue>0 ){
        changeTarget=false;
            canRepeat=false;
            clipValue-=(Time.deltaTime*punchSpeed*2.3f);
            leftTubeGeneratorObj.updateClipRange(0,clipValue);
            boxerLeftHand.updateClipRange(clipValue,1);

      }else {
           // LeftSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z));
            //Return to Idle state
              if(!startExpand && clipValue<=0 && shootnow){

               StartCoroutine("TrackTarget",0f);
               shootnow=false;
              }
            
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
    if(moveNpc)
      movePlayer(x,y);
      else 
      movePlayer(0,0);
    //Possible state (mouveNpc - punch the player , back Flip Animation)
  
}
    private void punch(){
     
    
         
         startExpand=true;
                 
                if(rightGlovePunch ){
                  rightPunchAnimate();
                  //rightSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z));
                  
            leftOutGlove.SetActive(false);
                  rightInGlove.SetActive(false);
            rightOutGlove.SetActive(true);
                 
                }else{
                   
                  leftPunchAnimate();
                 // LeftSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.x,enemyTraget.position.y,enemyTraget.position.z));
                  
                  rightOutGlove.SetActive(false);
                  leftInGlove.SetActive(false);
                  leftOutGlove.SetActive(true);

                }
        
          isDraging=true;               
      

    }
    private void movePlayer(float x , float z){
        //assign rotation data comming from joystick
      verticalRotation=z;
      horizontalRotation=x;
      //check the distance between the player and the npc
      if(Vector3.Distance(this.transform.position,enemyTraget.position)>acuracy && isAlive)
      transform.position+=(transform.forward*verticalRotation+transform.right*horizontalRotation) *Time.deltaTime*playerSpeed;
      //Debuging Purpose
        print("Vertical Value"+verticalRotation+"horizontal Value"+horizontalRotation);
       
            if(isAlive){
               if(verticalRotation==0 && horizontalRotation==0){
        if(!isDraging)
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
     public void animationOff(){
       npcDie();
           anim.SetBool("Fall_Back",true);
           anim.SetBool("Idle",false);
           anim.SetBool("Run_Forward",false);        
           anim.SetBool("Run_Backwards",false);
           anim.SetBool("Right_Run",false);
           anim.SetBool("Left_Run",false);
         
         
      
}
     public void npcDie(){
      
     	isAlive=false;
}
 public void elastickBack(float zPoint){
      startExpand=false;
        rightSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.x,enemyTraget.position.y,zPoint));
        // LeftSplineComp.SetPointPosition(2,new Vector3(enemyTraget.position.x,enemyTraget.position.y,zPoint));
    }
    public void isPlaying(bool state){
      inPlayMode=state;
    }
    public void npcLoose(){
      leftTubeGeneratorObj.hide();
      rightTubeGeneratorObj.hide();
      boxerRightHand.removeTrace();
      boxerLeftHand.removeTrace();
      anim.SetBool("Fall_Back",true);
    }
    public void headHit(){
           isAlive=false;
           anim.SetBool("Head_Hit",true);
           
           Invoke("returnToIdleState",1.5f);
    }
    private void returnToIdleState(){
          isAlive=true;
       anim.SetBool("Head_Hit",false);
       anim.SetBool("Idle",true);
     
    }
    public bool isNpcAlive(){
      return isAlive;

    }
    
}
