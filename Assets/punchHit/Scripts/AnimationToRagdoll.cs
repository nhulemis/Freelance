using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationToRagdoll : MonoBehaviour
{
	[SerializeField]Rigidbody rb;
    Rigidbody[] rigidBodies;
    bool inRagdolMode=false;
    // Start is called before the first frame update
    void Start()
    {
        rigidBodies=this.GetComponentsInChildren<Rigidbody>();
        toogleRagdoll(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toogleRagdoll(bool isAnimating){
    	inRagdolMode=!isAnimating;
    	float rbInChildLength=rigidBodies.Length;
    	if(rbInChildLength!=0){
    	if(inRagdolMode){
    	    for(int i=0;i<rbInChildLength;i++){
    				rigidBodies[i].isKinematic=inRagdolMode;
    			}
           
    		}
    		else{
    			 for(int i=0;i<rbInChildLength;i++){
    				rigidBodies[i].isKinematic=inRagdolMode;
    			}
             Invoke("reInstantiateMode",1f);
    		}
    	}



    }
    private void reInstantiateMode(){
         toogleRagdoll(false);
    }
    
}
