using UnityEngine;
using UnityEngine.UI;

namespace FashionWalkingDeath.Scripts
{
    public class CombineUiController : MonoBehaviour
    {
        //Serialized Data
        [SerializeField]
        private Image fillTimeSprite;
        [Header("Option Sprite")]
        [SerializeField]
        private Image fOptionAvatar;
        [SerializeField]
        private Image sOptionAvatar;
        [SerializeField]
        private Image tOptionAvatar;
        [SerializeField]
        private Sprite tempAvatar;
        [SerializeField]
        private Transform buttonHolder;

        //Private Data
        private bool reacheadEndTime;
        private OptionController[] optionC;
        private void Awake()
        {
            optionC = GetComponentsInChildren<OptionController>();

        }
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (!reacheadEndTime)
            {
                float currentFill = fillTimeSprite.fillAmount;
                if (currentFill <= 0)
                {
                    reacheadEndTime = true;
                    UiManager.instance.disableCombiSelectorUi1();
                }
                else
                {
                    fillTimeSprite.fillAmount -= Time.deltaTime/3;

                }

            }
        }
        public void resetData(int avatarI)
        {
            setAvatarData(avatarI);
        
            foreach(OptionController child in optionC)
            {
                child.setCurrentIndex(avatarI);
            }
            fillTimeSprite.fillAmount = 1f;
            reacheadEndTime = false; 
        }
        private void setAvatarData(int avatarI)
        {
            Sprite[] data = LevelManager.instance.getCurrentLevelSprite(avatarI);
            if (data.Length >= 2)
            {
                fOptionAvatar.sprite = data[0];
                sOptionAvatar.sprite = data[1];
                tOptionAvatar.sprite = data[2];
            }
        

        }
    }
}
