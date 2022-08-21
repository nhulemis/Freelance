using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedItemManager : MonoBehaviour
{
    
    public static SelectedItemManager instance;
    public Transform parent;
    [Header("Sounds")]
    
    public AudioSource noCurrencySound;
    public AudioSource reawrdButtonSound;
    public AudioSource buyCharctereButtonSound;
    
    void Awake(){
    	if(instance==null){
    		instance=this;

    	}else if(instance!=this)Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
    	// PlayerPrefs.SetString("UnloackedCharacters","nino");
      Advertisements.Instance.Initialize(); 
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
    	
          if(!haveMoney()){
            noCurrencySound.Play();
            return;
          }
            ;  
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
                  buyCharctereButtonSound.Play();
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
        reawrdButtonSound.Play();
        doubleMoney();
          
    	
    	  
    }
    public void doubleMoney(){
        Advertisements.Instance.ShowRewardedVideo(CompleteMethod);

       
    }
   
        public class HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb
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

        public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb()
        {
            
        }
        public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb GetHqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(){
        var clasx = new HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb();
        return  clasx;
    }

    public string RandomStringHqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void CompleteMethod(bool completed, string advertiser)
    {
      Debug.Log("Closed rewarded from: "+advertiser+" -> Completed " + completed);
    if(completed == true)
    {
     int money= PlayerPrefs.GetInt("current_score");
          money+=500;
         PlayerPrefs.SetInt("current_score",money);
         unloackRandom();
    }
     else
    {
       //no reward
    }
    }
    private void retreiveMoney(){
    	    int money= PlayerPrefs.GetInt("current_score");
    	    money-=1000;
    		PlayerPrefs.SetInt("current_score",money);
    }
    private bool haveMoney(){
    	 int money= PlayerPrefs.GetInt("current_score");
    	return  money>=1000?true:false;
    }
    public void hideItem(int ii){
    	 parent.GetChild(ii).gameObject.SetActive(false);
    }
}
