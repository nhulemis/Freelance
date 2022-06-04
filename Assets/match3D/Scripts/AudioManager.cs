using UnityEngine;

namespace match3D.Scripts
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField]
        private AudioSource mergeFailedSound;
        public AudioSource mergeSuccededSound;
        public AudioSource uiButtonClick;
        public static AudioManager instance;
        
        
    
        private void Awake()
        {
            if (!instance) instance = this;
            
            
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void playMergeFailed()
        {
            
            
            mergeFailedSound.Play();
        }
        public void playMergeSucceded()
        {
            mergeSuccededSound.Play();
        }
        public void playButtonClick()
        {
            uiButtonClick.Play();
        }
         
    }
}
