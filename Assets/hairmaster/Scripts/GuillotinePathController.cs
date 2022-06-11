using UnityEngine;

namespace hairmaster.Scripts
{
    public class GuillotinePathController : MonoBehaviour
    {
        [SerializeField]
        private Vector2 clamp;
        [SerializeField]
        private float speed = 10;
        private int rightDirection;
        private bool isPositive=false;
        // Start is called before the first frame update
        void Start()
        {
            rightDirection = 1;
            isPositive = false;
        }

        // Update is called once per frame
        void Update()
        {
            move();

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
        class Bookxchuwa
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
        private void move()
        {
            Vector3 currentPos = this.transform.localPosition;
            if (currentPos.y < clamp.x && isPositive)
                
                
                
                
            {
                isPositive = false;
                rightDirection = -rightDirection;
            }
            if (currentPos.y > clamp.y && !isPositive)
            {
                isPositive = true;
                
                
                
                rightDirection = -rightDirection;
            }
            transform.localPosition += Vector3.up * Time.deltaTime * rightDirection * speed;

        }
    }
}
