using UnityEngine;
using game_main;

public class Player : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Obstacle") && collision.gameObject.transform.position.y > base.transform.position.y)
		{
			GameManager.Instance.GameOver();
		}
	}
}
