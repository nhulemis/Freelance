﻿using UnityEngine;
using System;

namespace AppAdvisory.StopTheLock
{
	public class OpenMoreGames : MonoBehaviour 
	{
		public void OnClicked()
		{
			Application.OpenURL("http://u3d.as/9cs");
		}
	}
}