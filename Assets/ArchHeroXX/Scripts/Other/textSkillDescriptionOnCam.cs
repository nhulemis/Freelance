using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class textSkillDescriptionOnCam : MonoBehaviour
    {
        public GameObject mainText;
        public GameObject sdwText;
        public GameObject ico;

        public Sprite[] icons;
    
        public int started;

        private float timer;
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (started == 1)
            {
                timer += Time.deltaTime;
                if (timer > 3.3f)
                {
                    timer = 1;
                    started = 2;
                }
            }

            if (started == 2)
            {
                if (timer < 3) timer += Time.deltaTime;
                mainText.transform.localScale = new Vector3(mainText.transform.localScale.x, -timer, mainText.transform.localScale.z);
                transform.Translate(Vector3.forward*Time.deltaTime*20);
            }
        }

    
        void SetTextIcon(int i)
        {
            ico.GetComponent<SpriteRenderer>().sprite = icons[i];
        }
    
        void SetTextColor(Color c)
        {
            mainText.GetComponent<TextMesh>().color = c;
        }
    
        void SetText(string t)
        {
            Destroy(gameObject, 5);
            started = 1;
            mainText.GetComponent<TextMesh>().text = t;
            sdwText.GetComponent<TextMesh>().text = t;
        
            var TextScript = mainText.GetComponent<TextMesh>();
            var texts = TextScript.text.Replace("\\n","\n");
            TextScript.text = texts;
        
            TextScript = sdwText.GetComponent<TextMesh>();
            texts = TextScript.text.Replace("\\n","\n");
            TextScript.text = texts;
        }
    
    }
}
