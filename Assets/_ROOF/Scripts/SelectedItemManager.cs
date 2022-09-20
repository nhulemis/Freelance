using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedItemManager : MonoBehaviour
{
    
    public static SelectedItemManager instance;
    public Transform parent;


    void Awake(){
    	if(instance==null){
    		instance=this;

    	}else if(instance!=this)Destroy(this.gameObject);
    }
    // Start is called before the first frame update
 
        public class xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX
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

        public xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX()
        {
            
        }
        public xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX GetxsDpXMJnHBuWNyJsZFRQsqOkTLCqDX(){
        var clasx = new xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX();
        return  clasx;
    }

    public string RandomStringxsDpXMJnHBuWNyJsZFRQsqOkTLCqDX(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
    {
    	// PlayerPrefs.SetString("UnloackedCharacters","nino");
       // 
        //parent.GetChild(0).gameObject.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showItem(int s){
    	for(int i=0;i<parent.childCount;i++){
    		 parent.GetChild(i).gameObject.SetActive(false);

    	}
    	 parent.GetChild(s).gameObject.SetActive(true);
    }
    public void unloackRandom(){
    	print("Unloack Random");
          if(!haveMoney())
              return;
           print("yeees Money Enough");
          bool alreadyUnloacked=false;
          int charactereLength=parent.childCount;
          while(!alreadyUnloacked){
          	//Get all Unloacked Charactere Names
          	string cnames=PlayerPrefs.GetString("UnloackedCharacters");
          	string[] unloackedItems=cnames.Split('+');
          	if(unloackedItems.Length>=charactereLength+1)
          	  {
          	  	//Pop Up Message : All Charactere are Unloacked
          	  	print("all Charactere are Unlocked , Congrait !!");
          	  	return;
          	  }
          	  bool exist=true;
          	  while(exist){
                int s=Random.Range(0,charactereLength);
                string cn=parent.GetChild(s).gameObject.name;
                if(notAlreadyExist(ref unloackedItems,cn)){
                   
              		retreiveMoney();
              		ShopManager.instance.setTotalCoinText();
              		PlayerPrefs.SetInt("SelectedCharactere",s);
                    string newUnloackedName=parent.GetChild(s).gameObject.name;
                    string alreadyUnloackedNames=cnames;
                    alreadyUnloackedNames+='+'+newUnloackedName;
                    print("the already charctere existing are"+alreadyUnloackedNames);
                    PlayerPrefs.SetString("UnloackedCharacters",alreadyUnloackedNames);
                    print("the new Charactre is"+newUnloackedName);
                    print("the new charctere existing are"+alreadyUnloackedNames);
                    ShopManager.instance.unhideUnloacked();
                    exist=false;
              		alreadyUnloacked=true;
              		return;
                
                }

          	  }

          
             
          }

           
    }
    private bool notAlreadyExist(ref string[] nn,string ncn){
    	foreach(string n in nn){
    		if(n==ncn)
    		return false;
    	}
         return true;

    }
    public void rewardUnloack(){
        print("reward unloack");
       	//Show ads
        doubleMoney();
          
    	
    	  
    }
    public void doubleMoney(){
        //stance.ShowRewardedVideo(CompleteMethod);

       
    }
   
        public class GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI
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

        public GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI()
        {
            
        }
        public GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI GetGiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI(){
        var clasx = new GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI();
        return  clasx;
    }

    public string RandomStringGiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void CompleteMethod(bool completed, string advertiser)
    {
      Debug.Log("Closed rewarded from: "+advertiser+" -> Completed " + completed);
    if(completed == true)
    {
     int money= PlayerPrefs.GetInt("Total_Coin");
          money+=500;
         PlayerPrefs.SetInt("Total_Coin",money);
         unloackRandom();
    }
     else
    {
       //no reward
    }
    }
    private void retreiveMoney(){
    	    int money= PlayerPrefs.GetInt("Total_Coin");
    	    money-=1000;
    		 PlayerPrefs.SetInt("Total_Coin",money);;
    }
    private bool haveMoney(){
    	 int money=  PlayerPrefs.GetInt("Total_Coin");
    	return  money>=1000?true:false;
    }
    public void hideItem(int ii){
    	 parent.GetChild(ii).gameObject.SetActive(false);
    }
}
