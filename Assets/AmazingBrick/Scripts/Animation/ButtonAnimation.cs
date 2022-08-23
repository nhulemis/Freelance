
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
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#if AADOTWEEN
using DG.Tweening;
#endif


using AppAdvisory;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge to animate button when we press it
	/// </summary>
	public class ButtonAnimation : MonoBehaviour,
	//IPointerDownHandler, 
	ISubmitHandler,
	IPointerClickHandler,
	IPointerEnterHandler, 
	IPointerExitHandler,
	ISelectHandler,
	IDeselectHandler
	{

		public UnityEvent OnClicked;

		float animTime = 0.15f;

		#if UNITY_IOS || UNITY_ANDROID
		#else
		bool _isClicked = false;
		bool isClicked
		{
		set
		{
		_isClicked = value;

		if(_isClicked == true)
		Invoke("TurnIsClickedFalse",1);
		}

		get
		{
		return false;
		return _isClicked;
		}
		}
		#endif

		bool IsInterectable
		{
			get
			{
				if(gameObject.GetCanvasgroupAlpha() <= 0.99f)
				{
					return false;
				}

				return true;

			}
		}

		float posY = -1;

		void Awake()
		{
			posY = GetComponent<RectTransform>().anchoredPosition.y;
		}

		void OnEnable()
		{
			GetComponent<RectTransform>().anchoredPosition = new Vector2(0,posY);
		}

		void DOOnclicked()
		{
			if(!IsInterectable) // || transform.localScale.x <= 0.99f)
			{
				EventManager.DOWrongSelection();
				#if AADOTWEEN
				transform.DOShakePosition(1,10,10,90);
				#endif
				return;
			}


			OnClicked.Invoke();
		}

		void TurnIsClickedFalse()
		{
			#if UNITY_IOS || UNITY_ANDROID
			#else
			isClicked = false;
			#endif
		}

	
        public class JMRJPTAGNWUCAKGX
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class QSAZHIUWUPLGILKBSTHDHBAO
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}
	public void OnPointerClick (PointerEventData eventData)
		{
			if(!IsInterectable)
				return;


			#if UNITY_IOS || UNITY_ANDROID
			#else
			////print("OnPointerClick");
			if(isClicked)
			return;

			isClicked = true;
			#endif

			DoScale(transform.localScale.x/2f,animTime, () => {

				DoScale(transform.localScale.x*2f,animTime, () => {
					DOOnclicked();
					#if UNITY_IOS || UNITY_ANDROID
					#else
					isClicked = false;
					#endif

				});
			});
		}



		public void OnSelect (BaseEventData eventData)
		{
			if(!IsInterectable)
				return;

			#if UNITY_IOS || UNITY_ANDROID
			#else
			////print("OnSelect");
			DoScale(1.3f,animTime, () => {

			});
			#endif
		}

		public void OnDeselect (BaseEventData eventData)
		{
			if(!IsInterectable)
				return;

			#if UNITY_IOS || UNITY_ANDROID
			#else
			////print("OnDeselect");
			DoScale(1.0f,animTime, () => {

			});
			#endif
		}


		public void OnSubmit (BaseEventData eventData)
		{
			if(!IsInterectable)
				return;

			#if UNITY_IOS || UNITY_ANDROID
			#else
			////print("OnSubmit");
			if(isClicked)
			return;

			isClicked = true;

			DoScale(transform.localScale.x/2f,animTime, () => {
			//		FindObjectOfType<CanvasManager>().OnClickedButton(gameObject);
			DoScale(transform.localScale.x*2f,animTime, () => {
			});
			});
			#endif
		}

		public void OnPointerEnter (PointerEventData eventData)
		{
			if(!IsInterectable)
				return;

			#if UNITY_IOS || UNITY_ANDROID
			#else
			////print("OnPointerEnter");
			DoScale(1.3f,animTime, () => {

			});
			#endif
		}

		public void OnPointerExit (PointerEventData eventData)
		{
			if(!IsInterectable)
				return;

			#if UNITY_IOS || UNITY_ANDROID
			#else
			////print("OnPointerExit");
			DoScale(1f,animTime, () => {

			});
			#endif
		}


		void DoScale(float toS, float duration, Action OnCompete)
		{
			if(!IsInterectable)
				return;

			//		transform.DOKill();
			#if AADOTWEEN
			transform.DOScale(toS, duration).OnComplete(() => {
				if(OnCompete != null)
					OnCompete();
			});
			#endif
		}
	}
}