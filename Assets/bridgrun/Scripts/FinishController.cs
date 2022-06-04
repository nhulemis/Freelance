using UnityEngine;

namespace bridgrun.Scripts
{
    public class FinishController : MonoBehaviour
    {
        public Transform[] poses;
        public Transform finishCamPos;
        public EnnemyController[] ennemyC;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void classify()
        {

            ennemyC = FindObjectsOfType<EnnemyController>();




            int i = 2;
            int levelIndex = 1;
        
            foreach (EnnemyController ennemy in ennemyC)
            {
                i--;
                ennemy.classiffy(poses[i].position);              
            }
            levelIndex--;
       
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                print("Yoooooo Start Classification");
                GameManager.instance.endPlay();
                classify();
            
            
            
            
                camZoom();
            }
            if (other.gameObject.CompareTag("Ennemie"))
            {
                print("Yoooooo Player Loose Start Classification");
                GameManager.instance.endPlay();
            
            
            
                UiManager.instance.playerLoose();
            
            
            
            
            
            
            
                classify();
                camZoom();
            }

        }
        public void camZoom()
        {
            CameraController.instance.zoom(finishCamPos);
        }
    }
}
