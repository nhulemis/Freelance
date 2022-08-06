
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

#if AADOTWEEN
using DG.Tweening;
#endif

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge to move the two big walls continuously
	/// </summary>
	public class CountdownLogic : MonoBehaviorHelper
	{
    public class ProductItem
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    public class CKjioaw
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    public class KLCJiajwl
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }

    
    public class Kciwlzxc
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    
    public class CHuaiwsczx
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    
    public class Ciouawlkjix
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    public class Caixaw3f
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
		public Transform wallLeft;
		public Transform wallRight;

		float time = 4f;

		float posStartLeft;
		float posStartRight;

		float posLeft
		{
			set
			{
				wallLeft.localPosition = new Vector3(value, 0, 50);
			}
		}

		float posRight
		{
			set
			{
				wallRight.localPosition = new Vector3(value, 0, 50);
			}
		}

		public float GetDistance()
		{
			return wallRight.localPosition.x - wallLeft.localPosition.y;
		}

		void OnEnable()
		{
			EventManager.OnPlayerFail += StopAllTween;
			EventManager.OnAddOnePoint += StartCountDown;
			EventManager.OnGameEnded += StopAllTween;

			EventManager.OnClickedGameOverButtons += OnClickedGameOverButtons;
		}

		void OnDisable()
		{
			EventManager.OnPlayerFail -= StopAllTween;
			EventManager.OnAddOnePoint -= StartCountDown;
			EventManager.OnGameEnded -= StopAllTween;

			EventManager.OnClickedGameOverButtons -= OnClickedGameOverButtons;
		}

		void OnClickedGameOverButtons(bool success)
		{
			if(success)
				GoBack(null);
		}

		void Start()
		{
			posStartLeft = mainCameraManager.left.localPosition.x;
			posStartRight = mainCameraManager.right.localPosition.x;

			posLeft = posStartLeft;
			posRight = posStartRight;
		}

		void StopAllTween()
		{
			#if AADOTWEEN
			wallLeft.DOKill();
			wallRight.DOKill();
			#endif
		}

		public void Restart()
		{
			StopAllTween();
			GoBack(null);
		}

		public void StartCountDown()
		{
			StopCountdown(() => {
				GoIn();
			});
		}

		public void StopCountdown()
		{
			StopCountdown(null);
		}

		public void StopCountdown(Action callback)
		{
			StopAllTween();

			GoBack(callback);
		}

		public void GameOver()
		{
			playerManager.SendMessage("LaunchGameOver");
		}

		void GoIn()
		{
			#if AADOTWEEN
			wallLeft.DOKill();
			posLeft = posStartLeft;
			wallLeft.DOLocalMoveX(0,time).SetDelay(time * 0.1f);

			wallRight.DOKill();
			posRight = posStartRight;
			wallRight.DOLocalMoveX(0,time).SetDelay(time * 0.1f);
			#endif

		}

		void GoBack(Action callback)
		{
			float timeRatio =  0.3f * time * ((posStartLeft - wallLeft.localPosition.x) / posStartLeft);

			#if AADOTWEEN
			wallLeft.DOKill();
			wallLeft.DOLocalMoveX(posStartLeft,timeRatio).SetEase(Ease.OutBounce);

			wallRight.DOKill();
			wallRight.DOLocalMoveX(posStartRight,timeRatio).SetEase(Ease.OutBounce).OnComplete(() => {
				if(callback != null)
					callback();
			});
			#endif
		}
	}
}