using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class generationLevel : MonoBehaviour
    {
        public GameObject[] level;
        // Start is called before the first frame update
        public void StartGenerate()
        {
            Instantiate(level[ Random.Range(0, level.Length) ], transform.position, transform.rotation);
        }

    }
}
