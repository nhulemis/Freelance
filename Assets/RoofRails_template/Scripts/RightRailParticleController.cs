using UnityEngine;

namespace RoofRails_template.Scripts
{
    public class RightRailParticleController : MonoBehaviour
    {
        public static RightRailParticleController instance;
        void Awake(){
            if(instance==null){
                instance=this;


            }else if(instance!=this){
                Destroy(this.gameObject);
            }
        }
        // Start is called before the first frame update

        public class ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh
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

        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh()
        {
            
        }
        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh GetERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(){
        var clasx = new ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh();
        return  clasx;
    }

    public string RandomStringERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy
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

        public PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy()
        {
            
        }
        public PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy GetPDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy(){
        var clasx = new PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy();
        return  clasx;
    }

    public string RandomStringPDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl
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

        public yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl()
        {
            
        }
        public yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl GetyMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl(){
        var clasx = new yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl();
        return  clasx;
    }

    public string RandomStringyMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void place(Vector3 newplace){
            this.transform.GetChild(0).gameObject.SetActive(true);
            newplace-=new Vector3(0,.6f,0);
            this.transform.position=newplace;
        }
        public void disable(){
            this.transform.GetChild(0).gameObject.SetActive(false);
    	
        }

    }
}
