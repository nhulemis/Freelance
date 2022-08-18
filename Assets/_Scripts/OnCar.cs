using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCar : MonoBehaviour
{
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
    public float speed;

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
    public bool carCrash;

 
        public class NCEENQXLWWQ
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class CVFASTOBTPYJDFOCI
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class RSCTHGDSCSIRXELEKJUZLXXCZIGXMVK
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class GGXNCXSSRDUVTGOTSFKB
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class BWRXWBMVGPXGJET
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class OOJDZEKDUIJ
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class WVZLSJBZOJKHK
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class IBGWIUDXRSUSNQLZOXS
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class FDONFHMIEIKAWPYHUVITPUEOWGMZYSK
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}
   private float tempSpeed;
    // Start is called before the first frame update
    void Start()
    {
        if (speed == 0) speed = 5;

        tempSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * speed);

        if (transform.position.x < -100)
        {
            GetComponent<OnCar>().enabled = false;
        }

        if (transform.position.z < Camera.main.transform.position.z - 30)
        {
            enabled = false;
            transform.position = new Vector3(-999,0,0);
        }

        if (carCrash)
        {
            speed -= Time.deltaTime * tempSpeed;
        }

        if (speed < 0) speed = 0;
    }

    public void SetSpeed(float spd)
    {
        speed = spd;
    }
}
