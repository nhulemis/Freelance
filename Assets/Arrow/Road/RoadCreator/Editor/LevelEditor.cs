using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RoadCreator
{
	[CustomEditor(typeof(Level))]
	[CanEditMultipleObjects]
	public class LevelEditor : Editor
	{
		private void OnEnable()
		{
			var level = (Level)target;
			var groupPaths = level.GetComponentsInChildren<GroupPath>();
			foreach(var gp in groupPaths)
			{
				gp.InitEditor();
			}
		}
	}
}
