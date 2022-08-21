using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
    [Serializable]
    public  struct ennemyPowerManager{
    	public float challengeIndex;
    	public float forwardSpeed;
    	public float crashSpeed;
    	public float dragForce;

    }
public class ChallengeManager : MonoBehaviour
{
     public ennemyPowerManager[] ennemyP;
     public static ChallengeManager instance;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void upgradeEnnemyPower(){
    	int challengeWinIndex=PlayerPrefs.GetInt("ChallengeIndex");
    	EnemyHolder.instance.upgradePower(ennemyP[challengeWinIndex]);

    }
}
