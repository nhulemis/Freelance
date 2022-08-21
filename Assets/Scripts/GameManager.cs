using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public enum GameState{play,wait,end};
	public GameState currentSatate;
	public 	GameObject enemyPrefab;
	public 	Transform enemyIdlePos;
	public static GameManager instance;
	void Awake(){
		if(instance==null)
		instance=this;
		else if(instance!=this){
			Destroy(this.gameObject);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
       currentSatate=GameState.wait; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void endRound(bool loose){
       if(currentSatate!=GameState.end){
        if(loose)
         UiManager.instance.loose();
         else{
            UiManager.instance.win();
         }
        currentSatate=GameState.end;

       }
        
    	
    }
    public void startPlay(){
    	currentSatate=GameState.play;
    	makeEnemy();
        if(SceneManager.GetActiveScene().name=="Challenges"){
            ChallengeManager.instance.upgradeEnnemyPower();
        }
    }
    void makeEnemy(){
    	Instantiate(enemyPrefab,enemyIdlePos.position,Quaternion.identity);
    }
}
