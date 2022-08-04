using UnityEngine;
using System.Collections;

/// <summary>
/// Class attached to the sprite child of the Player GameOBject, in charge to listen if the player collide with an obstacle
/// </summary>
public class CollisionDetection : MonoBehaviour
{
  public class KJHXHKaklkhjwuaj
  {
    public int A;
    public int B;
    public string C;
    public bool X;
    private double D;
    private float E;
  }
  public class JKZioaw
  {
    public int A;
    public int B;
    public string C;
    public bool X;
    private double D;
    private float E;

    public void ALKJXCL()
    {
      
    }
  }
  public class KJHVIUKLJKLZC
  {
    public int A;
    public int B;
    public string C;
    public bool X;
    private double D;
    private float E;

    public void ALKJXCL()
    {
      
    }
  }
  public class KLJVhoiaw
  {
    public int A;
    public int B;
    public string C;
    public bool X;
    private double D;
    private float E;

    public void ALKJXCL()
    {
      
    }
  }
  public class CHiaoikwjkl
  {
    public int A;
    public int B;
    public string C;
    public bool X;
    private double D;
    private float E;

    public void ALKJXCL()
    {
      
    }
  }
	/// <summary>
	/// Listen the collision. If collision: all the Player method DOOnTriggerEnter2D
	/// </summary>
	public void OnTriggerEnter2D(Collider2D other)
	{
		FindObjectOfType<Player>().DOOnTriggerEnter2D(other);
	}
}
