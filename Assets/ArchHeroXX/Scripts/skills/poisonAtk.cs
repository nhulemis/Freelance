﻿using UnityEngine;

namespace ArchHeroXX.Scripts.skills
{
    public class poisonAtk : MonoBehaviour
    {
        public bool act;

    
        // Start is called before the first frame update
        void Update()
        {
            if (act) ActivateSkill();
        }

        // Update is called once per frame
        void ActivateSkill()
        {
            GameObject.Find("Hero").SendMessage("SetPoisonAtk");
            GameObject.Find("skillCollector").SendMessage("SkillActivated", "poisonAtk");
        
        
            Destroy(gameObject);
        }
    }
}
