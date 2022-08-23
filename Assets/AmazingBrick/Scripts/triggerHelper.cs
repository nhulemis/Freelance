
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/

using UnityEngine;
using System;
using System.Collections;
using UnityEngine.Events;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class to send information when trigger happens
	/// </summary>
	[Serializable]
	public class TriggerHelperEvent : UnityEvent <Collider2D> {}

	/// <summary>
	/// Class to help us to listen collision in the game
	/// </summary>
	public class triggerHelper : MonoBehaviour 
	{
		public TriggerHelperEvent OnTrigger;
		Collider2D _collider;

		ItemBase itemBase;

		void Awake()
		{
			_collider = GetComponent<Collider2D>();
			itemBase = GetComponentInParent<ItemBase>();
			OnTrigger.AddListener(itemBase.OnTrigger2D);
		}

		void OnEnable()
		{
			_collider.enabled = true;


		}

		void OnTriggerEnter2D(Collider2D other)
		{
			//print("OnTriggerEnter2D with + " + other.name);

			_collider.enabled = false;
			//		//print("OnTriggerEnter2D");
			OnTrigger.Invoke(other);
		}

		void OnTriggerStay2D(Collider2D other)
		{
			_collider.enabled = false;
			//		//print("OnTriggerStay2D");
			OnTrigger.Invoke(other);
		}

		void OnTriggerExit2D(Collider2D other)
		{
			_collider.enabled = false;
			//		//print("OnTriggerExit2D");
			OnTrigger.Invoke(other);
		}

	}
}