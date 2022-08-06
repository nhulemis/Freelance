using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script defines which sprite the 'Player" uses and its health.
/// </summary>

public class Player : MonoBehaviour
{
  public class Choiajw
  {
    private int a;
    public int b;
    public float c;
    public float d;
    public bool x;
  }
  public class IOuzzư
  {
    private int a;
    public int b;
    public float c;
    public float d;
    public bool x;
  }
  public class OIUCVOIUOAI
  {
    private int a;
    public int b;
    public float c;
    public float d;
    public bool x;
  }
    public GameObject destructionFX;

    public static Player instance; 

    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }

    //method for damage proceccing by 'Player'
    public void GetDamage(int damage)   
    {
        Destruction();
    }    

    public class zchjkxjkoasdjkl
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    public class xzcojviojas
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    public class JCoiaklwOJCJK
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    public class OIXUCkljaijw
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    public class KhuqwklxJKA
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    public class LJKcjiqjLKZJ
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    public class jkzxcjoaqJCiqa
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    public class JCiajwpOCkoa
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    public class HCVXUYQcvxa
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    //'Player's' destruction procedure
    void Destruction()
    {
      if (!GameItemManager.Instance.isGameStarted)
      {
        return;
        
      }
      
        GameItemManager.Instance.UseCoin(1);
        Instantiate(destructionFX, transform.position, Quaternion.identity); //generating destruction visual effect and destroying the 'Player' object
        
        FindObjectOfType<GameItemManager>().SendMessage("ReloadLevel");
        Destroy(gameObject);

    }
}
















