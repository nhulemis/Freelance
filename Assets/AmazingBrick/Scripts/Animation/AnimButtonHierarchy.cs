
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/


using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

#if AADOTWEEN
using DG.Tweening;
#endif

namespace AppAdvisory.AmazingBrick
{

    /// <summary>
    /// Class in charge to animate button horizontaly, one to left, then one to right etc...
    /// </summary>
    public class AnimButtonHierarchy : MonoBehaviour
    {
        public float time = 1;
        public float delay = 0;

        bool interectable
        {
            set
            {
                GetComponent<CanvasGroup>().interactable = value;
                GetComponent<CanvasGroup>().blocksRaycasts = value;

                ActivateInterectable(value);
            }
        }

        public void DoAnimIn()
        {
            interectable = false;

            DoAnimIn(null);
        }

        void ActivateInterectable(bool b)
        {
            var g = GetComponentsInChildren<CanvasGroup>(true);

			#if AADOTWEEN
            foreach (var c in g)
            {
                c.DOKill();
                c.transform.DOKill();
                c.GetComponent<RectTransform>().DOKill();
                c.interactable = b;
                c.blocksRaycasts = b;
            }
			#endif
        }

        public void DoAnimIn(Action callback)
        {


            interectable = false;

			#if AADOTWEEN
            foreach (Transform t in transform)
            {
                t.DOKill();
                t.GetComponent<RectTransform>().DOKill();
            }
			#endif
            int mult = 1;

			#if AADOTWEEN

            foreach (Transform t in transform)
            {
                var pos = t.GetComponent<RectTransform>().anchoredPosition;

                pos.x = mult * 2 * Screen.width;
                mult *= -1;
                t.GetComponent<RectTransform>().anchoredPosition = pos;
                t.GetComponent<RectTransform>().DOLocalMoveX(0, time)
                    .SetDelay(delay + 0.1f)
                    .SetEase(Ease.OutBack, 0.6f, time)
                    .OnComplete(() =>
                    {

                        interectable = true;

                        if (callback != null)
                            callback();
                    });
            }
			#endif
        }
        public void DoAnimOut()
        {
            DoAnimOut(null);
        }


        public void DoAnimOut(Action callback)
        {
            interectable = false;

			#if AADOTWEEN

            foreach (Transform t in transform)
            {
                t.DOKill();
                t.GetComponent<RectTransform>().DOKill();
            }

			#endif

            int mult = 1;

            foreach (Transform t in transform)
            {
                var pos = t.GetComponent<RectTransform>().anchoredPosition;

                float xOrigin = pos.x;

				#if AADOTWEEN
                t.GetComponent<RectTransform>().DOLocalMoveX(mult * 2 * Screen.width, 1)
                    .SetDelay(delay)
                    .SetEase(Ease.OutBack, 0.6f, time)
                    .OnComplete(() =>
                    {
                        gameObject.SetActive(false);
                        var p = t.GetComponent<RectTransform>().anchoredPosition;
                        p.x = xOrigin;
                        t.GetComponent<RectTransform>().anchoredPosition = pos;

                        interectable = false;

                        if (callback != null)
                            callback();
                    });
				#endif
                mult *= -1;
            }
        }
    }
}