using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItemManager : MonoBehaviour
{
    
    public static GameItemManager Instance
    {
        get;
        set;
    }

    private void Awake()
    {
        Object.DontDestroyOnLoad(this);
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            UnityEngine.Object.Destroy(base.gameObject);
        }
    }

    
    private int totalScore;

    public int GetTotalCoin()
    {
        totalScore = PlayerPrefs.GetInt("TotalCoin" , 0);
        return totalScore;
    }

    private int energy;
    public int GetEnergy()
    {
        energy = PlayerPrefs.GetInt("Energy" , 5);
        return energy;
    }

    public void UpdateEnergy(int changedAmount)
    {
        energy = GetEnergy();
        energy += changedAmount;
        PlayerPrefs.SetInt("Energy", totalScore);
    }

    public void UseCoin(int used)
    {
        totalScore -= used;
        PlayerPrefs.SetInt("TotalCoin", totalScore);

    }
    public void AddCoin(int coin)
    {
        totalScore += coin;
        PlayerPrefs.SetInt("TotalCoin", totalScore);
    }
}
