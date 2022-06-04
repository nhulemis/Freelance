using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class NpcBoxerHeadController : MonoBehaviour
{
  
    [SerializeField] AnimationToRagdoll npcRagdoll;
    private static int npcLife;
/*****Head Hit Sounds **************/
    [SerializeField] AudioSource[] headHit;
    public static NpcBoxerHeadController instance;

    void Awake(){
    	if(instance==null)
    	{
    		instance=this;
    		}else if(instance!=this){
    			Destroy(this);
    		}
    } 
    
	void OnCollisionEnter(Collision other){
	
		 if(other.gameObject.tag=="Player" ){
			 int i=Random.Range(0,headHit.Length);
			headHit[i].Play();
			npcLife++;
			 if(npcLife%2==0){
			 	 NpcController.instance.npcLoose();
			 print("Player Head shot Yeahhhhhhh !");
		    NpcController.instance.animationOff();
		    CameraShaker.Instance.ShakeOnce(2,.1f,.1f,1f);
			 //npcRagdoll.toogleRagdoll(true);
			//Time.timeScale=.2f;
			//Invoke("timeDefaultBack",0.03f);
			//Invoke("npcDie",1f);
            StartCoroutine("testSlowMo",.2f);
			print("player hiiiiiiiiiiittt");
			Invoke("win",1f);

			 }else{
			 	NpcController.instance.headHit();
			 	CameraShaker.Instance.ShakeOnce(2,.1f,.1f,1f);
			 }
            
			
			
			

		}

	}
	IEnumerator testSlowMo(){
		Time.timeScale=.2f;
   yield return new WaitForSeconds(.1f);
   timeDefaultBack();

	}
	private void npcDie(){
       NpcController.instance.npcDie();
      // Time.timeScale=1f;
	}
	private void timeDefaultBack(){
		Time.timeScale=1f;

	}
	private void win(){
        UiManager.instance.win();
	} private void loose(bool b){
        UiManager.instance.loose(b);
	}
	private void playerRelive(){
		 npcRagdoll.toogleRagdoll(true);
		 PlayerController.instance.animateOn();
		 loose(false);
	}
	public void addLifeToNpc(int index){
		npcLife=index;
	}
}
