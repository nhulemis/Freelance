using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using Lightbug.Utilities;
using Lightbug.CharacterControllerPro.Core;

namespace Lightbug.CharacterControllerPro.Implementation
{


/// <summary>
/// This class is responsable for detecting inputs and managing character actions. These actions may come from a human (the player) or an AI.
/// </summary>
// [RequireComponent( typeof(CharacterActor) )]
[AddComponentMenu("Character Controller Pro/Implementation/Character/Character Brain")]
public class CharacterBrain : MonoBehaviour
{
    
    [SerializeField]
    bool isAI = false;

	[SerializeField]
	InputHandlerSettings inputHandlerSettings = new InputHandlerSettings();
		

    // AI brain -------------------------------------------------------------------------------
    [SerializeField]
	CharacterAIBehaviour aiBehaviour = null;

	CharacterAIBehaviour currentAIBehaviour = null;
	
	
    // ─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────
	// ─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────

	[SerializeField]
	CharacterActions characterActions = new CharacterActions();

	
	bool dirty = false;

	CharacterActor characterActor = null;
	
	/// <summary>
	/// Gets the current brain mode (AI or Human).
	/// </summary>
	public bool IsAI
	{
		get
		{
			return isAI;
		}
	}

	/// <summary>
	/// Gets the current character action info used by the character.
	/// </summary>
	public CharacterActions CharacterActions
	{
		get
		{
			return characterActions;
		}
	}


	protected virtual void Awake()
	{
		characterActor = this.GetComponentInBranch<CharacterActor>();

		characterActions.InitializeActions();

		inputHandlerSettings.Initialize( gameObject );		
		
	}


	void OnDisable()
	{
		characterActions.Reset();
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
    void Start()
    {
        SetBrainType( isAI );

		StartCoroutine( LateFixedUpdate() );
    }

	/// <summary>
	/// Sets a custom character action info.
	/// </summary>
	public void SetAction( CharacterActions characterAction )
	{
		this.characterActions = characterAction;
	}


	    
	/// <summary>
	/// Sets the type of brain.
	/// </summary>
    public void SetBrainType( bool AI )
    {
		characterActions.Reset();

        if( AI )
        {
            SetAIBehaviour( aiBehaviour );        
        }

        this.isAI = AI;
    
    }

	/// <summary>
	/// Sets the AI behaviour type.
	/// </summary>
    public void SetAIBehaviour( CharacterAIBehaviour aiBehaviour )
    {
		if( aiBehaviour == null )
			return;
		
		characterActions.Reset();

		currentAIBehaviour = aiBehaviour;

		currentAIBehaviour.EnterBehaviour( Time.deltaTime );
        
    }
	
	

	IEnumerator LateFixedUpdate()
	{
		YieldInstruction waitForFixedUpdate = new WaitForFixedUpdate();
		while( true )
		{
			yield return waitForFixedUpdate;
			dirty = true;
		}
	}
	
	
	void Update()
	{
		float dt = Time.deltaTime;

		if( dirty )
		{
			dirty = false;
			characterActions.Reset();
		}

		UpdateBrain( dt );
	}


	public void UpdateBrain( float dt = 0f )
	{
		if( Time.timeScale == 0 )
			return;
		
		if( isAI )
		{			

			if( currentAIBehaviour == null )
				return;

			// Update the current AI logic.
			currentAIBehaviour.UpdateBehaviour( dt );

			// Copy the actions from the AI behaviour to the Brain.
			characterActions.SetValues( currentAIBehaviour.characterActions );			
		
			
		}
		else
		{
			// Update the human actions
			characterActions.SetValues( inputHandlerSettings.InputHandler );

		}

		// Update all the fields based on the change of state.
		characterActions.Update( dt );
		
	}


}

}
