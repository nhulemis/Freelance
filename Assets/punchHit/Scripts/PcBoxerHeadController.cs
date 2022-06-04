using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class PcBoxerHeadController : MonoBehaviour
{
  
    
    [SerializeField] PcRagdoll pcRagdoll;
    private static int pcLife;
    /*****Head Hit Sounds **************/
    [SerializeField] AudioSource[] headHit;




    public static PcBoxerHeadController instance;

    void Awake(){
    	if(instance==null)
    	{
    		instance=this;
    		}else if(instance!=this){
    			Destroy(this);
    		}
    } 
    
	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag=="NpcGlove"){
			int i=Random.Range(0,headHit.Length);
			headHit[i].Play();
			if(pcLife==0){
				print("Player Head shot NOOOOOOO !");
		        PlayerController.instance.pcLoose();
			    PlayerController.instance.animateOff();
		   // pcRagdoll.toogleRagdoll(true);
		        loose(true);

		   // Invoke("playerRelive",2f);

			}else{
				//Head Hit Animation
				pcLife--;
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
		 pcRagdoll.toogleRagdoll(true);
		 PlayerController.instance.animateOn();
		 loose(false);
	}
	public void addLifeToPc(int index){
		pcLife=index;
	}
}
