using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxerController : MonoBehaviour
{
    [SerializeField] Animator anim;
    // Start is cal led before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      checkForDrag();  
    }
    private void checkForDrag(){
    	if(Input.GetMouseButtonDown(0) && !PlayerController.instance.inRunMoode && PlayerController.instance.isDraging){
    		//Start Punch
    		anim.SetBool("Punch",true);
    		Invoke("dePunch",.2f);
    	}
    }
    private void dePunch(){
    	anim.SetBool("Punch",false);
    }
}
