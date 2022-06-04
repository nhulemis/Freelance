using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class Menu : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameObject.Find("t_gold").GetComponent<TextMesh>().text = PlayerPrefs.GetInt("gold")+"";
            GameObject.Find("t_stage").GetComponent<TextMesh>().text = PlayerPrefs.GetInt("stageMax")+"";
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (hit.collider.name == "b_play"){
                        Application.LoadLevel("game");
                    }
                }
            }
        }
    }
}
