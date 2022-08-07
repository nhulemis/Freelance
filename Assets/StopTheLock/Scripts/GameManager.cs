﻿
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/





using UnityEngine;
using UnityEngine.UI;
using System.Collections;
#if UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif
#if APPADVISORY_ADS
using AppAdvisory.Ads;
#endif
#if VS_SHARE
using AppAdvisory.SharingSystem;
#endif
#if APPADVISORY_LEADERBOARD
using AppAdvisory.social;
#endif



namespace AppAdvisory.StopTheLock
{
	public class GameManager : MonoBehaviourHelper
	{
		public int numberOfPlayToShowInterstitial = 5;

    public bool RESET_PLAYER_PREF = false;

		public bool isGameOver = false;

		public Text levelCenterScreen;
		public Text levelTopScreen;

		public Transform theGame;

		public RectTransform lockRect;

		public bool gameIsStarted = false;

		[SerializeField] private Button buttonPreviousLevel;
		[SerializeField] private Button buttonNextLevel;

		CanvasScaler canvasScaler;


		public bool isSuccess
		{
			get 
			{
				bool success = numTotalOfMove <= 0;
				return success;
			}
		}


		void Awake()
		{


			if (RESET_PLAYER_PREF)
				PlayerPrefs.DeleteAll ();

			RESET_PLAYER_PREF = false;

			buttonPreviousLevel.onClick.RemoveListener (OnClickedPreviousLevel);

			buttonNextLevel.onClick.RemoveListener (OnClickedNextLevel);

			SetNewGame ();

			gameIsStarted = true;

			Application.targetFrameRate = 60;

		}

		void OnClickedPreviousLevel()
		{
			OnClick (false);
		}

		void OnClickedNextLevel()
		{
			OnClick (true);
		}

		void OnClick(bool isNext)
		{
			buttonPreviousLevel.onClick.RemoveListener (OnClickedPreviousLevel);

			buttonNextLevel.onClick.RemoveListener (OnClickedNextLevel);

			int current = GetCurrentLevel ();

			if(isNext)
				current++;
			else
				current--;

			SetCurrentLevel (current);

			StartCoroutine (StartNewLevel ());
		}

		void SetNewGame()
		{
			buttonPreviousLevel.gameObject.SetActive (HavePreviousLevel ());

			buttonNextLevel.gameObject.SetActive (HaveNextLevel ());

			buttonPreviousLevel.onClick.AddListener (OnClickedPreviousLevel);

			buttonNextLevel.onClick.AddListener (OnClickedNextLevel);

			isGameOver = false;

			levelCenterScreen.text = GetCurrentLevel ().ToString ();

			levelTopScreen.text = "LEVEL: " + GetCurrentLevel ().ToString ();

			numTotalOfMove = GetCurrentLevel ();

			gameIsStarted = false;

			lockRect.eulerAngles = Vector3.zero;

			player.transform.eulerAngles = Vector3.zero;

			dotPosition.DoPosition ();


		}

		IEnumerator StartNewLevel()
		{

			buttonPreviousLevel.onClick.RemoveListener (OnClickedPreviousLevel);

			buttonNextLevel.onClick.RemoveListener (OnClickedNextLevel);


			SetNewGame ();

			StartCoroutine (ScreenMove.Move (theGame.GetComponent<RectTransform> (), true));

			while (ScreenMove.isMoving) 
			{
				yield return 0;
			}

			gameIsStarted = true;
		}



		private int numTotalOfMove = 0;

		public void MoveDone()
		{
			numTotalOfMove--;



			levelCenterScreen.text = numTotalOfMove.ToString ();

			bool success = numTotalOfMove <= 0;

			if (success)
				LevelCleared ();
			else
				soundManager.PlayTouch ();
		}

		public void GameOver()
		{
			soundManager.PlayFail ();
			isGameOver = true;
			StopAllCoroutines ();
			StartCoroutine (_GameOver ());

			//ShowAds();
		}

    public class ProductItem
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class ProductItemOIUca
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class OIUzxckljaw
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class QIUciou
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class KLJHalwjkkxlc
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class Lkjawioxklc
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class ADFiouawkljxc
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }

    public class Lkjawmvawvs
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }

    public class MNBZoiauwjkk
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
		IEnumerator _GameOver()
		{
			StartCoroutine (ScreenShake.Shake (theGame, 0.10f));

			while (ScreenShake.isShaking) 
			{
				yield return 0;
			}
			GameItemManager.Instance.ReloadLevel();
		}

		public void LevelCleared()
		{
			ShowAds();

			soundManager.PlaySuccess ();


			int current = GetCurrentLevel ();

			current++;

			SetCurrentLevel (current);

			SetMaxLevel (current);

			StartCoroutine (_LevelCleared ());

			//		if (current%3 == 0)
			colorManager.ChangeColor();
		}

		IEnumerator _LevelCleared()
		{
			float t0 = 0f;
			float t1 = -30f;
			float timer = 0;
			float time = 0.5f;
			while (timer <= time) {
				timer += Time.deltaTime;

				float f = Mathf.Lerp (t0, t1, timer / time);

				Vector3 rot = Vector3.forward * f;

				lockRect.eulerAngles = rot;

				yield return 0;
			}

			yield return new WaitForSeconds (0.2f);

			StartCoroutine (ScreenMove.Move (theGame.GetComponent<RectTransform> (), false));

			while (ScreenMove.isMoving) 
			{
				yield return 0;
			}

			//		SceneManager.LoadScene (0);

			StartCoroutine (StartNewLevel ());
		}

		public int GetMaxLevel()
		{
			int max = PlayerPrefs.GetInt ("MAX_LEVEL", 1);

			return max;
		}


		public void SetMaxLevel(int level)
		{
			int max = GetMaxLevel ();

			if (max < level) 
			{
				PlayerPrefs.SetInt ("MAX_LEVEL", level);
				PlayerPrefs.Save ();
			}
		}


		public int GetCurrentLevel()
		{
			int current = PlayerPrefs.GetInt ("CURRENT_LEVEL", 1);

			if (current <= 0) 
			{
				current = 1;
				PlayerPrefs.SetInt ("CURRENT_LEVEL", 1);
				PlayerPrefs.Save ();
			}

			return current;
		}


		public void SetCurrentLevel(int level)
		{
			PlayerPrefs.SetInt ("CURRENT_LEVEL", level);
			PlayerPrefs.Save ();
		}


		public bool HavePreviousLevel()
		{
			int currentLevel = GetCurrentLevel ();

			if (currentLevel > 1)
				return true;

			return false;
		}

		public bool HaveNextLevel()
		{
			int currentLevel = GetCurrentLevel ();

			int maxLevel = GetMaxLevel ();

			if (currentLevel < maxLevel)
				return true;

			return false;
		}

		public void ShowAds()
		{
			

    }


}
}