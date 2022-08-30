using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lightbug.CharacterControllerPro.Core
{

/// <summary>
/// This component can be used to make a Transform change its scale, based on the CharacterActor height.
/// </summary>
[AddComponentMenu("Character Controller Pro/Core/Character Graphics/Scaler")]
[DefaultExecutionOrder( ExecutionOrder.CharacterGraphicsOrder + 1 )]
public class CharacterGraphicsScaler : CharacterGraphics
{

    [SerializeField]
    VectorComponent scaleHeightComponent = VectorComponent.Y;

    // ─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────

    enum VectorComponent
    {
        X ,
        Y , 
        Z
    }

    Vector3 initialOffset = Vector3.zero;
    Vector3 initialLocalScale = Vector3.one;

        

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
    void Start()
    {
        initialOffset = transform.position - CharacterActor.transform.position;
        initialLocalScale = transform.localScale;
    }
    
    void Update()
    {        
        if( !CharacterActor.enabled )
            return;
        
        Vector3 scale = Vector3.one;
        Vector3 offset = Vector3.zero;
        
        switch( scaleHeightComponent )
        {
            case VectorComponent.X:

                scale = new Vector3(
                    initialLocalScale.x * ( CharacterActor.BodySize.y / CharacterActor.DefaultBodySize.y ) , 
                    initialLocalScale.y * ( CharacterActor.BodySize.x / CharacterActor.DefaultBodySize.x ) ,
                    initialLocalScale.z * ( CharacterActor.BodySize.x / CharacterActor.DefaultBodySize.x )
                );
                
                break;
            case VectorComponent.Y:

                scale = new Vector3(
                    initialLocalScale.x * ( CharacterActor.BodySize.x / CharacterActor.DefaultBodySize.x ) , 
                    initialLocalScale.y * ( CharacterActor.BodySize.y / CharacterActor.DefaultBodySize.y ) ,
                    initialLocalScale.z * ( CharacterActor.BodySize.x / CharacterActor.DefaultBodySize.x )
                );
                
                break;
            case VectorComponent.Z:

                scale = new Vector3(
                    initialLocalScale.x * ( CharacterActor.BodySize.x / CharacterActor.DefaultBodySize.x ) , 
                    initialLocalScale.y * ( CharacterActor.BodySize.x / CharacterActor.DefaultBodySize.x ) ,
                    initialLocalScale.z * ( CharacterActor.BodySize.y / CharacterActor.DefaultBodySize.y )
                );
                
                break;
        }

        offset = new Vector3( 
            initialOffset.x * scale.x ,
            initialOffset.y * scale.y ,
            initialOffset.z * scale.z
        );

        // If the root controller is present then use that as the reference position. If not, then fallback to the character actor position.
        Vector3 referencePosition = RootController != null ? RootController.transform.position : CharacterActor.transform.position;
        
        transform.position = referencePosition + transform.TransformDirection( offset );        
        transform.localScale = scale;
        

    }    
     
    

}

}

