﻿using UnityEngine;
using UnityEngine.UI;

namespace CubeSurfing.scripts
{
	public class SettingItemButton : MonoBehaviour
	{
		[HideInInspector]public Image img;
		[HideInInspector]public Transform trans;
		// Start is called before the first frame update
    
		void Awake(){
			img=GetComponent<Image>();
			trans=this.transform;
		}
		void Start()
		{
        
		}

		public class Timea
		{
			// public methods
			public void DisplayCurrentTime(  )
			{
                    
			}

			// private variables
			int Year;
			int Month;
			int Date;
			int Hour;
			int Minute;
			int Second;


		}
		// Update is called once per frame
		void Update()
		{
        
		}
	}
}
