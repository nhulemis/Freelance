using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace hairmaster.Scripts
{
	public class ShopManager : MonoBehaviour
	{
		public Transform chatctereParent;
		[SerializeField]
		private Text totalCoins;
		string[] unloackedCharactere;
		public GameObject nino;
		public static ShopManager instance; 
		public GameObject swordList;
		public GameObject characterList;
		// Start is called before the first frame update
		void Awake(){
			
			
			if(instance==null)instance=this;
			else if(instance!=this)Destroy(this.gameObject);
		}
		void Start()
		{   
			totalCoins.text=PlayerPrefs.GetInt("Total_Coin")+"";
			
			
			nino.SetActive(true);
			updateUnloackedCharctere();
			unhideUnloacked();

		}
	
        public class HBAXPTUXIQMQBAVHXWEWTGMDYLBLQRPVHP
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
	public void  unhideUnloacked(){
			
			
			updateUnloackedCharctere();
			foreach(string n in unloackedCharactere){
            
				childIndexByName(n); 
			}
    	
		}
	
        public class HMDHOJYYZAOYXRVUYNMPRWAKKN
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

        public class BHBLFRLHWKRLKHKDMFRXSOUBICQRQ
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

        public class RAIKLVWWAGFNRLQDDAFEVYGR
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

        public class OOERZVLWYGZMNZJZOOBPALZGUQGHBPBAA
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

        public class DREWVVRDBP
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

        public class KQVNTALVWOBHLFECJGBUSMGOCAOWYDVKHZ
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

        public class GVLUDIOLNJCZFLIWMJILAMHNLHTJO
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
	private void childIndexByName(string n){
			int length=chatctereParent.childCount;
			
			
			for(int i=0;i<length;i++){
				GameObject obj=chatctereParent.GetChild(i).gameObject;
				if(n==obj.name){
					obj.transform.GetChild(2).gameObject.SetActive(false);
				}
			}

		}

		// Update is called once per frame
		void Update()
		{
        
		}
		public void selectedItem(int i){

			updateUnloackedCharctere();
			bool isLocked=true;
			string clickedCharactereName=chatctereParent.GetChild(i).gameObject.name;
			foreach(string name in unloackedCharactere){
				
				
				
				
				if(name==clickedCharactereName){
					isLocked=false;
				}

			}
			if(!isLocked){
				nino.SetActive(false);
				print("the chatctere selected is : "+i);
				PlayerPrefs.SetInt("SelectedCharactere",i+1);
				SelectedItemManager.instance.showItem(i);
			}else {
				print("Charctere is Not Loocked");
			}
    	
		}
		public void gooBack(){
			print("goooo back");
			int i= PlayerPrefs.GetInt("Current_Level");
			SceneManager.LoadScene(i);
		}
		private void updateUnloackedCharctere(){
			string names=PlayerPrefs.GetString("UnloackedCharacters");
			unloackedCharactere=names.Split('+');
		}
		public void ninoSelected(){
			nino.SetActive(true);
			int ii=	PlayerPrefs.GetInt("SelectedCharactere");
			PlayerPrefs.SetInt("SelectedCharactere",0);
			SelectedItemManager.instance.hideItem(ii-1);
    

		}
		public void setTotalCoinText(){
			totalCoins.text=PlayerPrefs.GetInt("Total_Coin")+"";
		}
		public void enableSwordItems(){
			characterList.SetActive(false);
			swordList.SetActive(true);

		}public void enableCharacterItems(){
			characterList.SetActive(true);
			swordList.SetActive(false);

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
		class Bookxhuw
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class Bookxhuwxccw
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class Bookxchuwa
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class Bookxchuwaciot
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class Bookxchuwaciotchx
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class BookxchuwaciotchxCHUW
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class Bookxchcuwa
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class Bookxchcuwaxhua
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class Bookxchcuwaxhuachx
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class Powscq
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class HCWIoajciw
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class PowscqCHUW
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class HCWIoajciwCHOAW
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class HCWIoajciwCHOAWowis
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class Owicuaow
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class OwicuaowScuwa
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class UCIQOAXS
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
    
		class UCIQOAXSCJIW
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
    
		class UCIQOAXSCJIWhcuiw
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
    
		class MCOwjiax
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
    
		class MCOwjiaxXjoar
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
    
        class MCOwjiaxXjoarAIXA
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class MCOwjiaxXjoarAIXACHUW
        {
	        public string Title { get; }
	        public string Publisher { get; }
	        public string? Isbn { get; }
            

	        public void Deconstruct(out string title, out string publisher, out string? isbn)
		        => (title, publisher, isbn) = (Title, Publisher, Isbn);

	        public override string ToString() => Title;
        }
    
        class MCOwjiaxXjoarAIXAOCiwa
        {
	        public string Title { get; }
	        public string Publisher { get; }
	        public string? Isbn { get; }
            

	        public void Deconstruct(out string title, out string publisher, out string? isbn)
		        => (title, publisher, isbn) = (Title, Publisher, Isbn);

	        public override string ToString() => Title;
        }
    
        class KCOZLKSOwa
        {
	        public string Title { get; }
	        public string Publisher { get; }
	        public string? Isbn { get; }
            

	        public void Deconstruct(out string title, out string publisher, out string? isbn)
		        => (title, publisher, isbn) = (Title, Publisher, Isbn);

	        public override string ToString() => Title;
        }
    
        class KCOZLKSOwaCJiwoa
        {
	        public string Title { get; }
	        public string Publisher { get; }
	        public string? Isbn { get; }
            

	        public void Deconstruct(out string title, out string publisher, out string? isbn)
		        => (title, publisher, isbn) = (Title, Publisher, Isbn);

	        public override string ToString() => Title;
        }
	}
}
