using ArchHeroXX.Scripts.Other;
using UnityEngine;

namespace ArchHeroXX.Scripts.skills
{
    public class crit : MonoBehaviour
    {
        public float crits;
        public bool act;
        // Start is called before the first frame update
        void Update()
        {
            if (act) ActivateSkill();
        }

        // Update is called once per frame
        void ActivateSkill()
        {
            GameObject.Find("Hero").GetComponent<Stats>().critChance += crits;
            GameObject.Find("Hero").SendMessage("setupStats");
            GameObject.Find("skillCollector").SendMessage("SkillActivated", "crit");
            Destroy(gameObject);
        }
    }
}