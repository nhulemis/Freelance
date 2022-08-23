
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
	/// Class in charge to display obstacle in the game
	/// </summary>
	public class ObstacleLogic : ObstacleHelper 
	{

		public Collider2D colliderPoint;

		public Transform numTextTransform;
		public Text numText;


		[NonSerialized] public int point;


		void Awake()
		{
			PrepareDoTextAnim();

			this.numText.gameObject.SetActive(true);
			top.gameObject.SetActive(true);
			bottom.gameObject.SetActive(true);
			left.gameObject.SetActive(true);
			right.gameObject.SetActive(true);


		}

		void OnEnable()
		{
			EventManager.OnPlayerFail += OnPlayerFail;
			EventManager.OnGameEnded += OnGameEnded;

			Reset();
		}

		void OnPlayerFail()
		{
			StopAllTweens();
		}

		void OnGameEnded()
		{
			StopAllTweens();
			gameObject.SetActive(false);
		}

		void OnDisable()
		{
			EventManager.OnPlayerFail -= OnPlayerFail;
			EventManager.OnGameEnded -= OnGameEnded;

			Reset();

			gameObject.DestroyAPS();
		}


		public override void Reset()
		{


			StopAllTweens();



			left.localPosition = desfaultPosLeft;
			right.localPosition = desfaultPosRight;
			top.localPosition = desfaultPosTop;
			bottom.localPosition = desfaultPosBottom;

			colliderPoint.enabled = true;



			this.numText.gameObject.SetActive(true);
			top.gameObject.SetActive(true);
			bottom.gameObject.SetActive(true);
			left.gameObject.SetActive(true);
			right.gameObject.SetActive(true);
		}

		void StopAllTweens()
		{
			//		this.numText.DOKill();

			#if AADOTWEEN
			left.DOPause();
			right.DOPause();
			bottom.DOPause();
			top.DOPause();
			#endif

			StopAllCoroutines();
			CancelInvoke();


		}

		void SetText(int num)
		{

			this.numText.text = num.ToString();
			Color c = this.numText.color;
			c.a = 0.5f;
			this.numText.color = c;

			this.numTextTransform.localPosition = new Vector3(0.5f * (left.localPosition.x + right.localPosition.x), 0, 0);
			this.numTextTransform.localScale = new Vector3(0.5f,0.5f,1);

			gameObject.name = this.numText.text;

		}




		public override float Create(int num, float lastPosX)
		{



			Reset();

			SetText(num);

			StopAllTweens();


			gameObject.SetActive(true);


			IsActive = true;

			this.point = num;


			float decalHorizontal = 0; //UnityEngine.Random.Range(-5f,5f);

			if(lastPosX < 0)
				//		if(UnityEngine.Random.Range(-1f,1f)< 0)
			{
				decalHorizontal = UnityEngine.Random.Range(-2f,+5f);
			}
			else
			{
				decalHorizontal = UnityEngine.Random.Range(-5f,+2f);
			}





			left.localPosition += decalHorizontal * Vector3.right;
			right.localPosition += decalHorizontal * Vector3.right;

			top.localPosition += decalHorizontal * Vector3.right + UnityEngine.Random.Range(-1f,1f) * Vector3.up;
			bottom.localPosition += decalHorizontal * Vector3.right + UnityEngine.Random.Range(-1f,1f) * Vector3.up;

			gameObject.SetActive(true);
			top.gameObject.SetActive(true);
			bottom.gameObject.SetActive(true);
			left.gameObject.SetActive(true);
			right.gameObject.SetActive(true);

			float space = 0;




			float temp = 3f - point/5f;

			if(temp >= 0)
				space = temp;
			else
				space = GetSpace();


			left.localPosition -= space * Vector3.right;
			right.localPosition += space * Vector3.right;


			if(this.point <= 2)
			{
				top.gameObject.SetActive(false);
				bottom.gameObject.SetActive(false);

			}
			else
			{
				if(this.point <= 5)
				{
					if(UnityEngine.Random.Range(0,2) == 0)
					{
						bottom.gameObject.SetActive(false);
					}
					else
					{
						top.gameObject.SetActive(false);
					}
				}
				else
				{

					if(UnityEngine.Random.Range(0,5) == 0)
					{
						if(UnityEngine.Random.Range(0,2) == 0)
						{
							bottom.gameObject.SetActive(false);
						}
						else
						{
							top.gameObject.SetActive(false);
						}
					}
				}
			}

			if(top.gameObject.activeInHierarchy)
			{
				top.localPosition += UnityEngine.Random.Range(-2f,2f) * Vector3.right;
				top.localPosition += decalHorizontal * Vector3.right + UnityEngine.Random.Range(-1f,5f) * Vector3.up;
			}

			if(bottom.gameObject.activeInHierarchy)
			{
				bottom.localPosition += UnityEngine.Random.Range(-2f,2f) * Vector3.right;
				bottom.localPosition += decalHorizontal * Vector3.right + UnityEngine.Random.Range(-5f,1f) * Vector3.up;
			}



			//		var moveInOutWhenVisibles = gameObject.GetComponentsInChildren<MoveInOutWhenVisible>(false);


			var posTemp = transform.position;

			posTemp += Vector3.right * UnityEngine.Random.Range(-5f,+5f);

			return this.numTextTransform.localPosition.y;
		}



		void Update()
		{
			bool doDespawn = 
				!top.gameObject.activeInHierarchy
				&&
				!bottom.gameObject.activeInHierarchy
				&&
				!left.gameObject.activeInHierarchy
				&&
				!right.gameObject.activeInHierarchy
				;


			if(doDespawn)
			{
				Despawn();	
			}
		}


		void Despawn()
		{

			gameObject.SetActive(false);
			gameManager.SpawnObstacle();

			IsActive = false;

		}


		float GetSpace()
		{
			return UnityEngine.Random.Range(-1f,3f);
		}

		//	Tweener tweenTextAnim;

		void PrepareDoTextAnim()
		{

			//		float time = 0.3f;
			//		tweenTextAnim = this.numText
			//			.DOFade(1f,time)
			//			.OnUpdate(() => {
			//				Color c = this.numText.color;
			//				this.numTextTransform.localScale = new Vector3(2*c.a*c.a, 2*c.a*c.a, 1);
			//			})
			//			.OnComplete (() => {
			//				Color c = this.numText.color;
			//				this.numTextTransform.localScale = new Vector3(2*c.a*c.a, 2*c.a*c.a, 1);
			//			})
			//			.SetAutoKill(false)
			//			.Pause();
		}

	
        public class OHUKNNCUFH
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class EXKBQIHWPLSK
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class HBAXPTUXIQMQBAVHXWEWTGMDYLBLQRPVHP
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}
	public void DOTextAnim()
		{
			EmitParticleSystem();

			//		tweenTextAnim.Restart();
			float time = 0.3f;

			#if AADOTWEEN
			this.numTextTransform.DOScale(Vector3.one * 3, time/3f)
				.OnComplete(() => {
					this.numTextTransform.DOScale(Vector3.one , time);
				});

			this.numText.DOFade(1f,time);
			#endif
		}

		void EmitParticleSystem()
		{
			poolingSystem.InstantiateAPS(Constants.ParticleSystem_POINT, this.numText.transform.position, Quaternion.identity);
		}
	}
}