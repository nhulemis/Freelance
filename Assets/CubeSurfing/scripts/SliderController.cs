﻿using UnityEngine;
using UnityEngine.UI;

namespace CubeSurfing.scripts
{
    public class SliderController : MonoBehaviour
    {
        float distance;
        Vector3 startPos;
        Vector3 endpos;
        Transform playerTrans;
        [SerializeField]Image imgSlider;
        // Start is called before the first frame update
        void Start()
        {
            playerTrans=GameObject.FindGameObjectWithTag("Player").transform;
            startPos=playerTrans.position;
            endpos=GameObject.FindGameObjectWithTag("Ending").transform.position;
            distance=(endpos-startPos).magnitude;
        
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

        }
        class BookSUW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

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
        class SHUQAOXMAh
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQAOXMAhxjuoa
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
        class USOZJAHUWhuswHUW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class USOZJAHUWxhuwshiawo
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class USOZJAHUWxhuwshiawosswdSWww
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class OWIDAWC
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class OWIDAWCCJIW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        // Update is called once per frame
        void LateUpdate()
        {
            imgSlider.fillAmount=((playerTrans.position).magnitude/distance);
        }
    }
}
