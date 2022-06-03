using UnityEngine;

namespace Game
{
    public class SceneMng : MonoBehaviour
    {
        public Canvas mainCanvas;

        public GameObject LoseGamePopup;

        private void Start()
        {
            mainCanvas = FindObjectOfType<Canvas>();
        }

        public void LoseGame()
        {
            LoseGamePopup.SetActive(true);
        }
    }
}
