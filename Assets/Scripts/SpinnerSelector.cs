using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int selectedSpinnerIndex=PlayerPrefs.GetInt("SelectedCharactere"); 
       foreach(Transform child in this.transform){
       	    child.gameObject.SetActive(false);
       }
       GameObject selectedSpinner=this.transform.GetChild(selectedSpinnerIndex).gameObject;
       selectedSpinner.SetActive(true);
       selectedSpinner.GetComponent<SpinnerManager>().assignToController();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
