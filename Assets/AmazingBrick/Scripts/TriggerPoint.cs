
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
	/// Class in charge to listen when the player get a point
	/// </summary>
	public class TriggerPoint : MonoBehaviorHelper 
	{
		public ObstacleLogic obstacleLogic;

		Collider2D _collider;

		void Awake()
		{
			_collider = GetComponent<Collider2D>();
		}

		void OnEnable()
		{
			_collider.enabled = true;
			EventManager.OnPlayerFail += DOCancelInvoke;
			EventManager.OnGameEnded += DOCancelInvoke;
		}

		void OnDisable()
		{
			EventManager.OnPlayerFail -= DOCancelInvoke;
			EventManager.OnGameEnded -= DOCancelInvoke;
		}

		void OnTriggerEnter2D(Collider2D other)
		{
			if(other.name.Contains("Player"))
			{
				_collider.enabled = false;
				gameManager.UpdatePoint(obstacleLogic.point);
				obstacleLogic.DOTextAnim();
			}
		}

		void DOCancelInvoke()
		{
			DOCancelInvoke(true);
		}

		void DOCancelInvoke(bool success)
		{
			if(!success)
				return;

			CancelInvoke();
			obstacleLogic.CancelInvoke();
		}
	}
}