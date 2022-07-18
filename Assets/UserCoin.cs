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
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= _interval)
        {
            coin.text = $"You Have : {GameItemManager.Instance.GetTotalCoin().ToString()} coin";
            time = 0;
        }

    }

    public void ContinueWithSpendCoin()
    {
        int cCoin = GameItemManager.Instance.GetTotalCoin();
        if (cCoin >= 2 )
        {
            GameItemManager.Instance.UseCoin(2);
            GameManager.Instance.ContinueGame();
        }
    }
}
