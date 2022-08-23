
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge to listen the touch or click, and send event to subscribers
	/// </summary>
	public class InputTouch : MonoBehaviorHelper
	{
		/// <summary>
		/// Delegate to listen the touch or click, and send event to subscribers
		/// </summary>
		public delegate void TouchScreenLeft(DIRECTION dir);
		/// <summary>
		/// Event trigger when the player touch or click, send to all subscribers
		/// </summary>
		public static event TouchScreenLeft OnTouchScreen;

		#if UNITY_TVOS
		private Vector2 startPosition;
		//	void OnEnable()
		//	{
		//		GameManager.OnGameStarted += OnGameStart;
		//
		//		GameManager.OnGameEnded += OnGameOver;
		//	}
		//	void OnDisable()
		//	{
		//		GameManager.OnGameStarted -= OnGameStart;
		//
		//		GameManager.OnGameEnded -= OnGameOver;
		//	}

		bool gameStarted = true;

		void OnGameStart()
		{
		UnityEngine.Apple.TV.Remote.touchesEnabled = true;
		UnityEngine.Apple.TV.Remote.allowExitToHome = false;

		gameStarted = true;
		}

		void OnGameOver()
		{
		UnityEngine.Apple.TV.Remote.touchesEnabled = false;
		UnityEngine.Apple.TV.Remote.allowExitToHome = true;

		gameStarted = false;

		//		FindObjectOfType<EventSystem>().firstSelectedGameObject = gameManager.buttonStart.gameObject;
		FindObjectOfType<StandaloneInputModule>().forceModuleActive = true;
		}

		void Start()
		{
		UnityEngine.Apple.TV.Remote.reportAbsoluteDpadValues = true;
		}

		#endif

		void Update () 
		{

			#if (UNITY_ANDROID || UNITY_IOS || UNITY_TVOS)

			#if UNITY_TVOS
			if(!gameStarted)
			{

			gameManager.OnStart();
			return;
			}
			#endif


			if( Input.touchCount > 0)
			{

				Touch touch = Input.GetTouch(0);

				TouchPhase phase = touch.phase;

				if (phase == TouchPhase.Began)
				{
					DIRECTION dir = DIRECTION.left;

					if(touch.position.x >= Screen.width / 2f)
						dir = DIRECTION.right;

					if(OnTouchScreen != null)
						OnTouchScreen(dir);
				}
			}

			#endif

			#if (!UNITY_ANDROID && !UNITY_IOS && !UNITY_TVOS) || UNITY_EDITOR

			if(Input.GetKeyDown(KeyCode.LeftArrow))
			{
				if(OnTouchScreen != null)
					OnTouchScreen(DIRECTION.left);
			}

			if(Input.GetKeyDown(KeyCode.RightArrow))
			{
				if(OnTouchScreen != null)
					OnTouchScreen(DIRECTION.right);
			}



			#endif
		}
	}

	public enum DIRECTION
	{
		none,
		left,
		right
	}
}