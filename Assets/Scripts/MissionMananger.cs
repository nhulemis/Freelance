using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionMananger : MonoBehaviour
{
     public GameObject LockmodePanel;
     public GameObject unlockmodePanel;
     public GameObject playmodePanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void enableplaymode(){
    	LockmodePanel.SetActive(false);
    	unlockmodePanel.SetActive(false);
    	playmodePanel.SetActive(true);
    }public void enableLockmode(){
    	LockmodePanel.SetActive(true);
    	unlockmodePanel.SetActive(false);
    	playmodePanel.SetActive(false);
    }public void enableunloackmode(){
    	LockmodePanel.SetActive(false);
    	unlockmodePanel.SetActive(true);
    	playmodePanel.SetActive(false);
    }
}
