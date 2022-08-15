
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

namespace AppAdvisory.AmazingBrick
{
	public class SpritePlusBorderMaker : MonoBehaviour 
	{
		public SpriteRenderer sprite;
		public SpriteRenderer border;
		float diff = 0.30f;
		public bool isCircular = false;

		void OnEnable()
		{
			sprite.transform.position = border.transform.position;

			if(isCircular)
				diff *= 0.25f;

			sprite.transform.localScale = GetScale();
		}

		Vector3 GetScale()
		{
			return GetScale(1f);
		}

		Vector3 GetScale(float beat)
		{
			var localScaleBorder = border.transform.localScale;
			var lossyScaleBorder = border.transform.lossyScale;

			Vector3 scale = sprite.transform.localScale;
			scale.x = localScaleBorder.x - beat * diff / lossyScaleBorder.x;
			scale.y = localScaleBorder.y - beat * diff / lossyScaleBorder.y;

			return scale;
		}
	}
}