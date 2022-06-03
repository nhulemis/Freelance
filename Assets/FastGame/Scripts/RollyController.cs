using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollyController : MonoBehaviour
{
    
    [SerializeField] GameObject winCam;
     [SerializeField] GameObject jumpCam;
    /****************************/
    //Effect
    [Header("Effects")]
      [SerializeField]GameObject crashEffect_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
    	if(other.gameObject.tag=="Finish"){
    		PlayerController.instance.reset();
    		PlayerController.instance.finishSoundsA();
    		Transform obj=GameObject.FindGameObjectWithTag("FinishParent").gameObject.transform;
    		for(int i=0;i<4;i++){
    			obj.GetChild(i).gameObject.SetActive(true);
    		}
    		winCam.SetActive(true);
    		Invoke("finishLevel",1.5f);
    	}if(other.gameObject.tag=="Jump"){
    		jumpCam.SetActive(true);
            Invoke("desactivateJumpCam",.55f);
    		PlayerController.instance.jump();
    	}if(other.gameObject.tag=="coin"){
    		CoinManger.instance.animate(other.gameObject.transform.position,5);
    		UiManager.instance.updateCurrenScoreText();
    		Destroy(other.gameObject,.4f);
    	}
    }
    private void desactivateJumpCam(){
    	jumpCam.SetActive(false);

    }
    //Collision Detection 
    void OnCollisionEnter(Collision other){
    	if(other.gameObject.tag=="dead"){

    		winCam.SetActive(true);
    		crashEffect_1.SetActive(true);
    		PlayerController.instance.stopMoving();
    		PlayerController.instance.disassembleCar();
    		UiManager.instance.Loose();
    	}
    }
    private void finishLevel(){
    	PlayerController.instance.inRoadSoundsR();
    	PlayerController.instance.stopMoving();
    	UiManager.instance.win();
    }
}
