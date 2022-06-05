using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace PrivateHalley.Scripts
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
		public class Student  
		{  
			public int id;   
			public string name;  
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
