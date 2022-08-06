using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script attaches to ‘VisualEffect’ objects. It destroys or deactivates them after the defined time.
/// </summary>
public class VisualEffect : MonoBehaviour {

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
    [Tooltip("the time after object will be destroyed")]
    public float destructionTime;

    private void OnEnable()
    {
        StartCoroutine(Destruction()); //launching the timer of destruction
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
    IEnumerator Destruction() //wait for the estimated time, and destroying or deactivating the object
    {
        yield return new WaitForSeconds(destructionTime); 
        Destroy(gameObject);
    }
}
