using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lightbug.CharacterControllerPro.Core;
using Lightbug.Utilities;

namespace Lightbug.CharacterControllerPro.Demo
{

[AddComponentMenu("Character Controller Pro/Demo/Material Controller")]
public class MaterialController : MonoBehaviour
{
    [SerializeField]
    MaterialsProperties materialsProperties = null;

    CharacterActor characterActor = null;

	/// <summary>
	/// This event is called when the character enters a volume. 
	/// 
	/// The volume is passed as an argument.
	/// </summary>
	public event System.Action< Volume > OnVolumeEnter;

	/// <summary>
	/// This event is called when the character exits a volume. 
	/// 
	/// The volume is passed as an argument.
	/// </summary>
	public event System.Action< Volume > OnVolumeExit;

	/// <summary>
	/// This event is called when the character step on a surface. 
	/// 
	/// The surface is passed as an argument.
	/// </summary>
	public event System.Action< Surface > OnSurfaceEnter;

	/// <summary>
	/// This event is called when the character step off a surface. 
	/// 
	/// The surface is passed as an argument.
	/// </summary>
	public event System.Action< Surface > OnSurfaceExit;

    // Environment ------------------------------------------------------
	Volume currentVolume = null;
	Surface currentSurface = null;

	// Surface ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────

	/// <summary>
	/// Gets the surface the character is colliding with. If this returns null the surface will be considered as "default".
	/// </summary>
	public Surface CurrentSurface
	{
		get
		{
			return currentSurface;
		}
	}



	// Volume ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────

	/// <summary>
	/// Gets the volume the character is colliding with. If this returns null the volume will be considered as "default".
	/// </summary>
	public Volume CurrentVolume
	{
		get
		{
			return currentVolume;
		}
	}

	

	        
    void GetSurfaceData()
    {
        
        if( !characterActor.IsGrounded )
        {
           SetCurrentSurface( materialsProperties.DefaultSurface );           
        }
        else
        {
			Surface surface = null;

			bool validSurface = materialsProperties.GetSurface( characterActor.GroundObject , ref surface );

			if( validSurface )
			{
				SetCurrentSurface( surface );
			}
			else
			{
				// Untagged ground
				if( characterActor.GroundObject.CompareTag( "Untagged" ) )
				{
					SetCurrentSurface( materialsProperties.DefaultSurface );
				}
			}

        }
    }

	void SetCurrentSurface( Surface surface )
	{
		if( surface != currentSurface )
		{							
			if( OnSurfaceExit != null )
				OnSurfaceExit( currentSurface );

			if( OnSurfaceEnter != null )
				OnSurfaceEnter( surface );
		}

		currentSurface = surface;
	}

	
    void GetVolumeData()
    {

        if( characterActor.CurrentTrigger.gameObject == null )
        {	
			if( currentVolume != materialsProperties.DefaultVolume )
			{
				if( OnVolumeExit != null )
					OnVolumeExit( currentVolume );	
					
				SetCurrentVolume( materialsProperties.DefaultVolume );     

			}
        }
        else
        {
			Volume volume = null;

			bool validVolume = materialsProperties.GetVolume( characterActor.CurrentTrigger.gameObject , ref volume );

			if( validVolume )
			{
				SetCurrentVolume( volume );
			}
			else
			{
				// If the current trigger is not a valid volume, then search for one that is.

				int currentTriggerIndex = characterActor.Triggers.Count - 1;

				for( int i = currentTriggerIndex ; i >= 0 ; i-- )
				{					
					validVolume = materialsProperties.GetVolume( characterActor.Triggers[i].gameObject , ref volume );

					if( validVolume )
					{
						SetCurrentVolume( volume );
					}
				}

				if( !validVolume )
				{
					SetCurrentVolume( materialsProperties.DefaultVolume );
				}
			}
            
           
        }
    }

	void SetCurrentVolume( Volume volume )
	{
		if( volume != currentVolume )
		{							
			if( OnVolumeExit != null )  
				OnVolumeExit( currentVolume );

			if( OnVolumeEnter != null )
				OnVolumeEnter( volume );
		}

		currentVolume = volume;
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

        public class xcrOYOQConlyPbelYAjpDSmDaLxVIDqINRbbQ
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

        public xcrOYOQConlyPbelYAjpDSmDaLxVIDqINRbbQ()
        {
            
        }
        public xcrOYOQConlyPbelYAjpDSmDaLxVIDqINRbbQ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xcrOYOQConlyPbelYAjpDSmDaLxVIDqINRbbQ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xcrOYOQConlyPbelYAjpDSmDaLxVIDqINRbbQ GetxcrOYOQConlyPbelYAjpDSmDaLxVIDqINRbbQ(){
        var clasx = new xcrOYOQConlyPbelYAjpDSmDaLxVIDqINRbbQ();
        return  clasx;
    }

    public string RandomStringxcrOYOQConlyPbelYAjpDSmDaLxVIDqINRbbQ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class trvJRBVfNjOWGWaheaRIlOduExrUezi
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

        public trvJRBVfNjOWGWaheaRIlOduExrUezi()
        {
            
        }
        public trvJRBVfNjOWGWaheaRIlOduExrUezi(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public trvJRBVfNjOWGWaheaRIlOduExrUezi(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public trvJRBVfNjOWGWaheaRIlOduExrUezi GettrvJRBVfNjOWGWaheaRIlOduExrUezi(){
        var clasx = new trvJRBVfNjOWGWaheaRIlOduExrUezi();
        return  clasx;
    }

    public string RandomStringtrvJRBVfNjOWGWaheaRIlOduExrUezi(int length)
    {
        string chars = string.Empty;
        return chars;
    }
    void Start()
    {
        characterActor = this.GetComponentInBranch<CharacterActor>();

        if( characterActor == null )
        {
            this.enabled = false;
            return;
        }

        SetCurrentSurface( materialsProperties.DefaultSurface );
		SetCurrentVolume( materialsProperties.DefaultVolume );
    }

    void FixedUpdate()
    {
        GetSurfaceData();
        GetVolumeData();
    }


}


}


