
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
	/// BETA - for a next version
	/// </summary>
	public class ItemSpaceTrap : ItemBase
	{
		float originalScale = 0.4f;

		//	public EllipsoidParticleSystemEmitter ParticleSystem;

		public override void Create()
		{
			gameObject.SetActive(true);

			#if AADOTWEEN
			transform.DOKill();
			#endif

			transform.localScale = originalScale * Vector2.one;

			var e = transform.eulerAngles;
			e.z = -30f;
			transform.eulerAngles = e;

			DoRandomRotate();
			DoRandomScale(originalScale);
		}

		public override void OnTriggerEnterPlayer()
		{
			#if AADOTWEEN
			transform.DOKill();
			#endif

			Util.SetDiamond(Util.GetDiamond() + 1);

			//		ParticleSystem.Emit();

			DOAnimTrigger();

			playerTransform.GetComponent<Collider2D>().enabled = false;
			playerTransform.GetComponent<Rigidbody2D>().isKinematic = true;
			playerManager.isInvicible = true;

			Vector2 destination = new Vector2(0, playerTransform.position.y + 100);


			#if AADOTWEEN
			playerTransform.DOMove(destination, 1)
				.OnComplete(() => {
					playerTransform.GetComponent<Collider2D>().enabled = true;
					playerTransform.GetComponent<Rigidbody2D>().isKinematic = false;
					DOVirtual.DelayedCall(5, () => {
						playerManager.isInvicible = false;
					});
				});
			#endif
		}

		public override void OnTriggerEnterOther()
		{
			#if AADOTWEEN
			transform.DOKill();

			if(transform.position.IsVisibleFrom(mainCamera))
				transform.DOScale(Vector3.zero,0.3f);
			#endif
		}


		void DOAnimTrigger()
		{
			#if AADOTWEEN
			transform.DOScale(Vector3.one*2f,0.1f).OnComplete(() => {
				transform.DOScale(Vector3.zero,0.3f);
			});
			#endif
		}
	}
}