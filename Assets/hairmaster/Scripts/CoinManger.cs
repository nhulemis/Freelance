using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace hairmaster.Scripts
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
		private void Awake(){
			targetPosition=target.position;
			prepareCoin();
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
		// Start is called before the first frame update
		void Start()
		{
        
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
		class HCWIoajciwCHOAW
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
		class IWUCOASWkdkow
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
            

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class IWUCOASWkdkowCHOAW
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
    
		class UCIQOAXSCJIWhcuiwxhiaiw
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

		// Update is called once per frame
		void Update()
		{
        
		}
	}
}
