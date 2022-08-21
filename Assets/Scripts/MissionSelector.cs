using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionSelector : MonoBehaviour
{
     public static MissionSelector instance;
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
        selectMission();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void selectMission(){
    	int cIndex=PlayerPrefs.GetInt("ChallengeIndex");
    	int i=0;
    	if(cIndex!=0){
    		foreach(Transform child in this.transform){
    			if(i<cIndex){
    				this.transform.GetChild(i).gameObject.GetComponent<MissionMananger>().enableunloackmode();

    			}if(i>cIndex){
    				this.transform.GetChild(i).gameObject.GetComponent<MissionMananger>().enableLockmode();

    			}
    			if(i==cIndex){
    				this.transform.GetChild(i-1).gameObject.GetComponent<MissionMananger>().enableplaymode();
    			}

    			i++;
    		}
    	}
    }
}
