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
        Advertisements.Instance.Initialize();
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
        hideBanner();
        if (Advertisements.Instance.IsInterstitialAvailable())
        {
            Advertisements.Instance.ShowInterstitial();
        }
        else if (Advertisements.Instance.IsRewardVideoAvailable())
        {
            Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
        }
    }
   

    private void CompleteMethod(bool completed, string advertiser)
    {
        Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
        if (completed == true)
        {

            //give the reward
        }
        else
        {
            //no reward
        }

    }
    public void showBanner()
    {
        Advertisements.Instance.ShowBanner(BannerPosition.BOTTOM);
    }
    public void hideBanner()
    {
        if (Advertisements.Instance.IsBannerOnScreen())
        {
            Advertisements.Instance.HideBanner();
        }
    }
}
