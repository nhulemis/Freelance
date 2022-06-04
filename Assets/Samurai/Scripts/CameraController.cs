using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public bool rotate;
    private bool stop=false;
    public static CameraController instance;
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
        offset=target.position-this.transform.position;
        offset=-offset;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!rotate ){
            if(!stop){
                Vector3 newPos=target.position+offset;
            this.transform.position=Vector3.Slerp(transform.position,newPos,.5f);
            }
           
        }else {
           transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);

        }
    	
    }
    public void startRotating(){
        rotate=true;
    }
    public void stopFollowing(){
        stop=true;
    }

}
