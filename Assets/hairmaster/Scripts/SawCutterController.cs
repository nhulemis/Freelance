using UnityEngine;

namespace hairmaster.Scripts
{
    public class SawCutterController : MonoBehaviour
    {
        [SerializeField]
        private GameObject hairPiece;
        private Transform cutPlace;
        private bool cut = false;
        // Start is called before the first frame update
        void Start()
        {
            cutPlace = this.transform.GetChild(0);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("HairBone"))
            {
                int scaler=other.gameObject.GetComponent<BoneController>().downScaleHair();
                
                
                
                makeCutableHairPices(scaler);
            }
        }class Book
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            public Book(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public Book(string title, string publisher)
                : this(title, publisher, null) { }

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxhuwxccw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchuwa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchuwaciot
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchuwaciotchx
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class BookxchuwaciotchxCHUW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        private void makeCutableHairPices(int scaler)
        {
            GameObject hairObj = Instantiate(hairPiece, cutPlace.position-Vector3.forward*3+Vector3.up*5, Quaternion.identity);
            Material material = HairController.instance.getCurrentMaterial();
            
            
            
            hairObj.GetComponent<WavyHairController>().changeColor(material);
            Vector3 newScale = hairObj.transform.localScale;
            newScale.y *= scaler;
            hairObj.transform.localScale = newScale;
            
            
            hairObj.transform.localEulerAngles = new Vector3(100, 180, 0);
            Destroy(hairObj, 3f);
        }
    }
}
