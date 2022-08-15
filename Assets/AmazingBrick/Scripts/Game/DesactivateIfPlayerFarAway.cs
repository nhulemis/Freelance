
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
	/// An helper script to desactivate game object if the player is far away from it
	/// </summary>
	public class DesactivateIfPlayerFarAway : MonoBehaviorHelper 
	{
		void Update () 
		{
			if (playerTransform == null)
				return;

			float distance = Vector2.Distance(transform.position,playerTransform.position);

			if (distance > 10)
				gameObject.SetActive (false);
		}
	}
}