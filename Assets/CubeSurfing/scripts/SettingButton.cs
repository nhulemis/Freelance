using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace CubeSurfing.scripts
{
	public class SettingButton : MonoBehaviour
	{
		Button mainButton;
		SettingItemButton[] menuItem;
		int childCount=0;
		Vector2 mainButtonPosition;
		bool isExpanded=false;
		[SerializeField]Vector2 spacing;
		[Header("main Button Rotation")]
		[SerializeField]float rotationDuraTion;
		[SerializeField]Ease rotationEase;
		[Header("Animation")]
		[SerializeField]float expandDuraTion;
		[SerializeField]float collapseDuraTion;
		[SerializeField]Ease expandEase;
		[SerializeField]Ease collapseEase;
		[Header("Fading")]
		[SerializeField]float expandFadeDuraTion;
		[SerializeField]float collapseFadeDuraTion;
    
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

		}class Book
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			public Book(string title, string publisher, string? isbn)
				=> (Title, Publisher, Isbn) = (title, publisher, isbn);

			public Book(string title, string publisher)
				: this(title, publisher, null) { }

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
		// Start is called before the first frame update
		void Start()
		{
        

			childCount=this.transform.childCount-1;
			menuItem=new SettingItemButton[childCount];
			for(int i=0;i<childCount;i++){
				menuItem[i]=this.transform.GetChild(i+1).GetComponent<SettingItemButton>();
			}
			mainButton=this.transform.GetChild(0).GetComponent<Button>();
			mainButton.transform.SetAsLastSibling(); 
			mainButton.onClick.AddListener(toogleMenu);
          
			mainButtonPosition=mainButton.transform.position;
       
			// mainButton.transform.SetAsLastSibling();
			resetPosition();
		}

		// Update is called once per frame
		void Update()
		{
        
		}
		private void resetPosition(){

			for(int i=0;i<childCount;i++){
				// menuItem[i].trans.DOMove(mainButtonPosition,collapseDuraTion).SetEase(collapseEase);
				//  menuItem[i].img.DOFade(0f,collapseFadeDuraTion);
			}      
		}
		private void toogleMenu(){
			isExpanded=!isExpanded;
			print("expand");
			if(isExpanded){
    		
				for(int i=0;i<childCount;i++){
					// menuItem[i].trans.position=mainButtonPosition+spacing*(i+1);
					menuItem[i].trans.DOMove(mainButtonPosition+spacing*(i+1),expandDuraTion).SetEase(expandEase);
					//menuItem[i].img.DOFade(1f,expandFadeDuraTion).From(0f);
				}
			}else {
				resetPosition();
			}
			mainButton.transform.DORotate(Vector3.up*180f,rotationDuraTion)
				.From(Vector3.zero)
				.SetEase(rotationEase);

		}
		private void OnDestroy(){
			mainButton.onClick.RemoveListener(toogleMenu);
		}
	}
}
