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
