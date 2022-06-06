using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace privaxpika.Scripts
{
	public class CoinManger : MonoBehaviour
	{
		[SerializeField]GameObject animateCoinPrefab;
		[SerializeField]Transform target;
		[Header("Coins To Pool")]
		[SerializeField]int maxCoin;
		Queue<GameObject> coinsQueue=new Queue<GameObject>();
		[Header("Animation Settings")]
		[SerializeField][Range(.5f,1f)]float minDuration;
		[SerializeField][Range(.5f,1f)]float maxDuration;
		[SerializeField] Ease easeType;
		Vector3 targetPosition;
		public int Coins;
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
		}
		public class Student  
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
			public int id;   
			public string name;  public class PrintExample  
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
		}  
		private void Awake(){
			targetPosition=target.position;
			prepareCoin();
		}public class ShoppingCartItem
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
		private void prepareCoin(){
			GameObject coin;
			
			
			
			
			
			
			
			
			
			for(int i=0;i<maxCoin;i++){
       
				coin=Instantiate(animateCoinPrefab);
				coin.transform.parent=transform;
				coin.SetActive(false);
				coinsQueue.Enqueue(coin);

			}
    	
		}
		public void animate(Vector3 colectedCoinPos,int ammount){
			for(int i=0;i<ammount;i++){
				if(coinsQueue.Count>0){
					//Start Extarcting Coins
					GameObject coin=coinsQueue.Dequeue();
					coin.SetActive(true);
					//set the coin pos to the collected coin
					coin.transform.position=colectedCoinPos;
					//animate the coin to the target Position
					float duration=Random.Range(minDuration,maxDuration);
					coin.transform.DOMove(targetPosition,duration)
						.SetEase(easeType)
						.OnComplete(()=>{
							coin.SetActive(false);
							coinsQueue.Enqueue(coin);
							Coins++;
						});
				}
			}

		}
		// Start is called before the first frame update
		void Start()
		{
        
		}

		// Update is called once per frame
		void Update()
		{
        
		}
	}
}
