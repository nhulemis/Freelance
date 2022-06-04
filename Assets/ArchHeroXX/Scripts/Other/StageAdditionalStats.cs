using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class StageAdditionalStats : MonoBehaviour
    {
        // Start is called before the first frame update
        void Awake()
        {
            int stage = PlayerPrefs.GetInt("stage");
            GetComponent<Stats>().hp += stage*30;
            GetComponent<Stats>().damage += stage*5;
            GetComponent<Stats>().atkSpeed -= stage*0.07f;
            GetComponent<Stats>().weaponFlySpeed += stage*0.25f;
            GetComponent<Stats>().speed += stage*0.15f;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
