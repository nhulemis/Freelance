using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class skillCollector : MonoBehaviour
    {
        public GameObject[] skills;
        private GameObject canvas;
        private float corX;

        // Start is called before the first frame update
        void Start()
        {
            canvas = GameObject.Find("Canvas");
            corX = -1.9f;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void showThreeSkills()
        {
            Time.timeScale = 0;
            canvas.active = false;

            GameObject gs;
            int rnd;
        
            rnd= Random.Range(0, skills.Length);
            gs = Instantiate(skills[rnd], new Vector3(corX, 0, -2.5f), skills[rnd].transform.rotation);
            gs.transform.parent = Camera.main.transform;
            gs.transform.localPosition = new Vector3(corX,-3,10);
            corX += 1.9f;
        
            rnd= Random.Range(0, skills.Length);
            gs = Instantiate(skills[rnd], new Vector3(corX, 0, -2.5f), skills[rnd].transform.rotation);
            gs.transform.parent = Camera.main.transform;
            gs.transform.localPosition = new Vector3(corX,-3,10);
            corX += 1.9f;
        
            rnd= Random.Range(0, skills.Length);
            gs = Instantiate(skills[rnd], new Vector3(corX, 0, -2.5f), skills[rnd].transform.rotation);
            gs.transform.parent = Camera.main.transform;
            gs.transform.localPosition = new Vector3(corX,-3,10);
            corX += 1.9f;
        
            GameObject.Find("g_selectSkill").transform.localPosition = new Vector3(0,0,0);
        
            corX = -1.9f;
        }

        void SkillActivated(string st)
        {
            Time.timeScale = 1;
        
        
            GameObject[] skillGUI = GameObject.FindGameObjectsWithTag("SkillGUI");
        
            foreach (GameObject skl in skillGUI)
            {
                Destroy(skl);
            }

            EngDescription(st);
            canvas.active = true;
        
            GameObject.Find("g_selectSkill").transform.localPosition = new Vector3(999,0,0);
        }

        void EngDescription(string t)
        {

            if (t == "atkSpeed") t = "Attack speed increased";
            if (t == "crit") t = "Critical chance increased";
            if (t == "damage") t = "Attack damage increased";
            if (t == "dobleAtk") t = "Now your attacks are double";
            if (t == "treeBullets") t = "Your bullets are flying in different directions";
            if (t == "poisonAtk") t = "your bullets poison the enemy";
            
        
        
        
            if ( GameObject.Find("descriptEn") ) Destroy(GameObject.Find("descriptEn"));
            var td = Instantiate(GameObject.Find("textDescription"), Camera.main.transform.position, GameObject.Find("textDescription").transform.rotation);
            td.name = "descriptEn";
            int ic = 0;
            td.SendMessage("SetTextIcon", ic);
            td.SendMessage("SetText", t);
            td.transform.parent = Camera.main.transform;
        }
    }
}
