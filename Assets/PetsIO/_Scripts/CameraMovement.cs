using UnityEngine;

namespace PetsIO._Scripts
{
    public class CameraMovement : MonoBehaviour
    {
        // Start is called before the first frame update
        public float speed;

        //public float minZ;
    
        private GameObject hero;
    
        private float view;
        //private bool doview;
        //private int correct;

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
            hero = GameObject.Find("Hero");
            view = 45;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            if (hero) transform.position = Vector3.Lerp(transform.position, hero.transform.position + new Vector3(0, 18f, -15.5f), Time.deltaTime*speed);

            /* if (doview)
          {
              Camera.main.fieldOfView += Time.deltaTime*correct;
              if (correct == 1)
              {
                  if (Camera.main.fieldOfView > view)
                  {
                      Camera.main.fieldOfView = view;
                      doview = false;
                  }
              }
              else
              {
                  if (Camera.main.fieldOfView < view)
                  {
                      Camera.main.fieldOfView = view;
                      doview = false;
                  }
              }
          }*/
          
        }

        void FieldView(float f)
        {

            if (view < f)
            {
                //correct = 1;
            }
            else
            {
                //correct = -1;
            }
            view = f;
            // doview = true;

            if (view > 47) view = 47;
            view = 45;
        }
    }
}
