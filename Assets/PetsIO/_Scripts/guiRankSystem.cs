using UnityEngine;

namespace PetsIO._Scripts
{
    public class guiRankSystem : MonoBehaviour
    {
        public GameObject[] unitsGUI;
        public GameObject[] units;
        public GameObject[] unitsTemp;
        public int[] unitsScore;
    
        private int tempScore;
        private int tempUnit;

        private float timer;

        private bool colSet;
        // Start is called before the first frame update
        void Start()
        {
            colSet = false;

        }

        void SetColor()
        {
            for(int i = 0; i < 6; i++)
            {
                foreach (Transform child in unitsGUI[i].transform)
                {
                    //if (child.name == "bg") child.gameObject.GetComponent<SpriteRenderer>().color = units[i].GetComponent<Controll>().colorPlayer;
                    //if (child.name != "bg" && child.name != "bgCount" && child.name != "count")child.gameObject.GetComponent<TextMesh>().color = units[i].GetComponent<Controll>().colorPlayer;
                    if (child.name == "bgCount") child.gameObject.GetComponent<SpriteRenderer>().color = units[i].GetComponent<Controll>().colorPlayer;
                    if (child.name == "name") child.gameObject.GetComponent<TextMesh>().text = units[i].GetComponent<Controll>().names;
                }
            }
        
        }
        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            if (timer > 1)
            {
                timer = 0;
                if (colSet == false)
                {
                    colSet = true;
                    SetColor();
                }
                GetData();
            }
        }

        void GetData()
        {
            for(int i = 0; i < 6; i++)
            {
                unitsScore[i] = 0;
                if (units[i]){ unitsScore[i] = units[i].GetComponent<Controll>().countPet;}
                else
                {
                    if (unitsGUI[i]) Destroy(unitsGUI[i]);
                }
            }
        
        

            tempScore = -1;
            for(int i = 0; i < 6; i++)
            {
                if (tempScore < unitsScore[i])
                {
                    tempScore = unitsScore[i];
                    unitsTemp[0] = units[i];
                    tempUnit = i;
                }
            }
            unitsGUI[tempUnit].transform.localPosition = new Vector3(0,0,0);
            foreach (Transform child in unitsGUI[tempUnit].transform)
            {
                if (child.name == "count") child.gameObject.GetComponent<TextMesh>().text = tempScore+"";
                //if (child.name == "name") child.gameObject.GetComponent<TextMesh>().text = units[tempUnit].name+"";
            }
        
        
        
            tempScore = -1;
            for(int i = 0; i < 6; i++)
            {
                if (tempScore < unitsScore[i] && units[i] != unitsTemp[0])
                {
                    tempScore = unitsScore[i];
                    unitsTemp[1] = units[i];
                    tempUnit = i;
                }
            }
            unitsGUI[tempUnit].transform.localPosition = new Vector3(0,-0.5f,0);
            foreach (Transform child in unitsGUI[tempUnit].transform)
            {
                if (child.name == "count") child.gameObject.GetComponent<TextMesh>().text = tempScore+"";
                // if (child.name == "name") child.gameObject.GetComponent<TextMesh>().text = units[tempUnit].name+"";
            }
        
        
            tempScore = -1;
            for(int i = 0; i < 6; i++)
            {
                if (tempScore < unitsScore[i] && units[i] != unitsTemp[0] && units[i] != unitsTemp[1])
                {
                    tempScore = unitsScore[i];
                    unitsTemp[2] = units[i];
                    tempUnit = i;
                }
            }
            unitsGUI[tempUnit].transform.localPosition = new Vector3(0,-1,0);
            foreach (Transform child in unitsGUI[tempUnit].transform)
            {
                if (child.name == "count") child.gameObject.GetComponent<TextMesh>().text = tempScore+"";
                // if (child.name == "name") child.gameObject.GetComponent<TextMesh>().text = units[tempUnit].name+"";
            }
        
            tempScore = -1;
            for(int i = 0; i < 6; i++)
            {
                if (tempScore < unitsScore[i] && units[i] != unitsTemp[0] && units[i] != unitsTemp[1] && units[i] != unitsTemp[2])
                {
                    tempScore = unitsScore[i];
                    unitsTemp[3] = units[i];
                    tempUnit = i;
                }
            }
            unitsGUI[tempUnit].transform.localPosition = new Vector3(0,-1.5f,0);
            foreach (Transform child in unitsGUI[tempUnit].transform)
            {
                if (child.name == "count") child.gameObject.GetComponent<TextMesh>().text = tempScore+"";
                //  if (child.name == "name") child.gameObject.GetComponent<TextMesh>().text = units[tempUnit].name+"";
            }
        
            tempScore = -1;
            for(int i = 0; i < 6; i++)
            {
                if (tempScore < unitsScore[i] && units[i] != unitsTemp[0] && units[i] != unitsTemp[1] && units[i] != unitsTemp[2] && units[i] != unitsTemp[3])
                {
                    tempScore = unitsScore[i];
                    unitsTemp[4] = units[i];
                    tempUnit = i;
                }
            }
            unitsGUI[tempUnit].transform.localPosition = new Vector3(0,-2,0);
            foreach (Transform child in unitsGUI[tempUnit].transform)
            {
                if (child.name == "count") child.gameObject.GetComponent<TextMesh>().text = tempScore+"";
                //  if (child.name == "name") child.gameObject.GetComponent<TextMesh>().text = units[tempUnit].name+"";
            }
        
            tempScore = -1;
            for(int i = 0; i < 6; i++)
            {
                if (tempScore < unitsScore[i] && units[i] != unitsTemp[0] && units[i] != unitsTemp[1] && units[i] != unitsTemp[2] && units[i] != unitsTemp[3] && units[i] != unitsTemp[4])
                {
                    tempScore = unitsScore[i];
                    unitsTemp[5] = units[i];
                    tempUnit = i;
                }
            }
            unitsGUI[tempUnit].transform.localPosition = new Vector3(0,-2.5f,0);
            foreach (Transform child in unitsGUI[tempUnit].transform)
            {
                if (child.name == "count") child.gameObject.GetComponent<TextMesh>().text = tempScore+"";
                // if (child.name == "name") child.gameObject.GetComponent<TextMesh>().text = units[tempUnit].name+"";
            }
        
        }
    }
}
