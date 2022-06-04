using UnityEngine;

namespace ArchHeroXX.Scripts.Other
{
    public class generationMobs : MonoBehaviour
    {
        public int Location;
        public GameObject[] locMobs;
        public GameObject[] allMobs;
        private float locCoeficient;
        // Start is called before the first frame update
        public void StartGenerate()
        {

            var set3 = locMobs;
            SetLocMobs();

            locCoeficient = Location * 1.8f;

            set3[0] = locMobs[Random.Range(0, 5)];
            set3[1] = locMobs[Random.Range(0, 5)];
            set3[2] = locMobs[Random.Range(0, 5)];

            GameObject[] resp = GameObject.FindGameObjectsWithTag("Respawn");
            foreach (GameObject res in resp)
            {
                Instantiate(set3[Random.Range(0, allMobs.Length)], res.transform.position, res.transform.rotation);
                Destroy(res);
            }
        }

        void SetLocMobs()
        {
            int raschet = (Location - 1) * 5;
            if (Location == 1)
            {
                locMobs[0] = allMobs[0+raschet];
                locMobs[1] = allMobs[1+raschet];
                locMobs[2] = allMobs[2+raschet];
                locMobs[3] = allMobs[3+raschet];
                locMobs[4] = allMobs[4+raschet];
            }
        }

    }
}
