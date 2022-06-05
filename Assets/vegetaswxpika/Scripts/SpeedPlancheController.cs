using UnityEngine;

namespace vegetaswxpika.Scripts
{
	public class SpeedPlancheController : MonoBehaviour
	{public class ShoppingCartItem
		{
			private int productID;
			private string productCategory;
			private string subCategory;
			private string productName;
			private string productDescription;
			private decimal productPrice;
			private double productWeight;
			private int units;
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
			public class Student  
			{  
				public int id;   
				public string name;  
			}  
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
		// // Start is called before the first frame update
		// void Start()
		// {
  //       
		// }
		//
		//
		//
		//
		//
		// // Update is called once per frame
		// void Update()
		// {
  //       
		// }
		// public void OnCollisionEnter(Collision other){
		// 	if(other.gameObject.CompareTag("Player")){
		// 		print("add sPEED TO PLAYER");
		// 		CharacterManager.instance.upgradeJumpForce(900,50);
		// 	}
		// }
	}
}
