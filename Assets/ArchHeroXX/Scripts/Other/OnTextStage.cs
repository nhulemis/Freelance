using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class OnTextStage : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            if (PlayerPrefs.GetInt("stage") == 0) PlayerPrefs.SetInt("stage", 1);

            GetComponent<TextMesh>().text = PlayerPrefs.GetInt("stage") + "";
            //  Destroy(gameObject, 3.5f);
        }
    }
}
