using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace CubeSurfing.scripts
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
		
		public class TaoLaHUATUC
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaHUATUC()
			{
				
			}
		}
		public class TaoLaoTU
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaoTU()
			{
				
			}
		}
		public class Timea
		{
			// public methods
			public void DisplayCurrentTime(  )
			{
                    
			}

			// private variables
			int Year;
			int Month;
			int Date;
			int Hour;
			int Minute;
			int Second;


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
