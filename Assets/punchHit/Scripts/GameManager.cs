using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     public enum gameState{isPlaying,stop};
    public gameState currentGameState;
    public static GameManager instance;
    void Awake(){
    	if(instance==null)instance=this;
    	else if(instance!=this)Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void inPlayMode(){
    	currentGameState=gameState.isPlaying;
        NpcController.instance.isPlaying(true);
    }
    public void inStopMode(){
    	currentGameState=gameState.stop;
        NpcController.instance.isPlaying(false);

    }
}
