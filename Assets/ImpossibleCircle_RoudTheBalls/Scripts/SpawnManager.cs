using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Class in charge to pooled the particle to not have to instantiate and destroy them each time the player make a point (about 200 particles each time the player earns 1 point).
/// </summary>
public class SpawnManager : Singleton<SpawnManager> 
{
	public GameObject particle;
	List<ParticleSystem> listParticle = new List<ParticleSystem>();

	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	public void Init()
	{
		CreatePoolParticle();
	}

	void CreatePoolParticle()
	{
		while(listParticle.Count < 300)
		{
			var go = Instantiate(particle) as GameObject;
			go.gameObject.SetActive(false);
			go.transform.parent = transform;
			var epe = go.GetComponent<ParticleSystem>();
			listParticle.Add(epe);
		}
	}

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
  public class IOUqhjkmn
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
	public void SpawnParticle(Color c, Vector3 pos, Vector3 rot)
	{
    ParticleSystem p = listParticle.Find(pa => pa.gameObject.activeInHierarchy == false);

		while(p == null)
		{
			var go = Instantiate(particle) as GameObject;
			go.gameObject.SetActive(false);
			go.transform.parent = transform;
			var epe = go.GetComponent<ParticleSystem>();
			listParticle.Add(epe);

			p = listParticle.Find(pa => pa.gameObject.activeInHierarchy == false);
		}


		//p.GetComponent<ParticleSystem>().SetColor("_TintColor", c);
		p.transform.position = pos;
		p.transform.eulerAngles = rot;
		p.gameObject.SetActive(true);
		p.Emit(5);
	}
}
