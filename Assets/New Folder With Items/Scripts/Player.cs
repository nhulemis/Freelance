using UnityEngine;

namespace New_Folder_With_Items.Scripts
{
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
}
