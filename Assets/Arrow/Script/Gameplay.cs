//using MEC;

using System.Collections;
using UnityEngine;

//using GameAnalyticsSDK;

namespace Arrow.Script
{
	public class Gameplay : MonoBehaviour
	{
		public enum GameState
		{
			Init,
			Play,
			Lose,
			Win,
			Pause,
			Resume,
			Revive
		}

		class HSUQOXkkoaw1
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}

		class HSUQOXkzkockosa2
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}

		class HSUcjiaojxjsi3
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}
		class HSUvokaowmbnvxc5
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}
		[SerializeField] Camera mainCamera;
		public Camera Camera => mainCamera;
		private PlayerController character;
		[SerializeField] Level level;
		public Level Level => level;
		[SerializeField] CameraController cameraController;
		[SerializeField] int levelCount;
		[SerializeField] ElementAnalysis elementAnalysis;

		public bool Finished { get; private set; } = false;
		public int EarnedGem { get; set; } = 0;

		public static Gameplay Instance;
		public float RoadWidth => level.Width;
		public float Speed { get; set; } = 10;

		private void Awake()
		{
			Instance = this;
			character = GameObject.FindObjectOfType<PlayerController>();	
		}

		private void OnDestroy()
		{
			Instance = null;
		}

		private void Start()
		{
		
			ChangeState1(GameState.Init);
			Ini2t();
		}

		public void ChangeState1(GameState state)
		{
		}

		public void Ini2t()
		{

			print("GamePlay Init");
			cameraController.ChaseEnable = true;
			Finished = true;
			if(level != null)
			{
				level = Instantiate(level);
			}
		
			else
			{
				level = elementAnalysis.GenerateLevel(Random.Range(0.6f, 1f));
			}
		
			level.transform.SetParent(transform);
			level.Init();
			character.MoveTo(level.CurrentPart.GetPointAtTime(GameConstanst.StartPosition / level.CurrentPart.Length));
			Speed = level.CurrentPart.Speed;
			EarnedGem = 0;
		
		}


		class CHusjkjzoskc7c
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}

		class Kcojvis8ckoa
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}
		class Kkxcjoasdic9mas
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}
		public void Play()
		{	
			ChangeState1(GameState.Play);		
		}

		public void Lose()
		{
			ChangeState1(GameState.Lose);
		}

		public void Win()
		{
			ChangeState1(GameState.Win);
		}

   
		public void DoFrame()
		{
			if(!Finished)
			{
				level.DoFrame();
			}
		
			character.DoFrame();

			if (!character.HitObstacle)
			{
				cameraController.Chase(character.FollowCam);
			}

		}
	
		public void Land()
		{

			if(Finished)
			{
				return;
			}
		
			Finished = true;
	  
		}
	
		public void SpeedUp()
		{
			var targetSpeed = level.CurrentPart.Speed * 8f;
			StartCoroutine(IEChangeSpeed(targetSpeed, 5));
		}

		Coroutine speedDownCoroutine;
		public void SpeedDown()
		{
			var targetSpeed = level.CurrentPart.Speed * 0.8f;
			if(Speed <= targetSpeed)
			{
				return;
			}

			if(speedDownCoroutine != null)
				StopCoroutine(speedDownCoroutine);
			speedDownCoroutine = StartCoroutine(IEChangeSpeed(targetSpeed, 1f));
		}

		IEnumerator IEChangeSpeed(float target, float totalTime)
		{
			Speed = target;
			yield return new WaitForSeconds(totalTime);
			Speed = level.CurrentPart.Speed;
		}

		public void ShowKeyAmount()
		{
		
		}

		private void Update()
		{
			DoFrame();
		} 
		public void finish()
		{
			Finished = true;
		
		}
		public void startPlay()
		{
			Finished = false;

		}
	}
}
