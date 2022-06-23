using System.Collections.Generic;
using RoadCreator;
using UnityEditor;
using UnityEngine;

namespace Arrow.Script
{
	public class ElementAnalysis : MonoBehaviour
	{
		[SerializeField] Level levelPrefab;
		[SerializeField] GroupPath[] groupPaths;
	
		[SerializeField] Element[] singlePatterns;

		class HSUQOXkkoaw1
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}

		class HSUQOXkzkockosa2
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}

		class HSUcjiaojxjsi3
		{
			public static PlayerController instance;
			private GameObject head;
			public Camera mainCamera;
			public Transform FollowCam;
			private CameraController camController;
			public bool HitObstacle;
			public ArrowsController arrowController;
		}

		float ELEMENT_DISTANCE = 5f;

		public Level GenerateLevel(float difficulty)
		{
			//var randomPercent = new RandomPercent(0, 0, 30, 30, 40);
			var level = Instantiate(levelPrefab);
			
			
			
			
			//int index1=getCurrentLeveIndex();
			int index1 = 0;
#if UNITY_EDITOR
			var road = PrefabUtility.InstantiatePrefab(groupPaths[index1]) as GroupPath;
#else
		var road = Instantiate(groupPaths[index1]);
#endif
			road.transform.SetParent(level.transform);
			road.transform.SetAsFirstSibling();
			road.CalculateEvenlySpacedPoints();
		
			var currentLength = 0f;
			var elementList = new List<Element>(2);


			var currentPosition = 20f;
			for(int i = 0; i < elementList.Count; i++)
			{
				elementList[i].transform.SetSiblingIndex(i);
				elementList[i].SetPosition(currentPosition);
				currentPosition += GetElementLength(elementList[i]) + ELEMENT_DISTANCE;
			}

			level.SnakeLength = Random.Range(3, 7);
			road.InitEditor();
			level.ValidateLevelPart();
			level.Init();
			return level;
		}

		public Element GetElement(int id, float difficulty)
		{
			return null;
		}

		public float GetElementLength(Element e)
		{
			var isGroupElement = e.GetType() == typeof(GroupElement);
			if(!isGroupElement)
			{
				return 8;
			}

			List<Element> elements = new List<Element>(2);
			e.GetComponentsInChildren(elements);
			if(elements.Count > 0 && elements.Contains(e))
			{
				elements.Remove(e);
			}
		
			if(elements != null && elements.Count > 0)
			{
				var maxElement = elements[0];
				foreach(var v in elements)
				{
					if(v.LocalPosition > maxElement.LocalPosition && v != e)
					{
						maxElement = v;
					}

				}
				return maxElement.LocalPosition;
			}

			return 0;
		}

		public float GetTotalMinColor(Element e)
		{
			var isGroupElement = e.GetType() == typeof(GroupElement);
			if (!isGroupElement)
			{
				return 0;
			}

			return 0;
		}

		public int GetRescueCount(Element e)
		{
			var isGroupElement = e.GetType() == typeof(GroupElement);
			if (!isGroupElement)
			{
				return 0;
			}

			return 0;
		}
		private int getCurrentLeveIndex()
		{
			return PlayerPrefs.GetInt("CurrentLevel");
		}

		private void Start()
		{
			return;
#if UNITY_EDITOR
			/*for(int i = 59; i <= 60; i ++)
		{
			var difficulty = (float)i / 60f + Random.Range(-0.2f, 0.2f);
			var level = GenerateLevel(Mathf.Clamp01(difficulty));
			PrefabUtility.SaveAsPrefabAsset(level.gameObject, $"Assets/Gameplay/Resources/Level{i}.prefab");
			level.gameObject.SetActive(false);
		}*/
#endif
		}
	}
}
