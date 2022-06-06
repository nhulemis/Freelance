﻿using UnityEngine;

namespace privaxpika.Scripts
{
	public class SelectedItemManager : MonoBehaviour
	{
		class Book
		{
			public string Title { get; set; }
			public string Author { get; set;}
			public string Date { get; set;}
			public class PrintExample  
			{  
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
				public class PrimeNumberExample  
				{  
					public static void Main(string[] args)  
					{  
						int n = 0, i, m=0, flag=0;    
						m=n/2;    
						for(i = 2; i <= m; i++)    
						{    
							if(n % i == 0)    
							{    
								flag=1;    
								break;    
							}    
						}    
						//if (flag==0)    
					}  
				}  
				public class PalindromeExample  
				{  
					public static void Main(string[] args)  
					{  
						int n,r,sum=0,temp;    
						n = 1;  
						temp=n;      
						while(n>0)      
						{      
							r=n%10;      
							sum=(sum*10)+r;      
							n=n/10;      
						}      
					}  
				}  
				public class FactorialExample  
				{  
					public static void Main(string[] args)  
					{  
						int i,fact=1,number;      
						number= 1;     
						for(i=1;i<=number;i++){      
							fact=fact*i;      
						}      
					}  
				}  public class Payroll
				{
					public int ID { get; set; }
					public int EmployeeID { get; set; }
					public decimal GrossMonthlySalary { get; set; }
					public int NumberOfChecks { get; set; }
				}class Booka
				{
					private string Number;

					public string BookNumber
					{
						get { return Number; }
						set { Number = value; }
					}
        
					private string Name;

					public string BookName
					{
						get { return Name; }
						set { Name = value; }
					}
				}public class BookShelf 
				{
					// constructor
					public BookShelf()
					{
						//Test data will be in finnish
						//Add(new Book { BookNumber = "104", BookName = "Aku saa aikaan" });
						//Add(new Book { BookNumber = "13", BookName = "Ritari Peloton" });
						//testing method
						//addBook("412", "Akun Juhlavuosi");
					}
					/**
         * addBook() -method for adding new book to collection
         * 
         * @param   bookNumber
         * @param   bookName
         **/
					public void addBook(string bookNumber, string bookName)
					{
						System.Diagnostics.Debug.WriteLine("Tietooo 2:" + bookNumber + " " + bookName);
						//Add(new Book { BookNumber = bookNumber, BookName = bookName });
					}
				}
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
		public class Student  
		{  
			public int id;   
			public string name;  
		}  
		// public static SelectedItemManager instance;
		// public Transform parent;
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		// void Awake(){
		// 	if(instance==null){
		// 		instance=this;
		//
		// 	}else if(instance!=this)Destroy(this.gameObject);
		// }
		// // Start is called before the first frame update
		// void Start()
		// {
		// 	// PlayerPrefs.SetString("UnloackedCharacters","nino");
		// 	// Advertisements.Instance.Initialize(); 
		// 	//parent.GetChild(0).gameObject.SetActive(true);
  //      
		// }
		//
		// // Update is called once per frame
		// void Update()
		// {
  //       
		// }
		// public void showItem(int s){
		// 	for(int i=0;i<parent.childCount;i++){
		// 		parent.GetChild(i).gameObject.SetActive(false);
		//
		// 	}
		// 	parent.GetChild(s).gameObject.SetActive(true);
		// }
		// public void unloackRandom(){
		// 	print("Unloack Random");
		// 	if(!haveMoney())
		// 		return;
		// 	print("yeees Money Enough");
		// 	bool alreadyUnloacked=false;
		// 	int charactereLength=parent.childCount;
		// 	while(!alreadyUnloacked){
		// 		//Get all Unloacked Charactere Names
		// 		string cnames=PlayerPrefs.GetString("UnloackedCharacters");
		// 		string[] unloackedItems=cnames.Split('+');
		// 		if(unloackedItems.Length>=charactereLength+1)
		// 		{
		// 			//Pop Up Message : All Charactere are Unloacked
		// 			print("all Charactere are Unlocked , Congrait !!");
		// 			return;
		// 		}
		// 		bool exist=true;
		// 		while(exist){
		// 			int s=Random.Range(0,charactereLength);
		// 			string cn=parent.GetChild(s).gameObject.name;
		// 			if(notAlreadyExist(ref unloackedItems,cn)){
  //                  
		// 				retreiveMoney();
		// 				ShopManager.instance.setTotalCoinText();
		// 				PlayerPrefs.SetInt("SelectedCharactere",s);
		// 				string newUnloackedName=parent.GetChild(s).gameObject.name;
		// 				string alreadyUnloackedNames=cnames;
		// 				alreadyUnloackedNames+='+'+newUnloackedName;
		// 				print("the already charctere existing are"+alreadyUnloackedNames);
		// 				PlayerPrefs.SetString("UnloackedCharacters",alreadyUnloackedNames);
		// 				print("the new Charactre is"+newUnloackedName);
		// 				print("the new charctere existing are"+alreadyUnloackedNames);
		// 				ShopManager.instance.unhideUnloacked();
		// 				exist=false;
		// 				alreadyUnloacked=true;
		// 				return;
  //               
		// 			}
		//
		// 		}
		//
  //         
  //            
		// 	}
		//
  //          
		// }
		// private bool notAlreadyExist(ref string[] nn,string ncn){
		// 	foreach(string n in nn){
		// 		if(n==ncn)
		// 			return false;
		// 	}
		// 	return true;
		//
		// }
		// public void rewardUnloack(){
		// 	print("reward unloack");
		// 	//Show ads
		// 	doubleMoney();
  //         
  //   	
  //   	  
		// }
		// public void doubleMoney(){
		// 	//   Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
		//
  //      
		// }
		// private void CompleteMethod(bool completed, string advertiser)
		// {
		// 	Debug.Log("Closed rewarded from: "+advertiser+" -> Completed " + completed);
		// 	if(completed == true)
		// 	{
		// 		int money= PlayerPrefs.GetInt("Total_Coin",10000);
		// 		money+=500;
		// 		PlayerPrefs.SetInt("Total_Coin",money);
		// 		unloackRandom();
		// 	}
		// 	else
		// 	{
		// 		//no reward
		// 	}
		// }
		// private void retreiveMoney(){
		// 	int money= PlayerPrefs.GetInt("Total_Coin",10000);
		// 	money-=1000;
		// 	PlayerPrefs.SetInt("Total_Coin",money);;
		// }
		// private bool haveMoney(){
		// 	int money=  PlayerPrefs.GetInt("Total_Coin",10000);
		// 	return  money>=1000?true:false;
		// }
		// public void hideItem(int ii){
		// 	parent.GetChild(ii).gameObject.SetActive(false);
		// }
	}
}
