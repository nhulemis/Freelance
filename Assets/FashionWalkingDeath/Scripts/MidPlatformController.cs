using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class MidPlatformController : MonoBehaviour
    {
        //Serialized Data
        [SerializeField]
        private int avatarIndex;
        [SerializeField]
        private Transform avatarHolder;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void setAvatar(int avatarIndex)
        {
            this.avatarIndex = avatarIndex;
            avatarHolder.GetChild(avatarIndex+1).gameObject.SetActive(true);
        }
        public int getAvatarIndex()
        {

            return avatarIndex;
        }
    }
}
