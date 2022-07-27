using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserCoin : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI coin;

    private float _interval = 0.5f;
    private float time = 0f;
    private void OnEnable()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(UpdateCoin());
    }

    IEnumerator UpdateCoin()
    {
      while (true)
      {
        coin.text = $"{GameItemManager.Instance.GetTotalCoin().ToString()} <sprite name=\"coin\"> ";
        yield return new WaitForSeconds(_interval);
      }
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void ContinueWithSpendCoin()
    {
        
    }
}
