
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

#if AADOTWEEN
using DG.Tweening;
#endif

namespace AppAdvisory.AmazingBrick
{
	/// <summary> 
	/// Class to prompt a popup to ask the player to rate the game on the store
	/// </summary>
	public class RateUsManager : MonoBehaviour 
	{
		/// <summary> 
		/// Number of play to show the popup to ask the player to rate us. default value = 30
		/// </summary>
		public int NumberOfLevelPlayedToShowRateUs = 30;
		/// <summary> 
		/// iOS URL. Replace with your url
		/// </summary>
		public string iOSURL = "itms://itunes.apple.com/us/app/apple-store/id933517422?mt=8";
		/// <summary> 
		/// Android URL. Replace with your url
		/// </summary>
		public string ANDROIDURL = "http://app-advisory.com";


		public Button btnYes;
		public Button btnLater;
		public Button btnNever;

		public CanvasGroup popupCanvasGroup;

		void Awake()
		{
			popupCanvasGroup.alpha = 0;
			popupCanvasGroup.gameObject.SetActive(false);
		}

		void Start()
		{
			CheckIfPromptRateDialogue();
		}

		void AddButtonListeners()
		{
			btnYes.onClick.AddListener(OnClickedYes);
			btnLater.onClick.AddListener(OnClickedLater);
			btnNever.onClick.AddListener(OnClickedNever);
		}

		void RemoveButtonListener()
		{
			btnYes.onClick.RemoveListener(OnClickedYes);
			btnLater.onClick.RemoveListener(OnClickedLater);
			btnNever.onClick.RemoveListener(OnClickedNever);
		}

		void OnClickedYes()
		{
			#if UNITY_IPHONE
			Application.OpenURL(iOSURL);
			#endif

			#if UNITY_ANDROID
			Application.OpenURL(ANDROIDURL);
			#endif

			PlayerPrefs.SetInt("NumberOfLevelPlayedToShowRateUs",-1);
			PlayerPrefs.Save();
			HidePopup();
		}

		void OnClickedLater()
		{
			PlayerPrefs.SetInt("NumberOfLevelPlayedToShowRateUs",0);
			PlayerPrefs.Save();
			HidePopup();
		}

		void OnClickedNever()
		{
			PlayerPrefs.SetInt("NumberOfLevelPlayedToShowRateUs",-1);
			PlayerPrefs.Save();
			HidePopup();
		}

		void CheckIfPromptRateDialogue()
		{
			int count = PlayerPrefs.GetInt("NumberOfLevelPlayedToShowRateUs",0);

			if(count == -1)
				return;

			count ++;

			if(count > NumberOfLevelPlayedToShowRateUs)
			{
				PromptPopup();
			}
			else
			{
				PlayerPrefs.SetInt("NumberOfLevelPlayedToShowRateUs",count);
			}

			PlayerPrefs.Save();
		}

		public void PromptPopup()
		{
			popupCanvasGroup.alpha = 0;
			popupCanvasGroup.gameObject.SetActive(true);

			#if AADOTWEEN
			popupCanvasGroup.DOFade(1,1).OnComplete(() => {
				AddButtonListeners();
			});
			#endif
		}

		void HidePopup()
		{
			popupCanvasGroup.alpha = 1;
			#if AADOTWEEN
			popupCanvasGroup.DOFade(0, 1).OnComplete(() => {
				popupCanvasGroup.gameObject.SetActive(false);
				RemoveButtonListener();
			});
			#endif
		}
	}
}