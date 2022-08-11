using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class menu : MonoBehaviour
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
    public class Acawasczx
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
    private int curCar;
    // Update is called once per frame

    void Start()
    {
        curCar =0;
        CheckSkin();
        SetCarSkin();

        GameObject.Find("t_cross").GetComponent<TextMesh>().text = PlayerPrefs.GetInt("score")+"";
        GameObject.Find("t_cross2").GetComponent<TextMesh>().text = PlayerPrefs.GetInt("score")+"";
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.tag == "Button")
                {
                    if (hit.collider.name == "b_start")
                    {
                        GetComponent<AudioSource>().Play();
                        hit.collider.gameObject.AddComponent<ButtonClickEffect>();
                        Application.LoadLevel("gameplay");
                    }

                    if (hit.collider.name == "b_left")
                    {
                        curCar -= 1;
                        if (curCar < 0) curCar = GameObject.Find("_SkinsCar").GetComponent<skinsCar>().carSkin.Length-1;
                        CheckSkin();
                        SetCarSkin();
                        GetComponent<AudioSource>().Play();
                    }
                    if (hit.collider.name == "b_right")
                    {
                        curCar += 1;
                        if (curCar > GameObject.Find("_SkinsCar").GetComponent<skinsCar>().carSkin.Length-1) curCar = 0;
                        CheckSkin();
                        SetCarSkin();
                        GetComponent<AudioSource>().Play();
                    }
                    if (hit.collider.name == "b_sounds")
                    {
                        hit.collider.gameObject.AddComponent<ButtonClickEffect>();
                        AudioListener.volume = 1 - AudioListener.volume;
                        GetComponent<AudioSource>().Play();

                        if (AudioListener.volume == 1)
                        {
                            hit.collider.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
                        }
                        else
                        {
                            hit.collider.GetComponent<SpriteRenderer>().color = new Color(1,1,1,0.6f);
                        }
                    }
                    if (hit.collider.name == "b_noads")
                    {
                        hit.collider.gameObject.AddComponent<ButtonClickEffect>();
                        GameObject.Find("IAP").SendMessage("BuyProductID", "gp_no_ads");
                    }
                    
                }
            }
        }
    }


    void SetCarSkin()
    {
        
        
        var cp = GameObject.Find("carPlace");
        
        foreach (Transform child in cp.transform)
        {
            Destroy((child.gameObject));
        }

        var cr = Instantiate(GameObject.Find("_SkinsCar").GetComponent<skinsCar>().carSkin[curCar],
            cp.transform.position, cp.transform.rotation);
        cr.transform.parent = cp.transform;
    }

    void CheckSkin()
    {
        var score = PlayerPrefs.GetInt("score");
        var scNeed = 0;
        if (curCar == 0) scNeed = 0;
        if (curCar == 1) scNeed = 2;
        if (curCar == 2) scNeed = 5;
        if (curCar == 3) scNeed = 10;
        if (curCar == 4) scNeed = 20;
        if (curCar == 5) scNeed = 22;
        if (curCar == 6) scNeed = 24;
        if (curCar == 7) scNeed = 30;
        if (curCar == 8) scNeed = 40;
        if (curCar == 9) scNeed = 50;
        if (curCar == 10) scNeed = 60;
        if (curCar == 11) scNeed = 65;
        if (curCar == 12) scNeed = 70;
        if (curCar == 13) scNeed = 75;
        if (curCar == 14) scNeed = 80;
        if (curCar == 15) scNeed = 85;
        if (curCar == 16) scNeed = 90;

        if (score >= scNeed)
        {
            PlayerPrefs.SetInt("skin", curCar);
            GameObject.Find("t_needScore").GetComponent<TextMesh>().text = " ";
            GameObject.Find("t_needScore2").GetComponent<TextMesh>().text = " ";
        }
        else
        {
            GameObject.Find("t_needScore").GetComponent<TextMesh>().text = "NEED " + scNeed + " SCORE";
            GameObject.Find("t_needScore2").GetComponent<TextMesh>().text = "NEED " + scNeed + " SCORE";
        }
        
    }
}
