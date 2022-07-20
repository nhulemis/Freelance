using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdManager : MonoBehaviour
{
    public static AdManager instance;
    private void Awake()
    {
        if (!instance) instance = this;
        else if (instance != this) Destroy(this.gameObject);

        //Ads Init
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void showInter()
    {
        
    }
   

    private void CompleteMethod(bool completed, string advertiser)
    {
        

    }
    public void showBanner()
    {
        
    }
    public void hideBanner()
    {
       
    }
}
