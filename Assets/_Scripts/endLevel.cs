﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endLevel : MonoBehaviour
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
    public class Akjhcuiaw
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
    private float timer;

    public bool levelEnded;
    
    

    // Update is called once per frame
    void Update()
    {

        if (levelEnded)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                transform.localPosition = new Vector3(0, 0, 0);
                GameObject.Find("t_cross").transform.localPosition = new Vector3(0, 1.25f, 0);
                timer = -999;
            }
        }
    }
}
