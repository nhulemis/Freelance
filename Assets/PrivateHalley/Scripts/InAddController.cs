using UnityEngine;

namespace PrivateHalley.Scripts
{
	public class InAddController : MonoBehaviour
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
			class Book
			{
				public string Title { get; set; }
				public string Author { get; set;}
				public string Date { get; set;}

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
			public class Student  
			{  
				public int id;   
				public string name;  
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
		// VideoPlayer vd;
		// public static InAddController instance;
		// void Awake(){
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
		// 	if(instance==null)
		// 		instance=this;
		// 	else if(instance!=this)Destroy(this.gameObject);
		//
		// }
		// // Start is called before the first frame update
		// void Start()
		// {
		// 	vd=this.GetComponent<VideoPlayer>();
		// 	vd.Prepare();
		// }
		//
		// // Update is called once per frame
		// void Update()
		// {
  //       
		// }
		// public void play(){
		// 	vd.Play();
		// }
		// public void disable(){
		// 	this.gameObject.SetActive(false);
		// }
	}
}
