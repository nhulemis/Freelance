using UnityEngine;

namespace Arrow.Script
{
	public class PlayerController : MonoBehaviour
	{
		public static PlayerController instance;
		private GameObject head;
		public Camera mainCamera;
		public Transform FollowCam;
		private CameraController camController;
		public bool HitObstacle;
		public ArrowsController arrowController;

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
		//Private Data
		private Level level;
		private bool canControll;


		private void Awake()
		{
			if (!instance) instance = this;

			
			
			
			
			
			//Init
			arrowController = this.GetComponentInChildren<ArrowsController>();
		}
		public void Init()
		{
			//playerAnimationManager.Init();

		}
		public void MoveTo(Vector2 initPos)
		{
			this.transform.position = initPos;
		}

		// Start is called before the first frame update
		void Start()
		{
			//mainCamera = Camera.main;
			camController = FindObjectOfType<CameraController>();
			head = this.transform.GetChild(0).gameObject;
			level = FindObjectOfType<Level>();
			canControll = true;

		}

		// Update is called once per frame
		void Update()
		{
			//DoSwpie();
		}
		public void DoFrame()
		{
			//camController.Chase(this.transform);
			if(canControll)
				DoSwpie();
		}
		private void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.CompareTag("Finish"))
			{
				Gameplay.Instance.finish();
				canControll = false;
				arrowController.freeArrows1();
				//UiManager.instance.win();
			}
		
		
		}
		Vector3 touchPosition, touchPositionOrigin, playerPositionOrigin;
		private bool pressed, isTouchDown, flag, jumping = false;
		private float headY, jumpTime, jumpTotalTime, laneTime, num, roadWith = 0;
		private float startVelocity = 5f;
		private float gravity = 9.8f;
		public void DoSwpie()
		{
			roadWith = 2;

			touchPosition = Vector3.one;
			flag = Input.GetMouseButton(0);
			if (flag)
			{
				touchPosition = Input.mousePosition;
			}

			if (!flag)
			{
		
				isTouchDown = false;
			}
			else
			{

				touchPosition.z = 5.5f;
				Vector3 vector = mainCamera.ScreenToWorldPoint(touchPosition);
				vector.x *= 2.2f;
				if (!isTouchDown)
				{
					isTouchDown = true;
					touchPositionOrigin = vector;
					playerPositionOrigin = head.transform.localPosition;
				}

				num = Mathf.Clamp(playerPositionOrigin.x + (vector.x - touchPositionOrigin.x), -roadWith, roadWith);
				Vector3 position2 = head.transform.localPosition;
				position2.x = laneTime = Mathf.Lerp(position2.x, num, 45f * Time.smoothDeltaTime);
			}
			//print("lane time" + laneTime);

			//laneTime = Mathf.Clamp(laneTime, -roadWith, roadWith);
			head.transform.localPosition = new Vector3(
				laneTime,
				headY,
				head.transform.localPosition.z);

		
			headY = startVelocity * Mathf.Sin(Mathf.Deg2Rad * 90) * jumpTime - 0.5f * gravity * jumpTime * jumpTime;
		}

	

	}
}
