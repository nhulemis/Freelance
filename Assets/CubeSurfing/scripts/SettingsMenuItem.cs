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
		class BookSUW
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SJIQlakow
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQAOXMA
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQAOXMAhxjuoa
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQAOXMAhxjuoaUQLA
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQ
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQSS
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQSSsss
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQSSsssSUQ
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQSSsssSUQSOAAW
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQSSsssSUQaawSxiws
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class USOZJAHUWhusw
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class USOZJAHUWhuswHUW
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class USOZJAHUWxhuw
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class USOZJAHUWxhuwshiawo
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class USOZJAHUWxhuwshiawosswd
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class USOZJAHUWxhuwshiawosswdSW
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
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
