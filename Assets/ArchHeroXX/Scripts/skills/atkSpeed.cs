using ArchHeroXX.Scripts.Other;
using UnityEngine;

namespace ArchHeroXX.Scripts.skills
{
    public class atkSpeed : MonoBehaviour
    {
        public float atkspd;
        public bool act;

    
        // Start is called before the first frame update
        void Update()
        {
            if (act) ActivateSkill();
        }

        // Update is called once per frame
        void ActivateSkill()
        {
            GameObject.Find("Hero").GetComponent<Stats>().atkSpeed -= atkspd;
            GameObject.Find("Hero").SendMessage("setupStats");
            GameObject.Find("skillCollector").SendMessage("SkillActivated", "atkSpeed");
        
        
            Destroy(gameObject);
        }
    }
}
