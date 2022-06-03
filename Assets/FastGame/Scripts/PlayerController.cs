using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Settings
    [Header("Settings")]
    [SerializeField]Rigidbody sphereRb;
    [SerializeField]Transform sphereTrans;
    [SerializeField]Transform steeringWheel;
    [SerializeField]Transform kartNormal;
    [SerializeField]float speed=1;
    [SerializeField]float rotationSmoothness=.2f;
    [SerializeField] Transform car;
    [SerializeField] Transform carDir;
     [SerializeField] GameObject[] carComponents;
     [SerializeField] GameObject carBed;
    /*****************/
     float y_offset=-1;
     /***********************/
    //Audio
    [Header("Audio")]
    [SerializeField]AudioSource demarage;
    [SerializeField]AudioSource inRoad;
    [SerializeField]AudioSource finishSound;
    /******************************/
    [Header("Effects")]
     [SerializeField] GameObject wheel1Trail;
     [SerializeField] GameObject wheel2Trail;
      [SerializeField] GameObject smookeEffect;

    /***********************/
    private Vector3 finishPos;
    private float distanceToFinish=1;
    /***********************/
    //Mouvement 
    Vector3 firstPos;
    Vector3 currentPos;
    float rotation;
    bool isDraging=false;
    bool steeringWheelOriginback=false;
    /***********************/
    //Manager
     public enum gameState {play,stop};
     public gameState pState;
     public static PlayerController instance;
     /***********************/
    void Awake(){
        if(instance==null)instance=this;
        else if(instance!=this)Destroy(this.gameObject);
     }
   
    // Start is called before the first frame update
    void Start()
    {
        demarage.Play();
        Invoke("inRoadSounds",.018f);
        finishPos=GameObject.FindGameObjectWithTag("Finish").gameObject.transform.position;
        print(finishPos.x+"+"+finishPos.y+"+"+finishPos.z);
        distanceToFinish=(finishPos-sphereRb.transform.position).magnitude;
        
    }

    // Update is called once per frame
    void Update()
    {
       if(pState==gameState.play){
        car.position=sphereTrans.position+new Vector3(0,y_offset,0);
        //sphereTrans.position+new Vector3(0,-1.2f,0)
        if(Input.GetMouseButtonDown(0)){
        	Vector2 mPos=Input.mousePosition;
          //firstPos=Camera.main.ScreenToWorldPoint(new Vector3(mPos.x,mPos.y,10));
        	firstPos=mPos;

        }if(Input.GetMouseButton(0)){
        	isDraging=true;
        	Vector2 mPos=Input.mousePosition;
        	//currentPos=Camera.main.ScreenToWorldPoint(new Vector3(mPos.x,mPos.y,10));
        	currentPos=mPos;
        	rotation=currentPos.x-firstPos.x;
            steeringWheelOriginback=false;

              
        	//Debug.Log("Current Rotation is "+ rotation);
        	startRotation();

        }if(Input.GetMouseButtonUp(0)){
        	isDraging=false;
        	rotation=0;
            steeringWheelOriginback=true;
        }
         steeringWheel.localEulerAngles = new Vector3(-12, 90,rotation*.5f);
            }
    }
    void FixedUpdate(){
       
        if(pState==gameState.play){
    	sphereRb.AddForce(-car.transform.right*speed,ForceMode.Acceleration);
    	  sphereRb.AddForce(Vector3.down *100f, ForceMode.Acceleration);
    	 
       RaycastHit hitOn;
        RaycastHit hitNear;
        Physics.Raycast(car.position + (car.up*.1f), Vector3.down, out hitOn, .5f);
        Physics.Raycast(car.position + (car.up*.1f )   , Vector3.down, out hitNear, 5f);
      Debug.DrawLine(car.position+ (car.up*.1f ),hitNear.point,Color.yellow);
        //Normal Rotation
      kartNormal.up = Vector3.Lerp(kartNormal.up, hitNear.normal, Time.deltaTime * 8.0f);
       kartNormal.Rotate(0, transform.eulerAngles.y, 0);
       updateSlider();
      }

       
       
       
    }
    private void startRotation(){

        Vector3 newRotation= new Vector3(0,car.localEulerAngles.y+rotation*Time.deltaTime,car.localEulerAngles.z);
    	car.localEulerAngles=Vector3.Lerp(car.localEulerAngles,newRotation,rotationSmoothness);     
    }
    public void stopMoving(){
        pState=gameState.stop;

      
     }
     public void reset(){
          y_offset=-1.5f;
     }
     public void disassembleCar(){
        int length=carComponents.Length;
         for(int i=0;i<length;i++){
             carComponents[i].GetComponent<MeshCollider>().enabled=true;
            carComponents[i].GetComponent<Rigidbody>().useGravity=true;
        }
        smookeEffect.SetActive(true);
        Destroy(carBed);
     }
    public void startMoving(){

        pState=gameState.play;

    }
    private void updateSlider(){
        float distance=((sphereRb.transform.position).magnitude/distanceToFinish);
        UiManager.instance.mouveSlider(distance);
    }
    public void inRoadSounds(){
           inRoad.Play();
    } public void inRoadSoundsR(){
           inRoad.Stop();
    }
    public void finishSoundsA(){
        finishSound.Play();
    }
    public void jump(){
        wheel1Trail.SetActive(false);
        wheel2Trail.SetActive(false);

        Time.timeScale=.4f;
        sphereRb.AddForce(((Vector3.up*speed*20))+(-car.transform.right*speed*25),ForceMode.Acceleration);
        Invoke("returnBackNormalState",.8f);

    }
    void returnBackNormalState(){
 
        Time.timeScale=1f;
        wheel1Trail.SetActive(true);
        wheel2Trail.SetActive(true);
    }
}
