
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
using AppAdvisory;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class attached to Obstacle prefaabs (Rectangle and carre in Prefabs/Obstacles folder)
	/// This call will dispawned all obstacles who are out of screen
	/// </summary>
	public class CheckIfOutOfScreen : MonoBehaviorHelper
	{

		private Renderer[] m_renderers;


		Camera m_cam;
		Camera cam
		{
			get
			{
				if(m_cam == null)
				{
					GetCam();
				}

				return m_cam;
			}
		}

		void GetCam()
		{
			if(gameObject.layer ==  LayerMask.NameToLayer("Background1Layer"))
			{
				m_cam = camBackground1;
			}
			else if(gameObject.layer ==  LayerMask.NameToLayer("Background2Layer"))
			{
				m_cam = camBackground2;
			}
			else
			{
				m_cam = Camera.main;
			}

		}

		void Awake()
		{
			m_renderers = GetComponentsInChildren<SpriteRenderer>(true);
		}

		void OnEnable()
		{
			StopAllCoroutines();

			LaunchCoUpdate();
		}


		void OnDisable()
		{
			//		gameObject.DestroyAPS();
			StopAllCoroutines();
			m_cam = null;
		}

		void LaunchCoUpdate()
		{
			if (!Application.isPlaying)
				return;

			StartCoroutine(CoUpdate());
		}

		void StopCoUpdate()
		{
			var mini = GetComponent<ObstacleMiniLogic>();

			if(mini)
				mini.SpawnNewObstacleMini();


			transform.gameObject.SetActive (false);
			StopAllCoroutines();
		}

		/// <summary>
		/// Verify each seconds if the obstacle is out of screen.
		/// </summary>
		IEnumerator CoUpdate()
		{
			yield return new WaitForSeconds(1);

			GetCam();

			yield return new WaitForSeconds(1);

			while(true)
			{


				if(IsBehindAndNotVisibleByCamera())
				{

					break;
				}

				yield return new WaitForSeconds(1);
			}


			StopCoUpdate();


		}

		/// <summary>
		/// Check if the obstacle is out of screen.
		/// </summary>
		/// <summary>
		/// Check if the obstacle is out of screen.
		/// </summary>
		bool IsBehindAndNotVisibleByCamera()
		{
			if (playerTransform == null)
				return true;

			Vector3 forward = transform.TransformDirection(Vector3.up);
			Vector3 toOther = cam.transform.position - transform.position;

			if (Vector3.Dot (forward, toOther) > cam.GetHeight() / 3f)
			{
				for(int i = 0; i < m_renderers.Length; i++)
				{

					if(!m_renderers[i].IsVisibleFrom(cam))
					{
						return true;
					}
				}

				return false;
			}

			return false;
			//		}
		}

	}
}