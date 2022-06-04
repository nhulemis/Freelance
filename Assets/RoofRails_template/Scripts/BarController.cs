using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    public static BarController instance;
    private Rigidbody rb;
   
    private void Awake(){
    	if(instance==null){
            instance=this;
    	}else if(instance!=this){
    	    Destroy(this.gameObject);
    	}
    }
    // Start is called before the first frame update
    void Start()
    {
         RightChildController.instance.addChild(20);   
         LeftChildController.instance.addChild(20); 
         rb=this.GetComponent<Rigidbody>();
          
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addChild(){
    	
            /* RightChildController.instance.addChild(newChild);     		
    		 LeftChildController.instance.addChild(newChild);*/
    		  
    		 RightChildController.instance.addChild();     		
    		 LeftChildController.instance.addChild();  
    }
    public void startBalancingChildes(){
    	
        Invoke("BalenceChildes",1f);

    }
    private void BalenceChildes(){
    	int leftChild=LeftChildController.instance.getTotalChildNum();;
    	int rightChild=RightChildController.instance.getTotalChildNum();
    	int totalChilds=leftChild+rightChild;
    	int midle=(totalChilds/2);
        if(leftChild==midle && rightChild==midle){
            print("Childs are balenceed Yeaaaaaaaaaaaahh");
        }else{
            print("Childs Are Not Balenced nooooooooo");
            if(rightChild<midle){
            int toAddChild=midle-rightChild;
            RightChildController.instance.addChild(toAddChild);
        }else if(rightChild>midle){
            int temp=rightChild-midle;
            RightChildController.instance.deleteChild((rightChild-temp));

        }if(leftChild<midle){
            
            int toAddChild=midle-leftChild;
            LeftChildController.instance.addChild(toAddChild);
        }else if(leftChild>midle){
            int temp=leftChild-midle;
            LeftChildController.instance.deleteChild((leftChild-temp));

        }

        }
    	

    }
    public void stop(){
        this.GetComponent<Rigidbody>().velocity=Vector3.zero;
         this.GetComponent<Rigidbody>().isKinematic=true;
    }
    public void freeRotation(){
         // rb.constraints = RigidbodyConstraints.None;
          // rb.constraints = RigidbodyConstraints.FreezePositionZ |RigidbodyConstraints.FreezePositionX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;
          

    }
     public void lockRotation(){
         // rb.constraints = RigidbodyConstraints.FreezeRotation;         ;

    }
}
