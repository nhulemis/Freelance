
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

#if AADOTWEEN
using DG.Tweening;
#endif

using AppAdvisory;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge to follow the player and to place the left and right walls on the screen
	/// 
	/// This script is attached to the Main Camera. This script is in charge to follow the Player vertically.
	/// </summary>
	public class MainCameraManager : MonoBehaviorHelper
	{
    public class ProductItem
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
		/// <summary>
		/// Reference to the left wall
		/// </summary>
		public Transform left;
		/// <summary>
		/// Reference to the right wall
		/// </summary>
		public Transform right;

		/// <summary>
		/// If useContantWidth = true, the space between the left and right walls
		/// </summary>
		public float constantWidth = 15f;

		Vector3 posPlayer
		{
			get
			{
				var p = playerTransform.position;

				p += Vector3.up * 5f;

				return p;
			}
		}

		Vector3 myPos
		{
			set
			{
				transform.position = new Vector3(value.x, value.y, transform.position.z);
			}
		}


		[NonSerialized] Camera camMain;
		[NonSerialized] Camera camBack1;
		[NonSerialized] Camera camBack2;
		[NonSerialized] Camera camFor;

		public float GetHeight(CameraType type)
		{
			if(GetCamera(type) == null)
				return -1;

			return GetCamera(type).GetHeight();
		}

		public float GetWidth(CameraType type)
		{
			if(GetCamera(type) == null)
				return -1;

			return GetCamera(type).GetWidth();
		}

		public Camera GetCamera(CameraType type)
		{
			Camera camTemp = null;

			if(type == CameraType.main)
			{
				camTemp = camMain;
			}
			else if(type == CameraType.background1)
			{
				camTemp = camBack1;
			}
			else if(type == CameraType.background2)
			{
				camTemp = camBack2;
			}
			else if(type == CameraType.foreground)
			{
				camTemp = camFor;
			}

			return camTemp;
		}

		public Camera GetCamera(BackgroundLayer type)
		{
			Camera camTemp = null;

			if(type == BackgroundLayer.Background1Layer)
			{
				camTemp = camBack1;
			}
			else if(type == BackgroundLayer.Background2Layer)
			{
				camTemp = camBack2;
			}
			else if(type == BackgroundLayer.ForegroundLayer)
			{
				camTemp = camFor;
			}
			else
			{
				return mainCamera;
			}

			return camTemp;
		}

		void Awake ()
		{
			camMain = Camera.main;
			camBack1 = transform.Find("CameraBackground1").GetComponent<Camera>();
			camBack2 = transform.Find("CameraBackground2").GetComponent<Camera>();
			camFor = transform.Find("CameraForeground").GetComponent<Camera>();

			var allCams = FindObjectsOfType<Camera>();



			foreach(var cam in allCams)
			{
				if(cam.name.Contains("Background1"))
				{
					camBack1 = cam;
				}
				else if(cam.name.Contains("Background2"))
				{
					camBack2 = cam;
				}
				else if(cam.name.Contains("Foreground"))
				{
					camFor = cam;
				}
			}


			float size = constantWidth;


			left.localPosition = new Vector2 (-size * 0.8f, 0);   

			right.localPosition = new Vector2 (+size * 0.8f , 0);   

			camMain.orthographicSize = constantWidth * 1.5f;

			camBack1.orthographicSize = camMain.orthographicSize * 2f;
			camBack2.orthographicSize = camBack1.orthographicSize * 2f;
			camFor.orthographicSize = camMain.orthographicSize / 2f;

			myPos = playerTransform.position;//posPlayer;
		}

		void OnEnable()
		{
			EventManager.OnGameStarted += OnStarted;

			EventManager.OnGameEnded += OnFinished;
		}
		void OnDisable()
		{
			EventManager.OnGameStarted -= OnStarted;

			EventManager.OnGameEnded -= OnFinished;
		}


		private void OnStarted()
		{
			StartCoroutine(CoUpdate());
		}

		private void OnFinished()
		{
			StopAllCoroutines();
		}

		IEnumerator CoUpdate()
		{
			while(true)
			{
				UpdatePos();
				yield return 0;
			}
		}


		/// <summary>
		/// To update the Y position of the camera, y position always  player Y position (if the game is not at Game Over state)
		/// </summary>
		public void UpdatePos()
		{

			if (playerTransform == null)
				return;

			Vector3 pos = transform.position;

			if(posPlayer.y > pos.y)
			{
				pos.y = Mathf.Lerp(pos.y, posPlayer.y, 0.07f * Time.time);
				transform.position = pos;
			}


		}


		public void DOGaussiamBlur(float _from, float _to)
		{

			//		gaussianFilter.enabled = true;
			//		gaussianFilter.nIterations = _from;
			//		gaussianFilter.lod = _from / 3f;
			//
			//		DOVirtual.Float(_from,_to,0.3f,(float f) => {
			//			gaussianFilter.nIterations = (f);
			//			gaussianFilter.lod = (f/3f);
			//		}).OnComplete(()=>{
			//			gaussianFilter.nIterations = _to;
			//			gaussianFilter.lod = _to / 3f;
			//
			//			if(_to == 0)
			//				gaussianFilter.enabled = false;
			//		});
		}
	}
}