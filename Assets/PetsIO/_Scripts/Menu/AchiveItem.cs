using UnityEngine;

namespace PetsIO._Scripts.Menu
{
    public class AchiveItem : MonoBehaviour
    {
        private GameObject lockA;    
        private int num;
        // Start is called before the first frame update
        void Start()
        {
        
        
            num = int.Parse(gameObject.name[5].ToString());
        
            foreach (Transform child in transform.parent.transform)
            {
                if (child.name == "b_a"+num) lockA = child.gameObject;
            }
        
            int petCount = 1;

            if (num == 1) petCount = 10;
            if (num == 2) petCount = 25;
            if (num == 3) petCount = 50;
            if (num == 4) petCount = 75;
            if (num == 5) petCount = 100;
            if (num == 6) petCount = 150;
            if (num == 7) petCount = 200;
            if (num == 8) petCount = 250;
            if (num == 9) petCount = 300;
        
            //PlayerPrefs.SetInt("achi" + num, 0);
        
            if (PlayerPrefs.GetInt("maxPet") >= petCount)
            {
                Destroy(lockA);

                if (PlayerPrefs.GetInt("achi" + num) == 1)
                {
                    CheckAchi();
                }
                else
                {
                    GameObject.Find("i_ach").transform.localPosition = new Vector3(0,0,0);
                }
            }

        }

        // Update is called once per frame
        void SetAchiveActive()
        {
            PlayerPrefs.SetInt("achi" + num, 1);
        
            GameObject.Find("i_ach").transform.localPosition = new Vector3(0,999,0);
        
            if (num == 1) GameObject.Find("GUI").SendMessage("SetGold", 300);
            if (num == 2) GameObject.Find("GUI").SendMessage("SetGold", 500);
            if (num == 3) GameObject.Find("GUI").SendMessage("SetGold", 1000);
            if (num == 4) GameObject.Find("GUI").SendMessage("SetGold", 1500);
            if (num == 5) GameObject.Find("GUI").SendMessage("SetGold", 2000);
            if (num == 6) GameObject.Find("GUI").SendMessage("SetGold", 3000);
            if (num == 7) GameObject.Find("GUI").SendMessage("SetGold", 5000);
            if (num == 8) GameObject.Find("GUI").SendMessage("SetGold", 7000);
            if (num == 9) GameObject.Find("GUI").SendMessage("SetGold", 10000);
        
            CheckAchi();
        }

        void CheckAchi()
        {
            transform.parent.gameObject.GetComponent<SpriteRenderer>().color = new Color(0,1,0);
            Destroy(this.gameObject);
            Destroy(this.gameObject);
        }
    }
}
