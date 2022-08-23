
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
#if APPADVISORY_ADS
using AppAdvisory.Ads;
#endif

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge of the canvas displayed when the game is over
	/// </summary>
	public class CanvasGameOver : MonoBehaviorHelper 
	{
		public GameObject gameOverMenu;
		public Button buttonContinueWithLife;
		public Button buttonContinueWithDiamonds;
		public Button buttonRestart;
		public Button buttonGetDiamonds;
		public Button buttonGetLifes;

		public AnimationTransition animationTransition;



		bool haveLife
		{
			get
			{
				return Util.GetLife() > 0;
			}
		}

		bool haveDiamondsToContinue
		{
			get

			{
				return Util.GetDiamond() >= 100;		
			}
		}

		bool haveRewardedVideo
		{
			get
			{
				#if APPADVISORY_ADS
				return AdsManager.Instance.IsReadyRewardedVideo ();
				#endif

				return false;
			}
		}

		void Awake()
		{
			buttonContinueWithLife.GetComponent<ButtonAnimation>().OnClicked.AddListener(OnClickedContinueWithLife);
			buttonContinueWithDiamonds.GetComponent<ButtonAnimation>().OnClicked.AddListener(OnClickedContinueWithDiamond);
			buttonRestart.GetComponent<ButtonAnimation>().OnClicked.AddListener(OnClickedRestart);
			buttonGetDiamonds.GetComponent<ButtonAnimation>().OnClicked.AddListener(OnClickedGetDiamonds);
			buttonGetLifes.GetComponent<ButtonAnimation>().OnClicked.AddListener(OnClickedGetLifes);
		}

		void OnEnable()
		{
			EventManager.OnPlayerFail += OnPlayerFail;
			EventManager.OnSetLife += OnReceivedUpdates;
			EventManager.OnSetDiamond += OnReceivedUpdates;
			Init();
		}

		void OnDisable()
		{

			EventManager.OnPlayerFail -= OnPlayerFail;
			EventManager.OnSetLife -= OnReceivedUpdates;
			EventManager.OnSetDiamond -= OnReceivedUpdates;


		}

		void Init()
		{
			gameOverMenu.SetActive(false);

			buttonContinueWithLife.transform.localScale = 0.5f * Vector3.one;
			buttonContinueWithDiamonds.transform.localScale = 0.5f * Vector3.one;
			buttonGetDiamonds.transform.localScale = 0.5f * Vector3.one;
			buttonGetLifes.transform.localScale = 0.5f * Vector3.one;
		}

		void OnReceivedUpdates(int i)
		{
			OnReceivedUpdates();
		}

		void OnReceivedUpdates()
		{
			if(gameOverMenu.activeInHierarchy)
			{


				buttonContinueWithLife.transform.localScale = haveLife ? Vector3.one : 0.5f * Vector3.one;
				buttonContinueWithDiamonds.transform.localScale = haveDiamondsToContinue ? Vector3.one : 0.5f * Vector3.one;
				buttonGetDiamonds.transform.localScale = haveRewardedVideo ? Vector3.one : 0.5f * Vector3.one;
				buttonGetLifes.transform.localScale = haveRewardedVideo ? Vector3.one : 0.5f * Vector3.one;



				buttonContinueWithLife.GetComponent<CanvasGroup>().alpha = haveLife ? 1f : 0.3f;
				buttonContinueWithDiamonds.GetComponent<CanvasGroup>().alpha = haveDiamondsToContinue ? 1f : 0.3f;
				buttonGetDiamonds.GetComponent<CanvasGroup>().alpha = haveRewardedVideo ? 1f : 0.3f;
				buttonGetLifes.GetComponent<CanvasGroup>().alpha = haveRewardedVideo ? 1f : 0.3f;

			}
		}

		void OnPlayerFail()
		{
			gameOverMenu.SetActive(true);
			gameOverMenu.GetComponent<AnimButtonHierarchy>().DoAnimIn();
			OnReceivedUpdates();

			#if AADOTWEEN
			mainCameraManager.DOGaussiamBlur(0,3);
			#endif

		}

		void ShowRewardedVideo(Action<bool> success)
		{
			#if APPADVISORY_ADS
			AdsManager.instance.ShowRewardedVideo(success);
			#endif
		}

		public void OnClickedContinueWithLife()
		{
			Util.SetLife(Util.GetLife() - 1);

			EventManager.DOClickedGameOverButtons(true);

			gameOverMenu.GetComponent<AnimButtonHierarchy>().DoAnimOut(() => {

				gameOverMenu.SetActive(false);
			});
				
			mainCameraManager.DOGaussiamBlur(3,0);
		}

		public void OnClickedContinueWithDiamond()
		{
			Util.SetDiamond(Util.GetDiamond() - 100);

			EventManager.DOClickedGameOverButtons(true);

			gameOverMenu.GetComponent<AnimButtonHierarchy>().DoAnimOut(() => {

				gameOverMenu.SetActive(false);
			});


			mainCameraManager.DOGaussiamBlur(3,0);

		}

		public void OnClickedRestart()
		{
      GameItemManager.Instance.UseCoin(1);
			gameManager.IsGameOver = false;

			animationTransition.DOAnimIn(() => {
				gameManager.GameOver();
			});

			gameOverMenu.GetComponent<AnimButtonHierarchy>().DoAnimOut(() => {
				gameOverMenu.SetActive(false);
			});
		}

		public void OnClickedGetDiamonds()
		{
			ShowRewardedVideo((bool success) => {
				if(success)
				{
					Util.SetDiamond(Util.GetDiamond() + 300);
				}
				else
				{
					//print("failed to get diamonds from rewarded video");
				}
			});

		}

		public void OnClickedGetLifes()
		{
			//print("OnClickedGetLifes");

			ShowRewardedVideo((bool success) => {
				if(success)
				{
					Util.SetLife(Util.GetLife() + 3);
				}
				else
				{
					//print("failed to get lifes from rewarded video");
				}
			});
		}
	}
}