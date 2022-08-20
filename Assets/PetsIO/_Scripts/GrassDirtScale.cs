using UnityEngine;

namespace PetsIO._Scripts
{
    public class GrassDirtScale : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            transform.Rotate(Vector3.up * Random.Range(0, 350));
            transform.localScale = transform.localScale * Random.Range(0.8f, 1.3f);
            transform.position = new Vector3(transform.position.x, 0.05f, transform.position.z);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
