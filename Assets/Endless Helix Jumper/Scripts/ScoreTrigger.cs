using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour {

	public Collider[] colliders;


	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			//score
			LevelController.instance.SetScore();
			SetColliders(false);
		}
	}

  class ABCu
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class ABCulkjasd
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class ABCulkjasdoijzxlkcozuxjkca
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class jkzcvjkai
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class jkzcvjkailjzxjklckjla
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
	public void SetColliders(bool state)
	{
		for (int i = 0; i < colliders.Length; i++)
		{
			colliders[i].enabled = state;
		}
	}
}
