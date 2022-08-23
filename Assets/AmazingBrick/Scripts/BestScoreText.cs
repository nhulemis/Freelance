
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
	/// Script use to set the best score UI Text 
	/// </summary>
	public class BestScoreText : MonoBehaviour 
	{
		/// <summary>
		/// Reference to the best score UI Text 
		/// </summary>
		Text bestScoreText;

		void Awake()
		{
			bestScoreText = GetComponent<Text>();
		}

		void OnEnable()
		{
			EventManager.OnSetBestScore += OnSetBestScore;
		}

		void OnDisable()
		{
			EventManager.OnSetBestScore -= OnSetBestScore;
		}

		void OnSetBestScore(int best)
		{
			bestScoreText.text = "best: " + best;
		}
	}
}