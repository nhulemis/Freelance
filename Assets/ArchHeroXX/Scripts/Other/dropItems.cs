using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class dropItems : MonoBehaviour
    {
        public GameObject[] items;
        public float[] Chance;
    
    
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void DropItems(int chanc)
        {
            // 0 - gold
            // 1 - key
            // 2 - soul
            // 3 - crystal upgrade
        
            //Instantiate(items[0], transform.position, items[0].transform.rotation);
        
            float rnd;
            Vector3 vec;
        
            for(int i = 0; i < items.Length; i++)
            {
                rnd = Random.Range(0.00f, 100.01f);
                vec = new Vector3(Random.Range(-0.30f, 0.30f), 0, Random.Range(-0.30f, 0.30f));
                if (rnd < Chance[i]*chanc)
                {
                    if (i == 1) GameObject.Find("mainConfig").SendMessage("SetKeys"); 
                
                    var inst = Instantiate(items[i], transform.position+vec, items[i].transform.rotation);
                    Destroy(inst, 4);
                }
            
            }
        
            
            Destroy(this.gameObject);
        }

        void Informer(int num)
        {
            if (num == 1)
            {
                var td = Instantiate(GameObject.Find("textDescription"), Camera.main.transform.position, GameObject.Find("textDescription").transform.rotation);
                int ic = 1;
                td.SendMessage("SetTextIcon", ic);
                td.SendMessage("SetText", "Key received");
            }
        }

    
    }
}
