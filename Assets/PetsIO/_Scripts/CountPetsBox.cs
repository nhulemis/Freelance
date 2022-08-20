using UnityEngine;

namespace PetsIO._Scripts
{
    public class CountPetsBox : MonoBehaviour
    {
        private GameObject Main;
        void Awake()
        {
            Main = transform.parent.gameObject;
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (!Main) Destroy(this.gameObject);
        }
    }
}
