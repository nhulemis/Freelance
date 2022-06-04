using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class healthBar : MonoBehaviour
    {
        private GameObject hp;
        private GameObject hpOld;
    
        private GameObject numHp;
        private GameObject numHpSdw;

        private GameObject myParent;

        private Vector3 fixVector;

        private float maxHp;
        private float curHp;
    
        private float fixScale;

        private bool Hero;
    
        // Start is called before the first frame update
        void Start()
        {
            foreach (Transform child in transform)
            {
                if (child.name == "hp") hp = child.gameObject;
                if (child.name == "hpOld") hpOld = child.gameObject;
                if (child.name == "numHp") numHp = child.gameObject;
                if (child.name == "numHpSdw") numHpSdw = child.gameObject;
            }
        
        
            myParent = transform.parent.gameObject;
            myParent.SendMessage("SetHealthBar", gameObject);
        
            transform.parent = null;
            fixVector = transform.position - myParent.transform.position;

            if (myParent.tag == "Hero")
            {
                Hero = true;
            }
            else
            {
                foreach (Transform child in hp.transform)
                {
                    if (child.name == "healthbar_hp") child.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.9f, 0.17f, 0.12f);
                }
                transform.eulerAngles = new Vector3(90,0,0);
                Destroy(numHp);
                Destroy(numHpSdw);
            }
            
            SetHealthBar();
        }

        void SetHealthBar()
        {
            maxHp = myParent.GetComponent<Stats>().hp;
            curHp = myParent.GetComponent<Stats>().curHp;

            fixScale = curHp / maxHp;
            hpOld.AddComponent<oldHealthLerp>();
            hp.transform.localScale = new Vector3(fixScale,1,1);

            if (Hero)
            {
                numHp.GetComponent<TextMesh>().text = curHp+"";
                numHpSdw.GetComponent<TextMesh>().text = curHp+"";
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (myParent)
            {
                transform.position = myParent.transform.position+fixVector;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
