using Assets.DuckType.Jiggle;
using UnityEngine;

namespace hairmaster.Scripts
{
    public class RootBonesSwingerController : MonoBehaviour
    {
        public CharacterInputController characterInputController;
        private Jiggle jiggle;
        private bool canSwing = true;
        private HairBoneController hairBoneController;
        // Start is called before the first frame update
        void Start()
        {
            characterInputController = this.GetComponentInParent<CharacterInputController>();
            jiggle = this.GetComponent<Jiggle>();
            
            
            
            hairBoneController = GetComponentInParent<HairBoneController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (characterInputController.getTouchesDiference() > 1 && canSwing)
            {
                canSwing = false;
                
                
                
                
                jiggle.CenterOfMass.z = 10;

            }
            else if (characterInputController.getTouchesDiference() < -1 && canSwing)
            {
                jiggle.CenterOfMass.z = -10;
                
                
                canSwing = false;

            }
            float parentBoneScale = hairBoneController.transform.localScale.y;
            if(parentBoneScale>4)
                returnToIdleState();
            else
            {
                jiggle.CenterOfMass.z=0;
            }
         
        }class Book
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            public Book(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public Book(string title, string publisher)
                : this(title, publisher, null) { }

           
        public class CFKACJBOGNFLROBUSRMI
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class HBAXPTUXIQMQBAVHXWEWTGMDYLBLQRPVHP
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}
 public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxhuw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchuwaciot
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchuwaciotchx
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class BookxchuwaciotchxCHUW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchcuwa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchcuwaxhua
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchcuwaxhuachx
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Powscq
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class HCWIoajciw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class HCWIoajciwCHOAW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class HCWIoajciwCHOAWowis
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class OwicuaowScuwa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class IWUCOASWkdkowCHOAW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class UCIQOAXSCJIW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class UCIQOAXSCJIWhcuiwxhiaiw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class MCOwjiax
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class MCOwjiaxXjoar
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class MCOwjiaxXjoarAIXA
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class MCOwjiaxXjoarAIXACHUW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class MCOwjiaxXjoarAIXAOCiwa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class KCOZLKSOwa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class KCOZLKSOwaCJiwoa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
       
        public class BHBLFRLHWKRLKHKDMFRXSOUBICQRQ
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class RAIKLVWWAGFNRLQDDAFEVYGR
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class OOERZVLWYGZMNZJZOOBPALZGUQGHBPBAA
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class DREWVVRDBP
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class KQVNTALVWOBHLFECJGBUSMGOCAOWYDVKHZ
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class GVLUDIOLNJCZFLIWMJILAMHNLHTJO
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF
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

        public FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF()
        {
            
        }
        public FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF GetFJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF(){
        var clasx = new FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF();
        return  clasx;
    }

    public string RandomStringFJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU
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

        public IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU()
        {
            
        }
        public IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU GetIZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU(){
        var clasx = new IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU();
        return  clasx;
    }

    public string RandomStringIZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF
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

        public TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF()
        {
            
        }
        public TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF GetTUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF(){
        var clasx = new TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF();
        return  clasx;
    }

    public string RandomStringTUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF
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

        public EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF()
        {
            
        }
        public EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF GetEAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF(){
        var clasx = new EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF();
        return  clasx;
    }

    public string RandomStringEAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI
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

        public MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI()
        {
            
        }
        public MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI GetMSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI(){
        var clasx = new MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI();
        return  clasx;
    }

    public string RandomStringMSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void returnToIdleState()
        {
            Vector3 idleCenterOfMass = jiggle.CenterOfMass;
            if (idleCenterOfMass.z != 0)
            {
                idleCenterOfMass.z = 0;
                jiggle.CenterOfMass = Vector3.MoveTowards(jiggle.CenterOfMass, Vector3.Lerp(jiggle.CenterOfMass, idleCenterOfMass, 1),1);
            }
            else
            {
                canSwing = true;
            }
       
        }
    }
}
