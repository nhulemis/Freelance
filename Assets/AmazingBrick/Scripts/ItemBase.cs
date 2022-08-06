
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/

using UnityEngine;
using System.Collections;

#if AADOTWEEN
using DG.Tweening;
#endif

using AppAdvisory;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge of the pooling system (to spawn obstacle prefabs), trigger start and finished event, and display points / best score / button start when nedded
	/// </summary>
	public class ItemBase : MonoBehaviorHelper
	{
		public triggerHelper triggerHelper;

		public bool isVisible
		{
			get
			{
				if(transform.position.y < playerTransform.position.y - 5)
				{
					if(!transform.position.IsVisibleFrom(mainCamera))
					{
						return false;
					}
				}

				return true;
			}
		}

		public virtual void Create()
		{
			gameObject.SetActive(true);
		} 

		protected void OnEnable()
		{
			StopAllCoroutines();
			#if AADOTWEEN
			transform.DOKill();
			#endif
			StartCoroutine(CoUpdate());
			EventManager.OnGameEnded += OnGameEnded;
		}

		public void OnDisable()
		{
			StopAllCoroutines();
			#if AADOTWEEN
			transform.DOKill();
			#endif
			//		PoolingSystem.DestroyAPS(gameObject);
			EventManager.OnGameEnded -= OnGameEnded;
		}

		void OnGameEnded()
		{
			gameObject.SetActive(false);
		}


		public void OnTrigger2D(Collider2D other)
		{
			#if AADOTWEEN
			transform.DOKill();
			#endif

			if(other.gameObject.name.Contains("Player"))
			{
				OnTriggerEnterPlayer();
			}
			else
			{
				OnTriggerEnterOther();
			}
		}

		public virtual void OnTriggerEnterPlayer(){}
		public virtual void OnTriggerEnterOther(){}
		public virtual void DODisable(){}

		void DOAnimTrigger()
		{
			#if AADOTWEEN
			transform.DOScale(Vector3.one*2f,0.1f).OnComplete(() => {
				transform.DOScale(Vector3.zero,0.3f).OnComplete(() => {

				});
			});
			#endif

		}

		IEnumerator CoUpdate()
		{
			while(true)
			{
				if(!isVisible)
				{
					break;
				}

				yield return new WaitForSeconds(1);
			}

			DODisable();
			gameObject.SetActive(false);
			StopAllCoroutines();

		}

		public void DoRandomRotate()
		{
			#if AADOTWEEN
			transform.DORotate(30 * Vector3.forward,1f,RotateMode.Fast)
				.OnComplete(() => {
					transform.DORotate(-30 * Vector3.forward,1f,RotateMode.Fast)
						.OnComplete(() => {
							DoRandomRotate();
						});
				});
			#endif
		}


		public void DoRandomScale(float originalScale)
		{
			#if AADOTWEEN
			transform.DOScale(
				Vector3.one * originalScale * 1.1f,0.25f)
				.OnComplete(() => {
					transform.DOScale(Vector3.one * originalScale,0.5f)
						.OnComplete(() => {
							DoRandomScale(originalScale);
						});
				});
			#endif
		}

	}
}