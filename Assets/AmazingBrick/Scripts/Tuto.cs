
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
	/// Class in charge to display tutorial at start 
	/// </summary>
	public class Tuto : MonoBehaviour 
	{
		public Text textLeft;
		public Text textRight;

		string stringLeft
		{
			get
			{
				if(Application.isMobilePlatform)
				{
					return "Tap LEFT\n to jump LEFT";
				}
				else
				{
					return "LEFT arrow\n to jump LEFT";
				}
			}
		}

		string stringRight
		{
			get
			{
				if(Application.isMobilePlatform)
				{
					return "Tap RIGHT\n to jump RIGHT";
				}
				else
				{
					return "RIGHT arrow\n to jump RIGHT";
				}
			}
		}

		void Awake()
		{
			textLeft.text = stringLeft;
			textRight.text = stringRight;
		}
	}
}