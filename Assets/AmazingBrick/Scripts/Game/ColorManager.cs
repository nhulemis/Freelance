
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

#if AADOTWEEN
using DG.Tweening;
#endif

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge to change the background color 
	/// </summary>
	public class ColorManager : MonoBehaviorHelper 
	{
		public delegate void ColorSpriteChange (Color c);
		public static event ColorSpriteChange OnColorSpriteChange;

		public delegate void ColorBackgroundChange (Color c);
		public static event ColorBackgroundChange OnColorBackgroundChange;

		#if UNITY_EDITOR
		public bool DEBUG;
		public int testColorNum = -1;
		#endif
		/// <summary>
		/// List of the Colored used in the game
		/// </summary>
		public List<Colored> colored = new List<Colored>();

		void Awake()
		{
			colorBackground = Color.white;

			colorWall = Color.white;
		}

		int count = 0;

		void OnEnable()
		{
			EventManager.OnAddOnePoint += ChangeColor;
		}

		void OnDisable()
		{
			EventManager.OnAddOnePoint -= ChangeColor;
			StopAllCoroutines ();
			CancelInvoke();
		}

		void Start()
		{

			colorBackground = Color.white;

			colorWall = Color.white;


			//		Colored c = GetRandomColor();

			Colored c = colored[PlayerPrefs.GetInt("LASTSCOLOR",0)];
			Color cBack = c.colorBackground;
			Color cWall = c.colorWall;

			colorBackground = cBack;

			colorWall = cWall;

		}

		/// <summary>
		/// The current background color
		/// </summary>
		private Color m_colorBackground;
		public Color colorBackground
		{
			get
			{
				return m_colorBackground;
			}
			set
			{
				m_colorBackground = value;
				if(OnColorBackgroundChange != null)
					OnColorBackgroundChange(m_colorBackground);
			}
		}


		/// <summary>
		/// The current background color
		/// </summary>
		private Color m_colorWall;
		public Color colorWall
		{
			get
			{
				return m_colorWall;
			}
			set
			{
				m_colorWall = value;
				if(OnColorSpriteChange != null)
					OnColorSpriteChange(m_colorWall);
			}
		}


		public void ChangeColor()
		{

			count ++;

			if(count/3 == 1)
			{
				count = 0;
				var c = GetRandomColor();

				#if AADOTWEEN
				DOTween.To( () => colorBackground, 
					x => colorBackground = x,
					c.colorBackground, 1f);

				DOTween.To( () => colorWall, 
					x => colorWall = x,
					c.colorWall, 1f);
				#endif

			}
		}

		Colored GetRandomColor()
		{
			int i = UnityEngine.Random.Range (0, colored.Count);
			var c = colored[i];

			PlayerPrefs.SetInt("LASTSCOLOR",i);

			return c;
		}
	}
}