using UnityEngine;

namespace PetsIO._Scripts
{
    public class GenerateEvnironment : MonoBehaviour
    {

        public GameObject[] Objects;

        private float timer;

        private bool doit;

        public bool miniEnv;
        public float timerGenerate;
        // Start is called before the first frame update

        public class khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj()
        {
            
        }
        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj GetkhsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(){
        var clasx = new khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj();
        return  clasx;
    }

    public string RandomStringkhsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {
            timer = 999f;
            //timer = Random.Range(0.00f, 0.98f);

            if (timerGenerate == 0) timerGenerate = 0.7f;
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;

            if (timer > timerGenerate)
            {
                timer = 0;
                if (doit == true)
                {
                    Generate();
                    doit = false;
                }
                else
                {
                    doit = true;
                }

            }
        }
    
        void OnTriggerStay(Collider other)
        {
            doit = false;
       
        }

        void Generate()
        {
            
            int rnd;
            
            rnd = Random.Range(0, 2);
            if (miniEnv) rnd = Random.Range(0, 5);

            if (rnd != 0)
            {
                rnd = Random.Range(1, Objects.Length);
            }

            var obj = Instantiate(Objects[rnd], transform.position, Objects[rnd].transform.rotation);
            obj.transform.position = obj.transform.position + new Vector3(0, 2, 0);
            
        }
    
    }
}
