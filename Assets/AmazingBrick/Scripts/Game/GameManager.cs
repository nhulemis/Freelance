
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

using System.Linq;
using AppAdvisory;
#if APPADVISORY_ADS
using AppAdvisory.Ads;
#endif
#if APPADVISORY_LEADERBOARD
using AppAdvisory.social;
#endif

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge of the pooling system (to spawn obstacle prefabs), trigger start and finished event, and display points / best score / button start when nedded
	/// 
	/// This script is attached to the GameObject "GameManager".
	/// This script in in charge of the game logic. And to spawn the obstacles.
	/// </summary>
	public class GameManager : MonoBehaviorHelper 
	{
		public int numberOfPlayToShowInterstitial = 5;

		public string VerySimpleAdsURL = "http://u3d.as/oWD";

		public bool IsGameOver = false;

		public GameObject ObjectPoolingPrefab;

		/// <summary>
		/// ParticleSystem to emit when the player starts
		/// </summary>
		public ParticleSystem ParticleSystemExplosionStart;
		/// <summary>
		/// The current player score = number of jumps
		/// </summary>
		private int point;
		/// <summary>
		/// To get the current score of the player
		/// </summary>
		public int GetPoint()
		{
			return point;
		}
		/// <summary>
		/// Init the game, create instance of AdsManager and ObjectPooling
		/// </summary>
		private void Awake()
		{
			IsGameOver = false;

			if(FindObjectOfType<PoolingSystem>() == null)
			{
				#if AADOTWEEN
				DOTween.Init();
				#endif

				var go = Instantiate(ObjectPoolingPrefab) as GameObject;
				go.SetActive(true);
				go.name = "_PoolingSystem";
				DontDestroyOnLoad(go);
			}

			EventManager.DOSetBestScore(ScoreManager.GetBestScore ());

			EventManager.DOSetLife((Util.GetLife()));
		}

		void OnEnable()
		{
			EventManager.OnGameStarted += OnStarted;

			EventManager.OnGameEnded += OnFinished;

			EventManager.OnPlayerFail += OnFinished;

			EventManager.OnClickedGameOverButtons += OnClickedGameOverButtons;
		}

		void OnDisable()
		{
			EventManager.OnGameStarted -= OnStarted;

			EventManager.OnGameEnded -= OnFinished;

			EventManager.OnPlayerFail -= OnFinished;

			EventManager.OnClickedGameOverButtons -= OnClickedGameOverButtons;
		}

		private void OnStarted()
		{
			IsGameOver = false;
		}

		void OnFinished()
		{
			IsGameOver = true;
		}

		void OnClickedGameOverButtons(bool success)
		{
			if (success) 
			{
				IsGameOver = false;
			}
		}

		IEnumerator Start()
		{
			Util.Setup();

			yield return 0;

			SpawnerMini();
		}

		public void UpdatePoint(int point)
		{
			EventManager.DOAddOnePoint();

			this.point = point;

			int best = ScoreManager.GetBestScore ();

			if (point > best)
			{
				EventManager.DOSetBestScore(this.point);
			} 
			else
			{
				EventManager.DOSetBestScore(best);
			}
		}

		/// <summary>
		/// Game Over function, who called the OnFinished event
		/// </summary>
		public void GameOver()
		{
			if(!IsGameOver)
			{
				IsGameOver = true;

				ShowAds();

				ReportScoreToLeaderboard(this.point);

				ScoreManager.SaveScore (point);

				EventManager.DOGameEnded();

				Util.ReloadCurrentScene();
			}
		}

		/// <summary>
		/// If using Very Simple Leaderboard by App Advisory, report the score : http://u3d.as/qxf
		/// </summary>
		void ReportScoreToLeaderboard(int p)
		{
			#if APPADVISORY_LEADERBOARD
			LeaderboardManager.ReportScore(p);
			#else
			print("Get very simple leaderboard to use it : http://u3d.as/qxf");
			#endif
		}

		/// <summary>
		/// Desactivate start button (to avoid double click) and start the game
		/// </summary>
		public void OnStart()
		{
      if (!GameItemManager.Instance.IsEnoughCoin())
      {
        return;
      }
			EventManager.DOGameStarted();

			point = 0;

			countSpawn = 0;

			SpawnerObstacles ();

			SpawnParticleSystemStart();
		}

		/// <summary>
		/// To despawn all the spawned objects, spwaned by the pooling system and store in the Lists obstacleRectanglePrefabList and obstacleCarrePrefabList
		/// </summary>
		void DespawnAll()
		{
			foreach (Transform t in transform) 
			{
				t.gameObject.SetActive (false);
			}
		}

		void DespawnNearestObstacle()
		{
			var obs = FindObjectsOfType<ObstacleLogic>();

			foreach(var o in obs)
			{
				var spr = o.GetComponentsInChildren<SpriteRenderer>();

				bool isVisible = false;

				foreach(var s in spr)
				{
					if(s.IsVisibleFrom(mainCameraManager.mainCamera))
					{
						isVisible = true;
						break;
					}
				}

				if(isVisible)
				{
					o.gameObject.SetActive(false);
				}


			}
		}

		int ByDistance(GameObject a, GameObject b)
		{
			var dstToA = Vector3.Distance(transform.position, a.transform.position);
			var dstToB = Vector3.Distance(transform.position, b.transform.position);
			return dstToA.CompareTo(dstToB);
		}

		int ByDistance(ObstacleLogic a, ObstacleLogic b)
		{
			return ByDistance(a.gameObject, b.gameObject);
		}

		int ByDistance(ObstacleHelper a, ObstacleHelper b)
		{
			return ByDistance(a.gameObject, b.gameObject);
		}

		/// <summary>
		/// Count the number of obstacles spawned
		/// </summary>
		int countSpawn = 0;
		public float lastPosXObstacles;


		/// <summary>
		/// Spawn the obstacles in the game. If the number of obstacles currently showned in the game is > 10, we wait. If < 10 we spawn new obstacles
		/// </summary>
		void SpawnerObstacles()
		{
			int count = 0;

			while (count < 5) 
			{
				SpawnObstacle();
				count ++;
			}
		}

		public void SpawnObstacle()
		{
			countSpawn++;

			float posY = 0;

			var temp =poolingSystem.transform.GetComponentsInChildren<ObstacleLogic>();

			var llll = temp.ToList();

			if(llll != null && llll.Count > 0)
			{
				llll.Sort(ByDistance);
				posY = llll[llll.Count - 1].transform.position.y + UnityEngine.Random.Range(20f,40f); //30f
			}
			else
			{
				posY = 5 + (countSpawn) *  UnityEngine.Random.Range(20f,40f); //30;
			}

			Vector2 posRectangle = new Vector2 (0, posY);

			var ob =poolingSystem.InstantiateAPS(Constants.OBSTACLE).GetComponent<ObstacleLogic>();
			ob.Reset();
			ob.transform.position = posRectangle;
			lastPosXObstacles = ob.Create(countSpawn, lastPosXObstacles);
		}

		float lastPos1 = -Mathf.Infinity;
		float lastPos2 = -Mathf.Infinity;
		float lastPosForeground = -Mathf.Infinity;

		void SpawnerMini()
		{
			SpawnerMini(BackgroundLayer.Background1Layer);

			SpawnerMini(BackgroundLayer.Background2Layer);

			SpawnItemDiamond();
		}

		void SpawnerMini(BackgroundLayer backgroundLayer)
		{
			int count = 0;

			Camera cam = mainCameraManager.GetCamera(backgroundLayer);

			while (true) 
			{
				var s = SpawnMini(backgroundLayer);

				if(!s.transform.IsVisibleFrom(cam) && s.transform.position.y > cam.transform.position.y)
				{
					break;
				}

				if(count > 100)
				{
					break;
				}

				count ++;
			}
		}

		void _SpawnerMini2()
		{
			int count = 0;

			while (true) 
			{
				var s = SpawnMini(BackgroundLayer.Background2Layer);

				if(!s.transform.IsVisibleFrom(camBackground2) && s.transform.position.y > camBackground2.transform.position.y)
				{
					break;
				}

				if(count > 100)
				{
					break;
				}

				count ++;

			}
		}


		private void SpawnItemDiamond()
		{
			StartCoroutine(_SpawnItemDiamond());

		}

		IEnumerator _SpawnItemDiamond()
		{
			while(true)
			{
				if(FindObjectsOfType<ItemDiamond>().Length <= 1)
				{
					CreateDiamond();

					if(UnityEngine.Random.Range(0,2) == 0)
					{
						yield return new WaitForSeconds(2);

						CreateDiamond();
					}
				}

				yield return new WaitForSeconds(2);
			}
		}

		void CreateDiamond()
		{
			var v =poolingSystem.InstantiateAPS(Constants.ITEM_DIAMOND).GetComponent<ItemBase>();
			v.transform.position = 
				playerTransform.position 
				+ Vector3.up * UnityEngine.Random.Range(mainCamera.GetHeight(),mainCamera.GetHeight()*2f)
				+ Vector3.right * UnityEngine.Random.Range(-mainCamera.GetWidth()/3f,mainCamera.GetWidth()/3f);
			v.Create();
		}

		public ObstacleMiniLogic SpawnMini(BackgroundLayer background)
		{
			float posY = 0;

			if(background == BackgroundLayer.Background1Layer)
			{
				if(lastPos1 == -Mathf.Infinity)
				{

					lastPos1 = - 2f * camBackground1.orthographicSize;

				}

				posY = lastPos1 + UnityEngine.Random.Range(8f, 8f);

				lastPos1 = posY;
			}
			else if(background == BackgroundLayer.Background2Layer)
			{
				if(lastPos2 == -Mathf.Infinity)
				{
					lastPos2 = - 2f * camBackground2.orthographicSize;

				}

				posY = lastPos2 + UnityEngine.Random.Range(4f, 6f);

				lastPos2 = posY;
			}
			else if(background == BackgroundLayer.ForegroundLayer)
			{
				if(lastPosForeground == -Mathf.Infinity)
				{
					lastPosForeground = - 2f * camForeground.orthographicSize;

				}

				posY = lastPosForeground + UnityEngine.Random.Range(1f, 4f);
			}
			else 
			{
				Debug.LogWarning("check layer for mini");

				return null;
			}

			Vector2 posRectangle = new Vector2 (0, posY);

			var ob =poolingSystem.InstantiateAPS(Constants.OBSTACLE_MINI).GetComponent<ObstacleMiniLogic>();
			ob.transform.position = posRectangle;

			ob.Create(background);

			return ob;
		}

		/// <summary>
		/// Emit the ParticleSystem at start
		/// </summary>
		public void SpawnParticleSystemStart()
		{
			var pe = Instantiate (ParticleSystemExplosionStart) as ParticleSystem;
			pe.transform.position = new Vector3(0,0,-1);
			pe.transform.rotation = Quaternion.identity;

		}

		/// <summary>
		/// If using Very Simple Ads by App Advisory, show an interstitial if number of play > numberOfPlayToShowInterstitial: http://u3d.as/oWD
		/// </summary>
		public void ShowAds()
		{
			
	}
}
}