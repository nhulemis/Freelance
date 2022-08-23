
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/

using UnityEngine;
using System.Collections;
using AppAdvisory;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Despawn ParticleSystem when they finished their animation
	/// </summary>
	public class AutoDespawnShurikenParticleSystem : MonoBehaviorHelper 
	{
		void OnEnable()
		{
			StartCoroutine("CheckIfAlive");
		}

		void OnDisable()
		{
			StopCoroutine("CheckIfAlive");

			PoolingSystem.DestroyAPS(gameObject);
		}

		IEnumerator CheckIfAlive ()
		{
			ParticleSystem ps = this.GetComponent<ParticleSystem>();

			if(ps != null)
			{
				while(true && ps != null)
				{
					yield return new WaitForSeconds(0.5f);
					if(!ps.IsAlive(true))
					{
						#if UNITY_3_5
						this.gameObject.SetActiveRecursively(false);
						#else
						this.gameObject.SetActive(false);

						#endif

						break;
					}
				}
			}
			else
			{
				while(true)
				{
					yield return new WaitForSeconds(0.5f);

					if(!transform.IsVisibleFrom(mainCamera))
					{
						yield return new WaitForSeconds(2f);

						#if UNITY_3_5
						this.gameObject.SetActiveRecursively(false);
						#else
						this.gameObject.SetActive(false);

						#endif

					}

				}
			}

			//print("despawn : " + name);
		}
	}
}