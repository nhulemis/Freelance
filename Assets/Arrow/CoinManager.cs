using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateCurrentCollectedCoin(int newCollected=0)
    {
        int currentCollectedCoin = getCurrentCollectedCoin();
        currentCollectedCoin += newCollected;
        PlayerPrefs.SetInt("CurrentCollectedCoin", currentCollectedCoin);
    }
    public int getCurrentCollectedCoin()
    {
        return PlayerPrefs.GetInt("CurrentCollectedCoin");
    }
    public bool haveEnoughCoin(int value)
    {
        return getCurrentCollectedCoin() >= value;
    }
}
