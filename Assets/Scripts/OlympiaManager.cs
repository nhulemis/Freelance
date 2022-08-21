using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OlympiaManager : MonoBehaviour
{
    public  MainPlayerAvatarController mainPlayer;
    public  GameObject[] players;
    public  MainPlayerAvatarController[] playersScript;
    private MainPlayerAvatarController[] firstRoundQualified;
    private MainPlayerAvatarController[] secondeRoundQualified;
    private MainPlayerAvatarController[] thirdRoundQualified;
    public bool f,s,t;
    public static OlympiaManager instance;
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
        
           firstRoundQualified=new MainPlayerAvatarController[4];
           secondeRoundQualified=new MainPlayerAvatarController[2];
            thirdRoundQualified=new MainPlayerAvatarController[1];


        
    }

    // Update is called once per frame
    void Update()
    {
        if(f){
            firstRoundComplete();
        }if(s){
            secondeRoundComplete();
        }if(t){
            thirdRoundComplete();
        }
    }
    public void firstRoundComplete(){
         print("truuuuuuw");
        mainPlayer.firstMove();
    	int rightChildWinnerIndex=Random.Range(1,3);
    	playersScript[rightChildWinnerIndex].firstMove();
    	int firstleftChildWinnerIndex=Random.Range(3,5);
        playersScript[firstleftChildWinnerIndex].firstMove();
        int secondeleftChildWinnerIndex=Random.Range(5,7);
        playersScript[secondeleftChildWinnerIndex].firstMove();
        f=false;
        firstRoundQualified[0]=mainPlayer;
        firstRoundQualified[1]=playersScript[rightChildWinnerIndex];
        firstRoundQualified[2]=playersScript[firstleftChildWinnerIndex];
        firstRoundQualified[3]=playersScript[secondeleftChildWinnerIndex];




    	//players[rightChildWinnerIndex].GetComponent<players[rightChildWinnerIndex].name>().firstMove() ;

    }public void secondeRoundComplete(){
        int rightChildSecondeRoundWinnerIndex=Random.Range(2,4);
        firstRoundQualified[0].thirdeMove();
        firstRoundQualified[rightChildSecondeRoundWinnerIndex].thirdeMove();
    	s=false;
    }public void thirdRoundComplete(){
    	mainPlayer.fiveMove();
    }
}
