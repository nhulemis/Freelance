using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmBuyItem : MonoBehaviour
{

    //public Sprite iconItem;
    private string id;
    [SerializeField] private Image iconView;

    [SerializeField] private TextMeshProUGUI price;
    [SerializeField] private TextMeshProUGUI title;

    public void Init(string id, Sprite icon, string title, string price)
    {
        this.id = id;
        if (icon != null)
        {
            iconView.sprite = icon;
        }
        if (!string.IsNullOrEmpty(price))
        {
            this.price.text = price;
        }

        if (!string.IsNullOrEmpty(title))
        {
            this.title.text = title;
        }
    }
    
    public void Buy()
    {
        StoreManager.Instance.Buy(id);
    }

    public void Cancel()
    {
        Destroy(gameObject);
    }
}
