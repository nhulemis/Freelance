using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeWorldManager : MonoBehaviour
{
     public static ChallengeWorldManager instance;
     public GameObject[] worlds;
     int currentWorld;
     int previousWorld=-1;
     void Awake(){
     	if(instance==null){
     		instance=this;
     	}else if(instance!=this){
     		Destroy(this.gameObject);
     	}
     }

    // Start is called before the first frame update
    void Start()
    {
        selectWorld();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void selectWorld(){
    	hideWorlds();
    	
       currentWorld=PlayerPrefs.GetInt("ChallengeIndex");
       if(currentWorld>worlds.Length)
       currentWorld=0;
    	worlds[currentWorld].SetActive(true);
    	previousWorld=currentWorld;
    }
   
        public class UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU
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

        public UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU()
        {
            
        }
        public UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU GetUmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU(){
        var clasx = new UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU();
        return  clasx;
    }

    public string RandomStringUmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void hideWorlds(){
    	for(int i=0;i<worlds.Length;i++){
    		worlds[i].SetActive(false);
    	}
    }
}
