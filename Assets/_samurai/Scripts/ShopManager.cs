using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShopManager : MonoBehaviour
{
	public Transform chatctereParent;
    [SerializeField]
     private Text totalCoins;
    string[] unloackedCharactere;
    public GameObject nino;
    public static ShopManager instance; 
    public GameObject swordList;
    public GameObject characterList;
    // Start is called before the first frame update
    void Awake(){
    	if(instance==null)instance=this;
    	else if(instance!=this)Destroy(this.gameObject);
    }
 
        public class PBCCRefbinLCauOxoodUttlvaWcxQpp
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public PBCCRefbinLCauOxoodUttlvaWcxQpp()
        {
            
        }
        public PBCCRefbinLCauOxoodUttlvaWcxQpp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PBCCRefbinLCauOxoodUttlvaWcxQpp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PBCCRefbinLCauOxoodUttlvaWcxQpp GetPBCCRefbinLCauOxoodUttlvaWcxQpp(){
        var clasx = new PBCCRefbinLCauOxoodUttlvaWcxQpp();
        return  clasx;
    }

    public string RandomStringPBCCRefbinLCauOxoodUttlvaWcxQpp(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
    {   
      PlayerPrefs.SetInt("Total_Coin",10000);
    	totalCoins.text=PlayerPrefs.GetInt("Total_Coin",0)+"";
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
   
        public class qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn()
        {
            
        }
        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn GetqKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(){
        var clasx = new qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn();
        return  clasx;
    }

    public string RandomStringqKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void childIndexByName(string n){
    	int length=chatctereParent.childCount;
        for(int i=0;i<length;i++){
        	GameObject obj=chatctereParent.GetChild(i).gameObject;
        	if(n==obj.name){
        		obj.transform.GetChild(2).gameObject.SetActive(false);
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
    		nino.SetActive(false);
         print("the chatctere selected is : "+i);
    	PlayerPrefs.SetInt("SelectedCharactere",i+1);
    	SelectedItemManager.instance.showItem(i);
    	}else {
    		print("Charctere is Not Loocked");
    	}
    	
    }
    public void gooBack(){
        print("goooo back");
       int i= PlayerPrefs.GetInt("Current_Level",0);
       SceneManager.LoadScene(i);
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
    public void setTotalCoinText(){
        totalCoins.text=PlayerPrefs.GetInt("Total_Coin",0)+"";
    }
    public void enableSwordItems(){
    	characterList.SetActive(false);
    	swordList.SetActive(true);

    }public void enableCharacterItems(){
    	characterList.SetActive(true);
    	swordList.SetActive(false);

    }
}
