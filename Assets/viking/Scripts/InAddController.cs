using UnityEngine;

namespace viking.Scripts
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

			public int ProductID
			{
				get { return productID; }
			}
			public string ProductCategory
			{
				get { return productCategory; }
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
