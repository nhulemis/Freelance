
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using AppAdvisory;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Script use to set the life UI Text 
	/// </summary>
	public class LifeText : MonoBehaviour 
	{
		/// <summary>
		/// Reference to the life UI Text 
		/// </summary>
		Text lifeText;

		void Awake()
		{
			lifeText = GetComponent<Text>();
		}

		void Start()
		{
			OnSetLife(Util.GetLife());
		}

		void OnEnable()
		{
			EventManager.OnSetLife += OnSetLife;
		}

		void OnDisable()
		{
			EventManager.OnSetLife -= OnSetLife;
		}

		void OnSetLife(int tot)
		{
			lifeText.text = "x" + tot.ToString();
		}
	}
}