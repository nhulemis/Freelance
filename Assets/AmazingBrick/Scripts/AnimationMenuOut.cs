
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/

using UnityEngine;
using System.Collections;

#if AADOTWEEN
using DG.Tweening;
#endif

using AppAdvisory;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge to animate out UI
	/// </summary>
	public class AnimationMenuOut : MonoBehaviour 
	{
		Camera cam;

		public bool fromLeft;

		void Awake()
		{
			cam = Camera.main;
		}

		void OnEnable()
		{
			EventManager.OnGameStarted += OnGameStarted;
		}

		void OnDisable()
		{
			EventManager.OnGameStarted -= OnGameStarted;
		}

		void OnGameStarted()
		{
			DoLerpPositionOUT(transform);

		}

		void DoLerpPositionOUT(Transform t)
		{
			float time = 0.1f;

			float startPosX = t.position.x;

			#if AADOTWEEN

			float finalPosX = startPosX - cam.GetWidth();;

			if(!fromLeft)
				finalPosX = startPosX + cam.GetWidth();

			var pos = t.position;
			pos.x = startPosX;
			t.position = pos;

			t.DOMoveX(finalPosX,time);

			#endif
		}
	}
}