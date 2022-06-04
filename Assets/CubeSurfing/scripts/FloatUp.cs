using UnityEngine;

namespace CubeSurfing.scripts
{
    public class FloatUp : MonoBehaviour
    {
        public float speed=1;
        // Start is called before the first frame update
        void Start()
        {
            Destroy(this.gameObject, 1f);
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
    }
}
