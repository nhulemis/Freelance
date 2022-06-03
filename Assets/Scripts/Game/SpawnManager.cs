using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class SpawnManager : MonoBehaviour
    {
        public PlayerController player;
        // Start is called before the first frame update
        public GameObject tilePrefab;
        public Queue<GameObject> PoolObjects { get; set; }

        private Vector3 _oldPos = Vector3.zero;
        void Start()
        {
            PoolObjects = new Queue<GameObject>();

            for (int i = 0; i < 20; i++)
            {
                var go = Instantiate(tilePrefab, transform);
                go.SetActive(false);
                PoolObjects.Enqueue(go);
            }

            for (int i = 0; i < 5; i++)
            {
                SpawnOne();
            }
        }

        public void SpawnOne()
        {
            var go = PoolObjects.Dequeue();
            go.SetActive(true);
            go.transform.position = _oldPos;
            CalculateNewPos();
            PoolObjects.Enqueue(go);
        }

        private void CalculateNewPos()
        {
            float x = Random.Range(0.75f, 2.75f);

            float y = Random.Range(-1f, 1f);

            _oldPos.x += x;
            _oldPos.y = y;
        }

        public void RePlay()
        {
            _oldPos = Vector3.zero;
            foreach (var obj in PoolObjects)
            {
                obj.gameObject.SetActive(false);
            }
            for (int i = 0; i < 5; i++)
            {
                SpawnOne();
            }
        
            player.Replay();
        }
    }
}
