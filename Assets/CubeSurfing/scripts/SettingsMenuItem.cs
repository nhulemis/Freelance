using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CubeSurfing.scripts
{
	public class SettingsMenuItem : MonoBehaviour
	{
		[HideInInspector] public Image img;
		[HideInInspector] public Transform trans;

		//SettingsMenu reference
		SettingsMenu settingsMenu;

		//item button
		Button button;

		//index of the item in the hierarchy
		int index;

		public class TaoLaoTU
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaoTU()
			{
				
			}
		}
		public class TaoLaoTUxu
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaoTUxu()
			{
				
			}
		}
		public class TaoLaHUATUCSA
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaHUATUCSA()
			{
				
			}
		}
		public class TaoLaHUATUCSAchu5
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaHUATUCSAchu5()
			{
				
			}
		}
		public class TaoLaHUAhcu6
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaHUAhcu6()
			{
				
			}
		}
		public class TaoLaHhuchcua8
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaHhuchcua8()
			{
				
			}
		}
		public class TaoLaHchu9
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaHchu9()
			{
				
			}
		}
		public class TaoLaHchu9chuw
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaHchu9chuw()
			{
				
			}
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
		void Awake ()
		{
			img = GetComponent<Image> ();
			trans = transform;

			settingsMenu = trans.parent.GetComponent <SettingsMenu> ();

			//-1 to ignore the main button
			index = trans.GetSiblingIndex () - 1;

			//add click listener
			button = GetComponent<Button> ();
			button.onClick.AddListener (OnItemClick);
		}

		void OnItemClick ()
		{
			settingsMenu.OnItemClick (index);
		}

		void OnDestroy ()
		{
			//remove click listener to avoid memory leaks
			button.onClick.RemoveListener (OnItemClick);
		}
	}
}
