using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class translateText : MonoBehaviour
    {
        public string Rus;
        public string Eng;
        // Start is called before the first frame update
        void Start()
        {
            if (Application.systemLanguage + "" == "Russian"){
                GetComponent<TextMesh>().text = Rus;
            }else{
                GetComponent<TextMesh>().text = Eng;
            }
            GetComponent<TextMesh>().text = Eng;
            var TextScript = gameObject.GetComponent<TextMesh>();
            var texts = TextScript.text.Replace("\\n","\n");
            TextScript.text = texts;
        }

    }
}
