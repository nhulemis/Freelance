﻿using UnityEngine;

namespace PrivateHalley.Scripts
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
