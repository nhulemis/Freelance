using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform target;
    [SerializeField]
    GameObject speedEffect;
    Vector3 offset;
    Vector3 lastpos;
    public static CameraController instance;
    void Awake(){
    	if(instance==null)instance=this;
    	else if(instance!=this)Destroy(this.gameObject);
          target=null;
    }
   // Start is called before the first frame update
    void Start()
    {
       
      
       
    }

    // Update is called once per frame
    void Update()
    {
        if(target!=null){
                Vector3 newPos=new Vector3(this.transform.position.x,target.position.y-offset.y,target.position.z-offset.z);
                this.transform.position=Vector3.MoveTowards(this.transform.position,Vector3.Lerp(this.transform.position,newPos,1f),1f); 
            }
    	
    	//this.transform.position=Vector3.Lerp(this.transform.position,Vector3.MoveTowards(this.transform.position,newPos,.7f),.7f); 
        
    }
    public void upgradeOffset(){
    	offset+=new Vector3(0,-4,2);
    }
    public void enableSpeedEffect(){
        speedEffect.SetActive(true);


    }
    public void disableSpeedEffect(){
        speedEffect.SetActive(false);
    }
    public void assignTraget(){
       // int cuurentSelectedCharacter=PlayerPrefs.GetInt("SelectedCharactere");
       // target=characterSelector.GetChild(cuurentSelectedCharacter);

    }
     public void assign(Transform target){
        
        this.target=target;
        offset=this.target.position-this.transform.position;
         offset.x=0;

    }
}
