using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightChildController : MonoBehaviour
{
    public static RightChildController instance;
    [SerializeField]
     GameObject obj;
    private Vector3 offse;
    private Vector3 currentPo=Vector3.zero;
    void Awake(){
    	if(instance==null){
            instance=this;
    	}else if(instance!=this){
    	    Destroy(this.gameObject);
    	}
        offse=new Vector3(.25f,0,0);
    }
    void Start(){
    	offse=new Vector3(.25f,0,0);
    	currentPo=Vector3.zero;
    }
   /* public void addChild( GameObject newChild){
        newChild.transform.parent=this.transform;
    	newChild.transform.localPosition=currentPos;
    	currentPos+=offset;
    }*/
    public void addChild(int num=2){
        print("making Right Childs");
        Vector3 c=Vector3.zero;
        if(getTotalChildNum()>0){
          c=this.transform.GetChild(getTotalChildNum()-1).localPosition;
        }
        
        for(int i=0;i<num;i++){
        	GameObject newChild=Instantiate(obj,Vector3.zero,Quaternion.Euler(90,0,90),this.transform);
        	newChild.GetComponent<ChildController>().initialize(this.transform.childCount+1,true);
           newChild.transform.localPosition=c;
           //some problem happens when adding child from the level start related to the script execution order
    	   c+=new Vector3(.25f,0,0);
        }
        print("Right Childs Current pos : "+currentPo);
    	//BarController.instance.startBalancingChildes();
    }
    public void deleteChild(int start){
    	int end=transform.childCount;
        for(int i=start;i<end;i++){
            

              //this.transform.GetChild(i).transform.parent=null;
             Destroy(this.transform.GetChild(i).gameObject);
            
             
        }
         BarController.instance.startBalancingChildes();
       
    	//BarController.instance.startBalancingChildes();
    }
     
    public void removeChild(int start){
        int end=transform.childCount;
        for(int i=start;i<end;i++){
            this.transform.GetChild(i).parent=null;
            Destroy(this.transform.GetChild(i).gameObject,3f);
            currentPo-=new Vector3(.25f,0,0);
        }
        BarController.instance.startBalancingChildes();
    }
    public int getTotalChildNum(){
    	return this.transform.childCount;
    }
}
