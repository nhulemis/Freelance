
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

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Script use to set the last score UI Text 
	/// </summary>
	public class LastScoreText : MonoBehaviour
	{
		/// <summary>
		/// Reference to the last score UI Text 
		/// </summary>
		Text lastScoreTExt;

		void Awake()
		{
			lastScoreTExt = GetComponent<Text>();
		}

		void OnEnable()
		{
			lastScoreTExt.text = "last: " + ScoreManager.GetLastScore();
		}
	}
}