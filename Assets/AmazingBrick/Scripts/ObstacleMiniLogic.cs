
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/

using UnityEngine;
using System.Collections;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Obstacle Mini are the cube in the background. This class handle the creation
	/// </summary>
	public class ObstacleMiniLogic : ObstacleHelper 
	{
		BackgroundLayer background;

		public SpriteRenderer srLeft;

		public SpriteRenderer srRight;


		public Color colorBack1;
		public Color colorBack2;
		public Color colorForeground;

		float minScaleX1 = 1f; //10f
		float maxScaleX1 = 15; //20f

		float minScaleY1 = 5f;
		float maxScaleY1 = 9f;

		float minScaleX2 = 20f; //10f
		float maxScaleX2 = 40f; //20f

		float minScaleY2 = 10f;
		float maxScaleY2 = 15f;

		float minScaleXForeground = 0.2f; //10f
		float maxScaleXForeground = 5f; //20f

		float minScaleYForeground = 3f;
		float maxScaleYForeground = 6f;

		void Awake()
		{
			srLeft = left.GetComponent<SpriteRenderer>();
			srRight = right.GetComponent<SpriteRenderer>();
		}

		void OnEnable()
		{
			left.localPosition = desfaultPosLeft;
			right.localPosition = desfaultPosRight;	
		}

		void OnDisable()
		{
			StopAllCoroutines();

			PoolingSystem.DestroyAPS(gameObject);
		}

	
        public class FXULOZLHTIDIZLMT
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

        public class QSAZHIUWUPLGILKBSTHDHBAO
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
	public void SpawnNewObstacleMini()
		{
			gameManager.SpawnMini(this.background);
		}

		public override float Create(BackgroundLayer background)
		{
			this.background = background;

			if(background == BackgroundLayer.Background1Layer)
			{
				float height = 2f * camBackground1.orthographicSize;
				float width = height * camBackground1.aspect;

				left.localPosition = new Vector3(-width/2,0,0);
				right.localPosition = new Vector3(+width/2,0,0);

				var scaleLeft = left.transform.localScale;
				scaleLeft.x = Random.Range(minScaleX1,maxScaleX1);
				scaleLeft.y = Random.Range(minScaleY1,maxScaleY1);
				left.transform.localScale = scaleLeft;


				var scaleRight = right.transform.localScale;
				scaleRight.x = Random.Range(minScaleX1,maxScaleX1);
				scaleRight.y = Random.Range(minScaleY1,maxScaleY1);
				right.transform.localScale = scaleRight;

				SetLayers(BackgroundLayer.Background1Layer, colorBack1);
			}
			else if(background == BackgroundLayer.Background2Layer)
			{

				float height = 2f * camBackground2.orthographicSize;
				float width = height * camBackground2.aspect;

				left.localPosition = new Vector3(-width/2,0,0);
				right.localPosition = new Vector3(+width/2,0,0);


				var scaleLeft = left.transform.localScale;
				scaleLeft.x = Random.Range(minScaleX2,maxScaleX2);
				scaleLeft.y = Random.Range(minScaleY2,maxScaleY2);
				left.transform.localScale = scaleLeft;


				var scaleRight = right.transform.localScale;
				scaleRight.x = Random.Range(minScaleX2,maxScaleX2);
				scaleRight.y = Random.Range(minScaleY2,maxScaleY2);
				right.transform.localScale = scaleRight;

				SetLayers(BackgroundLayer.Background2Layer, colorBack2);
			}
			else if(background == BackgroundLayer.ForegroundLayer)
			{
				float height = 2f * camForeground.orthographicSize;
				float width = height * camForeground.aspect;

				left.localPosition = new Vector3(-width/2,0,0);
				right.localPosition = new Vector3(+width/2,0,0);


				var scaleLeft = left.transform.localScale;
				scaleLeft.x = Random.Range(minScaleXForeground,maxScaleXForeground);
				scaleLeft.y = Random.Range(minScaleYForeground,maxScaleYForeground);
				left.transform.localScale = scaleLeft;


				var scaleRight = right.transform.localScale;
				scaleRight.x = Random.Range(minScaleXForeground,maxScaleXForeground);
				scaleRight.y = Random.Range(minScaleYForeground,maxScaleYForeground);
				right.transform.localScale = scaleRight;

				SetLayers(BackgroundLayer.ForegroundLayer, colorForeground);
			}
			else 
			{
				gameObject.SetActive(false);
			}

			return transform.position.y;
		}


		void SetLayers(BackgroundLayer background, Color c)
		{
			string layerName = background.ToString();

			gameObject.layer = LayerMask.NameToLayer(layerName);
			srLeft.gameObject.layer = LayerMask.NameToLayer(layerName);

			srRight.gameObject.layer = LayerMask.NameToLayer(layerName);


			srLeft.color = c;

			srRight.color = c;

		}
	}
}