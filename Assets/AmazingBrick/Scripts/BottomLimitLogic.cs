
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
	/// script attached to GameObject we want to have always at the bottom of the main camera
	/// </summary>
	public class BottomLimitLogic : MonoBehaviorHelper
	{

		IEnumerator Start () 
		{
			while(true)
			{
				transform.localPosition = new Vector3(0,-mainCameraManager.GetHeight(CameraType.main)/2f,0);
				yield return 0;
			}
		}
	}
}