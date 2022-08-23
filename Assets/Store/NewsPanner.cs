using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewsPanner : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI string1 , string2 ,string3;
    // Start is called before the first frame update
    void Start()
    {
        string1.text = Application.productName;
        string2.text = Application.companyName;
        string3.text = DateTime.Now.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
