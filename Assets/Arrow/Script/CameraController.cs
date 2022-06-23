using UnityEngine;

namespace Arrow.Script
{
	public class CameraController : MonoBehaviour
	{
		// This value will change at the runtime depending on target movement. Initialize with zero vector.
		public float velocity = 50;
		public float smoothRotate = 50;
		public Vector3 offset;
		public bool ChaseEnable { get; set; } = true;
		
		
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

		public static CameraController instance;
		private void Awake()
		{
			if (!instance) instance = this;
			else if (instance != this) Destroy(this.gameObject);
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

		class SHhcuaowjcuas10ci
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}


		public void Chase(Transform target)
		{
			if (!ChaseEnable)
			{
				return;
			}
			transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, velocity * Time.smoothDeltaTime);
			
			
			
			
			transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, smoothRotate * Time.smoothDeltaTime);
		}

		public void ChaseImmediate(Transform target)
		{
			transform.position = target.transform.position + offset;
			transform.rotation = target.rotation;
		}
		Vector3 newOfsset = new Vector3(0, 7, -10);

		public void finalChase(Transform target)
		{
			transform.position = Vector3.Lerp(transform.position, target.transform.position + newOfsset, velocity * Time.smoothDeltaTime);
		}

	}
}
