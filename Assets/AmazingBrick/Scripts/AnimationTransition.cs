
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
using System.Collections.Generic;

#if AADOTWEEN
using DG.Tweening;
#endif


using AppAdvisory;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge to handle the transition animation (in and out)
	/// </summary>
	public class AnimationTransition : MonoBehaviorHelper 
	{
		public Transform objToClone;

		CanvasGroup[] _all;

		List<CanvasGroup> all =  new List<CanvasGroup>();

		Color c;

		float timeMax = 0.5f;
		float delayMax = 0.3f;

		void Awake()
		{
			while(transform.childCount < 160)
			{
				Transform t = Instantiate(objToClone) as Transform;
				t.SetParent(transform,false);
			}

			_all = GetComponentsInChildren<CanvasGroup>();


			foreach(var i in _all)
			{
				i.alpha = 1;
				all.Add(i);
			}

			all.Shuffle();
		}

		void OnEnable()
		{
			ColorManager.OnColorBackgroundChange += OnColorBackgroundChange;
		}

		void OnDisable()
		{
			ColorManager.OnColorBackgroundChange -= OnColorBackgroundChange;
		}

		void OnColorBackgroundChange(Color c)
		{
			this.c = c;
		}

		void Start()
		{
			DOAnimOut(null);
		}

		public void DOAnimOut(Action complete)
		{
			all.Shuffle();
			SetColor();
			StartCoroutine(_DOAnimOut(complete));
		}

		IEnumerator _DOAnimOut(Action complete)
		{
			BlockRaycast(true);

			#if AADOTWEEN
			foreach(var i in all)
			{
				i.alpha = 1f;
				i.DOFade(0f, UnityEngine.Random.Range(0f,timeMax))
					.SetDelay(UnityEngine.Random.Range(0f,delayMax));
			}
			#endif

			yield return 0;

			while(all.Find(o => o.alpha == 1) != null)
			{
				yield return 0;
			}


			BlockRaycast(false);

			foreach(var i in all)
			{
				i.gameObject.SetActive(false);
			}

			if(complete != null)
				complete();
		}

		public void DOAnimIn(Action complete)
		{
			all.Shuffle();
			SetColor();
			StartCoroutine(_DOAnimIn(complete));
		}

		IEnumerator _DOAnimIn(Action complete)
		{


			BlockRaycast(true);

			#if AADOTWEEN
			foreach(var i in all)
			{
				i.alpha = 0f;
				i.DOFade(1f, UnityEngine.Random.Range(0f,timeMax))
					.SetDelay(UnityEngine.Random.Range(0f,delayMax));
			}
			#endif

			foreach(var i in all)
			{
				i.gameObject.SetActive(true);
			}


			yield return 0;

			while(all.Find(o => o.alpha == 0) != null)
			{
				yield return 0;
			}

			yield return new WaitForSeconds(1);

			if(complete != null)
				complete();
		}

		void BlockRaycast(bool block)
		{
			foreach(var i in all)
			{
				i.blocksRaycasts = block;
			}
		}

		void SetColor()
		{
			foreach(var i in all)
			{
				i.transform.GetChild(0).GetComponent<Image>().color = c;
			}
		}

		//	IEnumerator Start()
		//	{
		//		List<Image> listImages = new List<Image>();
		//
		//		foreach(Transform t in transform)
		//		{
		//			listImages.Add(t.GetComponent<Image>());
		//		}
		//
		//		listImages.Shuffle();
		//
		//		foreach(var i in listImages)
		//		{
		//			i.color = Color.red;
		//
		//			yield return 0;
		//		}
		//	}
	}
}
