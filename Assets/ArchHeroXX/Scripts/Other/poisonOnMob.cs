using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class poisonOnMob : MonoBehaviour
    {
        private float timer;

        public float damage;
        // Start is called before the first frame update
        void Start()
        {
            Destroy(this, 10.5f);
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
        
            if (timer > 2)
            {
                timer = 0;
                gameObject.SendMessage("DoDamage", damage);
            
                var td = Instantiate(GameObject.Find("textDmg"), transform.position+new Vector3(0,1,0), GameObject.Find("textDmg").transform.rotation);
            
                td.GetComponent<TextMesh>().color = new Color(0.7f,0.12f,0.8f);
                td.GetComponent<TextMesh>().text = "-" + Mathf.Round(damage);
                td.GetComponent<onTextDamage>().enabled = true;
            }
        }
    }
}
