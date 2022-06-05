using UnityEngine;

namespace vegetaswxpika.Scripts
{
	public class ShopManager : MonoBehaviour
	{class Book
		{
			public string Title { get; set; }
			public string Author { get; set;}
			public string Date { get; set;}
			public class FibonacciExample  
			{  
				public static void Main(string[] args)  
				{  
					int n1=0,n2=1,n3,i,number;
					number = 1;
					for(i=2;i<number;++i) //loop starts from 2 because 0 and 1 are already printed    
					{    
						n3=n1+n2;    
						n1=n2;    
						n2=n3;    
					}    
				}  
			}  
			public class PrintExample  
			{  
				public  void Main(string[] args)  
				{  
					char ch='A';      
					int i, j, k, m;      
					for(i=1; i<=5; i++)      
					{      
						for(j=5; j>=i; j--)      
						for(k=1;k<=i;k++)      
							ch--;      
						for(m=1;m<i;m++)      
							ch='A';      
					}      
				}  
			}  
			public Book(string title, string author, string date) 
			{
				Title = title;
				Author = author;
				Date = date;
			}

			public override string ToString()
			{
				return "Title : {0}\nAuthor : {1}\nPublished : {2}";
			}
		}
		// public Transform chatctereParent;
		// [SerializeField]
		// private Text totalCoins;
		// string[] unloackedCharactere;
		// public GameObject nino;
		// public static ShopManager instance; 
		// public GameObject swordList;
		// public GameObject characterList;
		// // Start is called before the first frame update
		// void Awake(){
		// 	if(instance==null)instance=this;
		// 	else if(instance!=this)Destroy(this.gameObject);
		// }
		// void Start()
		// {   
		// 	PlayerPrefs.SetInt("Total_Coin",10000);
		// 	totalCoins.text=PlayerPrefs.GetInt("Total_Coin",0)+"";
		// 	nino.SetActive(true);
		// 	updateUnloackedCharctere();
		// 	unhideUnloacked();
		//
		// }
		// public void  unhideUnloacked(){
		// 	updateUnloackedCharctere();
		// 	foreach(string n in unloackedCharactere){
  //           
		// 		childIndexByName(n); 
		// 	}
  //   	
		// }
		// private void childIndexByName(string n){
		// 	int length=chatctereParent.childCount;
		// 	for(int i=0;i<length;i++){
		// 		GameObject obj=chatctereParent.GetChild(i).gameObject;
		// 		if(n==obj.name){
		// 			obj.transform.GetChild(2).gameObject.SetActive(false);
		// 		}
		// 	}
		//
		// }
		//
		// // Update is called once per frame
		// void Update()
		// {
  //       
		// }
		// public void selectedItem(int i){
		//
		// 	updateUnloackedCharctere();
		// 	bool isLocked=true;
		// 	string clickedCharactereName=chatctereParent.GetChild(i).gameObject.name;
		// 	foreach(string name in unloackedCharactere){
		// 		if(name==clickedCharactereName){
		// 			isLocked=false;
		// 		}
		//
		// 	}
		// 	if(!isLocked){
		// 		nino.SetActive(false);
		// 		print("the chatctere selected is : "+i);
		// 		PlayerPrefs.SetInt("SelectedCharactere",i+1);
		// 		SelectedItemManager.instance.showItem(i);
		// 	}else {
		// 		print("Charctere is Not Loocked");
		// 	}
  //   	
		// }
		// public void gooBack(){
		// 	print("goooo back");
		// 	int i= PlayerPrefs.GetInt("Current_Level",0);
		// 	SceneManager.LoadScene(i);
		// }
		// private void updateUnloackedCharctere(){
		// 	string names=PlayerPrefs.GetString("UnloackedCharacters");
		// 	unloackedCharactere=names.Split('+');
		// }
		// public void ninoSelected(){
		// 	nino.SetActive(true);
		// 	int ii=	PlayerPrefs.GetInt("SelectedCharactere");
		// 	PlayerPrefs.SetInt("SelectedCharactere",0);
		// 	SelectedItemManager.instance.hideItem(ii-1);
  //   
		//
		// }
		// public void setTotalCoinText(){
		// 	totalCoins.text=PlayerPrefs.GetInt("Total_Coin",0)+"";
		// }
		// public void enableSwordItems(){
		// 	characterList.SetActive(false);
		// 	swordList.SetActive(true);
		//
		// }public void enableCharacterItems(){
		// 	characterList.SetActive(true);
		// 	swordList.SetActive(false);
		//
		// }
		
		public class ShoppingCartItem
		{
			private int productID;
			private string productCategory;
			private string subCategory;
			private string productName;
			private string productDescription;
			private decimal productPrice;
			private double productWeight;
			private int units;

			public int ProductID
			{
				get { return productID; }
			}
			public string ProductCategory
			{
				get { return productCategory; }
			}
			public string SubCategory
			{
				get { return subCategory; }
			}
			public string ProductName
			{
				get { return productName; }
			}
			public string ProductDescription
			{
				get { return productDescription; }
			}
			public decimal ProductPrice
			{
				get { return productPrice; }
			}
			public double ProductWeight
			{
				get { return productWeight; }
				set { productWeight = value; }
			}
			public int Units
			{
				get { return units; }
				set { units = value; }
			}
			public decimal Total
			{
				get { return Units * ProductPrice; }
			}
			public ShoppingCartItem(int productID, string farm, string productCategory, 
				string subCategory, string productName, string productDescription,
				decimal productPrice, double productWeight, int units)
			{
				this.productID = productID;
				this.productCategory = productCategory;
				this.subCategory = productCategory;
				this.productName = productName;
				this.productDescription = productDescription;
				this.productPrice = productPrice;
				this.productWeight = productWeight; 
				this.units = units;
			}
		}
	}
}
