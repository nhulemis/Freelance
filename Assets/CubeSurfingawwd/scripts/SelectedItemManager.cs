// using UnityEngine;
//
// namespace CubeSurfingawwd.scripts
// {
// 	public class SelectedItemManager : MonoBehaviour
// 	{
//     
// 		public static SelectedItemManager instance;
// 		public Transform parent;
// 		[Header("Sounds")]
//     
// 		public AudioSource noCurrencySound;
// 		public AudioSource reawrdButtonSound;
// 		public AudioSource buyCharctereButtonSound;
//     
// 		void Awake(){
// 			if(instance==null){
// 				
// 				
// 				instance=this;
//
// 			}else if(instance!=this)Destroy(this.gameObject);
// 		}
// 		// Start is called before the first frame update
// 		void Start()
// 		{
// 			// PlayerPrefs.SetString("UnloackedCharacters","nino");
// 			//Advertisements.Instance.Initialize(); 
//       
//       
//       
//       
// 			//parent.GetChild(0).gameObject.SetActive(true);
//        
// 		}
//
// 		// Update is called once per frame
// 		void Update()
// 		{
//         
// 		}
// 		public void showItem(int s){
// 			for(int i=0;i<parent.childCount;i++){
// 				parent.GetChild(i).gameObject.SetActive(false);
//
// 			}
// 			parent.GetChild(s).gameObject.SetActive(true);
// 		}
// 		public void unloackRandom(){
//     	
// 			if(!haveMoney()){
// 				noCurrencySound.Play();
// 				return;
// 			}
// 			;  
// 			print("yeees Money Enough");
// 			bool alreadyUnloacked=false;
// 			int charactereLength=parent.childCount;
// 			while(!alreadyUnloacked){
// 				//Get all Unloacked Charactere Names
// 				string cnames=PlayerPrefs.GetString("UnloackedCharacters");
// 				string[] unloackedItems=cnames.Split('+');
// 				if(unloackedItems.Length>=charactereLength+1)
// 				{
// 					//Pop Up Message : All Charactere are Unloacked
// 					return;
// 				}
// 				bool exist=true;
// 				while(exist){
// 					int s=Random.Range(0,charactereLength);
// 					string cn=parent.GetChild(s).gameObject.name;
// 					if(notAlreadyExist(ref unloackedItems,cn)){
//                    
// 						retreiveMoney();
// 						buyCharctereButtonSound.Play();
// 						PlayerPrefs.SetInt("SelectedCharactere",s);
// 						string newUnloackedName=parent.GetChild(s).gameObject.name;
// 						string alreadyUnloackedNames=cnames;
// 						alreadyUnloackedNames+='+'+newUnloackedName;
// 						PlayerPrefs.SetString("UnloackedCharacters",alreadyUnloackedNames);
// 						exist=false;
// 						alreadyUnloacked=true;
// 						return;
//                 
// 					}
//
// 				}
//
//           
//              
// 			}
//
//            
// 		}
// 		private bool notAlreadyExist(ref string[] nn,string ncn){
// 			foreach(string n in nn){
// 				if(n==ncn)
// 					return false;
// 			}
// 			return true;
//
// 		}
// 		public void rewardUnloack(){
// 			//Show ads
// 			reawrdButtonSound.Play();
// 			doubleMoney();
//           
//     	
//     	  
// 		}
// 		public void doubleMoney(){
// 			//Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
//         
//         
//         
//
//        
// 		}
// 		private void CompleteMethod(bool completed, string advertiser)
// 		{
// 			if(completed == true)
// 			{
// 				int money= PlayerPrefs.GetInt("current_score");
// 				money+=500;
// 				unloackRandom();
// 			}
// 			else
// 			{
// 				//no reward
// 			}
// 		}
// 		private void retreiveMoney(){
// 			int money= PlayerPrefs.GetInt("current_score");
// 			money-=1000;
// 			PlayerPrefs.SetInt("current_score",money);
// 		}
// 		private bool haveMoney(){
// 			int money= PlayerPrefs.GetInt("current_score");
// 			return  money>=1000?true:false;
// 		}
// 		public void hideItem(int ii){
// 			parent.GetChild(ii).gameObject.SetActive(false);
// 		}
// 	}
// }
