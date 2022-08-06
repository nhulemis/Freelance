
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/


using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in chage to handle the color changes. All script who handle color change inherit from this class.
	/// </summary>
	public class ColorChangeBase : MonoBehaviorHelper 
	{
		[NonSerialized] public SpriteRenderer sr = null;
		[NonSerialized] public Image image = null;
		[NonSerialized] public Text text = null;
		[NonSerialized] public TrailRenderer tr = null;
		[NonSerialized] public Material m = null;

		void Awake()
		{
			sr = GetComponent<SpriteRenderer>();

			text = GetComponent<Text>();

			tr = GetComponent<TrailRenderer>();

			image = GetComponent<Image>();

			if(tr != null)
				m = tr.material;
		}

		void OnEnable()
		{
			Setup();
			ColorManager.OnColorSpriteChange += OnColorSpriteChange;
			ColorManager.OnColorBackgroundChange += OnColorBackgroundChange;
		}

		void OnDisable()
		{
			ColorManager.OnColorSpriteChange -= OnColorSpriteChange;
			ColorManager.OnColorBackgroundChange -= OnColorBackgroundChange;
		}


		void Start()
		{
			Setup();
		}

		public virtual void OnColorSpriteChange(Color c){}

		public virtual void OnColorBackgroundChange(Color c){}

		public virtual void Setup(){}
	}
}