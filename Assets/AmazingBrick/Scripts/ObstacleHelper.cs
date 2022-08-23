
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
	/// An helper class for the obstacle
	/// </summary>
	public class ObstacleHelper : MonoBehaviorHelper
	{
		public Transform left;
		public Transform right;
		public Transform top;
		public Transform bottom;
		public Vector2 desfaultPosLeft;
		public Vector2 desfaultPosRight;
		public Vector2 desfaultPosTop;
		public Vector2 desfaultPosBottom;

		public bool IsActive;


		public float GetPositionTOP_Y()
		{
			if(top != null)
				return top.transform.position.y;

			return left.transform.position.y;
		}

		public virtual float Create(int num, float lastPosX){return -1;}

		public virtual float Create(BackgroundLayer background){return -1;}

		public virtual void Reset(){}


		public virtual void onSpawnedEvent(){}

		public virtual void onDespawnedEvent(){}
	}
}