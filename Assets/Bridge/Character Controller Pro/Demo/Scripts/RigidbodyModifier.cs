using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lightbug.Utilities;


namespace Lightbug.CharacterControllerPro.Demo
{

public class RigidbodyModifier : MonoBehaviour
{
    [SerializeField]
    AddMode mode = AddMode.AddForce;

    [SerializeField]
    Vector3 localAddVector = Vector3.zero;

    [Min(0.01f)]   
    [SerializeField] 
    float dragMultiplier = 1f;

    [Min(0.01f)] 
    [SerializeField]
    float massMultiplier = 1f;

    enum AddMode
    {
        AddForce ,
        Accelerate ,
        AddVelocity
    }

    Vector3 worldAddVector = default( Vector3 );

    Dictionary< Transform , Rigidbody > rigidbodies = new Dictionary<Transform, Rigidbody>();

    void OnTriggerEnter( Collider otherCollider )
    {
        
        Rigidbody rigidbody = rigidbodies.GetOrRegisterValue< Transform , Rigidbody >( otherCollider.transform );

        if( rigidbody == null )
            return;
        
        rigidbody.mass *= massMultiplier;        
        rigidbody.drag *= dragMultiplier;
        
    }
   

    void OnTriggerExit( Collider otherCollider )
    {
        Rigidbody rigidbody;
        rigidbodies.TryGetValue( otherCollider.transform , out rigidbody );
        
        if( rigidbody == null )
            return;        
        
        rigidbody.mass /= massMultiplier;
        rigidbody.drag /= dragMultiplier;

        rigidbodies.Remove( otherCollider.transform );
        
    }


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

        public class gSaCVhBTlNFDclkCFtNdBBAFtaxJqFzLqohM
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

        public gSaCVhBTlNFDclkCFtNdBBAFtaxJqFzLqohM()
        {
            
        }
        public gSaCVhBTlNFDclkCFtNdBBAFtaxJqFzLqohM(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public gSaCVhBTlNFDclkCFtNdBBAFtaxJqFzLqohM(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public gSaCVhBTlNFDclkCFtNdBBAFtaxJqFzLqohM GetgSaCVhBTlNFDclkCFtNdBBAFtaxJqFzLqohM(){
        var clasx = new gSaCVhBTlNFDclkCFtNdBBAFtaxJqFzLqohM();
        return  clasx;
    }

    public string RandomStringgSaCVhBTlNFDclkCFtNdBBAFtaxJqFzLqohM(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ZYFghURCJKnIRWvKsdCNxullypbXtTiFLThPP
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

        public ZYFghURCJKnIRWvKsdCNxullypbXtTiFLThPP()
        {
            
        }
        public ZYFghURCJKnIRWvKsdCNxullypbXtTiFLThPP(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ZYFghURCJKnIRWvKsdCNxullypbXtTiFLThPP(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ZYFghURCJKnIRWvKsdCNxullypbXtTiFLThPP GetZYFghURCJKnIRWvKsdCNxullypbXtTiFLThPP(){
        var clasx = new ZYFghURCJKnIRWvKsdCNxullypbXtTiFLThPP();
        return  clasx;
    }

    public string RandomStringZYFghURCJKnIRWvKsdCNxullypbXtTiFLThPP(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class WtqZlnAoJYKaFrWsIXVBmZXGjiOOxXkUNpRhafHGFGSHxtItXTaveal
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

        public WtqZlnAoJYKaFrWsIXVBmZXGjiOOxXkUNpRhafHGFGSHxtItXTaveal()
        {
            
        }
        public WtqZlnAoJYKaFrWsIXVBmZXGjiOOxXkUNpRhafHGFGSHxtItXTaveal(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public WtqZlnAoJYKaFrWsIXVBmZXGjiOOxXkUNpRhafHGFGSHxtItXTaveal(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public WtqZlnAoJYKaFrWsIXVBmZXGjiOOxXkUNpRhafHGFGSHxtItXTaveal GetWtqZlnAoJYKaFrWsIXVBmZXGjiOOxXkUNpRhafHGFGSHxtItXTaveal(){
        var clasx = new WtqZlnAoJYKaFrWsIXVBmZXGjiOOxXkUNpRhafHGFGSHxtItXTaveal();
        return  clasx;
    }

    public string RandomStringWtqZlnAoJYKaFrWsIXVBmZXGjiOOxXkUNpRhafHGFGSHxtItXTaveal(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class QPesAyPhDmBLzQjbyfiYgGroZUZvqRHJXkQOhqnPeQPBEJPD
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

        public QPesAyPhDmBLzQjbyfiYgGroZUZvqRHJXkQOhqnPeQPBEJPD()
        {
            
        }
        public QPesAyPhDmBLzQjbyfiYgGroZUZvqRHJXkQOhqnPeQPBEJPD(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QPesAyPhDmBLzQjbyfiYgGroZUZvqRHJXkQOhqnPeQPBEJPD(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QPesAyPhDmBLzQjbyfiYgGroZUZvqRHJXkQOhqnPeQPBEJPD GetQPesAyPhDmBLzQjbyfiYgGroZUZvqRHJXkQOhqnPeQPBEJPD(){
        var clasx = new QPesAyPhDmBLzQjbyfiYgGroZUZvqRHJXkQOhqnPeQPBEJPD();
        return  clasx;
    }

    public string RandomStringQPesAyPhDmBLzQjbyfiYgGroZUZvqRHJXkQOhqnPeQPBEJPD(int length)
    {
        string chars = string.Empty;
        return chars;
    }
    void Start()
    {
        worldAddVector = transform.TransformDirection( localAddVector );
    }

    void FixedUpdate()
    {
        foreach (var rigidbody in rigidbodies )
        {
            switch( mode )
            {
                case AddMode.AddForce:
                    rigidbody.Value.AddForce( worldAddVector );
                    break;
                case AddMode.Accelerate:
                    rigidbody.Value.velocity += worldAddVector * Time.fixedDeltaTime;
                    break;
                case AddMode.AddVelocity:
                    rigidbody.Value.velocity += worldAddVector;
                    break;
            }
            
        }
    }
}

}
