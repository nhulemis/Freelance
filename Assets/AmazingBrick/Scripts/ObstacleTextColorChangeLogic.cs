
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
	/// Class in charge to change the color of the text between obstacles in the game
	/// </summary>
	public class ObstacleTextColorChangeLogic : ColorChangeBase
	{
		public override void Setup()
		{
			SetColor(colorManager.colorWall);
		}

		override public  void OnColorSpriteChange(Color c)
		{
			SetColor(c);
		}

		void SetColor(Color c)
		{
			c.a = text.color.a;
			text.color = c;
		}
	}
}