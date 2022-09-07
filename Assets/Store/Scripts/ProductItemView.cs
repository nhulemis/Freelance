using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

public class ProductItemView : MonoBehaviour
{
    [SerializeField] private ConfirmBuyItem confirmBuyItem;
    public string id { get; set; }

    public TextMeshProUGUI price, txtTitle;
    public Image icon;

    private string title;
    
    public ProductType productType;
    public void Init(string price, string id, Sprite icon, string title,ProductType productType)
    {
        var bg = GetComponent<Image>();
        if (bg != null)
        {
            bg.color =  Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
        
        this.price.text = string.IsNullOrEmpty(price)? "BUY" : price;
        this.id = id;
        if (this.icon != null)
        {
          this.icon.sprite = icon;
        }
        this.title = title;
        if (txtTitle != null)
        {
          txtTitle.text = title;
        }

        this.productType = productType;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy()
    {
      if (productType == ProductType.Subscription)
      {
        StoreManager.Instance.Buy(id);
      }
      else
      {
        var go = Instantiate(confirmBuyItem,StoreManager.Instance.mainCanvas.transform);
        go.Init(id,this.icon.sprite,title,price.text);
      }
    }
}
