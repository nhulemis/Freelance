
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

#if AADOTWEEN
using DG.Tweening;
#endif

using AppAdvisory;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Move some game object when they became visible and juste before they became invisible
	/// </summary>
	public class MoveInOutWhenVisible : MonoBehaviorHelper 
	{
		float time = 0.12f;

		void OnEnable()
		{
			#if AADOTWEEN
			transform.DOKill();
			#endif

			StopAllCoroutines();
			StartCoroutine(DOMoveInWhenVisible());
		}

		void OnDisable()
		{
			#if AADOTWEEN
			transform.DOKill();
			#endif
			StopAllCoroutines();
		}


		IEnumerator DOMoveInWhenVisible()
		{
			yield return 0;

			Transform t = transform;

			bool fromLeft = t.position.x < 0;

			float finalPosX = t.position.x;

			float startPosX = finalPosX - mainCamera.GetWidth()/2f;

			if(!fromLeft)
				startPosX = finalPosX + mainCamera.GetWidth()/2f;

			var pos = t.position;
			pos.x = startPosX;
			t.position = pos;

			float bias =  mainCamera.GetHeight() / 20; //0f;
			var posTemp = new Vector3(0,pos.y + bias,pos.z);

			while(!posTemp.IsVisibleFrom(mainCamera))
			{
				yield return 0;
				//			yield return new WaitForSeconds(0.1f);
			}

			#if AADOTWEEN
			t.DOMoveX(finalPosX,time);
			#endif

			StartCoroutine(DOMoveOutWhenVisible());

		}

		IEnumerator DOMoveOutWhenVisible()
		{

			//		//print("DOMoveOutWhenVisible - start");

			yield return new WaitForSeconds(1);

			Transform t = transform;
			var pos = t.position;
			float bias = mainCamera.GetHeight() / 5f; //0f;
			var posTemp = new Vector3(0,pos.y - bias,pos.z);

			while(posTemp.IsVisibleFrom(mainCamera))
			{
				yield return 0;
				//			yield return new WaitForSeconds(0.1f);
			}

			yield return 0;

			float startPosX = t.position.x;

			float finalPosX = startPosX - mainCamera.GetWidth()/2f;

			bool fromLeft = t.position.x < 0;

			if(!fromLeft)
				finalPosX = startPosX + mainCamera.GetWidth()/2f;

			#if AADOTWEEN
			t.DOMoveX(finalPosX,time)
				.OnComplete( () => {
					//				//print("DOMoveOutWhenVisible - SendMessage Despawn");
					gameObject.SetActive(false);
					//				transform.parent.gameObject.SendMessage("Despawn",SendMessageOptions.DontRequireReceiver);
				});
			#endif
		}
	}
}