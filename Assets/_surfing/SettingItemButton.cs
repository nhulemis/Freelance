using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingItemButton : MonoBehaviour
{
    [HideInInspector]public Image img;
    [HideInInspector]public Transform trans;
    // Start is called before the first frame update
    
    void Awake(){
    	img=GetComponent<Image>();
    	trans=this.transform;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
