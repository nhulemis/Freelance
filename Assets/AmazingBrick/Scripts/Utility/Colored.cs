
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

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class to handle color changing in the game
	/// </summary>
	[Serializable]
	public class Colored 
	{
		[SerializeField] public Color colorBackground = Color.black;
		[SerializeField] public Color colorWall = Color.black;

		public Colored(Color colorBackground, Color colorWall)
		{
			this.colorBackground = colorBackground;
			this.colorWall = colorWall;
		}
	}
}