using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThisGo : MonoBehaviour
{
    public class ProductItem
    {
        public string id;
        public Sprite icon;
        public string price;
        public string title;

        public void Acoakwos()
        {
            id = price + title;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
