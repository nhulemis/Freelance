using UnityEngine;

namespace PetsIO._Scripts.other
{
    public class OnFood : MonoBehaviour
    {

        // Update is called once per frame
   
        public class jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY
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

            public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY()
            {
            
            }
            public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(string title, string publisher)
                : this(title, publisher, null) {}

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }

        public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY GetjasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(){
            var clasx = new jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY();
            return  clasx;
        }

        public string RandomStringjasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(int length)
        {
            string chars = string.Empty;
            return chars;
        }

        public class PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL
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

            public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL()
            {
            
            }
            public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(string title, string publisher)
                : this(title, publisher, null) {}

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }

        public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL GetPcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(){
            var clasx = new PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL();
            return  clasx;
        }

        public string RandomStringPcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(int length)
        {
            string chars = string.Empty;
            return chars;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Minion")
            {
                other.GetComponent<Minion>().EatFood(); //.SendMessage("SetScore", 20);
                Destroy(this.gameObject);
                //Hero.GetComponent<Controll>().GetFood(other.gameObject); //SendMessage("GetFood", other.gameObject);
                var t = Instantiate(GameObject.Find("textCountPet"), transform.position + new Vector3(0, 1.5f, 0),
                    GameObject.Find("textCountPet").transform.rotation);
                t.SendMessage("startText", "+1");
                Camera.main.GetComponent<AudioSource>().Play();
            }
        
            if (other.tag == "MainMinion")
            {
                other.GetComponent<Controll>().SetScore(20);
                Destroy(this.gameObject);

                var t = Instantiate(GameObject.Find("textCountPet"), transform.position + new Vector3(0, 1.5f, 0),
                    GameObject.Find("textCountPet").transform.rotation);
                t.SendMessage("startText", "+1");
                Camera.main.GetComponent<AudioSource>().Play();
            
            }
        }
    }
}
