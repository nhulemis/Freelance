﻿
/***********************************************************************************************************
 * Produced by App Advisory - http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/




using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
#if APPADVISORY_ADS
using AppAdvisory.Ads;
#endif
#if APPADVISORY_LEADERBOARD
using AppAdvisory.social;
#endif

#if AADOTWEEN
using DG.Tweening;
#endif

/// <summary>
/// In Charge to display and managed all the UI elements in the game
/// </summary>
public class CanvasManager : Singleton<CanvasManager> 
{
	public int numberOfPlayToShowInterstitial = 10;

	/// <summary>
	/// Facebook url open by the native app on mobile
	/// </summary>
	public string VerySimpleAd_LINK = "http://u3d.as/oWD";

	public string moreGamesUrl = "http://barouch.fr/moregames.php";

	public string rateUrl = "http://barouch.fr/ww.php";

	/// <summary>
	/// Facebook url open by the native app on mobile
	/// </summary>
	public string fbkPageId = "515431001924232";
	/// <summary>
	/// Facebook url open by the web browser if failed to open the native app
	/// </summary>
	public string fbkPageName = "appadvisory";

	public Image panel;
		
	AudioSource _music;
	/// <summary>
	/// Audiosource with the music attached (if you add a music to it)
	/// </summary>
	AudioSource music
	{
		get 
		{
			if (_music == null)
				_music = Camera.main.GetComponentInChildren<AudioSource> ();

			return _music;
		}
	}

	/// <summary>
	/// The level displayed on the top of the game view
	/// </summary>
	public Text levelText;
	public Button buttonNextLevel;
	public Button buttonLastLevel;

	public Button buttonSetting;

	public Button buttonUnlock;

	public Button buttonLike;
	public Button buttonLeaderboard;
	public Button buttonRate;
	public Button buttonMoreGames;
	public Button buttonSound;

	/// <summary>
	/// Get the max level the player could play. A level is playable if the player unlock the previous level. for exemple: to player the level 10, the player have to cleared the level 
	/// </summary>
	int maxLevel
	{
		get 
		{
			return PlayerPrefs.GetInt (Constant.LEVEL_UNLOCKED, 1);
		}
	}

	/// <summary>
	/// Get the last level the player played
	/// </summary>
	int lastLevel
	{
		get 
		{
			return PlayerPrefs.GetInt (Constant.LAST_LEVEL_PLAYED, 1);
		}
	}

	/// <summary>
	/// Set all the UI In Game Buttons
	/// </summary>
	void SetButtons()
	{

		buttonNextLevel.onClick.AddListener (() => {
			ButtonLogic ();
			OnClickedButtonNextLevel();
			ButtonLogic ();
		});

		buttonLastLevel.onClick.AddListener (() => {
			ButtonLogic ();
			OnClickedButtonPreviousLevel();
			ButtonLogic ();
		});

	}

	void TurnSound()
	{
		int soundOn = PlayerPrefs.GetInt(Constant.SOUND_ON,1);

		if (soundOn == 1) 
		{
			music.Stop ();
			PlayerPrefs.SetInt (Constant.SOUND_ON, 0);
			buttonSound.transform.GetChild (0).gameObject.SetActive (false);
			buttonSound.transform.GetChild (1).gameObject.SetActive (true);
		}
		else 
		{
			music.Play ();
			PlayerPrefs.SetInt (Constant.SOUND_ON, 1);
			buttonSound.transform.GetChild (0).gameObject.SetActive (true);
			buttonSound.transform.GetChild (1).gameObject.SetActive (false);
		}


		PlayerPrefs.Save();
	}






	void Awake()
	{
		#if AADOTWEEN
		DOTween.Init ();
		#endif

		if (!PlayerPrefs.HasKey (Constant.LAST_LEVEL_PLAYED)) {
			PlayerPrefs.SetInt (Constant.LAST_LEVEL_PLAYED, 1);
		} 

		if (!PlayerPrefs.HasKey (Constant.LEVEL_UNLOCKED)) {
			PlayerPrefs.SetInt (Constant.LEVEL_UNLOCKED, 1);
		} 

		PlayerPrefs.Save ();

	

		SetButtons ();
	

		ButtonLogic ();


	}


	private void ShowRewardedVideoGameOver(){

		#if UNITY_WEBGL
		#else
		//		NGUIManager.Instance.UIBackground.gameObject.SetActive (false);
		GameManager.Instance.success = false;
		GameManager.Instance.isGameOver = false;

		#if APPADVISORY_ADS
		AdsManager.Instance.ShowRewardedVideo ((bool success) => {
			if(success)
				PlayNextLevel (true);
		});
		#endif

		#endif
	}

	/// <summary>
	/// Display the next and/or last button (the arrow around the level at the top of the screen)
	/// </summary>
	void ButtonLogic()
	{

		if (lastLevel == 1)
			SetButtonActive(buttonLastLevel,false);
		else
			SetButtonActive(buttonLastLevel,true);

		if(lastLevel >= maxLevel)
			SetButtonActive(buttonNextLevel,false);
		else
			SetButtonActive(buttonNextLevel,true);
	}

	/// <summary>
	/// Activate and enable - or not - buttons
	/// </summary>
	void SetButtonActive(Button b,bool isActive)
	{
		if (isActive) 
		{
			if(GameManager.Instance != null && GameManager.Instance.currentAAColor != null)
			{
				b.GetComponent<Image> ().color = GameManager.Instance.currentAAColor.colorBright;
			}
			b.interactable = true;
		} 
		else
		{
			b.GetComponent<Image> ().color = Color.clear;
			b.interactable = false;
		}

	}


	void Start()
	{
		PlayLevel (lastLevel, true);
	}


	/// <summary>
	/// When the player failed, we show an unlock button ONLY IF there is a rewarded video available
	/// </summary>
	void ShowButtonUnlock()
	{
		#if APPADVISORY_ADS
		if (AdsManager.Instance.IsReadyRewardedVideo()) {
			if (buttonUnlock.transform.localScale.x == 1) {
				buttonUnlock.transform.DOScale (Vector3.one * 1.5f, 0.3f).SetLoops (6, LoopType.Yoyo);
			} else {
				buttonUnlock.transform.DOScale (Vector3.one, 0.3f);
			}
		}
		#endif
	}

	void DOFadeDotManager(float a)
	{
		var f = FindObjectsOfType<DotManager>();

		#if AADOTWEEN
		foreach(var d in f)
		{
			d.DotSprite.DOFade(a,Constant.DELAY_TRANSITION);
		}
		#endif
	}

	void DOFadeDotManagerWithDelay(float a)
	{
		var f = FindObjectsOfType<DotManager>();

		#if AADOTWEEN
		foreach(var d in f)
		{
			d.DotSprite.DOFade(a,Constant.DELAY_TRANSITION).SetDelay(Constant.DELAY_TRANSITION);
		}
		#endif
	}

	public void AnimationCameraGameOver()
	{

		ShowAds();

		GameManager.Instance.canShoot = false;

		ShowButtonUnlock();



		#if AADOTWEEN
		Camera.main.transform.DOShakePosition (Constant.DELAY_TRANSITION, 2, 20, 90, false)
			.OnComplete(() => {

				Camera.main.transform.position = new Vector3(0, 0, -10);

				DOFadeDotManager(0);

				ReplayCurrentLevel (lastLevel, false);

			});
		#endif
	}


  public class Lkjawmvawvs
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
	public void AnimationCameraSuccess()
	{

		GameManager.Instance.canShoot = false;

		PlayNextLevel (true);
	}

	public void ShowAds()
	{
		int count = PlayerPrefs.GetInt("GAMEOVER_COUNT",0);
		count++;

		#if APPADVISORY_ADS
		if(count > numberOfPlayToShowInterstitial && AdsManager.instance.IsReadyInterstitial())
		{
		PlayerPrefs.SetInt("COUNT_ADS",0);
		AdsManager.instance.ShowInterstitial();
		}
		else
		{
		PlayerPrefs.SetInt("COUNT_ADS", count);
		}
		PlayerPrefs.Save();
		#else
		if(count >= numberOfPlayToShowInterstitial)
		{
			Debug.LogWarning("To show ads, please have a look to Very Simple Ad on the Asset Store, or go to this link: " + VerySimpleAd_LINK);
			Debug.LogWarning("Very Simple Ad is already implemented in this asset");
			Debug.LogWarning("Just import the package and you are ready to use it and monetize your game!");
			Debug.LogWarning("Very Simple Ad : " + VerySimpleAd_LINK);
			PlayerPrefs.SetInt("GAMEOVER_COUNT",0);
		}
		else
		{
			PlayerPrefs.SetInt("GAMEOVER_COUNT", count);
		}
		PlayerPrefs.Save();
		#endif

	}

	/// <summary>
	/// Run the level logic on the UI side
	/// </summary>
	private void PlayLevel(int level, bool fromSuccess)
	{
		
		levelText.text = "Level " + level.ToString() + " / 1200";

		if(level > maxLevel)
			PlayerPrefs.SetInt (Constant.LEVEL_UNLOCKED, level);

		PlayerPrefs.SetInt (Constant.LAST_LEVEL_PLAYED, level);

		PlayerPrefs.Save ();

		ButtonLogic ();

		GameManager.Instance.CreateGame (level, fromSuccess);

	}

	/// <summary>
	/// Method called when the player clicked on the left arrow on the left of the level text on the top of the screen during the game
	/// </summary>
	private void OnClickedButtonPreviousLevel()
	{
		GameManager.Instance.RefreshColors();

		#if AADOTWEEN
		buttonUnlock.transform.DOScale(Vector3.zero,0.3f);
		#endif

		int last = lastLevel;

		last--;

		if (last < 1)
			last = 1;

		#if AADOTWEEN
		Camera.main.transform.DOMove (new Vector3 (-50, 0, -10), 0.3f).OnComplete (() => {
			Camera.main.transform.position = new Vector3 (50, 0, -10);
			Camera.main.orthographicSize = 20f;
			levelText.text = "Level " + last.ToString();
			PlayLevel (last, false);
			Camera.main.transform.DOMove (new Vector3 (0, 0, -10), 0.3f).OnComplete (() => {
			});
		});
		#endif


	}

	/// <summary>
	/// Method called when the player clicked on the right arrow on the roght of the level text on the top of the screen during the game
	/// </summary>
	private void OnClickedButtonNextLevel()
	{
		GameManager.Instance.RefreshColors();

		#if AADOTWEEN
		buttonUnlock.transform.DOScale(Vector3.zero,0.3f);
		#endif

		PlayNextLevel (false);
	}

	/// <summary>
	/// Method called when the player failed and so ... we replay the current level
	/// </summary>
	private void ReplayCurrentLevel(int level, bool fromSuccess)
	{

		DOFadeDotManagerWithDelay(1);


		PlayLevel (level, fromSuccess);
	}

	/// <summary>
	/// Method called when the player have to play the next level (if the current level is cleared, or if the payer taps/Clicks on the next button or if the player see a rewarded video to unlock the current level
	/// </summary>
	private void PlayNextLevel(bool fromSuccess)
	{
		int last = lastLevel;

		last++;
		#if APPADVISORY_LEADERBOARD
		LeaderboardManager.ReportScore (last);
		#endif

		#if AADOTWEEN
		Camera.main.transform.DOMove (new Vector3 (50, 0, -10), 0.3f).OnComplete (() => {

			Camera.main.transform.position = new Vector3 (-50, 0, -10);
			Camera.main.orthographicSize = 20f;
			levelText.text = "Level " + last.ToString();

			PlayLevel (last, fromSuccess);

			Camera.main.transform.DOMove (new Vector3 (0, 0, -10), 0.3f).OnComplete (() => {
			});
		});
		#endif


	}


}
