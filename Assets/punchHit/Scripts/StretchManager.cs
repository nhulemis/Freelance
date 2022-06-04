using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using   Dreamteck.Splines;
public class StretchManager : MonoBehaviour
{
	TubeGenerator tubeGeneratorObj;
	[SerializeField] float punchSpeed=1;
	
    double clipValue=0;
    bool hasReachedDestination=true;
	void Awake(){
		tubeGeneratorObj=this.GetComponent<TubeGenerator>();
		
	}
	void Update(){
		
      if(clipValue<=1 && !hasReachedDestination)
      clipValue+=(Time.deltaTime*punchSpeed);
      else if(clipValue>1  ){
      	hasReachedDestination=true;

      }if(hasReachedDestination){
      	clipValue-=(Time.deltaTime*punchSpeed*1.5f);
      }
      tubeGeneratorObj.updateClipRange(0,clipValue);
      checkForMouve();
	}
	 void checkForMouve(){
	 	if(Input.GetMouseButtonDown(0)){
	 		if(hasReachedDestination){
	 			hasReachedDestination=false;
	 		}
	 	}
	 }
}
