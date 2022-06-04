using ArchHeroXX.Scripts.Other;
using UnityEngine;

namespace ArchHeroXX.Scripts.skills
{
    public class damage : MonoBehaviour
    {
        public float damagePercenr;//1.15 - 15%
        public bool act;
    
        // Start is called before the first frame update
        void Update()
        {
            if (act) ActivateSkill();
        }

        // Update is called once per frame
        void ActivateSkill()
        {
            GameObject.Find("Hero").GetComponent<Stats>().damage *= damagePercenr;
            GameObject.Find("Hero").SendMessage("setupStats");
            GameObject.Find("skillCollector").SendMessage("SkillActivated", "damage");
            Destroy(gameObject);
        }
    }
}
