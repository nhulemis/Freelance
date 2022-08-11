using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonZfix : MonoBehaviour
{
	private float sc;
	private float startSc;
	private int step;
	
	public float scale;
	public float speed;
	
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
	public class Awcbhse
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
	public class Ojkxcioaw
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
	public class Taxcawxcz
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
	public class OIucvjklaw
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
	public class KJhcuiawjk
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
	void Start ()
	{
		sc = transform.localScale.x;
		startSc = sc;

		if (speed == 0) speed = 0.3f;
		if (scale == 0) scale = 1.2f;

		step = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (step == 0)
		{
			sc += Time.deltaTime * speed;
			transform.localScale = new Vector3(sc,sc,1);

			if (sc > startSc * scale) step = 1;
		}
		else
		{
			sc -= Time.deltaTime * speed;
			transform.localScale = new Vector3(sc,sc,1);
			
			if (sc < startSc) step = 0;
		}
		
	}
}
