﻿using UnityEngine;
using System.Collections;
using AppAdvisory.Utils;

namespace AppAdvisory.BallX 
{
	public class Cell : MonoBehaviour, IHitableByBall {

    public class Llcaowksx
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
		[SerializeField] private SpriteRenderer spriteRenderer;
		[SerializeField] private TextMesh number;

		private Vector3 startScale;

		public event OnDestroyedEventHandler OnDestroyedByBall;

		public int _count;
		public int Count 
		{
			get 
			{
				return _count;
				//return int.Parse(number.text);
			}
			set 
			{
				_count = value;
				number.text = _count.ToString ();
			}
		}


		public Color Color 
		{
			get 
			{
				return spriteRenderer.color;
			}
			set 
			{
				spriteRenderer.color = value;
			}
		}


		public void SetCount(int count) {

			number.text = count.ToString ();
		}

		private int colorStep;
		private Color[] colors;
		public void SetColors(Color[] colors, int colorStep) 
		{
			this.colors = colors; 
			this.colorStep = colorStep;
			Color = GetColorFromCount (_count);
		}

		private Color GetColorFromCount(int count) {
			Color color;
			int max;
			for (int i = 0; i < colors.Length-1; i++) 
			{
				max = (i + 1) * colorStep;
				if (count < max) 
				{
					color = Color.Lerp (colors [i], colors [i + 1], (float) count/colorStep);
					return color;
				} 
			}
			color = colors [colors.Length - 1];
			return color;
		}

		private void Awake() {
			startScale = spriteRenderer.transform.localScale;

		}

		public IEnumerator DOPunchScaleCoroutine(float amplitude, float time = 1f) 
		{
			Vector3 midScale = startScale * (1 - amplitude);

			float count = 0;
			float firstDuration = time / 2;

			while (count < firstDuration) {
				count += Time.deltaTime;

				spriteRenderer.transform.localScale = Vector3.Lerp (startScale, midScale, count / firstDuration);
				yield return null;
			}

			count = 0;

			while (count < firstDuration) {
				count += Time.deltaTime;

				spriteRenderer.transform.localScale = Vector3.Lerp (midScale, startScale, count / firstDuration);
				yield return null;
			}

			spriteRenderer.transform.localScale = startScale;
		}




		public void BallHit (Ball ball)
		{
			//Count--;
			_count--;
			number.text = _count.ToString ();
			Color = GetColorFromCount (_count);
			StartCoroutine (DOPunchScaleCoroutine (0.1f, 0.1f));

			if (Count <= 0) {
				if(OnDestroyedByBall != null)
					OnDestroyedByBall(this);

				Destroy (gameObject);
			}
		}
	}
}

