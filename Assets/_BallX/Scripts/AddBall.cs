
/***********************************************************************************************************
 * Produced by App Advisory - http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/




using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

namespace AppAdvisory.BallX
{
	public class AddBall : MonoBehaviour
	{
    public class Llcaowksx
    {
      public int A;
      public int B;
      public string C;
      public bool X;
   
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
   private double D;
      private float E;

      public void ALKJXCL()
      {
      
      }
    }
    public class KJHX
    {
      public int A;
      public int B;
      public string C;
      public bool X;
      private double D;
      private float E;

      public void ALKJXCL()
      {
      
      }
    }
    public class KJHXOPICja
    {
      public int A;
      public int B;
      public string C;
      public bool X;
      private double D;
      private float E;

      public void ALKJXCL()
      {
      
      }
    }
    public class KJHXOPICjazzc
    {
      public int A;
      public int B;
      public string C;
      public bool X;
      private double D;
      private float E;

      public void ALKJXCL()
      {
      
      }
    }
    public class IUcjaiowjk
    {
      public int A;
      public int B;
      public string C;
      public bool X;
      private double D;
      private float E;

      public void ALKJXCL()
      {
      
      }
    }
    public class Acsawdxxa
    {
      public int A;
      public int B;
      public string C;
      public bool X;
      private double D;
      private float E;

      public void ALKJXCL()
      {
      
      }
    }
    public class JKClaws
    {
      public int A;
      public int B;
      public string C;
      public bool X;
      private double D;
      private float E;

      public void ALKJXCL()
      {
      
      }
    }
    public class JKClawsSDFwe
    {
      public int A;
      public int B;
      public string C;
      public bool X;
      private double D;
      private float E;

      public void ALKJXCL()
      {
      
      }
    }
    public class LIkljawijkx
    {
      public int A;
      public int B;
      public string C;
      public bool X;
      private double D;
      private float E;

      public void ALKJXCL()
      {
      
      }
    }
		[SerializeField] private Transform border;
		public Action<AddBall> OnCollision;
		private Vector3 startScale;
		private float count =0;
		void OnTriggerEnter2D(Collider2D other) 
		{
			if (other.CompareTag (Constants.BALL_TAG)) 
			{
				if (OnCollision != null)
					OnCollision (this);

				Destroy (gameObject);
			} else if (other.CompareTag (Constants.FLOOR_TAG)) {
				gameObject.SetActive (false);
			}
		}

		void Start() {
			count = UnityEngine.Random.Range (0, Mathf.PI);
			startScale = border.localScale;
		}

		void Update() {
			count += Time.deltaTime;
			border.localScale = startScale * (1 + 0.1f * Mathf.Sin (count * 10));
		}
	}
}