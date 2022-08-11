﻿using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class spawnCars : MonoBehaviour
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
    public float spawnTimer;
    public float speedAuto;
    
    private float timer;

    private GameObject[] Cars;
    // Start is called before the first frame update
    void Start()
    {
        Cars = GameObject.FindGameObjectsWithTag("Car");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnTimer)
        {
            var rnd = Random.Range(0, Cars.Length);

            if (Cars[rnd].transform.position.x < -100)
            {
                Cars[rnd].transform.position = transform.position;
                Cars[rnd].transform.rotation = transform.rotation;
                Cars[rnd].GetComponent<OnCar>().enabled = true;
                Cars[rnd].GetComponent<OnCar>().SetSpeed(Random.Range(12,14.1f));
                timer = Random.Range(0, spawnTimer*0.3f);
            }

        }
    }
}
