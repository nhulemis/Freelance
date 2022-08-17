using UnityEngine;
using System.Collections;
using System;

namespace AppAdvisory.BallX 
{
	public class InputManager : MonoBehaviour {
		public static event Action<Vector3> OnSwipeStarted;
		public static event Action<Vector3> OnSwipe;
		public static event Action<Vector3> OnSwipeEnded;

    public class Llcaowksx
    {
      public int A;
      public int B;
      public string C;
      public bool X;
   
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

        public class AXXXSPYSVCLKVHDRKGDINHQXFAVYHYVBTD
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

        public class FKYIEUWXCVU
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

        public class NHTQWHHLCKZXQIXQRD
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
		private Vector3 startPosition;
		void Update()
		{
			if (Input.GetMouseButtonDown (0)) {
				startPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				if (OnSwipeStarted != null)
					OnSwipeStarted (startPosition);
			} else if (Input.GetMouseButton (0)) 
			{
				Vector3 currentPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Vector3 movement = startPosition - currentPosition;

				if (OnSwipe != null)
					OnSwipe (movement);

			}
			else if (Input.GetMouseButtonUp(0))
			{
				Vector3 currentPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Vector3 movement = startPosition - currentPosition;

				if (OnSwipeEnded != null)
					OnSwipeEnded (movement);
			}
				
//			if (Input.GetKeyDown(KeyCode.Escape))
//			{
//				GameManager.Instance.Escape();
//			}

		}
	}
}

