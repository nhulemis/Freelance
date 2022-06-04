using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class oldHealthLerp : MonoBehaviour
    {
        private GameObject hp;

        private float timer;
        // Start is called before the first frame update
        void Start()
        {
            foreach (Transform child in transform.parent)
            {
                if (child.name == "hp") hp = child.gameObject;
            }
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            if (timer > 0.5)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, hp.transform.localScale, Time.deltaTime*4);

                if (timer > 2)
                {
                    Destroy(this);
                }
            }
        }
    }
}
