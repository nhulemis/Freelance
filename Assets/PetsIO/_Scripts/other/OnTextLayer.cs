using UnityEngine;

namespace PetsIO._Scripts.other
{
    public class OnTextLayer : MonoBehaviour
    {
        public int Order;
        // Start is called before the first frame update
        void Start()
        {
            if (Order == 0) Order = 600;
            gameObject.GetComponent<MeshRenderer> ().sortingOrder = Order;
        }
    }
}
