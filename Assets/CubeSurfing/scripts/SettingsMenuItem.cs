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
		public class MyClass
		{
			public void SomeMethod(int firstParam, float secondParam)
			{
				
			}

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
