
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
	/// Script attached to diamond GameObject
	/// </summary>
	public class ItemDiamond : ItemBase
	{
		float originalScale = 0.3f;

        public ParticleSystem ParticleSystem;

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

			poolingSystem.InstantiateAPS(Constants.ParticleSystem_DIAMOND,transform.position,Quaternion.identity);

			DOAnimTrigger();
		}

		public override void OnTriggerEnterOther()
		{
			#if AADOTWEEN
			transform.DOKill();

			if(transform.position.IsVisibleFrom(mainCamera))
				transform.DOScale(Vector3.zero,0.3f);

			#endif
		}


		public new void OnDisable()
		{
			base.OnDisable();
			//		gameManager.SpawnItemDiamond();
		}


		void DOAnimTrigger()
		{
			#if AADOTWEEN
			transform.DOScale(Vector3.one*2f,0.1f).OnComplete(() => {
				transform.DOScale(Vector3.zero,0.3f).OnComplete(() => {
					//				gameManager.SpawnItemDiamond();
					gameObject.SetActive(false);
				});
			});
			#endif
		}

		public override void DODisable()
		{

			gameObject.SetActive(false);
			//		gameManager.SpawnItemDiamond();
		}
	}
}