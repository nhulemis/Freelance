using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
        public class HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb
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

        public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb()
        {
            
        }
        public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb GetHqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(){
        var clasx = new HqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb();
        return  clasx;
    }

    public string RandomStringHqNvCrjvuDpAWxBMMPLaHodjpiPtASVDuJktUSHsVOb(int length)
    {
        string chars = string.Empty;
        return chars;
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
