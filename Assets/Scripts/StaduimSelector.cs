using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaduimSelector : MonoBehaviour
{
    public GameObject[] staduim;
    public static StaduimSelector instance;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void selectStaduim(){
    	int staduimIndex=Random.Range(0,staduim.Length);
    	hideStaduim();
    	staduim[staduimIndex].SetActive(true);
    	staduim[staduimIndex].GetComponent<StaduimManager>().setMaterial();
    }
    private void hideStaduim(){
       foreach(Transform child in this.transform){
       	  child.gameObject.SetActive(false);
       }

    }
}
