using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderController : MonoBehaviour
{
    float distance;
    Vector3 startPos;
    Vector3 endpos;
    Transform playerTrans;
    [SerializeField]Image imgSlider;
    // Start is called before the first frame update

        public class sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF
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

        public sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF()
        {
            
        }
        public sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF GetsHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF(){
        var clasx = new sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF();
        return  clasx;
    }

    public string RandomStringsHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa
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

        public sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa()
        {
            
        }
        public sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa GetsLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa(){
        var clasx = new sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa();
        return  clasx;
    }

    public string RandomStringsLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa(int length)
    {
        string chars = string.Empty;
        return chars;
    }
    void Start()
    {
    	playerTrans=GameObject.FindGameObjectWithTag("Player").transform;
    	startPos=playerTrans.position;
        endpos=GameObject.FindGameObjectWithTag("Finish").transform.position;
        endpos += Vector3.forward * 20;
        print(GameObject.FindGameObjectWithTag("Finish").name);
    	distance=(endpos-startPos).magnitude;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //imgSlider.fillAmount=((playerTrans.position).magnitude/distance);
    }
}
