using Assets.DuckType.Jiggle;
using UnityEngine;

namespace hairmaster.Scripts
{
    public class BonesRootController : MonoBehaviour
    {
        int curretChild;
        [SerializeField]
        private GameObject hairBone;
        [SerializeField]
        Jiggle[] bonHairHolders;
        // Start is called before the first frame update
        void Start()
        {
            curretChild = 1;
        }

        // Update is called once per frame
        void Update()
        {
        
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
        class Bookxhuw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

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
        class Bookxchcuwaxhuachx
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        public void addNewHairPices()
        {
            int i = 0;

            foreach (Jiggle j in bonHairHolders)
            {
                
                
                j.AddWind = true;
                if (i < 1)
                    j.SpringStrength = .2f;
                else
                    j.SpringStrength = .25f;
                j.RotationInertia = .85f;
                
                
                j.Dampening = .65f;
                i++;

            }
            // GameObject newHairChildObj = Instantiate(hairBone, Vector3.zero, Quaternion.identity, this.transform);
            // curretChild++;
        }
        public void resetJiggleSatate()
        {
            foreach (Jiggle j in bonHairHolders)
            {
                j.AddWind = false;
           
                j.SpringStrength = .25f;

                j.RotationInertia = 0;
                j.Dampening = 1f;
            }
        }
        public void disable()
        {
            foreach (Jiggle j in bonHairHolders)
            {
                j.CenterOfMass = new Vector3(-.3f, .1f, 0);
                j.RotationInertia = 1f;
                //j.CenterOfMassInertia = .1f;
                j.Gravity = .15f;
                j.SpringStrength = .05f;

                //j.enabled = false;
            }
        }

    }
}
