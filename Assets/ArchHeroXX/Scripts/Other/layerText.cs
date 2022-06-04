using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class layerText : MonoBehaviour
    {
        public int SortingOrder;
        // Start is called before the first frame update
        void Start()
        {
            if (SortingOrder == 0) SortingOrder = 10;
            gameObject.GetComponent<MeshRenderer>().sortingOrder = SortingOrder;
            Destroy(this);
        }

    }
}
