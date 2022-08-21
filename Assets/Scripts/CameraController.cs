using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;
    public Transform target;
    public Transform idle;
    public float smoothnes;
    public bool focus;
    public bool gooidle;
    private Vector3 offset;
    private CameraShaker camShaker;
    void Awake(){
    	if(instance==null)
    	instance=this;
    	else if(instance!=this)
    	Destroy(this.gameObject);
    }  

      // Start is called before the first frame update
    void Start()
    {
       // offset=target.position-this.transform.position;
        offset=Vector3.zero;
         camShaker=this.GetComponent<CameraShaker>();
    }

    // Update is called once per frame
    void Update()
    {

        if(focus && Vector3.Distance (this.transform.position,target.position)>10){
        	this.transform.LookAt(target);
        	this.transform.position=Vector3.Lerp(this.transform.position,target.position,smoothnes);
        }else if(gooidle){
            transform.eulerAngles=idle.eulerAngles;
            //this.transform.LookAt(-idle.position);
            this.transform.position=Vector3.Lerp(this.transform.position,idle.position,smoothnes);
        }
    }
    public void enableShaker(){
        camShaker.enabled=true;

    }public void disableShaker(){
        camShaker.enabled=false;

    }

}
