using UnityEngine;
using UnityEngine.SceneManagement;

namespace CubeSurfing.scripts
{
	public class ShopManager : MonoBehaviour
	{
		public Transform chatctereParent;
		string[] unloackedCharactere;
		public GameObject nino;
		[Header("Sounds")]
		public AudioSource gooBackSound;
		public AudioSource buyButtonSound;
		public AudioSource noCurrencySound;
		public static ShopManager instance; 
		// Start is called before the first frame update
		void Awake(){
			if(instance==null)instance=this;
			else if(instance!=this)Destroy(this.gameObject);
		}
		void Start()
		{
    	
			nino.SetActive(true);
			updateUnloackedCharctere();
			unhideUnloacked();

		}
		public void  unhideUnloacked(){
			updateUnloackedCharctere();
			foreach(string n in unloackedCharactere){
            
				childIndexByName(n); 
			}
    	
		}
		private void childIndexByName(string n){
			int length=chatctereParent.childCount;
			for(int i=0;i<length;i++){
				GameObject obj=chatctereParent.GetChild(i).gameObject;
				if(n==obj.name){
					obj.transform.GetChild(0).gameObject.SetActive(false);
				}
			}

		}

		// Update is called once per frame
		void Update()
		{
        
		}
		public void selectedItem(int i){

			updateUnloackedCharctere();
			bool isLocked=true;
			string clickedCharactereName=chatctereParent.GetChild(i).gameObject.name;
			foreach(string name in unloackedCharactere){
				if(name==clickedCharactereName){
					isLocked=false;
				}

			}
			if(!isLocked){
				buyButtonSound.Play();
				nino.SetActive(false);
				print("the chatctere selected is : "+i);
				PlayerPrefs.SetInt("SelectedCharactere",i+1);
				SelectedItemManager.instance.showItem(i);
			}else {
				noCurrencySound.Play();
				print("Charctere is Not Loocked");
			}
    	
		}
		public void gooBack(){
			gooBackSound.Play();
			int i= PlayerPrefs.GetInt("current_level");
			SceneManager.LoadScene(i+"");
		}
		private void updateUnloackedCharctere(){
			string names=PlayerPrefs.GetString("UnloackedCharacters");
			unloackedCharactere=names.Split('+');
		}
		public void ninoSelected(){
			nino.SetActive(true);
			int ii=	PlayerPrefs.GetInt("SelectedCharactere");
			PlayerPrefs.SetInt("SelectedCharactere",0);
			SelectedItemManager.instance.hideItem(ii-1);
    

		}
	}
}
