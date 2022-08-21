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
    void Start()
    {
    	// PlayerPrefs.SetString("UnloackedCharacters","nino");
      // Advertisements.Instance.Initialize(); 
        //parent.GetChild(0).gameObject.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showItem(int s){
    	for(int i=0;i<parent.childCount-1;i++){
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
    // Advertisements.Instance.ShowRewardedVideo(CompleteMethod);

       
    }
    private void CompleteMethod(bool completed, string advertiser)
    {
      Debug.Log("Closed rewarded from: "+advertiser+" -> Completed " + completed);
    if(completed == true)
    {
     int money= PlayerPrefs.GetInt("Total_Coin",10000);
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
    	    int money= PlayerPrefs.GetInt("Total_Coin",10000);
    	    money-=1000;
    		 PlayerPrefs.SetInt("Total_Coin",money);;
    }
    private bool haveMoney(){
    	 int money=  PlayerPrefs.GetInt("Total_Coin",10000);
    	return  money>=1000?true:false;
    }
    public void hideItem(int ii){
    	 parent.GetChild(ii).gameObject.SetActive(false);
    }
}
