using UnityEngine;

namespace ArchHeroXX.Scripts.Weapon
{
    public class translateForward : MonoBehaviour
    {
        private float speed;
    
        void SetWeaponSpeed(float spd)
        {
            speed = spd;
        }

        void Update()
        {
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
    }
}
