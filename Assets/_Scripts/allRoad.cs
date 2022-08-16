using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allRoad : MonoBehaviour
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
    
    public class Awcbhse
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
    
    public GameObject[] pointBuilding;
    private GameObject[] buildings;
    // Start is called before the first frame update
    void Start()
    {
       

        buildings = GameObject.FindGameObjectsWithTag("Building");
        RandomPointBuildings();
    }

    // Update is called once per frame
    void RandomPointBuildings()
    {
        foreach (GameObject pb in pointBuilding)
        {
            var rnd = Random.Range(0, buildings.Length);
            //var b = Instantiate(buildings[rnd], pb.transform.position, buildings[rnd].transform.rotation);
            if (buildings[rnd].transform.position.x < -100)
            {
                buildings[rnd].transform.position = pb.transform.position;
                if (buildings[rnd].transform.position.x < 0)
                {
                    buildings[rnd].transform.localScale = new Vector3(1, 1, -1);
                }
                else
                {
                    buildings[rnd].transform.localScale = new Vector3(1, 1, 1);
                }
            }

            buildings[rnd].transform.parent = pb.transform;
        }
    }

    void NewLocation()
    {
        
        transform.Translate(Vector3.forward*88*3);

        foreach (GameObject pb in pointBuilding)
        {
            foreach (Transform child in pb.transform)
            {
                child.transform.position = new Vector3(-999,0,0);
                child.transform.parent = null;
            }
        }

        RandomPointBuildings();

    }

    void Update()
    {
        if (transform.position.z < Camera.main.transform.position.z - 120)
        {
            NewLocation();
        }
    }
}
