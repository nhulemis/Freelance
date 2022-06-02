using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Purchasing;
using Product = UnityEngine.Purchasing.Product;

public class StoreManager : MonoBehaviour
{
    private string buyNotThing = "com.DefaultCompany.StepJump.BuySomething";

    private string unlockLevel = "com.DefaultCompany.StepJump.UnlockLevel";

    private Toast _toast;
    // Start is called before the first frame update
    void Start()
    {
        _toast = FindObjectOfType<Toast>();
    }

    public static async void ExampleAsync()
    {
        string[] lines = { "First line", "Second line", "Third line" };
        using StreamWriter file = new("WriteLines2.txt");

        foreach (string line in lines)
        {
            if (!line.Contains("Second"))
            {
                await file.WriteLineAsync(line);
            }
        }
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
