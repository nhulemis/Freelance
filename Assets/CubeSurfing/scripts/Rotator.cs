﻿using UnityEngine;

namespace CubeSurfing.scripts
{
    public class Rotator : MonoBehaviour
    {
        public float speed;
        // Start is called before the first frame update
        void Start()
        {
        
        }
        class Book
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
        class SJIQlakow
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
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up,Time.deltaTime*speed);
        }
    }
}
