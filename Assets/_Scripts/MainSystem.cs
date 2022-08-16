using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSystem : MonoBehaviour
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
    
    
    public GameObject AllRoad1;
    public GameObject AllRoad2;
    public GameObject AllRoad3;
    // Start is called before the first frame update
    void Start()
    {
        AllRoad2 = Instantiate(AllRoad1, AllRoad1.transform.position + (Vector3.forward * 88),
            AllRoad1.transform.rotation);
        
        AllRoad3 = Instantiate(AllRoad1, AllRoad1.transform.position + (Vector3.forward * 88 * 2),
            AllRoad1.transform.rotation);
    }

    // Update is called once per frame
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
                    if (hit.collider.name == "b_tryagain" && GameItemManager.Instance.IsEnoughCoin())
                    {
                        //GameObject.Find("ADS").SendMessage("ShowInterstitial");
                        GetComponent<AudioSource>().Play();
                        hit.collider.gameObject.AddComponent<ButtonClickEffect>();
                        Application.LoadLevel(Application.loadedLevel);
                        //GameItemManager.Instance.UseCoin(1);
                    }

                    if (hit.collider.name == "b_mainmenu")
                    {
                        //GameObject.Find("ADS").SendMessage("ShowInterstitial");
                        GetComponent<AudioSource>().Play();
                        hit.collider.gameObject.AddComponent<ButtonClickEffect>();
                        GameItemManager.Instance.ReloadLevel();
                    }
                }
            }
        }

    }
}
