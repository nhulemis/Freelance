﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Error : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  class ABCu
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class ABCulkjasd
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class ABCulkjasdoijzxlkc
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }

  class ABCulkjasdoijzxlkcozuxjkca
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class jkzcvjkai
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class jkzcvjkailjzxjklckjla
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class jkzcvjkaiopizxckla
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
	private void OnTriggerEnter(Collider other)
	{
		Ball ball = other.GetComponent<Ball>();
		if(ball != null)
		{
			LevelController.instance.GameOver();
			ball.transform.position = new Vector3(ball.transform.position.x, transform.position.y + 0.5f, ball.transform.position.z);
			ball.GameOver();
		}

		
	}
}
