using UnityEngine;
using game_sub;

public class Shield : MonoBehaviour
{
	public Animator anim;

	private int shieldSpeed;

	private void Update()
	{
		if (GameManager.Instance.uIManager.gameState == GameState1.PLAYING || GameManager.Instance.uIManager.gameState == GameState1.MENU)
		{
			base.transform.Rotate(0f, 0f, (float)shieldSpeed * Time.deltaTime);
		}
	}
	public void convert()
	{
		// float fValue = 0.123456f;
		// int iValue = (int)fValue;
		// Debug.Log("int val: " +iValue);
  //        
		// iValue = Mathf.FloorToInt(fValue);
		// Debug.Log("int val: " +iValue);
  //        
		// iValue = Mathf.CeilToInt(fValue);
		// Debug.Log("int val: " +iValue);
  //        
		// iValue = Mathf.RoundToInt(fValue);
		// Debug.Log("int val: " +iValue);
	}

	public void SetShieldSpeed(int _shieldSpeed)
	{
		shieldSpeed = _shieldSpeed;
	}

	public void HideShield()
	{
		shieldSpeed = 0;
		anim.Play("ShieldHide");
	}
}
