using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
     //win item
    [Header("Ui Panel")]
    public GameObject playUi;
    public GameObject winUi;
    public GameObject nextButton;
    public GameObject failUi;
    public GameObject happyUi;
    public GameObject collectedCoin;
    public GameObject xCoinButton;
    public Animator totalCollectedCoinAnim;
    public Text winCollectedCoin;
    public Text currentLevelText;
    private  int currentLevel;
    public static UiManager instance;
    public Text totalCoinText;
    private int totalCoin;
    public GameObject shopNotification;
    public CoinManger coinM;
    public Transform coinSP;
   
        public class qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn
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

        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn()
        {
            
        }
        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn GetqKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(){
        var clasx = new qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn();
        return  clasx;
    }

    public string RandomStringqKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class SPjqRJABJIuOGHGXFHnyHBdXqcQkKerPqSEiFqzGuxXwPZzLppHRS
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

        public SPjqRJABJIuOGHGXFHnyHBdXqcQkKerPqSEiFqzGuxXwPZzLppHRS()
        {
            
        }
        public SPjqRJABJIuOGHGXFHnyHBdXqcQkKerPqSEiFqzGuxXwPZzLppHRS(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public SPjqRJABJIuOGHGXFHnyHBdXqcQkKerPqSEiFqzGuxXwPZzLppHRS(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public SPjqRJABJIuOGHGXFHnyHBdXqcQkKerPqSEiFqzGuxXwPZzLppHRS GetSPjqRJABJIuOGHGXFHnyHBdXqcQkKerPqSEiFqzGuxXwPZzLppHRS(){
        var clasx = new SPjqRJABJIuOGHGXFHnyHBdXqcQkKerPqSEiFqzGuxXwPZzLppHRS();
        return  clasx;
    }

    public string RandomStringSPjqRJABJIuOGHGXFHnyHBdXqcQkKerPqSEiFqzGuxXwPZzLppHRS(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class qkwNSimOCcpTcCXgHVICXcWIJGoFBsBMYuqFRPccRGNfAYBrbndUMFNONnEMthNJad
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

        public qkwNSimOCcpTcCXgHVICXcWIJGoFBsBMYuqFRPccRGNfAYBrbndUMFNONnEMthNJad()
        {
            
        }
        public qkwNSimOCcpTcCXgHVICXcWIJGoFBsBMYuqFRPccRGNfAYBrbndUMFNONnEMthNJad(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qkwNSimOCcpTcCXgHVICXcWIJGoFBsBMYuqFRPccRGNfAYBrbndUMFNONnEMthNJad(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qkwNSimOCcpTcCXgHVICXcWIJGoFBsBMYuqFRPccRGNfAYBrbndUMFNONnEMthNJad GetqkwNSimOCcpTcCXgHVICXcWIJGoFBsBMYuqFRPccRGNfAYBrbndUMFNONnEMthNJad(){
        var clasx = new qkwNSimOCcpTcCXgHVICXcWIJGoFBsBMYuqFRPccRGNfAYBrbndUMFNONnEMthNJad();
        return  clasx;
    }

    public string RandomStringqkwNSimOCcpTcCXgHVICXcWIJGoFBsBMYuqFRPccRGNfAYBrbndUMFNONnEMthNJad(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class FjgewykzSGQqSVcStSlyXiqzgAPgMKGhfLKQWVgsT
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

        public FjgewykzSGQqSVcStSlyXiqzgAPgMKGhfLKQWVgsT()
        {
            
        }
        public FjgewykzSGQqSVcStSlyXiqzgAPgMKGhfLKQWVgsT(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public FjgewykzSGQqSVcStSlyXiqzgAPgMKGhfLKQWVgsT(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public FjgewykzSGQqSVcStSlyXiqzgAPgMKGhfLKQWVgsT GetFjgewykzSGQqSVcStSlyXiqzgAPgMKGhfLKQWVgsT(){
        var clasx = new FjgewykzSGQqSVcStSlyXiqzgAPgMKGhfLKQWVgsT();
        return  clasx;
    }

    public string RandomStringFjgewykzSGQqSVcStSlyXiqzgAPgMKGhfLKQWVgsT(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PrYvihVkHlcnQIscDggNogqXrxnGSHvYcXGfalMzWReMroTEWRJWFlh
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

        public PrYvihVkHlcnQIscDggNogqXrxnGSHvYcXGfalMzWReMroTEWRJWFlh()
        {
            
        }
        public PrYvihVkHlcnQIscDggNogqXrxnGSHvYcXGfalMzWReMroTEWRJWFlh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PrYvihVkHlcnQIscDggNogqXrxnGSHvYcXGfalMzWReMroTEWRJWFlh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PrYvihVkHlcnQIscDggNogqXrxnGSHvYcXGfalMzWReMroTEWRJWFlh GetPrYvihVkHlcnQIscDggNogqXrxnGSHvYcXGfalMzWReMroTEWRJWFlh(){
        var clasx = new PrYvihVkHlcnQIscDggNogqXrxnGSHvYcXGfalMzWReMroTEWRJWFlh();
        return  clasx;
    }

    public string RandomStringPrYvihVkHlcnQIscDggNogqXrxnGSHvYcXGfalMzWReMroTEWRJWFlh(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class iwAGrXkPYkyMAvBrCfNHMknbZXtWmvMpCs
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

        public iwAGrXkPYkyMAvBrCfNHMknbZXtWmvMpCs()
        {
            
        }
        public iwAGrXkPYkyMAvBrCfNHMknbZXtWmvMpCs(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public iwAGrXkPYkyMAvBrCfNHMknbZXtWmvMpCs(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public iwAGrXkPYkyMAvBrCfNHMknbZXtWmvMpCs GetiwAGrXkPYkyMAvBrCfNHMknbZXtWmvMpCs(){
        var clasx = new iwAGrXkPYkyMAvBrCfNHMknbZXtWmvMpCs();
        return  clasx;
    }

    public string RandomStringiwAGrXkPYkyMAvBrCfNHMknbZXtWmvMpCs(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class eHiHyPMHrQFXvAYmbsOYOffotKfEkLUXdhLkpg
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

        public eHiHyPMHrQFXvAYmbsOYOffotKfEkLUXdhLkpg()
        {
            
        }
        public eHiHyPMHrQFXvAYmbsOYOffotKfEkLUXdhLkpg(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public eHiHyPMHrQFXvAYmbsOYOffotKfEkLUXdhLkpg(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public eHiHyPMHrQFXvAYmbsOYOffotKfEkLUXdhLkpg GeteHiHyPMHrQFXvAYmbsOYOffotKfEkLUXdhLkpg(){
        var clasx = new eHiHyPMHrQFXvAYmbsOYOffotKfEkLUXdhLkpg();
        return  clasx;
    }

    public string RandomStringeHiHyPMHrQFXvAYmbsOYOffotKfEkLUXdhLkpg(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GJpkDoLweeVmYmLQunHUPSNJfisfpexLvpYXQZTnKRGyTiKPmwYPWCI
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

        public GJpkDoLweeVmYmLQunHUPSNJfisfpexLvpYXQZTnKRGyTiKPmwYPWCI()
        {
            
        }
        public GJpkDoLweeVmYmLQunHUPSNJfisfpexLvpYXQZTnKRGyTiKPmwYPWCI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GJpkDoLweeVmYmLQunHUPSNJfisfpexLvpYXQZTnKRGyTiKPmwYPWCI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GJpkDoLweeVmYmLQunHUPSNJfisfpexLvpYXQZTnKRGyTiKPmwYPWCI GetGJpkDoLweeVmYmLQunHUPSNJfisfpexLvpYXQZTnKRGyTiKPmwYPWCI(){
        var clasx = new GJpkDoLweeVmYmLQunHUPSNJfisfpexLvpYXQZTnKRGyTiKPmwYPWCI();
        return  clasx;
    }

    public string RandomStringGJpkDoLweeVmYmLQunHUPSNJfisfpexLvpYXQZTnKRGyTiKPmwYPWCI(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void Awake(){
    	if(instance==null){
    		instance=this;
    	}else if(instance!=this){
    		Destroy(this.gameObject);
    	}
    }
    // Start is called before the first frame update
 
        public class PBCCRefbinLCauOxoodUttlvaWcxQpp
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

        public PBCCRefbinLCauOxoodUttlvaWcxQpp()
        {
            
        }
        public PBCCRefbinLCauOxoodUttlvaWcxQpp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PBCCRefbinLCauOxoodUttlvaWcxQpp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PBCCRefbinLCauOxoodUttlvaWcxQpp GetPBCCRefbinLCauOxoodUttlvaWcxQpp(){
        var clasx = new PBCCRefbinLCauOxoodUttlvaWcxQpp();
        return  clasx;
    }

    public string RandomStringPBCCRefbinLCauOxoodUttlvaWcxQpp(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class sfQmLApsPqfReYoCYSPIgDKdgIQcEvVWZwxmnwtpKNeGsekB
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

        public sfQmLApsPqfReYoCYSPIgDKdgIQcEvVWZwxmnwtpKNeGsekB()
        {
            
        }
        public sfQmLApsPqfReYoCYSPIgDKdgIQcEvVWZwxmnwtpKNeGsekB(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public sfQmLApsPqfReYoCYSPIgDKdgIQcEvVWZwxmnwtpKNeGsekB(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public sfQmLApsPqfReYoCYSPIgDKdgIQcEvVWZwxmnwtpKNeGsekB GetsfQmLApsPqfReYoCYSPIgDKdgIQcEvVWZwxmnwtpKNeGsekB(){
        var clasx = new sfQmLApsPqfReYoCYSPIgDKdgIQcEvVWZwxmnwtpKNeGsekB();
        return  clasx;
    }

    public string RandomStringsfQmLApsPqfReYoCYSPIgDKdgIQcEvVWZwxmnwtpKNeGsekB(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class uhLROrtgkQPqIlFwdNPgzShcreKPiktDFWdTgKZlbgVwzXeTHwDzu
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

        public uhLROrtgkQPqIlFwdNPgzShcreKPiktDFWdTgKZlbgVwzXeTHwDzu()
        {
            
        }
        public uhLROrtgkQPqIlFwdNPgzShcreKPiktDFWdTgKZlbgVwzXeTHwDzu(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public uhLROrtgkQPqIlFwdNPgzShcreKPiktDFWdTgKZlbgVwzXeTHwDzu(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public uhLROrtgkQPqIlFwdNPgzShcreKPiktDFWdTgKZlbgVwzXeTHwDzu GetuhLROrtgkQPqIlFwdNPgzShcreKPiktDFWdTgKZlbgVwzXeTHwDzu(){
        var clasx = new uhLROrtgkQPqIlFwdNPgzShcreKPiktDFWdTgKZlbgVwzXeTHwDzu();
        return  clasx;
    }

    public string RandomStringuhLROrtgkQPqIlFwdNPgzShcreKPiktDFWdTgKZlbgVwzXeTHwDzu(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GioQWReggIchUPWsgxvjEmHziLHKMvYmsfRACjKjkzgCdzKvoYpXkIPTb
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

        public GioQWReggIchUPWsgxvjEmHziLHKMvYmsfRACjKjkzgCdzKvoYpXkIPTb()
        {
            
        }
        public GioQWReggIchUPWsgxvjEmHziLHKMvYmsfRACjKjkzgCdzKvoYpXkIPTb(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GioQWReggIchUPWsgxvjEmHziLHKMvYmsfRACjKjkzgCdzKvoYpXkIPTb(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GioQWReggIchUPWsgxvjEmHziLHKMvYmsfRACjKjkzgCdzKvoYpXkIPTb GetGioQWReggIchUPWsgxvjEmHziLHKMvYmsfRACjKjkzgCdzKvoYpXkIPTb(){
        var clasx = new GioQWReggIchUPWsgxvjEmHziLHKMvYmsfRACjKjkzgCdzKvoYpXkIPTb();
        return  clasx;
    }

    public string RandomStringGioQWReggIchUPWsgxvjEmHziLHKMvYmsfRACjKjkzgCdzKvoYpXkIPTb(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class jBAEktPRApELsCNCSUgrWBegCejkBxZTqpXdZgbFHAeWndaCJPqBYuLhWUCGK
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

        public jBAEktPRApELsCNCSUgrWBegCejkBxZTqpXdZgbFHAeWndaCJPqBYuLhWUCGK()
        {
            
        }
        public jBAEktPRApELsCNCSUgrWBegCejkBxZTqpXdZgbFHAeWndaCJPqBYuLhWUCGK(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public jBAEktPRApELsCNCSUgrWBegCejkBxZTqpXdZgbFHAeWndaCJPqBYuLhWUCGK(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public jBAEktPRApELsCNCSUgrWBegCejkBxZTqpXdZgbFHAeWndaCJPqBYuLhWUCGK GetjBAEktPRApELsCNCSUgrWBegCejkBxZTqpXdZgbFHAeWndaCJPqBYuLhWUCGK(){
        var clasx = new jBAEktPRApELsCNCSUgrWBegCejkBxZTqpXdZgbFHAeWndaCJPqBYuLhWUCGK();
        return  clasx;
    }

    public string RandomStringjBAEktPRApELsCNCSUgrWBegCejkBxZTqpXdZgbFHAeWndaCJPqBYuLhWUCGK(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class sguBlUspbWqUQjdSSOFxByIZhTeOccXJKHCVxBtsOWIRkEG
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

        public sguBlUspbWqUQjdSSOFxByIZhTeOccXJKHCVxBtsOWIRkEG()
        {
            
        }
        public sguBlUspbWqUQjdSSOFxByIZhTeOccXJKHCVxBtsOWIRkEG(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public sguBlUspbWqUQjdSSOFxByIZhTeOccXJKHCVxBtsOWIRkEG(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public sguBlUspbWqUQjdSSOFxByIZhTeOccXJKHCVxBtsOWIRkEG GetsguBlUspbWqUQjdSSOFxByIZhTeOccXJKHCVxBtsOWIRkEG(){
        var clasx = new sguBlUspbWqUQjdSSOFxByIZhTeOccXJKHCVxBtsOWIRkEG();
        return  clasx;
    }

    public string RandomStringsguBlUspbWqUQjdSSOFxByIZhTeOccXJKHCVxBtsOWIRkEG(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mRseTUGwTUEbbEJIXzcuNokHXgvitNoowvGxgkLLhxqKAIj
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

        public mRseTUGwTUEbbEJIXzcuNokHXgvitNoowvGxgkLLhxqKAIj()
        {
            
        }
        public mRseTUGwTUEbbEJIXzcuNokHXgvitNoowvGxgkLLhxqKAIj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mRseTUGwTUEbbEJIXzcuNokHXgvitNoowvGxgkLLhxqKAIj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mRseTUGwTUEbbEJIXzcuNokHXgvitNoowvGxgkLLhxqKAIj GetmRseTUGwTUEbbEJIXzcuNokHXgvitNoowvGxgkLLhxqKAIj(){
        var clasx = new mRseTUGwTUEbbEJIXzcuNokHXgvitNoowvGxgkLLhxqKAIj();
        return  clasx;
    }

    public string RandomStringmRseTUGwTUEbbEJIXzcuNokHXgvitNoowvGxgkLLhxqKAIj(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class nvgFVwfGzgKqiOoAVTTJxMOpwYctsGiosgkbjUyqfKGSJrbBywDvCtKbhq
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

        public nvgFVwfGzgKqiOoAVTTJxMOpwYctsGiosgkbjUyqfKGSJrbBywDvCtKbhq()
        {
            
        }
        public nvgFVwfGzgKqiOoAVTTJxMOpwYctsGiosgkbjUyqfKGSJrbBywDvCtKbhq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public nvgFVwfGzgKqiOoAVTTJxMOpwYctsGiosgkbjUyqfKGSJrbBywDvCtKbhq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public nvgFVwfGzgKqiOoAVTTJxMOpwYctsGiosgkbjUyqfKGSJrbBywDvCtKbhq GetnvgFVwfGzgKqiOoAVTTJxMOpwYctsGiosgkbjUyqfKGSJrbBywDvCtKbhq(){
        var clasx = new nvgFVwfGzgKqiOoAVTTJxMOpwYctsGiosgkbjUyqfKGSJrbBywDvCtKbhq();
        return  clasx;
    }

    public string RandomStringnvgFVwfGzgKqiOoAVTTJxMOpwYctsGiosgkbjUyqfKGSJrbBywDvCtKbhq(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
    {
        
        GameItemManager.Instance.SetUpColor();
         currentLevel=PlayerPrefs.GetInt("Current_Level",1);
         //if(SceneManager.GetActiveScene().buildIndex!=currentLevel)
           //  SceneManager.LoadScene(currentLevel);
        totalCoin=PlayerPrefs.GetInt("Total_Coin",0);
        if(totalCoin>1000)
        shopNotification.SetActive(true);
        else
         shopNotification.SetActive(false);
         setTotalCoinText();

       
        setLevelText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void dragToPlay(){
    	GameManager.instance.enablePlayMode();
    	startPlayMode();
    }
    public void startPlayMode(){
    	playUi.SetActive(false);

    }
    public void win(){
        
    	winUi.SetActive(true);
        StartCoroutine("panelsDelay",.5f);
    } 
    IEnumerator panelsDelay(){
         happyUi.SetActive(true);
        yield return new WaitForSeconds(2f);
        collectedCoin.SetActive(true);
       
        StartCoroutine("coinTextIncremetorDelay");
        xCoinButton.SetActive(true);

    }
    int tempCoin=0;
    IEnumerator coinTextIncremetorDelay(){
          coinM.animate(coinSP.position,1);
        yield return new WaitForSeconds(.00001f);
        if(tempCoin<200){
            tempCoin++;
            winCollectedCoin.text=tempCoin+"";
          StartCoroutine("coinTextIncremetorDelay");
        }else{
            totalCollectedCoinAnim.enabled=false;
            nextButton.SetActive(true);
            totalCoin+=200;
            PlayerPrefs.SetInt("Total_Coin",totalCoin);
        }
       



    }
    public void levelFail(){
        
        failUi.SetActive(true);
    }
    public void retry(){
        SceneManager.LoadScene(currentLevel);        
    }
    public void skipLevel(){      
       gooNextLevel();
    }
    public void gooNextLevel(){
        currentLevel++;
        if(currentLevel>21)
        PlayerPrefs.SetInt("Current_Level",1);
        else
        PlayerPrefs.SetInt("Current_Level",currentLevel);

        SceneManager.LoadScene(currentLevel);
    }
    public void gooShopping(){
        SceneManager.LoadScene("Shop");
    }
    private void setLevelText(){
        currentLevelText.text="level:"+currentLevel;

    }
    
    private void setTotalCoinText(){
        totalCoinText.text=totalCoin+"";
    }
}
