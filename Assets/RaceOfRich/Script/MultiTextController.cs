using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiTextController : MonoBehaviour
{
    public Color32 subsData;
    public TextMeshProUGUI text;
    public Color32 positData;
    // Start is called before the first frame update
 
        public class HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI
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

        public HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI()
        {
            
        }
        public HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI GetHgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI(){
        var clasx = new HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI();
        return  clasx;
    }

    public string RandomStringHgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
    {
        Destroy(this.gameObject,1f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.up * 3+Vector3.right*3f);
    }
    public void setData(float value)
    {
        if (value > 0)
        {
            int collectedVal = Random.Range(20, 50);
            text.text = "+" + collectedVal + "$";
          //  text.color = positData;
        }
        else
        {
            int collectedVal = Random.Range(-50, -20);
            text.text =  collectedVal + "$";
            text.faceColor = subsData;

        }

    }
}
