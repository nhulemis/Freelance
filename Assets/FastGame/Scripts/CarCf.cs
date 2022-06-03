using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCf : MonoBehaviour
{
    [SerializeField] float speed=1;
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+=transform.forward*Time.deltaTime*speed;
    }
    void OnTriggerEnter(Collider other){
    	if(other.gameObject.tag=="Respawn"){
    		//TrafficSystemController.instance.arrivedToStart();
    		TrafficSystemController.instance.respawn(other.gameObject.transform);
               Destroy(this.gameObject);
    		}
    }
}
