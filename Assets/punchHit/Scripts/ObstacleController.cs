using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class ObstacleController : MonoBehaviour
{
	Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other){
    	if(other.gameObject.tag=="Box"){
    		CameraShaker.Instance.ShakeOnce(2,.3f,.1f,1f);
          float otherDirection=other.gameObject.transform.position.z;
          float zDirection=otherDirection-this.transform.position.z;
          rb.AddForce(0,100,-zDirection*300);


    	   
    	}
    }
}
