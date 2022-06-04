using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterBoxController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay(Collision other){
    	if(other.gameObject.tag=="Obstacles")
    	PlayerController.instance.elastickBack(other.gameObject.transform.position.z);
    }
}
