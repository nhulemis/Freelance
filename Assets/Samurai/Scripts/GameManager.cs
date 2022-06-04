﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public  enum GameState{play,end,wait};
    public  GameState currentState;
    public  static GameManager instance;
    void  Awake(){
        if(instance==null){
            instance=this;
        }else if(instance!=this){
            Destroy(this.gameObject);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentState=GameState.wait;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void enablePlayMode(){
        currentState=GameState.play;
    } public void enableEndyMode(){
        currentState=GameState.end;
        UiManager.instance.win();

    } public void enableWaitMode(){
        currentState=GameState.wait;
    }
}
