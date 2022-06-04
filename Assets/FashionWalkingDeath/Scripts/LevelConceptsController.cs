using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class LevelConceptsController : MonoBehaviour
    {
        //Serialized Data
        [SerializeField]
        private GameObject[] nightClubHair;
        [SerializeField]
        private GameObject[] nightClubShoe;
        [SerializeField]
        private GameObject[] nightDress;
        [SerializeField]
        private GameObject[] topDress;
        [SerializeField]
        private GameObject[] bottomDress;
        [SerializeField]
        private GameObject[] nightClubGlasses;
        [SerializeField]
        private GameObject[] nightClubGloves;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void selectTshirtItem(int selectedHairIndex)
        {
            foreach (GameObject child in topDress)
            {
                child.SetActive(false);
            }
            if (selectedHairIndex >= topDress.Length)
            {
                selectedHairIndex = topDress.Length - 1;
            }
            topDress[selectedHairIndex].SetActive(true);
        }
        public void selectShoeItem(int selectedHairIndex)
        {
            print("Selected Shoe Item is : " + selectedHairIndex);
            foreach (GameObject child in nightClubShoe)
            {
                child.SetActive(false);
            }
            if (selectedHairIndex >= nightClubShoe.Length)
            {
                selectedHairIndex = nightClubShoe.Length - 1;
            }
            nightClubShoe[selectedHairIndex].SetActive(true);
        }

        public void selectDressItem(int selectedHairIndex)
        {
            print("Selected Dress Item is : " + selectedHairIndex);
            foreach (GameObject child in nightDress)
            {
                child.SetActive(false);
            }
            if (selectedHairIndex >= nightDress.Length)
            {
                selectedHairIndex = nightDress.Length - 1;
            }
            nightDress[selectedHairIndex].SetActive(true);
        }
        public void selectHairItem(int selectedHairIndex)
        {
            print("Selected Hair Item is : "+selectedHairIndex);
            foreach(GameObject child in nightClubHair)
            {
                child.SetActive(false);
            }
            if (selectedHairIndex >= nightClubHair.Length)
            {
                selectedHairIndex = nightClubHair.Length - 1;
            }
            nightClubHair[selectedHairIndex].SetActive(true);
        }
        public void selectBottomItem(int selectedHairIndex)
        {
            print("Selected Hair Item is : " + selectedHairIndex);
            foreach (GameObject child in bottomDress)
            {
                child.SetActive(false);
            }
            if (selectedHairIndex > bottomDress.Length)
            {
                selectedHairIndex = bottomDress.Length - 1;
            }
            bottomDress[selectedHairIndex].SetActive(true);
        }

        public void selectTopDressItem(int selectedHairIndex)
        {
            print("Selected Dress Item is : " + selectedHairIndex);
            foreach (GameObject child in topDress)
            {
                child.SetActive(false);
            }
            if (selectedHairIndex > topDress.Length)
            {
                selectedHairIndex = topDress.Length - 1;
            }
            topDress[selectedHairIndex].SetActive(true);
        }
        public void selectGlassesItem(int selectedHairIndex)
        {
            print("Selected Dress Item is : " + selectedHairIndex);
            foreach (GameObject child in nightClubGlasses)
            {
                child.SetActive(false);
            }
            if (selectedHairIndex > nightClubGlasses.Length)
            {
                selectedHairIndex = nightClubGlasses.Length - 1;
            }
            nightClubGlasses[selectedHairIndex].SetActive(true);
        }
        public void selectGlovesItem(int selectedHairIndex)
        {
            print("Selected Hair Item is : " + selectedHairIndex);
            foreach (GameObject child in nightClubGloves)
            {
                child.SetActive(false);
            }
            if (selectedHairIndex > nightClubGloves.Length)
            {
                selectedHairIndex = nightClubGloves.Length - 1;
            }
            nightClubGloves[selectedHairIndex].SetActive(true);
        }

    }
}
