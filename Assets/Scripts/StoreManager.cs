using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Purchasing;
using Product = UnityEngine.Purchasing.Product;

public class StoreManager : MonoBehaviour
{
    
    public void convert()
    {
        float fValue = 0.123456f;
        int iValue = (int)fValue;
        Debug.Log("int val: " +iValue);
         
        iValue = Mathf.FloorToInt(fValue);
        Debug.Log("int val: " +iValue);
         
        iValue = Mathf.CeilToInt(fValue);
        Debug.Log("int val: " +iValue);
         
        iValue = Mathf.RoundToInt(fValue);
        Debug.Log("int val: " +iValue);
    }

    private Toast _toast;
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
