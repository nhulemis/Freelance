using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;

[Serializable]
public class ProductItem
{
    public string id;
    public Sprite icon;
    public string price;
    public string title;
    public ProductType productType;

}

public class StoreManager : MonoBehaviour , IStoreListener
{
    public static StoreManager Instance;
    [SerializeField]
    private List<ProductItem> productItems;

    [SerializeField] private ProductItemView itemPrefab; 

    public Canvas mainCanvas;

    [SerializeField] private Transform productContainer;
    [SerializeField] private TextMeshProUGUI noProductAvailable;
    
    IStoreController m_StoreController;
    IAppleExtensions m_AppleExtensions;
    private Toast _toast;

   // [SerializeField] private GameObject removeAdsButton;

    [SerializeField] private TextMeshProUGUI currentScore;

    [SerializeField] private GameObject restoreButton;

    [SerializeField]
    private ProductItemView subButton;

    private ProductItem removeAdsInfo;
    [SerializeField] private GameObject loading;

    private GameObject loadingHolder;

    [SerializeField]
    private Transform subArea;
    private void Awake()
    {
        _toast = FindObjectOfType<Toast>();

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
#if UNITY_IOS
            restoreButton.SetActive(true);
            #else
            restoreButton.SetActive(false);
#endif
        ShowLoading();
        
    }

    void ShowLoading()
    {
        if (loadingHolder != null)
        {
            Destroy(loadingHolder);
        }
        loadingHolder = Instantiate(loading, mainCanvas.transform);
    }

    void HideLoading()
    {
        if (loadingHolder != null)
        {
            Destroy(loadingHolder);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!IsInitIAP())
        {
            InitializePurchasing();
        }

        if (PlayerPrefs.HasKey("exp"))
        {
            string exp = PlayerPrefs.GetString("exp");
            var date = DateTime.Parse(exp);
            Debug.Log(date.AddYears(1).ToString());
            if (DateTime.Now.CompareTo(date.AddYears(1))>=0)
            {
                Debug.Log("het ngay");
                PlayerPrefs.SetInt("noads", 0);
                //removeAdsButton.SetActive(true);
            }
        }
        UpdateScore();

    }

    bool IsInitIAP()
    {
        return m_StoreController != null && m_AppleExtensions != null;
    }
    
    void InitializePurchasing()
    {
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        foreach (var prod in productItems)
        {
          builder.AddProduct(prod.id, prod.productType);
        }

        UnityPurchasing.Initialize(this, builder);
    }

    private void OnEnable()
    {
        //UpdateScore();
    }

    public void UpdateScore()
    {
        currentScore.text = $"You have: {GameItemManager.Instance.GetTotalCoin().ToString()} <sprite name=\"coin\"> ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy(string id)
    {
        ShowLoading();

        m_StoreController.InitiatePurchase(id);
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        noProductAvailable.gameObject.SetActive(true);
        restoreButton.SetActive(false);

        Debug.Log($"In-App Purchasing initialize failed: {error}");
        HideLoading();
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
    {
        var product = purchaseEvent.purchasedProduct;

        Debug.Log($"Processing Purchase: {product.definition.id}");
        _toast.SaySomething(product.definition.id );
        Purcharse(product.definition.id);
        return PurchaseProcessingResult.Complete;
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
    {
        _toast.SaySomething($"{product.definition.id} failed 'coz {reason}");
        Debug.Log($"Purchase failed - Product: '{product.definition.id}', PurchaseFailureReason: {reason}");
        HideLoading();
        
    }

    Sprite GetSprite(string id)
    {
        var p = productItems.Find(ti => ti.id == id);
        return p.icon;
    }
    
    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        Debug.Log("In-App Purchasing successfully initialized");
        
        m_StoreController = controller;
        
        m_AppleExtensions = extensions.GetExtension<IAppleExtensions>();

        var listProduct = new List<ProductItem>();


        for (int i = productContainer.childCount - 1; i >= 0; i--)
        {
            Destroy(productContainer.GetChild(i).gameObject);
        }


        foreach (var product in m_StoreController.products.all)
        {
            

            var p = new ProductItem()
            {
                productType = product.definition.type,
                id = product.definition.id,
                price = product.metadata.localizedPriceString,
                icon = GetSprite(product.definition.id),
                title = product.metadata.localizedTitle
            };
            listProduct.Add(p);

        }

        foreach (var item in listProduct)
        {
          if (item.productType == ProductType.Subscription)
          {
            var gi = Instantiate(subButton, subArea);
            gi.Init(item.price,item.id,item.icon,item.title, item.productType);
          }
          else
          {
            var go = Instantiate(itemPrefab, productContainer);
            go.Init(item.price,item.id,item.icon,item.title, item.productType);
          }
        }
        noProductAvailable.gameObject.SetActive(false);
        
        //restoreButton.SetActive(true);

        HideLoading();
        _toast.SaySomething("IAP init successed");
    }

    IEnumerator UpdateCoin()
    {
       
        var old = currentScore.color;
        currentScore.text = $"You have: {GameItemManager.Instance.GetTotalCoin().ToString()} <sprite name=\"coin\"> ";
        currentScore.color = Color.red;
        yield return new WaitForSeconds(2);
        currentScore.color = old;
    }

    private void AddCoin(int coin)
    {
      var popupConfirm = FindObjectOfType<ConfirmBuyItem>()?.gameObject;
      if (popupConfirm != null)
      {
        Destroy(popupConfirm);
      }
      _toast.SaySomething($"added {coin} coin");
      GameItemManager.Instance.AddCoin(coin);
      StartCoroutine(UpdateCoin());
    }
    
    private void Purcharse(string producId)
    {
        switch (producId)
        {
            case "inapp1":
                AddCoin(5);
                break;
            
            case "inapp2_2":
                AddCoin(12);

                break;
            
            case "inapp3": 
              AddCoin(19);

                break;
            
            case "inapp4": 
              AddCoin(29);
                break;
            
            case "inapp5":  
              AddCoin(39);
                break;
            
            case "buyapp1_1":                _toast.SaySomething("Remove Ads");
                PlayerPrefs.SetInt("noads", 1);
                DateTime dateTime = DateTime.Now;
                PlayerPrefs.SetString("exp",dateTime.ToString());
                var popupConfirm = FindObjectOfType<ConfirmBuyItem>()?.gameObject;
                if (popupConfirm != null)
                {
                    Destroy(popupConfirm);
                }
               // removeAdsButton.SetActive(false);
                break;
            
            case "buyapp2":                _toast.SaySomething("Add 5 score");

                break;
            
            case "buyapp3":                _toast.SaySomething("added 5 Magic Coin");

                break;
            
        }
        
        HideLoading();
    }

    public void RemoveAds()
    {
        
    }
    
}
