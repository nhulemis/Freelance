using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class textUp : MonoBehaviour
    {
        private float timer;
        // Start is called before the first frame update
        void Start()
        {
            Time.timeScale = 0;
            timer = 1.2f;
        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.fixedDeltaTime;
            transform.Translate(Vector3.up*Time.fixedDeltaTime);
            Debug.Log(timer);
            if (timer < 0)
            {
                Destroy(this.gameObject);
            }
            GetComponent<TextMesh>().color = new Color(1,1,1,timer);
        
        }
    }
}
