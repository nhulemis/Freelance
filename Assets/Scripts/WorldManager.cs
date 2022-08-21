using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
     public static WorldManager instance;
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
    	while(currentWorld==previousWorld){
    		currentWorld=Random.Range(0,worlds.Length);

    	}
    	worlds[currentWorld].SetActive(true);
    	previousWorld=currentWorld;
    }
    private void hideWorlds(){
    	for(int i=0;i<worlds.Length;i++){
    		worlds[i].SetActive(false);
    	}
    }
}
