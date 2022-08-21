using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemySelector : MonoBehaviour
{
     public static EnnemySelector instance;
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
    public void selectEnemy(){
    	int childC=transform.childCount;
    	int selectedEnemyIndex=Random.Range(0,childC);

    	GameObject selectedObject=this.transform.GetChild(selectedEnemyIndex).gameObject;
    	selectedObject.SetActive(true);
    	selectedObject.GetComponent<EnnemyManager>().setWingsHolder();

    }
    private  void hideEnnemy(){
    	foreach(Transform child in this.transform){
    		child.gameObject.SetActive(false);
    	}
    }
}
