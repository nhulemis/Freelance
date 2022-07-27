using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

public class GameItemManager : MonoBehaviour
{

  [SerializeField] private UserCoin coin;
    
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

#if DebugLog
      SceneManager.LoadScene("Mobile Console/Assets/LogConsole", LoadSceneMode.Additive);
#endif
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

    public void AddCoinDaily()
    {
      if (PlayerPrefs.HasKey("daily_coin"))
      {
        string date = PlayerPrefs.GetString("daily_coin");
        var yesterday = DateTime.Parse(date);
        if (DateTime.Now.CompareTo(yesterday.AddDays(1)) >= 0)
        {
            AddCoin(5);
        }
      }
      else
      {
        AddCoin(5);
        PlayerPrefs.SetString("daily_coin",DateTime.Now.ToString());
      }
    }

    public bool IsEnoughCoin()
    {
      bool isEnough = GetTotalCoin() > 0;
      if (!isEnough)
      {
        coin.Alert();
      }
      return GetTotalCoin() > 0;
    }
}
