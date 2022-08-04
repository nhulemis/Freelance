﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Class in charge to desactivate the particles.
/// </summary>
public class ParticleLogic : MonoBehaviour 
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
	void OnEnable()
	{
		StartCoroutine("waitForDesactivate");
	}

	void OnDisable()
	{
		StopCoroutine("waitForDesactivate");
	}

	IEnumerator waitForDesactivate()
	{
		yield return new WaitForSeconds(1);
		gameObject.SetActive(false);
	}
}
