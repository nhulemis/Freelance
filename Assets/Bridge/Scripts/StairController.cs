using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairController : MonoBehaviour
{
    //Serialized Data
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private string color;
    //Private Data
    private Vector3 localPostion;
    public bool canbeCollected = true;

    // Start is called before the first frame update

        public class VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk
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

        public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk()
        {
            
        }
        public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk GetVqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(){
        var clasx = new VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk();
        return  clasx;
    }

    public string RandomStringVqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx
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

        public SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx()
        {
            
        }
        public SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx GetSwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx(){
        var clasx = new SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx();
        return  clasx;
    }

    public string RandomStringSwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm
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

        public RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm()
        {
            
        }
        public RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm GetRPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm(){
        var clasx = new RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm();
        return  clasx;
    }

    public string RandomStringRPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm(int length)
    {
        string chars = string.Empty;
        return chars;
    }
    void Start()
    {
        localPostion = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void popUP()
    {
         //StairsManager.instance.makeNewChild(localPostion,"Yellow");
        anim.SetBool("PopUp", true);
    }
    public string getColor()
    {
        return color;
    }

}
