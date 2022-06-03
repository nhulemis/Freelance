using UnityEngine;

namespace Game
{
    public class DeathSite : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            // col.gameObject.SetActive(false);
            // GameManager.Instance.spawnMng.SpawnOne();
        }
    }
}
