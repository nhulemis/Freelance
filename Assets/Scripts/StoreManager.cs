using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Purchasing;
using Product = UnityEngine.Purchasing.Product;

public class StoreManager : MonoBehaviour
{
    private string buyNotThing = "com.DefaultCompany.StepJump.BuySomething";

    private string unlockLevel = "com.DefaultCompany.StepJump.UnlockLevel";

    private Toast _toast;

    [SerializeField] private TextMeshProUGUI currentScore;

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

    private void OnEnable()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        currentScore.text = $"Coin: {GameItemManager.Instance.GetTotalCoin().ToString()}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPurchaseComplete(Product prod)
    {
        _toast.SaySomething(prod.definition.id );
        Purcharse(prod.definition.id);

    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
    {
        _toast.SaySomething($"{product.definition.id} failed 'coz {reason}");
        Purcharse(product.definition.id);
    }

    private void Purcharse(string producId)
    {
        switch (producId)
        {
            case "inapp1":
                _toast.SaySomething("added 5 coin");
                GameItemManager.Instance.AddCoin(5);
                UpdateScore();
                break;
            
            case "inapp2":                _toast.SaySomething("added 5 hammer");

                break;
            
            case "inapp3":                _toast.SaySomething("you bought success 5 energy");
                GameItemManager.Instance.UpdateEnergy(5);
                break;
            
            case "inapp4":                _toast.SaySomething("added 5 MP");

                break;
            
            case "inapp5":                _toast.SaySomething("added 5 crit");

                break;
            
            case "buyapp1":                _toast.SaySomething("Remove Ads");
                PlayerPrefs.SetInt("Noads", 1);
                break;
            
            case "buyapp2":                _toast.SaySomething("Add 5 score");

                break;
            
            case "buyapp3":                _toast.SaySomething("added 5 Magic Coin");

                break;
            
        }
    }
    
}
