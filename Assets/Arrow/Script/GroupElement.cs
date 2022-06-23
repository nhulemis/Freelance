using UnityEngine;

namespace Arrow.Script
{
	public class GroupElement : Element
	{
		public override void Init()
		{
			var elements = GetComponentsInChildren<Element>();
			for (int i = 0; i < elements.Length; i++)
			{
				elements[i].UpdatePosition();
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
		public override void OnHit(GameObject collider)
		{

		}

		public float GetLength()
		{
			var childs = GetComponentsInChildren<Element>();
			return childs.Length > 0 ? childs[childs.Length - 1].Position : 0;
		}
	}
}
