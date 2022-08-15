
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
	public class DiamondText : MonoBehaviour 
	{
		/// <summary>
		/// Reference to the life UI Text 
		/// </summary>
		Text diamondText;

		void Awake()
		{
			diamondText = GetComponent<Text>();
		}

		void Start()
		{
			OnSetDiamond(Util.GetDiamond());
		}

		void OnEnable()
		{
			EventManager.OnSetDiamond += OnSetDiamond;
		}

		void OnDisable()
		{
			EventManager.OnSetDiamond -= OnSetDiamond;
		}

		void OnSetDiamond(int tot)
		{
			diamondText.text = "x" + tot.ToString();
		}
	}
}