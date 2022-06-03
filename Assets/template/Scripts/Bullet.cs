using UnityEngine;
using game_sub;
public class Bullet : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Shield") && GameManager.Instance.uIManager.gameState == GameState1.PLAYING)
		{
			GameManager.Instance.GameOver();
			GameManager.Instance.camObject.GetComponent<CameraFollowTarget>().ShakeCamera();
			collision.transform.parent.GetComponent<Shield>().anim.Play("ShieldBlink");
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
	public void convert()
	{
		float fValue = 0.123456f;
		int iValue = (int)fValue;
		Debug.Log("int val: " +iValue);
         
		iValue = Mathf.FloorToInt(fValue);
		Debug.Log("int val: " +iValue);
         
		iValue = Mathf.CeilToInt(fValue);
		Debug.Log("int val: " +iValue);
         
		iValue = Mathf.RoundToInt(fValue);
		Debug.Log("int val: " +iValue);
	}
}
