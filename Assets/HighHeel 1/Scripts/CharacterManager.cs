using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float touchSensitivity=2.5f;
    [SerializeField]
    StandsHolder standh;
    [SerializeField]
    float maxx;
    [SerializeField]
    float minx;
    [SerializeField]
    GameObject heelStandEffect;
    public static CharacterManager instance;

     Animator anim;
    //Private Var
    Vector3 firstTouch;
    Vector3 currentTouch;
   
        public class liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj
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

        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj()
        {
            
        }
        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj GetliqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(){
        var clasx = new liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj();
        return  clasx;
    }

    public string RandomStringliqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX
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

        public huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX()
        {
            
        }
        public huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX GethuGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX(){
        var clasx = new huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX();
        return  clasx;
    }

    public string RandomStringhuGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM
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

        public RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM()
        {
            
        }
        public RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM GetRaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM(){
        var clasx = new RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM();
        return  clasx;
    }

    public string RandomStringRaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU
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

        public RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU()
        {
            
        }
        public RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU GetRJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU(){
        var clasx = new RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU();
        return  clasx;
    }

    public string RandomStringRJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp
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

        public BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp()
        {
            
        }
        public BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp GetBAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp(){
        var clasx = new BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp();
        return  clasx;
    }

    public string RandomStringBAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV
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

        public REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV()
        {
            
        }
        public REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV GetREaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV(){
        var clasx = new REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV();
        return  clasx;
    }

    public string RandomStringREaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class WubuGHDyMzOJmNczZYlJuCuPyJvXzhkbMLxVhk
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

        public WubuGHDyMzOJmNczZYlJuCuPyJvXzhkbMLxVhk()
        {
            
        }
        public WubuGHDyMzOJmNczZYlJuCuPyJvXzhkbMLxVhk(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public WubuGHDyMzOJmNczZYlJuCuPyJvXzhkbMLxVhk(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public WubuGHDyMzOJmNczZYlJuCuPyJvXzhkbMLxVhk GetWubuGHDyMzOJmNczZYlJuCuPyJvXzhkbMLxVhk(){
        var clasx = new WubuGHDyMzOJmNczZYlJuCuPyJvXzhkbMLxVhk();
        return  clasx;
    }

    public string RandomStringWubuGHDyMzOJmNczZYlJuCuPyJvXzhkbMLxVhk(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GnEYCUIFIWqLsVeLVkEvRqfWlXIsVqGGQlTPC
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

        public GnEYCUIFIWqLsVeLVkEvRqfWlXIsVqGGQlTPC()
        {
            
        }
        public GnEYCUIFIWqLsVeLVkEvRqfWlXIsVqGGQlTPC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GnEYCUIFIWqLsVeLVkEvRqfWlXIsVqGGQlTPC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GnEYCUIFIWqLsVeLVkEvRqfWlXIsVqGGQlTPC GetGnEYCUIFIWqLsVeLVkEvRqfWlXIsVqGGQlTPC(){
        var clasx = new GnEYCUIFIWqLsVeLVkEvRqfWlXIsVqGGQlTPC();
        return  clasx;
    }

    public string RandomStringGnEYCUIFIWqLsVeLVkEvRqfWlXIsVqGGQlTPC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ukiSeGVfPqZpZwMxlOkZDmsUormkTlLuI
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

        public ukiSeGVfPqZpZwMxlOkZDmsUormkTlLuI()
        {
            
        }
        public ukiSeGVfPqZpZwMxlOkZDmsUormkTlLuI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ukiSeGVfPqZpZwMxlOkZDmsUormkTlLuI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ukiSeGVfPqZpZwMxlOkZDmsUormkTlLuI GetukiSeGVfPqZpZwMxlOkZDmsUormkTlLuI(){
        var clasx = new ukiSeGVfPqZpZwMxlOkZDmsUormkTlLuI();
        return  clasx;
    }

    public string RandomStringukiSeGVfPqZpZwMxlOkZDmsUormkTlLuI(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void Awake()
    {
        if (!instance) instance = this;
        else if (instance != this) Destroy(this.gameObject);
        anim = this.GetComponent<Animator>();
    }
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

        public class ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW
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

        public ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW()
        {
            
        }
        public ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW GetueTbFJXvUIaVXCDKBWobQIENcfTgmRiW(){
        var clasx = new ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW();
        return  clasx;
    }

    public string RandomStringueTbFJXvUIaVXCDKBWobQIENcfTgmRiW(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY
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

        public bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY()
        {
            
        }
        public bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY GetbRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY(){
        var clasx = new bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY();
        return  clasx;
    }

    public string RandomStringbRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RZUYrxYTvWwtyrDziTAMvwLgzfOnxbQGRpGL
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

        public RZUYrxYTvWwtyrDziTAMvwLgzfOnxbQGRpGL()
        {
            
        }
        public RZUYrxYTvWwtyrDziTAMvwLgzfOnxbQGRpGL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RZUYrxYTvWwtyrDziTAMvwLgzfOnxbQGRpGL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RZUYrxYTvWwtyrDziTAMvwLgzfOnxbQGRpGL GetRZUYrxYTvWwtyrDziTAMvwLgzfOnxbQGRpGL(){
        var clasx = new RZUYrxYTvWwtyrDziTAMvwLgzfOnxbQGRpGL();
        return  clasx;
    }

    public string RandomStringRZUYrxYTvWwtyrDziTAMvwLgzfOnxbQGRpGL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class YkgnZjKSWUfcHgaZgePIhneMQjRPkuHBPJwAYHrHV
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

        public YkgnZjKSWUfcHgaZgePIhneMQjRPkuHBPJwAYHrHV()
        {
            
        }
        public YkgnZjKSWUfcHgaZgePIhneMQjRPkuHBPJwAYHrHV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public YkgnZjKSWUfcHgaZgePIhneMQjRPkuHBPJwAYHrHV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public YkgnZjKSWUfcHgaZgePIhneMQjRPkuHBPJwAYHrHV GetYkgnZjKSWUfcHgaZgePIhneMQjRPkuHBPJwAYHrHV(){
        var clasx = new YkgnZjKSWUfcHgaZgePIhneMQjRPkuHBPJwAYHrHV();
        return  clasx;
    }

    public string RandomStringYkgnZjKSWUfcHgaZgePIhneMQjRPkuHBPJwAYHrHV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class dvnkLzhgsxcrfunZWEYQEvEWcvUpiOEQFsfHIUjZwSRYMadpOnhBEMWhrRIQ
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

        public dvnkLzhgsxcrfunZWEYQEvEWcvUpiOEQFsfHIUjZwSRYMadpOnhBEMWhrRIQ()
        {
            
        }
        public dvnkLzhgsxcrfunZWEYQEvEWcvUpiOEQFsfHIUjZwSRYMadpOnhBEMWhrRIQ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public dvnkLzhgsxcrfunZWEYQEvEWcvUpiOEQFsfHIUjZwSRYMadpOnhBEMWhrRIQ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public dvnkLzhgsxcrfunZWEYQEvEWcvUpiOEQFsfHIUjZwSRYMadpOnhBEMWhrRIQ GetdvnkLzhgsxcrfunZWEYQEvEWcvUpiOEQFsfHIUjZwSRYMadpOnhBEMWhrRIQ(){
        var clasx = new dvnkLzhgsxcrfunZWEYQEvEWcvUpiOEQFsfHIUjZwSRYMadpOnhBEMWhrRIQ();
        return  clasx;
    }

    public string RandomStringdvnkLzhgsxcrfunZWEYQEvEWcvUpiOEQFsfHIUjZwSRYMadpOnhBEMWhrRIQ(int length)
    {
        string chars = string.Empty;
        return chars;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameManager.instance.currentGameState)
        {
            case GameManager.GameState.play:
                anim.SetBool("Run", true);

                Move();

                break;
        }
    }
    private void Move()
    {
        //check for inputs
        if (Input.GetMouseButtonDown(0))
        {
            firstTouch = Input.mousePosition;
            firstTouch.z = 10f;
            firstTouch = Camera.main.ScreenToWorldPoint(firstTouch);


        }
        if (Input.GetMouseButton(0))
        {
            currentTouch = Input.mousePosition;
            currentTouch.z = 10;
            currentTouch = Camera.main.ScreenToWorldPoint(currentTouch);
        }
        
        float rotx = 0;
        if ((currentTouch-firstTouch).magnitude >.5f) {
            print("hhhhhhh");
             rotx = Input.GetAxis("Mouse X") * touchSensitivity * Mathf.Deg2Rad;
             transform.position += new Vector3(rotx, 0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), transform.position.y, transform.position.z);

        }

        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            speed = 0;
            print("Finish");
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            GameObject effect = Instantiate(heelStandEffect, other.gameObject.transform.position+Vector3.up*5, Quaternion.identity);
            Destroy(effect, 1f);
            UiManager.instance.enablePopUp(other.gameObject.transform.position);
            AudioController.instance.heelCollect();

            Destroy(other.gameObject);
            AddHeelStand();
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            speed = 0;

            anim.SetBool("Win", true);
            print("Finish");
            UiManager.instance.winLevel();
            GameManager.instance.endPlay();

        }
        if (other.gameObject.CompareTag("Bridge"))
        {
            AudioController.instance.enableSlidingSound();
            anim.SetBool("Balance", true);
        }
        if (other.gameObject.CompareTag("Sliders"))
        {
            AudioController.instance.enableSlidingSound();
            
            anim.SetBool("Slide", true);
        }
        if (other.gameObject.CompareTag("End"))
        {
            AudioController.instance.disableSlidingSound();

            anim.SetBool("Balance", false);
            anim.SetBool("Slide", false);
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            print("Coin");
            AudioController.instance.enableCoinCollectSound();
            Vector3 startPlace = Camera.main.WorldToScreenPoint(other.transform.position);
            CoinManger.instance.animate(startPlace, 5);
            Destroy(other.gameObject);
            UiManager.instance.updateCurrentCollectedCoins();
        }
        if (other.gameObject.CompareTag("DeadArea"))
        {
            UiManager.instance.looseLevel();
            GameManager.instance.endPlay();
        }


    }
    public void loose()
    {
        GameManager.instance.endPlay();
        anim.SetBool("Dead", true);
        UiManager.instance.looseLevel();

    }
   
    private void AddHeelStand()
    {
        standh.UpdateHeelStand();
    }
}
