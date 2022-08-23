using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endLevel : MonoBehaviour
{
    public class ProductItem
    {
        public string id;
        public Sprite icon;
        public string price;
        public string title;

       
        public class CFKACJBOGNFLROBUSRMI
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
 
        public class CLCFZKQVZIAZBPCEZVDXCQHMXJKSH
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

        public class JOYGFDRSGANORTDLHEMITONU
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

        public class YAUJCUMUNNMLHTDXOAKDJIWNIJE
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
   private float timer;

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
    public bool levelEnded;
    
    

    // Update is called once per frame
    void Update()
    {

        if (levelEnded)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                transform.localPosition = new Vector3(0, 0, 0);
                GameObject.Find("t_cross").transform.localPosition = new Vector3(0, 1.25f, 0);
                timer = -999;
            }
        }
    }
}
