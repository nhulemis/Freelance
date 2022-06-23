using UnityEngine;

namespace Arrow.Script
{
	public class Level : MonoBehaviour
	{
		[SerializeField] int snakeLength;
		public int SnakeLength
		{
			get => snakeLength;
			set
			{
				snakeLength = value;
			}
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

		class CHusjxoacm6x
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}
		public float Width => CurrentPart.Width;
		[SerializeField] float flySpeedMultiply = 2f;
		[SerializeField] LevelPart[] levelParts;
		public LevelPart CurrentPart => levelParts[Mathf.Clamp(iPath, 0, levelParts.Length - 1)];
		int iPath = 0;
		float travelDistance = GameConstanst.StartPosition;
		float totalPartTravelDistance = 0f;
		public float TravelDistance => travelDistance;
		public float TravelTime => travelDistance / CurrentPart.Length;
		public float Length { private set; get; } = 0f;
		public float GlobalTravelDistance => totalPartTravelDistance + travelDistance;
		public float speed=80f;
		public void DoFrame()
		{
			travelDistance += Time.smoothDeltaTime *speed;
			if (travelDistance > CurrentPart.Length)
			{
				travelDistance = 0;
				totalPartTravelDistance += CurrentPart.Length;
				CurrentPart.Exit();
				iPath++;
				CurrentPart.Enter();

				CurrentPart.SetActiveEnvironm1ent(true);
				if (CurrentPart.Next != null)
				{
					CurrentPart.Next.SetActiveEnvironm1ent(true);
				}
				if (CurrentPart.Backward != null)
				{
					CurrentPart.Backward.SetActiveEnvironm1ent(false);
				}
				if (iPath >= levelParts.Length)
				{
					//Gameplay.Instance.Win();
					return;
				}
			
				return;
			}
			Vector3 newpos = CurrentPart.GetPointAtTime(travelDistance / CurrentPart.Length);
			PlayerController.instance.transform.rotation = CurrentPart.GetDirectionAtTime(travelDistance / CurrentPart.Length);
			PlayerController.instance.transform.position = newpos;

		}

		public void ThrowBack(float distance)
		{
			travelDistance -= distance;
	  
		}

		EnvironmentPart[] environmentParts;
		public void Init()
		{
			Length = 0;
			totalPartTravelDistance = 0f;
			levelParts = GetComponentsInChildren<LevelPart>();
			for (int i = 0; i < levelParts.Length; i++)
			{
				levelParts[i].Init();
				if(levelParts[i].GetType() != typeof(FinishLineController))
					Length += levelParts[i].Length;
			}
			iPath = 0;
		
		}

		public void RefreshEnvironment()
		{
			environmentParts = GetComponentsInChildren<EnvironmentPart>(true);
		
		}

		private void OnValidate()
		{
			if (!isActiveAndEnabled)
			{
				return;
			}
			if (Application.isPlaying)
			{
				return;
			}

			ValidateLevelPart();
		}

		public void ValidateLevelPart()
		{
			levelParts = GetComponentsInChildren<LevelPart>();
			for (int i = 0; i < levelParts.Length; i++)
			{
				if (i < levelParts.Length - 1)
				{
					levelParts[i].Next = levelParts[i + 1];
				}
				if (i > 0)
				{
					levelParts[i].Backward = levelParts[i - 1];
					var dir = levelParts[i].transform.position - levelParts[i - 1].EndPoint;
					levelParts[i].transform.rotation = Quaternion.LookRotation(levelParts[i - 1].OutDirection, Vector3.up);
					levelParts[i].transform.position = levelParts[i - 1].EndPoint;
				}
			}
			RefreshEnvironment();
		}

	
		public void updateSpeedValue(float newSpeedValue)
		{
			speed = newSpeedValue;
		}

		[ContextMenu("Manual Init")]
		public void ManualInit()
		{
			ValidateLevelPart();
		}
	}
}
