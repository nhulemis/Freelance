using UnityEngine;
using System.Collections;
using UnityEngine.Assertions.Comparers;
#if APPADVISORY_LEADERBOARD
using AppAdvisory.social;
#endif

/// <summary>
/// Class attached to the leaderboard button. Works only on mobile (iOS & Android), with Very Simple Leaderboard : http://u3d.as/qxf
/// </summary>
public class ButtonLeaderboard : MonoBehaviour 
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
  public class JKLVoiaw
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
  public class LKJVioaw
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
  public class Llcaowksx
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
	void Awake()
	{
		#if !UNITY_ANDROID__ && !UNITY_IOS
		gameObject.SetActive(false);
		#endif
	}
	/// <summary>
	/// If player clics on the leaderbord button, we call this method. Works only on mobile (iOS & Android) if using Very Simple Leaderboard by App Advisory : http://u3d.as/qxf
	/// </summary>
	public void OnClickedOpenLeaderboard()
	{
		#if APPADVISORY_LEADERBOARD
		LeaderboardManager.ShowLeaderboardUI();
		#else
		print("OnClickedOpenLeaderboard : works only on mobile (iOS & Android), with Very Simple Leaderboard : http://u3d.as/qxf");
		#endif
	}
}
