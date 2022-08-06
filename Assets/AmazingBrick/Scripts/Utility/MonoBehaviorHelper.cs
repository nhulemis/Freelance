
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
	/// Class to avoid some duplicate codes. 
	/// </summary>
	public class MonoBehaviorHelper : MonoBehaviour
	{

		private GameManager _gameManager;
		public GameManager gameManager
		{
			get
			{
				if (_gameManager == null)
					_gameManager = FindObjectOfType<GameManager> ();

				return _gameManager;
			}
		}

		private PlayerManager _playerManager;
		public PlayerManager playerManager
		{
			get
			{
				if (_playerManager == null)
					_playerManager = FindObjectOfType<PlayerManager> ();

				return _playerManager;
			}
		}

		private Transform _playerTransform;
		public Transform playerTransform
		{
			get
			{
				if (playerManager == null)
					return null;

				if (_playerTransform == null)
					_playerTransform = playerManager.transform;

				return _playerTransform;
			}
		}

		private MainCameraManager _mainCameraManager;
		public MainCameraManager mainCameraManager
		{
			get
			{
				if (_mainCameraManager == null)
					_mainCameraManager = FindObjectOfType<MainCameraManager> ();

				return _mainCameraManager;
			}
		}

		private Camera _mainCamera;
		public Camera mainCamera
		{
			get
			{
				if(_mainCamera == null)
				{
					_mainCamera = mainCameraManager.GetCamera(CameraType.main);
				}

				return _mainCamera;
			}
		}

		private Camera _camBackground1;
		public Camera camBackground1
		{
			get
			{
				if(_camBackground1 == null)
				{
					_camBackground1 = mainCameraManager.GetCamera(CameraType.background1);
				}

				return _camBackground1;
			}
		}

		private Camera _camBackground2;
		public Camera camBackground2
		{
			get
			{
				if(_camBackground2 == null)
				{
					_camBackground2 = mainCameraManager.GetCamera(CameraType.background2);
				}

				return _camBackground2;
			}
		}

		private Camera _camForeground;
		public Camera camForeground
		{
			get
			{
				if(_camForeground == null)
				{
					_camForeground = mainCameraManager.GetCamera(CameraType.foreground);
				}

				return _camForeground;
			}
		}

		private Transform _camTransform;
		public Transform camTransform
		{
			get
			{
				if (_camTransform == null)
					_camTransform = Camera.main.transform;

				return _camTransform;
			}
		}


		private ColorManager _colorManager;
		public ColorManager colorManager
		{
			get
			{
				if (_colorManager == null)
					_colorManager = FindObjectOfType<ColorManager> ();

				return _colorManager;
			}
		}


		private CountdownLogic _countdownLogic;
		public CountdownLogic countdownLogic
		{
			get
			{
				if (_countdownLogic == null)
					_countdownLogic = FindObjectOfType<CountdownLogic> ();

				return _countdownLogic;
			}
		}

		private PoolingSystem _poolingSystem;
		public PoolingSystem poolingSystem
		{
			get
			{
				if (_poolingSystem == null)
					_poolingSystem = FindObjectOfType<PoolingSystem> ();

				return _poolingSystem;
			}
		}

	}
}