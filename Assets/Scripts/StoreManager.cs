using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class StoreManager : MonoBehaviour
{
    private string buyNotThing = "com.DefaultCompany.StepJump.BuySomething";

    private string unlockLevel = "com.DefaultCompany.StepJump.UnlockLevel";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPurchaseComplete(Product prod)
    {
        if (prod.definition.id == unlockLevel)
        {
            Debug.Log("unlock");    
        }

        if (prod.definition.id == buyNotThing)
        {
            Debug.Log("nothing");
        }
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
    {
        Debug.Log($"{product.definition.id} failed 'coz {reason}");
    }
    
}
