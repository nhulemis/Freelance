﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcBoxObstaclesController : MonoBehaviour
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
    	NpcController.instance.elastickBack(other.gameObject.transform.position.z);
    }
}
