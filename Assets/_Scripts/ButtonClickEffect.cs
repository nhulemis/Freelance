﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickEffect : MonoBehaviour {
	float timer;
	float speed;
	
	float start_x;
	int step;
	
	public class ProductItem
	{
		public string id;
		public Sprite icon;
		public string price;
		public string title;

		public void Acoakwos()
		{
			id = price + title;
		}
	}
	public class Akjhcuiaw
	{
		public string id;
		public Sprite icon;
		public string price;
		public string title;

		public void Acoakwos()
		{
			id = price + title;
		}
	}
	public class Acawasczx
	{
		public string id;
		public Sprite icon;
		public string price;
		public string title;

		public void Acoakwos()
		{
			id = price + title;
		}
	}

	// Use this for initialization
	void Start () {
		
		start_x = transform.localScale.x;
		transform.localScale = new Vector3(transform.localScale.x * 0.8f, transform.localScale.y *0.8f, transform.localScale.z * 0.8f);
		speed = start_x * 1.5f;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		float sc = transform.localScale.x;
		timer += Time.deltaTime;


		if (step == 0){
			transform.localScale = new Vector3(sc+Time.deltaTime*speed, sc+Time.deltaTime*speed, sc+Time.deltaTime*speed);
			if (transform.localScale.x > start_x*1.1f){
				transform.localScale = new Vector3(start_x*1.1f,start_x*1.1f,start_x*1.1f);
				step = 1;
			}
		}else{
			transform.localScale = new Vector3(sc-Time.deltaTime*speed, sc-Time.deltaTime*speed, sc-Time.deltaTime*speed);
			if (transform.localScale.x < start_x){
				transform.localScale = new Vector3(start_x,start_x,start_x);
				Destroy(this);
			}
		}

	}
}
