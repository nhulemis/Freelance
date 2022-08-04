using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

/// <summary>
/// Class attached to the Player GameObject in the hierarchy. In charge to handle the Player the player controls, detect touch and collision.
/// </summary>
public class Player : MonoBehaviour
{
	public Transform playerSprite;
	public SpriteRenderer sr;
	GameManager gameManager;
	public Vector3 defaultPosition = Vector3.zero;

	public float jumpWidth
	{
		get
		{
			return FindObjectOfType<Circle>().GetWidth()/2f - sr.sprite.bounds.size.x * 0.5f * sr.transform.localScale.x;		
		}
	}

	void Awake()
	{
		gameManager = FindObjectOfType<GameManager>();
		sr.color = gameManager.playerColor;
	}

	void Start()
	{
		DOStart();
	}

	public float GetRotation()
	{
		return transform.eulerAngles.z;
	}

	public void DOPosition(float x, float y)
	{
		defaultPosition = new Vector3(x,y,2f);
		playerSprite.position = defaultPosition;
		sr.transform.localPosition = new Vector3(-jumpWidth, 0, 0);
	}

	public void DOStart()
	{
		transform.DORotate(new Vector3(0,0,-360f), 10, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1,LoopType.Incremental);
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
	public void ActivateTouchControl()
	{
		InputTouch.OnTouchedDown += OnTouchDown;
	}

	public void DesactivateTouchControl()
	{
		InputTouch.OnTouchedDown -= OnTouchDown;
	}

	void OnTouchDown (TouchDirection td)
	{

		if(sr.transform.localPosition.x > 0)
		{
			var v = new Vector3(-jumpWidth, 0, 0);
			sr.transform.DOLocalMove(v, 0.1f)
				.OnComplete(OnCompleteJump);
		}
		else
		{
			var v = new Vector3(+jumpWidth, 0, 0);
			sr.transform.DOLocalMove(v, 0.1f)
				.OnComplete(OnCompleteJump);
		}

	}

	void OnCompleteJump()
	{
		if(DOTween.IsTweening(Camera.main))
			return;
		
		gameManager.Add1Point();
		FindObjectOfType<CameraManager>().DOShake();
	
	}

	public void AnimPlayer(float targetPos)
	{
		StopAllCoroutines();

		if(gameManager.isGameOver)
			return;
		
		StartCoroutine(_AnimPlayer(targetPos));
	}

	public IEnumerator _AnimPlayer(float targetPos)
	{
		yield return 0;
	}

	public void DOOnTriggerEnter2D(Collider2D other)
	{
		FindObjectOfType<GameManager>().GameOver();
	}

}
