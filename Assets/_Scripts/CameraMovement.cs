﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    //public float minZ;
    

    
    
    private GameObject hero;
    
    private float view;
    //private bool doview;
    //private int correct;
    void Start()
    {
        hero = GameObject.Find("Hero");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
          if (hero) transform.position = Vector3.Lerp(transform.position, hero.transform.position + new Vector3(-3.8f, 60, -13.5f), Time.fixedDeltaTime*speed);

    }

}
