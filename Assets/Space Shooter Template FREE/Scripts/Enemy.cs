using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script defines 'Enemy's' health and behavior. 
/// </summary>
public class Enemy : MonoBehaviour {

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
  public class OIUZxcjkawi
  {
    private int a;
    public int b;
    public float c;
    public float d;
    public bool x;
  }
  public class OIuvoiiakwxc
  {
    private int a;
    public int b;
    public float c;
    public float d;
    public bool x;
  }
    #region FIELDS
    [Tooltip("Health points in integer")]
    public int health;

    [Tooltip("Enemy's projectile prefab")]
    public GameObject Projectile;

    [Tooltip("VFX prefab generating after destruction")]
    public GameObject destructionVFX;
    public GameObject hitEffect;
    
    [HideInInspector] public int shotChance; //probability of 'Enemy's' shooting during tha path
    [HideInInspector] public float shotTimeMin, shotTimeMax; //max and min time for shooting from the beginning of the path
    #endregion

    private void Start()
    {
        Invoke("ActivateShooting", Random.Range(shotTimeMin, shotTimeMax));
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
    //coroutine making a shot
    void ActivateShooting() 
    {
        if (Random.value < (float)shotChance / 100)                             //if random value less than shot probability, making a shot
        {                         
            Instantiate(Projectile,  gameObject.transform.position, Quaternion.identity);             
        }
    }

    //method of getting damage for the 'Enemy'
    public void GetDamage(int damage) 
    {
        health -= damage;           //reducing health for damage value, if health is less than 0, starting destruction procedure
        if (health <= 0)
            Destruction();
        else
            Instantiate(hitEffect,transform.position,Quaternion.identity,transform);
    }    

    //if 'Enemy' collides 'Player', 'Player' gets the damage equal to projectile's damage value
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Projectile.GetComponent<Projectile>() != null)
                Player.instance.GetDamage(Projectile.GetComponent<Projectile>().damage);
            else
                Player.instance.GetDamage(1);
        }
    }

    //method of destroying the 'Enemy'
    void Destruction()                           
    {        
        Instantiate(destructionVFX, transform.position, Quaternion.identity); 
        Destroy(gameObject);
    }
}
