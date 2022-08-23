
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/

using UnityEngine;
using System.Collections;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge to change the color of the player's trail
	/// </summary>
	public class TrailColorChangeLogic : ColorChangeBase 
	{
		public override void Setup()
		{
			tr = GetComponent<TrailRenderer>();

			if(tr != null)
				m = tr.material;

			m.SetColor("_TintColor",colorManager.colorWall);
		}

		override public  void OnColorSpriteChange(Color c)
		{
			if(tr == null || m == null)
				Setup();

			if(tr == null || m == null)
				return;

			m.SetColor("_TintColor",c);
		}
	}
}