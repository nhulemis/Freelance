using UnityEngine;

namespace CubeSurfing.scripts
{
    public class Collectables : MonoBehaviour
    {public class Llcaowksx
        {
            public int A;
            public int B;
            public string C;
            public bool X;
            private double D;
            private float E;

            public void ALKJXCL()
            {
      
            }
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        public class Timea
        {
            // public methods
            public void DisplayCurrentTime(  )
            {
                    
            }

            // private variables
            int Year;
            int Month;
            int Date;
            int Hour;
            int Minute;
            int Second;


        }
        public class MyClass
        {
            public void SomeMethod(int firstParam, float secondParam)
            {
				
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
        class ABCUXLA
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQAOXMA
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQAOXMAh
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQAOXMAhxjuoaUQLA
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQ
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSS
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSSsssSUQ
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSSsssSUQSOAAW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSSsssSUQaaw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSSsssSUQaawSxiws
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class USOZJAHUW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class USOZJAHUWxhuw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class USOZJAHUWxhuwq
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Barriere"  )
            {
                this.transform.parent = null;
            }else if ( collision.gameObject.tag == "water")
            {
                this.gameObject.SetActive(false);
            }
            else if (collision.gameObject.tag == "Finish" )
            {
                this.transform.parent = null;
                Destroy(this.gameObject, .2f);
            }
            
        }
   
    }
}
