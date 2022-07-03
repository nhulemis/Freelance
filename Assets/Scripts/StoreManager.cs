using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Purchasing;
using Product = UnityEngine.Purchasing.Product;

public class StoreManager : MonoBehaviour
{
    private string buyNotThing = "com.DefaultCompany.StepJump.BuySomething";

    private string unlockLevel = "com.DefaultCompany.StepJump.UnlockLevel";

    private Toast _toast;

    [SerializeField] private GameObject restoreButton;

    private void Awake()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            restoreButton.SetActive(true);
        }
        else
        {
            restoreButton.SetActive(false);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _toast = FindObjectOfType<Toast>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPurchaseComplete(Product prod)
    {
        _toast.SaySomething(prod.definition.id );
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
    {
        _toast.SaySomething($"{product.definition.id} failed 'coz {reason}");
    }
    
}
