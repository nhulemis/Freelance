
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
#if UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

#if AADOTWEEN
using DG.Tweening;
#endif

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// An utility class
	/// </summary>
	public static class Util
	{
		public static ObstacleLogic GetNearestObstacle(List<ObstacleLogic> list, Transform t)
		{
			return GetNearestObstacle(list,t,true);
		}

		public static ObstacleLogic GetNearestObstacle(List<ObstacleLogic> list, Transform t, bool justAbove)
		{
			ObstacleLogic obst = null;

			if(justAbove)
			{
				foreach(var o in list.FindAll(ob => ob.gameObject.activeInHierarchy && ob.transform.position.y > t.position.y))
				{
					if(obst == null)
					{
						obst = o;
					}
					else
					{
						var dist1 = Vector2.Distance(o.transform.position,t.position);
						var dist2 = Vector2.Distance(obst.transform.position,t.position);

						if(dist1 < dist2)
						{
							obst = o;
						}
					}
				}
			}
			else
			{
				foreach(var o in list.FindAll(ob => ob.gameObject.activeInHierarchy))
				{
					if(obst == null)
					{
						obst = o;
					}
					else
					{
						var dist1 = Vector2.Distance(o.transform.position,t.position);
						var dist2 = Vector2.Distance(obst.transform.position,t.position);

						if(dist1 < dist2)
						{
							obst = o;
						}
					}
				}
			}

			return obst;
		}

		public static void Setup()
		{
			GC.Collect ();

			Resources.UnloadUnusedAssets ();

			if(Application.isMobilePlatform)
			{
				Application.targetFrameRate = 60;
				Time.fixedDeltaTime = 1f/60;
				Time.maximumDeltaTime = 3 * Time.fixedDeltaTime;
			}
			else
			{
				Application.targetFrameRate = 200;
				Time.fixedDeltaTime = 1f/200f;
				Time.maximumDeltaTime = 3 * Time.fixedDeltaTime;
			}

			Physics2D.gravity = new Vector2(0,-300);
		}

		public static void ReloadCurrentScene()
		{
			Time.fixedDeltaTime = 1f/60f;
			Time.maximumDeltaTime = 3 * Time.deltaTime;

			GC.Collect ();

			#if AADOTWEEN
			DOTween.KillAll();
			#endif

			Resources.UnloadUnusedAssets ();

			#if UNITY_5_3_OR_NEWER

			SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex,LoadSceneMode.Single);

			#else
			Application.LoadLevel(Application.loadedLevel);
			#endif

			Resources.UnloadUnusedAssets ();

			GC.Collect ();
		}

		public static string CurrentSceneName()
		{
			#if UNITY_5_3_OR_NEWER
			return SceneManager.GetActiveScene().name;
			#else
			return Application.loadedLevelName;
			#endif
		}

		public static Color InvertColor(Color c)
		{
			float r = c.r;
			float g = c.g;
			float b = c.b;
			float a = c.a;

			float ir = 1f - r;
			float ig = 1f - g;
			float ib = 1f - b;


			return new Color(ir,ig,ib,a);
		}
		public static Color GeBorderColor(Color c)
		{
			float r = c.r;
			float g = c.g;
			float b = c.b;

			float tot = r + g + b;

			if(tot < 1.5f)
				return Color.white;

			return Color.black;
		}


		public static int GetLife()
		{
			return PlayerPrefs.GetInt("LIFE", 3);
		}

		public static void SetLife(int TOTAL)
		{
			PlayerPrefs.SetInt("LIFE", TOTAL);
			PlayerPrefs.Save();

			EventManager.DOSetLife(TOTAL);
		}


		public static int GetDiamond()
		{
			return PlayerPrefs.GetInt("DIAMONDS", 0);
		}

		public static void SetDiamond(int TOTAL)
		{
			PlayerPrefs.SetInt("DIAMONDS", TOTAL);
			PlayerPrefs.Save();

			EventManager.DOSetDiamond(TOTAL);
		}

		public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
		{
			Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
			return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
		}

		public static float GetHeight(this Camera cam)
		{
			if(cam == null)
				return 0;

			return 2f * cam.orthographicSize;
		}

		public static float GetWidth(this Camera cam)
		{
			if(cam == null)
				return 0;

			return cam.GetHeight() * cam.aspect;
		}

		public static bool IsVisibleFrom(this Transform transform, Camera camera)
		{
			if(!transform.gameObject.activeInHierarchy)
				return false;

			return transform.position.IsVisibleFrom(camera);
		}

		public static bool IsVisibleFrom(this Vector3 pos, Camera camera)
		{
			float width = camera.GetWidth();
			float height = camera.GetHeight();

			var left = camera.transform.position.x - width / 2f;
			var right = camera.transform.position.x + width / 2f;
			var top = camera.transform.position.y + height / 2f;
			var bottom = camera.transform.position.y - height / 2f;


			if(left < pos.x && pos.x < right && bottom < pos.y && pos.y < top)
				return true;

			return false;
		}

		public static Color GetRandomColor()
		{
			return new Color(UnityEngine.Random.Range(0f,1f),UnityEngine.Random.Range(0f,1f),UnityEngine.Random.Range(0f,1f),1);
		}

		private static System.Random rng = new System.Random();  

		public static void Shuffle<T>(this IList<T> list)  
		{  
			int n = list.Count;  
			while (n > 1) {  
				n--;  
				int k = rng.Next(n + 1);  
				T value = list[k];  
				list[k] = list[n];  
				list[n] = value;  
			}  
		}

		public static float GetMaxPositionBorderSpriteInChild_Y(this Transform t)
		{
			var spriteAll = t.GetComponentsInChildren<SpriteRenderer>(false);

			var max = -Mathf.Infinity;

			foreach(var s in spriteAll)
			{
				var temp = s.bounds.max.y + s.transform.position.y;
				if(max < temp)
					max = temp;
			}
			Debug.Log("max = " + max);
			return max;
		}

		public static void SetUIColorDarker(this GameObject b)
		{
			List<Text> listText = new List<Text>();

			var text = b.GetComponent<Text>();
			if(!listText.Contains(text))
			{
				listText.Add(text);
			}

			foreach(var t in b.GetComponentsInChildren<Text>(false))
			{
				if(!listText.Contains(t))
				{
					listText.Add(t);
				}
			}

			List<Image> listImage = new List<Image>();

			var image = b.GetComponent<Image>();
			if(!listImage.Contains(image))
			{
				listImage.Add(image);
			}

			foreach(var i in b.GetComponentsInChildren<Image>(false))
			{
				if(!listImage.Contains(i))
				{
					listImage.Add(i);
				}
			}

			foreach(var t in listText)
			{
				if(t != null)
					t.color = t.color.SetColorDarker(0.3f);
			}

			foreach(var i in listImage)
			{
				if(i != null)
					i.color = i.color.SetColorDarker(0.3f);
			}
		}

		public static Color SetColorDarker(this Color c, float n)
		{
			c.r -= n;
			c.g -= n;
			c.b -= n;
			return c;
		}

		public static void SetCanvasgroupAlpha(this Button b, float alpha)
		{
			b.GetComponent<CanvasGroup>().alpha = alpha;
		}

		public static float GetCanvasgroupAlpha(this GameObject b)
		{
			return b.GetComponent<CanvasGroup>().alpha;
		}

		public static float GetCanvasgroupAlpha(this Button b)
		{
			return GetCanvasgroupAlpha(b.gameObject);
		}

		public static void SetAlpha(this Button b, float alpha)
		{
			Image i = b.GetComponent<Image>();
			i.SetAlpha(alpha);
		}

		public static void SetAlpha(this Image i, float alpha)
		{
			Color c = i.color;
			c.a = alpha;
			i.color = c;
		}

		public static float GetAlpha(this Button b)
		{
			Image i = b.GetComponent<Image>();
			return i.GetAlpha();
		} 

		public static float GetAlpha(this Image i)
		{
			Color c = i.color;
			return c.a;
		}

		public static void SetColor(this Text text, Color c)
		{
			text.color = c;
		}

		public static void SetColor(this SpriteRenderer sprite, Color c)
		{
			sprite.color = c;
		}

		public static float GetScalingByResolution()
		{
			int high = Mathf.Max(Screen.height, Screen.width);
			int low = Mathf.Min(Screen.height, Screen.width);

			if (high < 640 || (high == 1024 && low == 768))
			{
				return 0.5f;
			}

			return 1.0f;
		}
	}
}