using UnityEngine;

namespace Game.Scripts
{
	public class MissDetector : MonoBehaviour
	{
		public class ANCXUA
		{
			private int buaquadi;
			private string chusx;
			public float gmac;
			private double mciajx;

			public int getX()
			{
				return buaquadi;
			}
		}
		[SerializeField]BreakStocker leftStocker;
		int currentCurrenny;
		public static MissDetector instance;
		public AudioSource bricksPickUp;
		void Awake(){
			if(instance==null)instance=this;
			else if(instance!=this)Destroy(this.gameObject);
		}
	
		// Start is called before the first frame update
		void Start()
		{
			currentCurrenny=PlayerPrefs.GetInt("current_Currenny",0);
			GameManager.instance.setTotalCoin(currentCurrenny);
		}

		// Update is called once per frame
		void Update()
		{
        
		}
		private void OnTriggerEnter(Collider other){
			if(other.gameObject.tag=="pickupBrick" && GameManager.instance.gameIsplaying()){
				//Destroy(other.gameObject);
    		
    		
				leftStocker.addBrick(other.gameObject);
    		

			}if(other.gameObject.tag=="Coin"){
				currentCurrenny++;
				GameManager.instance.updateCurrentCollectedCoin(currentCurrenny);
				other.gameObject.GetComponent<MeshRenderer>().enabled=false;
				other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
				Destroy(other.gameObject,1f);
			}

		}
		public void setCurrency(){
			PlayerPrefs.SetInt("current_Currenny",currentCurrenny);

		}
	}
}
