using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRailParticleController : MonoBehaviour
{
   public static LeftRailParticleController instance;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void place(Vector3 newplace){
    	this.transform.GetChild(0).gameObject.SetActive(true);
    	newplace-=new Vector3(0,.6f,0);
    	this.transform.position=newplace;
    }
    public void disable(){
    	this.transform.GetChild(0).gameObject.SetActive(false);
    	
    }
}
