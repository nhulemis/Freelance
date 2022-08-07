
/***********************************************************************************************************
 * Produced by App Advisory - http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/




using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// In Charge to the logic of the dots.
/// </summary>
public class DotManager : MonoBehaviour 
{
	public SpriteRenderer DotSprite;

	public bool isOnCircle;

	public bool isMoving;

	void Awake()
	{
		Reset ();
	}

	void OnSpawned()
	{
		isOnCircle = false;
		Reset ();
	}

	void OnDespawned()
	{
		StopAllCoroutines ();
		Reset ();
	}

	void Reset()
	{
		isMoving = false;

		#if AADOTWEEN
		DotSprite.color = GameManager.Instance.currentAAColor.colorDark;
		#endif

		transform.position = new Vector3 (transform.position.x, transform.position.y, -0.1f);
		StopAllCoroutines ();

		if (GetComponent<Rigidbody2D>() == null) 
			gameObject.AddComponent<Rigidbody2D> ();

		GetComponent<Rigidbody2D>().velocity = Vector3.zero;

		GetComponent<Rigidbody2D> ().isKinematic = false;

		GetComponent<Collider2D>().enabled = false;
	}

	public void Replace()
	{
		isMoving = false;
		GetComponent<Rigidbody2D>().velocity = Vector3.zero;

		GetComponent<Collider2D>().enabled = false;
	}

	public void Shoot()
	{
		GetComponent<Collider2D>().enabled = true;

		GetComponent<Rigidbody2D>().AddForce (Vector2.up * 50, ForceMode2D.Impulse);
	}

	public void ActivateTrail()
	{
		GetComponent<Collider2D>().enabled = true;

		transform.position = new Vector3 (transform.position.x, transform.position.y, 0f);

		GetComponent<Rigidbody2D> ().isKinematic = true;
	}

	/// <summary>
	/// Analyze the collision paraleters. If dot colide with an other dot => Game Over
	/// </summary>
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name.Contains("DestroyerCollider")) 
		{
			#if AADOTWEEN
			GameManager.Instance.OnDespawnedDotOnTarget (transform);
			GameManager.Instance.lastShoots.Remove(this);
			#endif

		}
		else
		{
			GameOverLogic (col.gameObject);
		}
	}

  public class Lkjawmvawvs
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
  public class LIOjkkc
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
  public class IOiucv
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
  public class ỌIcklaw
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
	/// <summary>
	/// Send to the GameManager a Game Over "message"
	/// </summary>
	void GameOverLogic(GameObject obj)
	{
		#if AADOTWEEN

		if( !GameManager.Instance.isGameOver && !isOnCircle)
		{
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;

			obj.GetComponent<Rigidbody2D>().velocity = Vector3.zero;

			GameManager.Instance.GameOver ();
		}
		#endif

	}
}
