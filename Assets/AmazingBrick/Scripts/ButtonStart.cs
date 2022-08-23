
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class attached to the start button. Run the game.
	/// </summary>
	public class ButtonStart : MonoBehaviorHelper
	{
		/// <summary>
		/// Reference to the start UI Button
		/// </summary>
		public Button buttonStart;

		void Awake()
		{
			buttonStart = GetComponent<Button>();
			ActivateButtonStart ();
		}
		/// <summary>
		/// To activate button start
		/// </summary>
		void ActivateButtonStart()
		{

			buttonStart.onClick.RemoveAllListeners ();
			buttonStart.onClick.AddListener (() => {
				//			buttonStart.onClick.RemoveAllListeners ();
				//			buttonStart.enabled = false;
				gameManager.OnStart();	
			});

		}
	}
}
	