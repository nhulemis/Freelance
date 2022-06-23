using UnityEngine;

namespace Arrow.Script
{
	public abstract class LevelPart : MonoBehaviour
	{
		public float Width => 3;
		[SerializeField] float speed = 10;
		public float Speed => speed;
		public LevelPart Backward;
		public LevelPart Next;

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

		class HSUckvoawopvp4
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}
		public abstract void Init();
		public abstract Vector3 GetPointAtTime(float t);
		public abstract Quaternion GetDirectionAtTime(float t);
		public abstract float Length { get; }
		public abstract Vector3 EndPoint { get; }
		public abstract Vector3 OutDirection { get; }
		public abstract bool IsAirLine { get; }

		public virtual void Enter()
		{

		}

		public virtual void Exit()
		{

		}

		public void SetActiveEnvironm1ent(bool _active)
		{
			var environmentParts = GetComponentsInChildren<EnvironmentPart>(true);
			foreach (var e in environmentParts)
			{
				e.gameObject.SetActive(_active);
			}
		}
	}
}
