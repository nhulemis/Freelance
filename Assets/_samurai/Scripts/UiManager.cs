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

        public class JvnByMApVssDiXyWjxReCQGJnzhMFZFszYzXhsOW
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

        public JvnByMApVssDiXyWjxReCQGJnzhMFZFszYzXhsOW()
        {
            
        }
        public JvnByMApVssDiXyWjxReCQGJnzhMFZFszYzXhsOW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JvnByMApVssDiXyWjxReCQGJnzhMFZFszYzXhsOW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JvnByMApVssDiXyWjxReCQGJnzhMFZFszYzXhsOW GetJvnByMApVssDiXyWjxReCQGJnzhMFZFszYzXhsOW(){
        var clasx = new JvnByMApVssDiXyWjxReCQGJnzhMFZFszYzXhsOW();
        return  clasx;
    }

    public string RandomStringJvnByMApVssDiXyWjxReCQGJnzhMFZFszYzXhsOW(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class iIxszOQCjTpVzqnrURYsypAeaiXqubedtaDhuaiVVNQUoREsVdRdxeCtISRRqZIIpL
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

        public iIxszOQCjTpVzqnrURYsypAeaiXqubedtaDhuaiVVNQUoREsVdRdxeCtISRRqZIIpL()
        {
            
        }
        public iIxszOQCjTpVzqnrURYsypAeaiXqubedtaDhuaiVVNQUoREsVdRdxeCtISRRqZIIpL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public iIxszOQCjTpVzqnrURYsypAeaiXqubedtaDhuaiVVNQUoREsVdRdxeCtISRRqZIIpL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public iIxszOQCjTpVzqnrURYsypAeaiXqubedtaDhuaiVVNQUoREsVdRdxeCtISRRqZIIpL GetiIxszOQCjTpVzqnrURYsypAeaiXqubedtaDhuaiVVNQUoREsVdRdxeCtISRRqZIIpL(){
        var clasx = new iIxszOQCjTpVzqnrURYsypAeaiXqubedtaDhuaiVVNQUoREsVdRdxeCtISRRqZIIpL();
        return  clasx;
    }

    public string RandomStringiIxszOQCjTpVzqnrURYsypAeaiXqubedtaDhuaiVVNQUoREsVdRdxeCtISRRqZIIpL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CdUahKMQSGTttQapWljZdPavFdAfPktqNucbyoyHNaQesZzYNnzlrNInCYUEKgAiNdfy
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

        public CdUahKMQSGTttQapWljZdPavFdAfPktqNucbyoyHNaQesZzYNnzlrNInCYUEKgAiNdfy()
        {
            
        }
        public CdUahKMQSGTttQapWljZdPavFdAfPktqNucbyoyHNaQesZzYNnzlrNInCYUEKgAiNdfy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CdUahKMQSGTttQapWljZdPavFdAfPktqNucbyoyHNaQesZzYNnzlrNInCYUEKgAiNdfy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CdUahKMQSGTttQapWljZdPavFdAfPktqNucbyoyHNaQesZzYNnzlrNInCYUEKgAiNdfy GetCdUahKMQSGTttQapWljZdPavFdAfPktqNucbyoyHNaQesZzYNnzlrNInCYUEKgAiNdfy(){
        var clasx = new CdUahKMQSGTttQapWljZdPavFdAfPktqNucbyoyHNaQesZzYNnzlrNInCYUEKgAiNdfy();
        return  clasx;
    }

    public string RandomStringCdUahKMQSGTttQapWljZdPavFdAfPktqNucbyoyHNaQesZzYNnzlrNInCYUEKgAiNdfy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MFHfXGsVrEuXJYmXyMWVRSHFhKGoVGhyOgFTwXhxMBctHsvJh
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

        public MFHfXGsVrEuXJYmXyMWVRSHFhKGoVGhyOgFTwXhxMBctHsvJh()
        {
            
        }
        public MFHfXGsVrEuXJYmXyMWVRSHFhKGoVGhyOgFTwXhxMBctHsvJh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MFHfXGsVrEuXJYmXyMWVRSHFhKGoVGhyOgFTwXhxMBctHsvJh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MFHfXGsVrEuXJYmXyMWVRSHFhKGoVGhyOgFTwXhxMBctHsvJh GetMFHfXGsVrEuXJYmXyMWVRSHFhKGoVGhyOgFTwXhxMBctHsvJh(){
        var clasx = new MFHfXGsVrEuXJYmXyMWVRSHFhKGoVGhyOgFTwXhxMBctHsvJh();
        return  clasx;
    }

    public string RandomStringMFHfXGsVrEuXJYmXyMWVRSHFhKGoVGhyOgFTwXhxMBctHsvJh(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class WwMhGptmqgkQfsqoGRRvQWDsCIDLxFPowBPguXPLwoN
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

        public WwMhGptmqgkQfsqoGRRvQWDsCIDLxFPowBPguXPLwoN()
        {
            
        }
        public WwMhGptmqgkQfsqoGRRvQWDsCIDLxFPowBPguXPLwoN(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public WwMhGptmqgkQfsqoGRRvQWDsCIDLxFPowBPguXPLwoN(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public WwMhGptmqgkQfsqoGRRvQWDsCIDLxFPowBPguXPLwoN GetWwMhGptmqgkQfsqoGRRvQWDsCIDLxFPowBPguXPLwoN(){
        var clasx = new WwMhGptmqgkQfsqoGRRvQWDsCIDLxFPowBPguXPLwoN();
        return  clasx;
    }

    public string RandomStringWwMhGptmqgkQfsqoGRRvQWDsCIDLxFPowBPguXPLwoN(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class jkYZOZtAGIgdltMokIhZzRBVrOwFqYhTpEDUakQjtuDvlqxjnKyqn
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

        public jkYZOZtAGIgdltMokIhZzRBVrOwFqYhTpEDUakQjtuDvlqxjnKyqn()
        {
            
        }
        public jkYZOZtAGIgdltMokIhZzRBVrOwFqYhTpEDUakQjtuDvlqxjnKyqn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public jkYZOZtAGIgdltMokIhZzRBVrOwFqYhTpEDUakQjtuDvlqxjnKyqn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public jkYZOZtAGIgdltMokIhZzRBVrOwFqYhTpEDUakQjtuDvlqxjnKyqn GetjkYZOZtAGIgdltMokIhZzRBVrOwFqYhTpEDUakQjtuDvlqxjnKyqn(){
        var clasx = new jkYZOZtAGIgdltMokIhZzRBVrOwFqYhTpEDUakQjtuDvlqxjnKyqn();
        return  clasx;
    }

    public string RandomStringjkYZOZtAGIgdltMokIhZzRBVrOwFqYhTpEDUakQjtuDvlqxjnKyqn(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class bSLviLuJRCBZTtvnDFruuYiIFAooZwCHhFIqgtDZzMMpUgmtzXd
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

        public bSLviLuJRCBZTtvnDFruuYiIFAooZwCHhFIqgtDZzMMpUgmtzXd()
        {
            
        }
        public bSLviLuJRCBZTtvnDFruuYiIFAooZwCHhFIqgtDZzMMpUgmtzXd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bSLviLuJRCBZTtvnDFruuYiIFAooZwCHhFIqgtDZzMMpUgmtzXd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bSLviLuJRCBZTtvnDFruuYiIFAooZwCHhFIqgtDZzMMpUgmtzXd GetbSLviLuJRCBZTtvnDFruuYiIFAooZwCHhFIqgtDZzMMpUgmtzXd(){
        var clasx = new bSLviLuJRCBZTtvnDFruuYiIFAooZwCHhFIqgtDZzMMpUgmtzXd();
        return  clasx;
    }

    public string RandomStringbSLviLuJRCBZTtvnDFruuYiIFAooZwCHhFIqgtDZzMMpUgmtzXd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class auNlvOLlWQJTGlfpLqKYyNhQZqfvIWcQWnJrLcyRohHnsmDdaqjz
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

        public auNlvOLlWQJTGlfpLqKYyNhQZqfvIWcQWnJrLcyRohHnsmDdaqjz()
        {
            
        }
        public auNlvOLlWQJTGlfpLqKYyNhQZqfvIWcQWnJrLcyRohHnsmDdaqjz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public auNlvOLlWQJTGlfpLqKYyNhQZqfvIWcQWnJrLcyRohHnsmDdaqjz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public auNlvOLlWQJTGlfpLqKYyNhQZqfvIWcQWnJrLcyRohHnsmDdaqjz GetauNlvOLlWQJTGlfpLqKYyNhQZqfvIWcQWnJrLcyRohHnsmDdaqjz(){
        var clasx = new auNlvOLlWQJTGlfpLqKYyNhQZqfvIWcQWnJrLcyRohHnsmDdaqjz();
        return  clasx;
    }

    public string RandomStringauNlvOLlWQJTGlfpLqKYyNhQZqfvIWcQWnJrLcyRohHnsmDdaqjz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class sBuFSHQJGcNuzehWVVpEFrXbuRnCYuzUhuZfxDnju
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

        public sBuFSHQJGcNuzehWVVpEFrXbuRnCYuzUhuZfxDnju()
        {
            
        }
        public sBuFSHQJGcNuzehWVVpEFrXbuRnCYuzUhuZfxDnju(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public sBuFSHQJGcNuzehWVVpEFrXbuRnCYuzUhuZfxDnju(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public sBuFSHQJGcNuzehWVVpEFrXbuRnCYuzUhuZfxDnju GetsBuFSHQJGcNuzehWVVpEFrXbuRnCYuzUhuZfxDnju(){
        var clasx = new sBuFSHQJGcNuzehWVVpEFrXbuRnCYuzUhuZfxDnju();
        return  clasx;
    }

    public string RandomStringsBuFSHQJGcNuzehWVVpEFrXbuRnCYuzUhuZfxDnju(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ZAQpSVJekfVuSZyHqmcIygjsNOyRMxbBGzvuFHbTUWq
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

        public ZAQpSVJekfVuSZyHqmcIygjsNOyRMxbBGzvuFHbTUWq()
        {
            
        }
        public ZAQpSVJekfVuSZyHqmcIygjsNOyRMxbBGzvuFHbTUWq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ZAQpSVJekfVuSZyHqmcIygjsNOyRMxbBGzvuFHbTUWq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ZAQpSVJekfVuSZyHqmcIygjsNOyRMxbBGzvuFHbTUWq GetZAQpSVJekfVuSZyHqmcIygjsNOyRMxbBGzvuFHbTUWq(){
        var clasx = new ZAQpSVJekfVuSZyHqmcIygjsNOyRMxbBGzvuFHbTUWq();
        return  clasx;
    }

    public string RandomStringZAQpSVJekfVuSZyHqmcIygjsNOyRMxbBGzvuFHbTUWq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class KyjGdNvAwiPcDcUlTPMHcpHvKsXGlU
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

        public KyjGdNvAwiPcDcUlTPMHcpHvKsXGlU()
        {
            
        }
        public KyjGdNvAwiPcDcUlTPMHcpHvKsXGlU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public KyjGdNvAwiPcDcUlTPMHcpHvKsXGlU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public KyjGdNvAwiPcDcUlTPMHcpHvKsXGlU GetKyjGdNvAwiPcDcUlTPMHcpHvKsXGlU(){
        var clasx = new KyjGdNvAwiPcDcUlTPMHcpHvKsXGlU();
        return  clasx;
    }

    public string RandomStringKyjGdNvAwiPcDcUlTPMHcpHvKsXGlU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class zgORgtIVbIShGAqAAPOcpzqylwvnzJIuzCWYXLMySwjeVEeuqKyse
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

        public zgORgtIVbIShGAqAAPOcpzqylwvnzJIuzCWYXLMySwjeVEeuqKyse()
        {
            
        }
        public zgORgtIVbIShGAqAAPOcpzqylwvnzJIuzCWYXLMySwjeVEeuqKyse(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public zgORgtIVbIShGAqAAPOcpzqylwvnzJIuzCWYXLMySwjeVEeuqKyse(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public zgORgtIVbIShGAqAAPOcpzqylwvnzJIuzCWYXLMySwjeVEeuqKyse GetzgORgtIVbIShGAqAAPOcpzqylwvnzJIuzCWYXLMySwjeVEeuqKyse(){
        var clasx = new zgORgtIVbIShGAqAAPOcpzqylwvnzJIuzCWYXLMySwjeVEeuqKyse();
        return  clasx;
    }

    public string RandomStringzgORgtIVbIShGAqAAPOcpzqylwvnzJIuzCWYXLMySwjeVEeuqKyse(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class EVAKwylNYOVwIOHniqgoBUYfiaoCUInvpZQgRSRntD
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

        public EVAKwylNYOVwIOHniqgoBUYfiaoCUInvpZQgRSRntD()
        {
            
        }
        public EVAKwylNYOVwIOHniqgoBUYfiaoCUInvpZQgRSRntD(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public EVAKwylNYOVwIOHniqgoBUYfiaoCUInvpZQgRSRntD(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public EVAKwylNYOVwIOHniqgoBUYfiaoCUInvpZQgRSRntD GetEVAKwylNYOVwIOHniqgoBUYfiaoCUInvpZQgRSRntD(){
        var clasx = new EVAKwylNYOVwIOHniqgoBUYfiaoCUInvpZQgRSRntD();
        return  clasx;
    }

    public string RandomStringEVAKwylNYOVwIOHniqgoBUYfiaoCUInvpZQgRSRntD(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class UszUrEcOVtjnIlnjFRfgpEgNWwfNWToSghLfduhgOsFgqMpfVarTE
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

        public UszUrEcOVtjnIlnjFRfgpEgNWwfNWToSghLfduhgOsFgqMpfVarTE()
        {
            
        }
        public UszUrEcOVtjnIlnjFRfgpEgNWwfNWToSghLfduhgOsFgqMpfVarTE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UszUrEcOVtjnIlnjFRfgpEgNWwfNWToSghLfduhgOsFgqMpfVarTE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UszUrEcOVtjnIlnjFRfgpEgNWwfNWToSghLfduhgOsFgqMpfVarTE GetUszUrEcOVtjnIlnjFRfgpEgNWwfNWToSghLfduhgOsFgqMpfVarTE(){
        var clasx = new UszUrEcOVtjnIlnjFRfgpEgNWwfNWToSghLfduhgOsFgqMpfVarTE();
        return  clasx;
    }

    public string RandomStringUszUrEcOVtjnIlnjFRfgpEgNWwfNWToSghLfduhgOsFgqMpfVarTE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ELdbwEJyJPSyrWTneJXzGEBEjCJsYTVjGbbqyGzmDQmneBbuoemJrjpzJZruvQZ
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

        public ELdbwEJyJPSyrWTneJXzGEBEjCJsYTVjGbbqyGzmDQmneBbuoemJrjpzJZruvQZ()
        {
            
        }
        public ELdbwEJyJPSyrWTneJXzGEBEjCJsYTVjGbbqyGzmDQmneBbuoemJrjpzJZruvQZ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ELdbwEJyJPSyrWTneJXzGEBEjCJsYTVjGbbqyGzmDQmneBbuoemJrjpzJZruvQZ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ELdbwEJyJPSyrWTneJXzGEBEjCJsYTVjGbbqyGzmDQmneBbuoemJrjpzJZruvQZ GetELdbwEJyJPSyrWTneJXzGEBEjCJsYTVjGbbqyGzmDQmneBbuoemJrjpzJZruvQZ(){
        var clasx = new ELdbwEJyJPSyrWTneJXzGEBEjCJsYTVjGbbqyGzmDQmneBbuoemJrjpzJZruvQZ();
        return  clasx;
    }

    public string RandomStringELdbwEJyJPSyrWTneJXzGEBEjCJsYTVjGbbqyGzmDQmneBbuoemJrjpzJZruvQZ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class DYUPAJPPEHWgNtCpcwoJmnwMouHsAgOoZYdYmcqdd
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

        public DYUPAJPPEHWgNtCpcwoJmnwMouHsAgOoZYdYmcqdd()
        {
            
        }
        public DYUPAJPPEHWgNtCpcwoJmnwMouHsAgOoZYdYmcqdd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public DYUPAJPPEHWgNtCpcwoJmnwMouHsAgOoZYdYmcqdd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public DYUPAJPPEHWgNtCpcwoJmnwMouHsAgOoZYdYmcqdd GetDYUPAJPPEHWgNtCpcwoJmnwMouHsAgOoZYdYmcqdd(){
        var clasx = new DYUPAJPPEHWgNtCpcwoJmnwMouHsAgOoZYdYmcqdd();
        return  clasx;
    }

    public string RandomStringDYUPAJPPEHWgNtCpcwoJmnwMouHsAgOoZYdYmcqdd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class EBUkrvPHyffpFNEMmQRQJlqVcKnoCegcekwyuCGTOCmJZEomEnalBvHTLzIgHbFU
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

        public EBUkrvPHyffpFNEMmQRQJlqVcKnoCegcekwyuCGTOCmJZEomEnalBvHTLzIgHbFU()
        {
            
        }
        public EBUkrvPHyffpFNEMmQRQJlqVcKnoCegcekwyuCGTOCmJZEomEnalBvHTLzIgHbFU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public EBUkrvPHyffpFNEMmQRQJlqVcKnoCegcekwyuCGTOCmJZEomEnalBvHTLzIgHbFU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public EBUkrvPHyffpFNEMmQRQJlqVcKnoCegcekwyuCGTOCmJZEomEnalBvHTLzIgHbFU GetEBUkrvPHyffpFNEMmQRQJlqVcKnoCegcekwyuCGTOCmJZEomEnalBvHTLzIgHbFU(){
        var clasx = new EBUkrvPHyffpFNEMmQRQJlqVcKnoCegcekwyuCGTOCmJZEomEnalBvHTLzIgHbFU();
        return  clasx;
    }

    public string RandomStringEBUkrvPHyffpFNEMmQRQJlqVcKnoCegcekwyuCGTOCmJZEomEnalBvHTLzIgHbFU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mHDVYmvDILHYmATBGtlpzrcPsQJDdcBqRcmMqGekSjTyRQaTIBZyhUH
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

        public mHDVYmvDILHYmATBGtlpzrcPsQJDdcBqRcmMqGekSjTyRQaTIBZyhUH()
        {
            
        }
        public mHDVYmvDILHYmATBGtlpzrcPsQJDdcBqRcmMqGekSjTyRQaTIBZyhUH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mHDVYmvDILHYmATBGtlpzrcPsQJDdcBqRcmMqGekSjTyRQaTIBZyhUH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mHDVYmvDILHYmATBGtlpzrcPsQJDdcBqRcmMqGekSjTyRQaTIBZyhUH GetmHDVYmvDILHYmATBGtlpzrcPsQJDdcBqRcmMqGekSjTyRQaTIBZyhUH(){
        var clasx = new mHDVYmvDILHYmATBGtlpzrcPsQJDdcBqRcmMqGekSjTyRQaTIBZyhUH();
        return  clasx;
    }

    public string RandomStringmHDVYmvDILHYmATBGtlpzrcPsQJDdcBqRcmMqGekSjTyRQaTIBZyhUH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class YxcfvhboYyvZtlOfdjcCaQouybGPMoBhKBOMxwLUpzBaBnpQCG
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

        public YxcfvhboYyvZtlOfdjcCaQouybGPMoBhKBOMxwLUpzBaBnpQCG()
        {
            
        }
        public YxcfvhboYyvZtlOfdjcCaQouybGPMoBhKBOMxwLUpzBaBnpQCG(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public YxcfvhboYyvZtlOfdjcCaQouybGPMoBhKBOMxwLUpzBaBnpQCG(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public YxcfvhboYyvZtlOfdjcCaQouybGPMoBhKBOMxwLUpzBaBnpQCG GetYxcfvhboYyvZtlOfdjcCaQouybGPMoBhKBOMxwLUpzBaBnpQCG(){
        var clasx = new YxcfvhboYyvZtlOfdjcCaQouybGPMoBhKBOMxwLUpzBaBnpQCG();
        return  clasx;
    }

    public string RandomStringYxcfvhboYyvZtlOfdjcCaQouybGPMoBhKBOMxwLUpzBaBnpQCG(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class kxeDrcnbBNWCJZgAzpFqEoaOplRjUbxVoGZJQGSNFLDvDnTyE
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

        public kxeDrcnbBNWCJZgAzpFqEoaOplRjUbxVoGZJQGSNFLDvDnTyE()
        {
            
        }
        public kxeDrcnbBNWCJZgAzpFqEoaOplRjUbxVoGZJQGSNFLDvDnTyE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public kxeDrcnbBNWCJZgAzpFqEoaOplRjUbxVoGZJQGSNFLDvDnTyE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public kxeDrcnbBNWCJZgAzpFqEoaOplRjUbxVoGZJQGSNFLDvDnTyE GetkxeDrcnbBNWCJZgAzpFqEoaOplRjUbxVoGZJQGSNFLDvDnTyE(){
        var clasx = new kxeDrcnbBNWCJZgAzpFqEoaOplRjUbxVoGZJQGSNFLDvDnTyE();
        return  clasx;
    }

    public string RandomStringkxeDrcnbBNWCJZgAzpFqEoaOplRjUbxVoGZJQGSNFLDvDnTyE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class YFaPhzYffCOSxKnOEBRqIAIMrDOEvIXQsiDJNfrPtsNsubhxCPJnBwdYxO
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

        public YFaPhzYffCOSxKnOEBRqIAIMrDOEvIXQsiDJNfrPtsNsubhxCPJnBwdYxO()
        {
            
        }
        public YFaPhzYffCOSxKnOEBRqIAIMrDOEvIXQsiDJNfrPtsNsubhxCPJnBwdYxO(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public YFaPhzYffCOSxKnOEBRqIAIMrDOEvIXQsiDJNfrPtsNsubhxCPJnBwdYxO(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public YFaPhzYffCOSxKnOEBRqIAIMrDOEvIXQsiDJNfrPtsNsubhxCPJnBwdYxO GetYFaPhzYffCOSxKnOEBRqIAIMrDOEvIXQsiDJNfrPtsNsubhxCPJnBwdYxO(){
        var clasx = new YFaPhzYffCOSxKnOEBRqIAIMrDOEvIXQsiDJNfrPtsNsubhxCPJnBwdYxO();
        return  clasx;
    }

    public string RandomStringYFaPhzYffCOSxKnOEBRqIAIMrDOEvIXQsiDJNfrPtsNsubhxCPJnBwdYxO(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class XfIGVRbGtVoJKwylSEKhETulyuRlVAgbACKpQxKWJiaCcyoZdMUPoINE
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

        public XfIGVRbGtVoJKwylSEKhETulyuRlVAgbACKpQxKWJiaCcyoZdMUPoINE()
        {
            
        }
        public XfIGVRbGtVoJKwylSEKhETulyuRlVAgbACKpQxKWJiaCcyoZdMUPoINE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public XfIGVRbGtVoJKwylSEKhETulyuRlVAgbACKpQxKWJiaCcyoZdMUPoINE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public XfIGVRbGtVoJKwylSEKhETulyuRlVAgbACKpQxKWJiaCcyoZdMUPoINE GetXfIGVRbGtVoJKwylSEKhETulyuRlVAgbACKpQxKWJiaCcyoZdMUPoINE(){
        var clasx = new XfIGVRbGtVoJKwylSEKhETulyuRlVAgbACKpQxKWJiaCcyoZdMUPoINE();
        return  clasx;
    }

    public string RandomStringXfIGVRbGtVoJKwylSEKhETulyuRlVAgbACKpQxKWJiaCcyoZdMUPoINE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RUveSyQmIvIXSNMWIqQnxeggiAlxsqMYymSkzGnnSoLcsBGWuMCnlsSnn
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

        public RUveSyQmIvIXSNMWIqQnxeggiAlxsqMYymSkzGnnSoLcsBGWuMCnlsSnn()
        {
            
        }
        public RUveSyQmIvIXSNMWIqQnxeggiAlxsqMYymSkzGnnSoLcsBGWuMCnlsSnn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RUveSyQmIvIXSNMWIqQnxeggiAlxsqMYymSkzGnnSoLcsBGWuMCnlsSnn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RUveSyQmIvIXSNMWIqQnxeggiAlxsqMYymSkzGnnSoLcsBGWuMCnlsSnn GetRUveSyQmIvIXSNMWIqQnxeggiAlxsqMYymSkzGnnSoLcsBGWuMCnlsSnn(){
        var clasx = new RUveSyQmIvIXSNMWIqQnxeggiAlxsqMYymSkzGnnSoLcsBGWuMCnlsSnn();
        return  clasx;
    }

    public string RandomStringRUveSyQmIvIXSNMWIqQnxeggiAlxsqMYymSkzGnnSoLcsBGWuMCnlsSnn(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class sCYtEvTaWZvPYCKMmwRKFDwYTFkdwALzmdhjN
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

        public sCYtEvTaWZvPYCKMmwRKFDwYTFkdwALzmdhjN()
        {
            
        }
        public sCYtEvTaWZvPYCKMmwRKFDwYTFkdwALzmdhjN(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public sCYtEvTaWZvPYCKMmwRKFDwYTFkdwALzmdhjN(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public sCYtEvTaWZvPYCKMmwRKFDwYTFkdwALzmdhjN GetsCYtEvTaWZvPYCKMmwRKFDwYTFkdwALzmdhjN(){
        var clasx = new sCYtEvTaWZvPYCKMmwRKFDwYTFkdwALzmdhjN();
        return  clasx;
    }

    public string RandomStringsCYtEvTaWZvPYCKMmwRKFDwYTFkdwALzmdhjN(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class sFixByfiLidQsTIyybTMaaPEzyNULeJ
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

        public sFixByfiLidQsTIyybTMaaPEzyNULeJ()
        {
            
        }
        public sFixByfiLidQsTIyybTMaaPEzyNULeJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public sFixByfiLidQsTIyybTMaaPEzyNULeJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public sFixByfiLidQsTIyybTMaaPEzyNULeJ GetsFixByfiLidQsTIyybTMaaPEzyNULeJ(){
        var clasx = new sFixByfiLidQsTIyybTMaaPEzyNULeJ();
        return  clasx;
    }

    public string RandomStringsFixByfiLidQsTIyybTMaaPEzyNULeJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MLqQnQgYaITcBemuyqyXXXiqKPAocEmX
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

        public MLqQnQgYaITcBemuyqyXXXiqKPAocEmX()
        {
            
        }
        public MLqQnQgYaITcBemuyqyXXXiqKPAocEmX(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MLqQnQgYaITcBemuyqyXXXiqKPAocEmX(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MLqQnQgYaITcBemuyqyXXXiqKPAocEmX GetMLqQnQgYaITcBemuyqyXXXiqKPAocEmX(){
        var clasx = new MLqQnQgYaITcBemuyqyXXXiqKPAocEmX();
        return  clasx;
    }

    public string RandomStringMLqQnQgYaITcBemuyqyXXXiqKPAocEmX(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class fFgfyhWkczqeYJQcrLFvwyVAOWjROdQcG
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

        public fFgfyhWkczqeYJQcrLFvwyVAOWjROdQcG()
        {
            
        }
        public fFgfyhWkczqeYJQcrLFvwyVAOWjROdQcG(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public fFgfyhWkczqeYJQcrLFvwyVAOWjROdQcG(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public fFgfyhWkczqeYJQcrLFvwyVAOWjROdQcG GetfFgfyhWkczqeYJQcrLFvwyVAOWjROdQcG(){
        var clasx = new fFgfyhWkczqeYJQcrLFvwyVAOWjROdQcG();
        return  clasx;
    }

    public string RandomStringfFgfyhWkczqeYJQcrLFvwyVAOWjROdQcG(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class wRFuBVVQfuFdJOztryyfLQZUCGTarXezzNPHCihwHQevqnTjpZDxFHTfsl
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

        public wRFuBVVQfuFdJOztryyfLQZUCGTarXezzNPHCihwHQevqnTjpZDxFHTfsl()
        {
            
        }
        public wRFuBVVQfuFdJOztryyfLQZUCGTarXezzNPHCihwHQevqnTjpZDxFHTfsl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public wRFuBVVQfuFdJOztryyfLQZUCGTarXezzNPHCihwHQevqnTjpZDxFHTfsl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public wRFuBVVQfuFdJOztryyfLQZUCGTarXezzNPHCihwHQevqnTjpZDxFHTfsl GetwRFuBVVQfuFdJOztryyfLQZUCGTarXezzNPHCihwHQevqnTjpZDxFHTfsl(){
        var clasx = new wRFuBVVQfuFdJOztryyfLQZUCGTarXezzNPHCihwHQevqnTjpZDxFHTfsl();
        return  clasx;
    }

    public string RandomStringwRFuBVVQfuFdJOztryyfLQZUCGTarXezzNPHCihwHQevqnTjpZDxFHTfsl(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class TFOuOXBsIzUPmUolOnjcaIxEwGnwngyEkjuToXYDNtnHlvcb
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

        public TFOuOXBsIzUPmUolOnjcaIxEwGnwngyEkjuToXYDNtnHlvcb()
        {
            
        }
        public TFOuOXBsIzUPmUolOnjcaIxEwGnwngyEkjuToXYDNtnHlvcb(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public TFOuOXBsIzUPmUolOnjcaIxEwGnwngyEkjuToXYDNtnHlvcb(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public TFOuOXBsIzUPmUolOnjcaIxEwGnwngyEkjuToXYDNtnHlvcb GetTFOuOXBsIzUPmUolOnjcaIxEwGnwngyEkjuToXYDNtnHlvcb(){
        var clasx = new TFOuOXBsIzUPmUolOnjcaIxEwGnwngyEkjuToXYDNtnHlvcb();
        return  clasx;
    }

    public string RandomStringTFOuOXBsIzUPmUolOnjcaIxEwGnwngyEkjuToXYDNtnHlvcb(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class XSUaWorYvaIywLJXbGRgnwIFgnJNlqVWJ
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

        public XSUaWorYvaIywLJXbGRgnwIFgnJNlqVWJ()
        {
            
        }
        public XSUaWorYvaIywLJXbGRgnwIFgnJNlqVWJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public XSUaWorYvaIywLJXbGRgnwIFgnJNlqVWJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public XSUaWorYvaIywLJXbGRgnwIFgnJNlqVWJ GetXSUaWorYvaIywLJXbGRgnwIFgnJNlqVWJ(){
        var clasx = new XSUaWorYvaIywLJXbGRgnwIFgnJNlqVWJ();
        return  clasx;
    }

    public string RandomStringXSUaWorYvaIywLJXbGRgnwIFgnJNlqVWJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GxlUHdZUjSaCMzCUrSafuFoFbNCFXUWsWsjAsRSehoedzBeCyGNviGqAJgstbTwP
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

        public GxlUHdZUjSaCMzCUrSafuFoFbNCFXUWsWsjAsRSehoedzBeCyGNviGqAJgstbTwP()
        {
            
        }
        public GxlUHdZUjSaCMzCUrSafuFoFbNCFXUWsWsjAsRSehoedzBeCyGNviGqAJgstbTwP(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GxlUHdZUjSaCMzCUrSafuFoFbNCFXUWsWsjAsRSehoedzBeCyGNviGqAJgstbTwP(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GxlUHdZUjSaCMzCUrSafuFoFbNCFXUWsWsjAsRSehoedzBeCyGNviGqAJgstbTwP GetGxlUHdZUjSaCMzCUrSafuFoFbNCFXUWsWsjAsRSehoedzBeCyGNviGqAJgstbTwP(){
        var clasx = new GxlUHdZUjSaCMzCUrSafuFoFbNCFXUWsWsjAsRSehoedzBeCyGNviGqAJgstbTwP();
        return  clasx;
    }

    public string RandomStringGxlUHdZUjSaCMzCUrSafuFoFbNCFXUWsWsjAsRSehoedzBeCyGNviGqAJgstbTwP(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class IKhXYgkKXcvvXGRhCbkYmytnmgeTEfYBwTfQdMOyXEdzTY
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

        public IKhXYgkKXcvvXGRhCbkYmytnmgeTEfYBwTfQdMOyXEdzTY()
        {
            
        }
        public IKhXYgkKXcvvXGRhCbkYmytnmgeTEfYBwTfQdMOyXEdzTY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public IKhXYgkKXcvvXGRhCbkYmytnmgeTEfYBwTfQdMOyXEdzTY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public IKhXYgkKXcvvXGRhCbkYmytnmgeTEfYBwTfQdMOyXEdzTY GetIKhXYgkKXcvvXGRhCbkYmytnmgeTEfYBwTfQdMOyXEdzTY(){
        var clasx = new IKhXYgkKXcvvXGRhCbkYmytnmgeTEfYBwTfQdMOyXEdzTY();
        return  clasx;
    }

    public string RandomStringIKhXYgkKXcvvXGRhCbkYmytnmgeTEfYBwTfQdMOyXEdzTY(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class EHMIaUxrIiZTuTWbCglmHDSdYmbQKuOyiOlEkVujzFaBwCSA
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

        public EHMIaUxrIiZTuTWbCglmHDSdYmbQKuOyiOlEkVujzFaBwCSA()
        {
            
        }
        public EHMIaUxrIiZTuTWbCglmHDSdYmbQKuOyiOlEkVujzFaBwCSA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public EHMIaUxrIiZTuTWbCglmHDSdYmbQKuOyiOlEkVujzFaBwCSA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public EHMIaUxrIiZTuTWbCglmHDSdYmbQKuOyiOlEkVujzFaBwCSA GetEHMIaUxrIiZTuTWbCglmHDSdYmbQKuOyiOlEkVujzFaBwCSA(){
        var clasx = new EHMIaUxrIiZTuTWbCglmHDSdYmbQKuOyiOlEkVujzFaBwCSA();
        return  clasx;
    }

    public string RandomStringEHMIaUxrIiZTuTWbCglmHDSdYmbQKuOyiOlEkVujzFaBwCSA(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class IYZTVWetYcdeKVfdPADWslMWwSZPheygipOEmcKESNcExeDvvFnV
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

        public IYZTVWetYcdeKVfdPADWslMWwSZPheygipOEmcKESNcExeDvvFnV()
        {
            
        }
        public IYZTVWetYcdeKVfdPADWslMWwSZPheygipOEmcKESNcExeDvvFnV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public IYZTVWetYcdeKVfdPADWslMWwSZPheygipOEmcKESNcExeDvvFnV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public IYZTVWetYcdeKVfdPADWslMWwSZPheygipOEmcKESNcExeDvvFnV GetIYZTVWetYcdeKVfdPADWslMWwSZPheygipOEmcKESNcExeDvvFnV(){
        var clasx = new IYZTVWetYcdeKVfdPADWslMWwSZPheygipOEmcKESNcExeDvvFnV();
        return  clasx;
    }

    public string RandomStringIYZTVWetYcdeKVfdPADWslMWwSZPheygipOEmcKESNcExeDvvFnV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class EzENTNaKSeGLFrfKHbzXpSpSWvuCzItgpydakRRuRDYLNyyE
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

        public EzENTNaKSeGLFrfKHbzXpSpSWvuCzItgpydakRRuRDYLNyyE()
        {
            
        }
        public EzENTNaKSeGLFrfKHbzXpSpSWvuCzItgpydakRRuRDYLNyyE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public EzENTNaKSeGLFrfKHbzXpSpSWvuCzItgpydakRRuRDYLNyyE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public EzENTNaKSeGLFrfKHbzXpSpSWvuCzItgpydakRRuRDYLNyyE GetEzENTNaKSeGLFrfKHbzXpSpSWvuCzItgpydakRRuRDYLNyyE(){
        var clasx = new EzENTNaKSeGLFrfKHbzXpSpSWvuCzItgpydakRRuRDYLNyyE();
        return  clasx;
    }

    public string RandomStringEzENTNaKSeGLFrfKHbzXpSpSWvuCzItgpydakRRuRDYLNyyE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class BAbfVgmVUZPfDVpfjVLBoHCUthPyAZETHNEWm
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

        public BAbfVgmVUZPfDVpfjVLBoHCUthPyAZETHNEWm()
        {
            
        }
        public BAbfVgmVUZPfDVpfjVLBoHCUthPyAZETHNEWm(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public BAbfVgmVUZPfDVpfjVLBoHCUthPyAZETHNEWm(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public BAbfVgmVUZPfDVpfjVLBoHCUthPyAZETHNEWm GetBAbfVgmVUZPfDVpfjVLBoHCUthPyAZETHNEWm(){
        var clasx = new BAbfVgmVUZPfDVpfjVLBoHCUthPyAZETHNEWm();
        return  clasx;
    }

    public string RandomStringBAbfVgmVUZPfDVpfjVLBoHCUthPyAZETHNEWm(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GUcmYDZztJIwnAfklaPzpiMyLNEDZJ
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

        public GUcmYDZztJIwnAfklaPzpiMyLNEDZJ()
        {
            
        }
        public GUcmYDZztJIwnAfklaPzpiMyLNEDZJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GUcmYDZztJIwnAfklaPzpiMyLNEDZJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GUcmYDZztJIwnAfklaPzpiMyLNEDZJ GetGUcmYDZztJIwnAfklaPzpiMyLNEDZJ(){
        var clasx = new GUcmYDZztJIwnAfklaPzpiMyLNEDZJ();
        return  clasx;
    }

    public string RandomStringGUcmYDZztJIwnAfklaPzpiMyLNEDZJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class gOOBGPTkbNNQIBjquJKFkNMYqopbxBshprZKswIAIyHbcZSvqEFdVOlT
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

        public gOOBGPTkbNNQIBjquJKFkNMYqopbxBshprZKswIAIyHbcZSvqEFdVOlT()
        {
            
        }
        public gOOBGPTkbNNQIBjquJKFkNMYqopbxBshprZKswIAIyHbcZSvqEFdVOlT(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public gOOBGPTkbNNQIBjquJKFkNMYqopbxBshprZKswIAIyHbcZSvqEFdVOlT(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public gOOBGPTkbNNQIBjquJKFkNMYqopbxBshprZKswIAIyHbcZSvqEFdVOlT GetgOOBGPTkbNNQIBjquJKFkNMYqopbxBshprZKswIAIyHbcZSvqEFdVOlT(){
        var clasx = new gOOBGPTkbNNQIBjquJKFkNMYqopbxBshprZKswIAIyHbcZSvqEFdVOlT();
        return  clasx;
    }

    public string RandomStringgOOBGPTkbNNQIBjquJKFkNMYqopbxBshprZKswIAIyHbcZSvqEFdVOlT(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class BvqtEjkAnezlHRBMbGkkiMAuVWIwwpLiq
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

        public BvqtEjkAnezlHRBMbGkkiMAuVWIwwpLiq()
        {
            
        }
        public BvqtEjkAnezlHRBMbGkkiMAuVWIwwpLiq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public BvqtEjkAnezlHRBMbGkkiMAuVWIwwpLiq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public BvqtEjkAnezlHRBMbGkkiMAuVWIwwpLiq GetBvqtEjkAnezlHRBMbGkkiMAuVWIwwpLiq(){
        var clasx = new BvqtEjkAnezlHRBMbGkkiMAuVWIwwpLiq();
        return  clasx;
    }

    public string RandomStringBvqtEjkAnezlHRBMbGkkiMAuVWIwwpLiq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class buCVDUMoztkCprnOnJHUlRcfhIcASzes
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

        public buCVDUMoztkCprnOnJHUlRcfhIcASzes()
        {
            
        }
        public buCVDUMoztkCprnOnJHUlRcfhIcASzes(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public buCVDUMoztkCprnOnJHUlRcfhIcASzes(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public buCVDUMoztkCprnOnJHUlRcfhIcASzes GetbuCVDUMoztkCprnOnJHUlRcfhIcASzes(){
        var clasx = new buCVDUMoztkCprnOnJHUlRcfhIcASzes();
        return  clasx;
    }

    public string RandomStringbuCVDUMoztkCprnOnJHUlRcfhIcASzes(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class XZnElVawWjObqxvTGvOVwrqgVHSzerDYZiiRzncIcJyCwRlkWUAqlqtfjHje
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

        public XZnElVawWjObqxvTGvOVwrqgVHSzerDYZiiRzncIcJyCwRlkWUAqlqtfjHje()
        {
            
        }
        public XZnElVawWjObqxvTGvOVwrqgVHSzerDYZiiRzncIcJyCwRlkWUAqlqtfjHje(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public XZnElVawWjObqxvTGvOVwrqgVHSzerDYZiiRzncIcJyCwRlkWUAqlqtfjHje(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public XZnElVawWjObqxvTGvOVwrqgVHSzerDYZiiRzncIcJyCwRlkWUAqlqtfjHje GetXZnElVawWjObqxvTGvOVwrqgVHSzerDYZiiRzncIcJyCwRlkWUAqlqtfjHje(){
        var clasx = new XZnElVawWjObqxvTGvOVwrqgVHSzerDYZiiRzncIcJyCwRlkWUAqlqtfjHje();
        return  clasx;
    }

    public string RandomStringXZnElVawWjObqxvTGvOVwrqgVHSzerDYZiiRzncIcJyCwRlkWUAqlqtfjHje(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class QFLqmwzbJmBnwanoQrWVkpIzskerxTJgMFzylJPeVSYnULNolTpuFrRaw
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

        public QFLqmwzbJmBnwanoQrWVkpIzskerxTJgMFzylJPeVSYnULNolTpuFrRaw()
        {
            
        }
        public QFLqmwzbJmBnwanoQrWVkpIzskerxTJgMFzylJPeVSYnULNolTpuFrRaw(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QFLqmwzbJmBnwanoQrWVkpIzskerxTJgMFzylJPeVSYnULNolTpuFrRaw(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QFLqmwzbJmBnwanoQrWVkpIzskerxTJgMFzylJPeVSYnULNolTpuFrRaw GetQFLqmwzbJmBnwanoQrWVkpIzskerxTJgMFzylJPeVSYnULNolTpuFrRaw(){
        var clasx = new QFLqmwzbJmBnwanoQrWVkpIzskerxTJgMFzylJPeVSYnULNolTpuFrRaw();
        return  clasx;
    }

    public string RandomStringQFLqmwzbJmBnwanoQrWVkpIzskerxTJgMFzylJPeVSYnULNolTpuFrRaw(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ZzuykpEGQRdALNpLPNYDvYmRbRYlUoBjGhvCCsYdttBqAbxmzyL
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

        public ZzuykpEGQRdALNpLPNYDvYmRbRYlUoBjGhvCCsYdttBqAbxmzyL()
        {
            
        }
        public ZzuykpEGQRdALNpLPNYDvYmRbRYlUoBjGhvCCsYdttBqAbxmzyL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ZzuykpEGQRdALNpLPNYDvYmRbRYlUoBjGhvCCsYdttBqAbxmzyL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ZzuykpEGQRdALNpLPNYDvYmRbRYlUoBjGhvCCsYdttBqAbxmzyL GetZzuykpEGQRdALNpLPNYDvYmRbRYlUoBjGhvCCsYdttBqAbxmzyL(){
        var clasx = new ZzuykpEGQRdALNpLPNYDvYmRbRYlUoBjGhvCCsYdttBqAbxmzyL();
        return  clasx;
    }

    public string RandomStringZzuykpEGQRdALNpLPNYDvYmRbRYlUoBjGhvCCsYdttBqAbxmzyL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CLDtcOzjUlErNXuPWceToaCzwZVFnHeYHJIhvDXKKlR
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

        public CLDtcOzjUlErNXuPWceToaCzwZVFnHeYHJIhvDXKKlR()
        {
            
        }
        public CLDtcOzjUlErNXuPWceToaCzwZVFnHeYHJIhvDXKKlR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CLDtcOzjUlErNXuPWceToaCzwZVFnHeYHJIhvDXKKlR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CLDtcOzjUlErNXuPWceToaCzwZVFnHeYHJIhvDXKKlR GetCLDtcOzjUlErNXuPWceToaCzwZVFnHeYHJIhvDXKKlR(){
        var clasx = new CLDtcOzjUlErNXuPWceToaCzwZVFnHeYHJIhvDXKKlR();
        return  clasx;
    }

    public string RandomStringCLDtcOzjUlErNXuPWceToaCzwZVFnHeYHJIhvDXKKlR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class kmCpdHBVuUzbXGlPuoOxplxlHFjyQWkRrggTmCpxnwTfYKh
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

        public kmCpdHBVuUzbXGlPuoOxplxlHFjyQWkRrggTmCpxnwTfYKh()
        {
            
        }
        public kmCpdHBVuUzbXGlPuoOxplxlHFjyQWkRrggTmCpxnwTfYKh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public kmCpdHBVuUzbXGlPuoOxplxlHFjyQWkRrggTmCpxnwTfYKh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public kmCpdHBVuUzbXGlPuoOxplxlHFjyQWkRrggTmCpxnwTfYKh GetkmCpdHBVuUzbXGlPuoOxplxlHFjyQWkRrggTmCpxnwTfYKh(){
        var clasx = new kmCpdHBVuUzbXGlPuoOxplxlHFjyQWkRrggTmCpxnwTfYKh();
        return  clasx;
    }

    public string RandomStringkmCpdHBVuUzbXGlPuoOxplxlHFjyQWkRrggTmCpxnwTfYKh(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RkFDbcqSegnloUcdvteKzgWPDWNngcdhcItgeR
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

        public RkFDbcqSegnloUcdvteKzgWPDWNngcdhcItgeR()
        {
            
        }
        public RkFDbcqSegnloUcdvteKzgWPDWNngcdhcItgeR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RkFDbcqSegnloUcdvteKzgWPDWNngcdhcItgeR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RkFDbcqSegnloUcdvteKzgWPDWNngcdhcItgeR GetRkFDbcqSegnloUcdvteKzgWPDWNngcdhcItgeR(){
        var clasx = new RkFDbcqSegnloUcdvteKzgWPDWNngcdhcItgeR();
        return  clasx;
    }

    public string RandomStringRkFDbcqSegnloUcdvteKzgWPDWNngcdhcItgeR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ciDaifMEDeFMGefAstAoZNzqfXCADCWmZAkr
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

        public ciDaifMEDeFMGefAstAoZNzqfXCADCWmZAkr()
        {
            
        }
        public ciDaifMEDeFMGefAstAoZNzqfXCADCWmZAkr(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ciDaifMEDeFMGefAstAoZNzqfXCADCWmZAkr(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ciDaifMEDeFMGefAstAoZNzqfXCADCWmZAkr GetciDaifMEDeFMGefAstAoZNzqfXCADCWmZAkr(){
        var clasx = new ciDaifMEDeFMGefAstAoZNzqfXCADCWmZAkr();
        return  clasx;
    }

    public string RandomStringciDaifMEDeFMGefAstAoZNzqfXCADCWmZAkr(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class XyHWZZLSAdkPMBLPHyODdiFsLYnMKzsBVkOvOotTn
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

        public XyHWZZLSAdkPMBLPHyODdiFsLYnMKzsBVkOvOotTn()
        {
            
        }
        public XyHWZZLSAdkPMBLPHyODdiFsLYnMKzsBVkOvOotTn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public XyHWZZLSAdkPMBLPHyODdiFsLYnMKzsBVkOvOotTn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public XyHWZZLSAdkPMBLPHyODdiFsLYnMKzsBVkOvOotTn GetXyHWZZLSAdkPMBLPHyODdiFsLYnMKzsBVkOvOotTn(){
        var clasx = new XyHWZZLSAdkPMBLPHyODdiFsLYnMKzsBVkOvOotTn();
        return  clasx;
    }

    public string RandomStringXyHWZZLSAdkPMBLPHyODdiFsLYnMKzsBVkOvOotTn(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class bczgSWDdQoZcdJTiLbRfQCDeOxkoIz
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

        public bczgSWDdQoZcdJTiLbRfQCDeOxkoIz()
        {
            
        }
        public bczgSWDdQoZcdJTiLbRfQCDeOxkoIz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bczgSWDdQoZcdJTiLbRfQCDeOxkoIz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bczgSWDdQoZcdJTiLbRfQCDeOxkoIz GetbczgSWDdQoZcdJTiLbRfQCDeOxkoIz(){
        var clasx = new bczgSWDdQoZcdJTiLbRfQCDeOxkoIz();
        return  clasx;
    }

    public string RandomStringbczgSWDdQoZcdJTiLbRfQCDeOxkoIz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class OFYefyUHuJmKmzcuGsnpIsllJKpnegBY
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

        public OFYefyUHuJmKmzcuGsnpIsllJKpnegBY()
        {
            
        }
        public OFYefyUHuJmKmzcuGsnpIsllJKpnegBY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OFYefyUHuJmKmzcuGsnpIsllJKpnegBY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OFYefyUHuJmKmzcuGsnpIsllJKpnegBY GetOFYefyUHuJmKmzcuGsnpIsllJKpnegBY(){
        var clasx = new OFYefyUHuJmKmzcuGsnpIsllJKpnegBY();
        return  clasx;
    }

    public string RandomStringOFYefyUHuJmKmzcuGsnpIsllJKpnegBY(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class VSKcEWMvMIgQtTjexGBWOxzxcTuNvyxGMAnUIRRcczQDwNBjJsexSWnXSMAkcyzOK
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

        public VSKcEWMvMIgQtTjexGBWOxzxcTuNvyxGMAnUIRRcczQDwNBjJsexSWnXSMAkcyzOK()
        {
            
        }
        public VSKcEWMvMIgQtTjexGBWOxzxcTuNvyxGMAnUIRRcczQDwNBjJsexSWnXSMAkcyzOK(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VSKcEWMvMIgQtTjexGBWOxzxcTuNvyxGMAnUIRRcczQDwNBjJsexSWnXSMAkcyzOK(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VSKcEWMvMIgQtTjexGBWOxzxcTuNvyxGMAnUIRRcczQDwNBjJsexSWnXSMAkcyzOK GetVSKcEWMvMIgQtTjexGBWOxzxcTuNvyxGMAnUIRRcczQDwNBjJsexSWnXSMAkcyzOK(){
        var clasx = new VSKcEWMvMIgQtTjexGBWOxzxcTuNvyxGMAnUIRRcczQDwNBjJsexSWnXSMAkcyzOK();
        return  clasx;
    }

    public string RandomStringVSKcEWMvMIgQtTjexGBWOxzxcTuNvyxGMAnUIRRcczQDwNBjJsexSWnXSMAkcyzOK(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class AKOOjmYZtoRuLWaBXfUhEHWFdZDnBhNVcEFqEbtKInszHJcejGpglZrsoIlKjkYMbwSGQ
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

        public AKOOjmYZtoRuLWaBXfUhEHWFdZDnBhNVcEFqEbtKInszHJcejGpglZrsoIlKjkYMbwSGQ()
        {
            
        }
        public AKOOjmYZtoRuLWaBXfUhEHWFdZDnBhNVcEFqEbtKInszHJcejGpglZrsoIlKjkYMbwSGQ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public AKOOjmYZtoRuLWaBXfUhEHWFdZDnBhNVcEFqEbtKInszHJcejGpglZrsoIlKjkYMbwSGQ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public AKOOjmYZtoRuLWaBXfUhEHWFdZDnBhNVcEFqEbtKInszHJcejGpglZrsoIlKjkYMbwSGQ GetAKOOjmYZtoRuLWaBXfUhEHWFdZDnBhNVcEFqEbtKInszHJcejGpglZrsoIlKjkYMbwSGQ(){
        var clasx = new AKOOjmYZtoRuLWaBXfUhEHWFdZDnBhNVcEFqEbtKInszHJcejGpglZrsoIlKjkYMbwSGQ();
        return  clasx;
    }

    public string RandomStringAKOOjmYZtoRuLWaBXfUhEHWFdZDnBhNVcEFqEbtKInszHJcejGpglZrsoIlKjkYMbwSGQ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class llSWEmwWeXsYJFTKPbAdAnZhIDjEEYAALcYHfjHdmhOTEDZajxzbJmFyLlNADsSGXs
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

        public llSWEmwWeXsYJFTKPbAdAnZhIDjEEYAALcYHfjHdmhOTEDZajxzbJmFyLlNADsSGXs()
        {
            
        }
        public llSWEmwWeXsYJFTKPbAdAnZhIDjEEYAALcYHfjHdmhOTEDZajxzbJmFyLlNADsSGXs(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public llSWEmwWeXsYJFTKPbAdAnZhIDjEEYAALcYHfjHdmhOTEDZajxzbJmFyLlNADsSGXs(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public llSWEmwWeXsYJFTKPbAdAnZhIDjEEYAALcYHfjHdmhOTEDZajxzbJmFyLlNADsSGXs GetllSWEmwWeXsYJFTKPbAdAnZhIDjEEYAALcYHfjHdmhOTEDZajxzbJmFyLlNADsSGXs(){
        var clasx = new llSWEmwWeXsYJFTKPbAdAnZhIDjEEYAALcYHfjHdmhOTEDZajxzbJmFyLlNADsSGXs();
        return  clasx;
    }

    public string RandomStringllSWEmwWeXsYJFTKPbAdAnZhIDjEEYAALcYHfjHdmhOTEDZajxzbJmFyLlNADsSGXs(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class uuXMLeYhkCQgBijjRTmhuilKcBfuszCxwIJQIxbdlURMmUbJimp
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

        public uuXMLeYhkCQgBijjRTmhuilKcBfuszCxwIJQIxbdlURMmUbJimp()
        {
            
        }
        public uuXMLeYhkCQgBijjRTmhuilKcBfuszCxwIJQIxbdlURMmUbJimp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public uuXMLeYhkCQgBijjRTmhuilKcBfuszCxwIJQIxbdlURMmUbJimp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public uuXMLeYhkCQgBijjRTmhuilKcBfuszCxwIJQIxbdlURMmUbJimp GetuuXMLeYhkCQgBijjRTmhuilKcBfuszCxwIJQIxbdlURMmUbJimp(){
        var clasx = new uuXMLeYhkCQgBijjRTmhuilKcBfuszCxwIJQIxbdlURMmUbJimp();
        return  clasx;
    }

    public string RandomStringuuXMLeYhkCQgBijjRTmhuilKcBfuszCxwIJQIxbdlURMmUbJimp(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PnKbwrzjcpDnXZRApPIlFKSBqixaACVqa
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

        public PnKbwrzjcpDnXZRApPIlFKSBqixaACVqa()
        {
            
        }
        public PnKbwrzjcpDnXZRApPIlFKSBqixaACVqa(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PnKbwrzjcpDnXZRApPIlFKSBqixaACVqa(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PnKbwrzjcpDnXZRApPIlFKSBqixaACVqa GetPnKbwrzjcpDnXZRApPIlFKSBqixaACVqa(){
        var clasx = new PnKbwrzjcpDnXZRApPIlFKSBqixaACVqa();
        return  clasx;
    }

    public string RandomStringPnKbwrzjcpDnXZRApPIlFKSBqixaACVqa(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CqWDjvlhjatDHEJpIyBYeDwiDjQMeXslxTLemnwCtGCryOdTnekUUKzyt
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

        public CqWDjvlhjatDHEJpIyBYeDwiDjQMeXslxTLemnwCtGCryOdTnekUUKzyt()
        {
            
        }
        public CqWDjvlhjatDHEJpIyBYeDwiDjQMeXslxTLemnwCtGCryOdTnekUUKzyt(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CqWDjvlhjatDHEJpIyBYeDwiDjQMeXslxTLemnwCtGCryOdTnekUUKzyt(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CqWDjvlhjatDHEJpIyBYeDwiDjQMeXslxTLemnwCtGCryOdTnekUUKzyt GetCqWDjvlhjatDHEJpIyBYeDwiDjQMeXslxTLemnwCtGCryOdTnekUUKzyt(){
        var clasx = new CqWDjvlhjatDHEJpIyBYeDwiDjQMeXslxTLemnwCtGCryOdTnekUUKzyt();
        return  clasx;
    }

    public string RandomStringCqWDjvlhjatDHEJpIyBYeDwiDjQMeXslxTLemnwCtGCryOdTnekUUKzyt(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class iWziUmaEVgxyecRFUrPLqWWAIcSPghqnjZDURSfdCZjMLSPnAOBKRl
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

        public iWziUmaEVgxyecRFUrPLqWWAIcSPghqnjZDURSfdCZjMLSPnAOBKRl()
        {
            
        }
        public iWziUmaEVgxyecRFUrPLqWWAIcSPghqnjZDURSfdCZjMLSPnAOBKRl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public iWziUmaEVgxyecRFUrPLqWWAIcSPghqnjZDURSfdCZjMLSPnAOBKRl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public iWziUmaEVgxyecRFUrPLqWWAIcSPghqnjZDURSfdCZjMLSPnAOBKRl GetiWziUmaEVgxyecRFUrPLqWWAIcSPghqnjZDURSfdCZjMLSPnAOBKRl(){
        var clasx = new iWziUmaEVgxyecRFUrPLqWWAIcSPghqnjZDURSfdCZjMLSPnAOBKRl();
        return  clasx;
    }

    public string RandomStringiWziUmaEVgxyecRFUrPLqWWAIcSPghqnjZDURSfdCZjMLSPnAOBKRl(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class VFOavbxZPrpFQwuOMaYvdnpSJgoDCSilWUnXTEmlmCfjCObtfaaxfjmhPvQPmtXwIDiwI
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

        public VFOavbxZPrpFQwuOMaYvdnpSJgoDCSilWUnXTEmlmCfjCObtfaaxfjmhPvQPmtXwIDiwI()
        {
            
        }
        public VFOavbxZPrpFQwuOMaYvdnpSJgoDCSilWUnXTEmlmCfjCObtfaaxfjmhPvQPmtXwIDiwI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VFOavbxZPrpFQwuOMaYvdnpSJgoDCSilWUnXTEmlmCfjCObtfaaxfjmhPvQPmtXwIDiwI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VFOavbxZPrpFQwuOMaYvdnpSJgoDCSilWUnXTEmlmCfjCObtfaaxfjmhPvQPmtXwIDiwI GetVFOavbxZPrpFQwuOMaYvdnpSJgoDCSilWUnXTEmlmCfjCObtfaaxfjmhPvQPmtXwIDiwI(){
        var clasx = new VFOavbxZPrpFQwuOMaYvdnpSJgoDCSilWUnXTEmlmCfjCObtfaaxfjmhPvQPmtXwIDiwI();
        return  clasx;
    }

    public string RandomStringVFOavbxZPrpFQwuOMaYvdnpSJgoDCSilWUnXTEmlmCfjCObtfaaxfjmhPvQPmtXwIDiwI(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class icAdnShcHfJiqqxQKBaPgMPGCnOYeHgYQaIWDBGdlTv
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

        public icAdnShcHfJiqqxQKBaPgMPGCnOYeHgYQaIWDBGdlTv()
        {
            
        }
        public icAdnShcHfJiqqxQKBaPgMPGCnOYeHgYQaIWDBGdlTv(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public icAdnShcHfJiqqxQKBaPgMPGCnOYeHgYQaIWDBGdlTv(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public icAdnShcHfJiqqxQKBaPgMPGCnOYeHgYQaIWDBGdlTv GeticAdnShcHfJiqqxQKBaPgMPGCnOYeHgYQaIWDBGdlTv(){
        var clasx = new icAdnShcHfJiqqxQKBaPgMPGCnOYeHgYQaIWDBGdlTv();
        return  clasx;
    }

    public string RandomStringicAdnShcHfJiqqxQKBaPgMPGCnOYeHgYQaIWDBGdlTv(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class KTLQSmeczkMAXavCNiwOLmiItgpHQEsMbXyyHoeqPwjuqNJJguSSxB
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

        public KTLQSmeczkMAXavCNiwOLmiItgpHQEsMbXyyHoeqPwjuqNJJguSSxB()
        {
            
        }
        public KTLQSmeczkMAXavCNiwOLmiItgpHQEsMbXyyHoeqPwjuqNJJguSSxB(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public KTLQSmeczkMAXavCNiwOLmiItgpHQEsMbXyyHoeqPwjuqNJJguSSxB(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public KTLQSmeczkMAXavCNiwOLmiItgpHQEsMbXyyHoeqPwjuqNJJguSSxB GetKTLQSmeczkMAXavCNiwOLmiItgpHQEsMbXyyHoeqPwjuqNJJguSSxB(){
        var clasx = new KTLQSmeczkMAXavCNiwOLmiItgpHQEsMbXyyHoeqPwjuqNJJguSSxB();
        return  clasx;
    }

    public string RandomStringKTLQSmeczkMAXavCNiwOLmiItgpHQEsMbXyyHoeqPwjuqNJJguSSxB(int length)
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

        public class GkXZSPxeJgSneOqtodOzenjvnADJXboqivXSshrYCCCZHRNliGiEePsSBcmSLnHisc
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

        public GkXZSPxeJgSneOqtodOzenjvnADJXboqivXSshrYCCCZHRNliGiEePsSBcmSLnHisc()
        {
            
        }
        public GkXZSPxeJgSneOqtodOzenjvnADJXboqivXSshrYCCCZHRNliGiEePsSBcmSLnHisc(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GkXZSPxeJgSneOqtodOzenjvnADJXboqivXSshrYCCCZHRNliGiEePsSBcmSLnHisc(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GkXZSPxeJgSneOqtodOzenjvnADJXboqivXSshrYCCCZHRNliGiEePsSBcmSLnHisc GetGkXZSPxeJgSneOqtodOzenjvnADJXboqivXSshrYCCCZHRNliGiEePsSBcmSLnHisc(){
        var clasx = new GkXZSPxeJgSneOqtodOzenjvnADJXboqivXSshrYCCCZHRNliGiEePsSBcmSLnHisc();
        return  clasx;
    }

    public string RandomStringGkXZSPxeJgSneOqtodOzenjvnADJXboqivXSshrYCCCZHRNliGiEePsSBcmSLnHisc(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class bZnGxuiCXkZfqIefUQJBgPXJYbIRevFIedqfEPg
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

        public bZnGxuiCXkZfqIefUQJBgPXJYbIRevFIedqfEPg()
        {
            
        }
        public bZnGxuiCXkZfqIefUQJBgPXJYbIRevFIedqfEPg(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bZnGxuiCXkZfqIefUQJBgPXJYbIRevFIedqfEPg(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bZnGxuiCXkZfqIefUQJBgPXJYbIRevFIedqfEPg GetbZnGxuiCXkZfqIefUQJBgPXJYbIRevFIedqfEPg(){
        var clasx = new bZnGxuiCXkZfqIefUQJBgPXJYbIRevFIedqfEPg();
        return  clasx;
    }

    public string RandomStringbZnGxuiCXkZfqIefUQJBgPXJYbIRevFIedqfEPg(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class nyqhmbLDywDfdcSbkIyAmpYZUtxgZiROuBlOxSyPBEpGVob
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

        public nyqhmbLDywDfdcSbkIyAmpYZUtxgZiROuBlOxSyPBEpGVob()
        {
            
        }
        public nyqhmbLDywDfdcSbkIyAmpYZUtxgZiROuBlOxSyPBEpGVob(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public nyqhmbLDywDfdcSbkIyAmpYZUtxgZiROuBlOxSyPBEpGVob(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public nyqhmbLDywDfdcSbkIyAmpYZUtxgZiROuBlOxSyPBEpGVob GetnyqhmbLDywDfdcSbkIyAmpYZUtxgZiROuBlOxSyPBEpGVob(){
        var clasx = new nyqhmbLDywDfdcSbkIyAmpYZUtxgZiROuBlOxSyPBEpGVob();
        return  clasx;
    }

    public string RandomStringnyqhmbLDywDfdcSbkIyAmpYZUtxgZiROuBlOxSyPBEpGVob(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class cpARSztyByNzDAlWvIdSTbaeZIPqNyoPwHsRhgvhMVuZUxJBqXMjRr
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

        public cpARSztyByNzDAlWvIdSTbaeZIPqNyoPwHsRhgvhMVuZUxJBqXMjRr()
        {
            
        }
        public cpARSztyByNzDAlWvIdSTbaeZIPqNyoPwHsRhgvhMVuZUxJBqXMjRr(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public cpARSztyByNzDAlWvIdSTbaeZIPqNyoPwHsRhgvhMVuZUxJBqXMjRr(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public cpARSztyByNzDAlWvIdSTbaeZIPqNyoPwHsRhgvhMVuZUxJBqXMjRr GetcpARSztyByNzDAlWvIdSTbaeZIPqNyoPwHsRhgvhMVuZUxJBqXMjRr(){
        var clasx = new cpARSztyByNzDAlWvIdSTbaeZIPqNyoPwHsRhgvhMVuZUxJBqXMjRr();
        return  clasx;
    }

    public string RandomStringcpARSztyByNzDAlWvIdSTbaeZIPqNyoPwHsRhgvhMVuZUxJBqXMjRr(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CcSgfEPFNMlJztUeyliokQwTedJuiBGzcIBQjbYHizCbKsPnZsRZOzdlfyCCuUXLGmgr
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

        public CcSgfEPFNMlJztUeyliokQwTedJuiBGzcIBQjbYHizCbKsPnZsRZOzdlfyCCuUXLGmgr()
        {
            
        }
        public CcSgfEPFNMlJztUeyliokQwTedJuiBGzcIBQjbYHizCbKsPnZsRZOzdlfyCCuUXLGmgr(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CcSgfEPFNMlJztUeyliokQwTedJuiBGzcIBQjbYHizCbKsPnZsRZOzdlfyCCuUXLGmgr(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CcSgfEPFNMlJztUeyliokQwTedJuiBGzcIBQjbYHizCbKsPnZsRZOzdlfyCCuUXLGmgr GetCcSgfEPFNMlJztUeyliokQwTedJuiBGzcIBQjbYHizCbKsPnZsRZOzdlfyCCuUXLGmgr(){
        var clasx = new CcSgfEPFNMlJztUeyliokQwTedJuiBGzcIBQjbYHizCbKsPnZsRZOzdlfyCCuUXLGmgr();
        return  clasx;
    }

    public string RandomStringCcSgfEPFNMlJztUeyliokQwTedJuiBGzcIBQjbYHizCbKsPnZsRZOzdlfyCCuUXLGmgr(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class jARiChAdoJhbNnhpsOAryfEOGkBQMRgarfFD
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

        public jARiChAdoJhbNnhpsOAryfEOGkBQMRgarfFD()
        {
            
        }
        public jARiChAdoJhbNnhpsOAryfEOGkBQMRgarfFD(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public jARiChAdoJhbNnhpsOAryfEOGkBQMRgarfFD(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public jARiChAdoJhbNnhpsOAryfEOGkBQMRgarfFD GetjARiChAdoJhbNnhpsOAryfEOGkBQMRgarfFD(){
        var clasx = new jARiChAdoJhbNnhpsOAryfEOGkBQMRgarfFD();
        return  clasx;
    }

    public string RandomStringjARiChAdoJhbNnhpsOAryfEOGkBQMRgarfFD(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rDKODkDqiWFkUzusOkFHKCRuhLtoZOvpBTKEXqFGcDUCucs
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

        public rDKODkDqiWFkUzusOkFHKCRuhLtoZOvpBTKEXqFGcDUCucs()
        {
            
        }
        public rDKODkDqiWFkUzusOkFHKCRuhLtoZOvpBTKEXqFGcDUCucs(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rDKODkDqiWFkUzusOkFHKCRuhLtoZOvpBTKEXqFGcDUCucs(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rDKODkDqiWFkUzusOkFHKCRuhLtoZOvpBTKEXqFGcDUCucs GetrDKODkDqiWFkUzusOkFHKCRuhLtoZOvpBTKEXqFGcDUCucs(){
        var clasx = new rDKODkDqiWFkUzusOkFHKCRuhLtoZOvpBTKEXqFGcDUCucs();
        return  clasx;
    }

    public string RandomStringrDKODkDqiWFkUzusOkFHKCRuhLtoZOvpBTKEXqFGcDUCucs(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ysNNNwLFiPczntwTbnejstkQFtYnmCVSndSdZwePQtiY
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

        public ysNNNwLFiPczntwTbnejstkQFtYnmCVSndSdZwePQtiY()
        {
            
        }
        public ysNNNwLFiPczntwTbnejstkQFtYnmCVSndSdZwePQtiY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ysNNNwLFiPczntwTbnejstkQFtYnmCVSndSdZwePQtiY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ysNNNwLFiPczntwTbnejstkQFtYnmCVSndSdZwePQtiY GetysNNNwLFiPczntwTbnejstkQFtYnmCVSndSdZwePQtiY(){
        var clasx = new ysNNNwLFiPczntwTbnejstkQFtYnmCVSndSdZwePQtiY();
        return  clasx;
    }

    public string RandomStringysNNNwLFiPczntwTbnejstkQFtYnmCVSndSdZwePQtiY(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class dLIgaaEGMXiMvaAdTLBTNkMcsMFECYRhFKbfPuT
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

        public dLIgaaEGMXiMvaAdTLBTNkMcsMFECYRhFKbfPuT()
        {
            
        }
        public dLIgaaEGMXiMvaAdTLBTNkMcsMFECYRhFKbfPuT(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public dLIgaaEGMXiMvaAdTLBTNkMcsMFECYRhFKbfPuT(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public dLIgaaEGMXiMvaAdTLBTNkMcsMFECYRhFKbfPuT GetdLIgaaEGMXiMvaAdTLBTNkMcsMFECYRhFKbfPuT(){
        var clasx = new dLIgaaEGMXiMvaAdTLBTNkMcsMFECYRhFKbfPuT();
        return  clasx;
    }

    public string RandomStringdLIgaaEGMXiMvaAdTLBTNkMcsMFECYRhFKbfPuT(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class AGcWdkQnkAVgsRYcDXrRmEUoTdEBjKJocqjmksUhvK
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

        public AGcWdkQnkAVgsRYcDXrRmEUoTdEBjKJocqjmksUhvK()
        {
            
        }
        public AGcWdkQnkAVgsRYcDXrRmEUoTdEBjKJocqjmksUhvK(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public AGcWdkQnkAVgsRYcDXrRmEUoTdEBjKJocqjmksUhvK(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public AGcWdkQnkAVgsRYcDXrRmEUoTdEBjKJocqjmksUhvK GetAGcWdkQnkAVgsRYcDXrRmEUoTdEBjKJocqjmksUhvK(){
        var clasx = new AGcWdkQnkAVgsRYcDXrRmEUoTdEBjKJocqjmksUhvK();
        return  clasx;
    }

    public string RandomStringAGcWdkQnkAVgsRYcDXrRmEUoTdEBjKJocqjmksUhvK(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rqxAPskmCsVzvvrZsdFiTdOxKVqnwkqoPbqZeCMbAhNTmctMEkAtBCBObApuCx
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

        public rqxAPskmCsVzvvrZsdFiTdOxKVqnwkqoPbqZeCMbAhNTmctMEkAtBCBObApuCx()
        {
            
        }
        public rqxAPskmCsVzvvrZsdFiTdOxKVqnwkqoPbqZeCMbAhNTmctMEkAtBCBObApuCx(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rqxAPskmCsVzvvrZsdFiTdOxKVqnwkqoPbqZeCMbAhNTmctMEkAtBCBObApuCx(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rqxAPskmCsVzvvrZsdFiTdOxKVqnwkqoPbqZeCMbAhNTmctMEkAtBCBObApuCx GetrqxAPskmCsVzvvrZsdFiTdOxKVqnwkqoPbqZeCMbAhNTmctMEkAtBCBObApuCx(){
        var clasx = new rqxAPskmCsVzvvrZsdFiTdOxKVqnwkqoPbqZeCMbAhNTmctMEkAtBCBObApuCx();
        return  clasx;
    }

    public string RandomStringrqxAPskmCsVzvvrZsdFiTdOxKVqnwkqoPbqZeCMbAhNTmctMEkAtBCBObApuCx(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class VnApPgkyVVSAXiDdRcoDQKtQMdhSAwpKQPeOWjHfczwaQexWa
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

        public VnApPgkyVVSAXiDdRcoDQKtQMdhSAwpKQPeOWjHfczwaQexWa()
        {
            
        }
        public VnApPgkyVVSAXiDdRcoDQKtQMdhSAwpKQPeOWjHfczwaQexWa(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VnApPgkyVVSAXiDdRcoDQKtQMdhSAwpKQPeOWjHfczwaQexWa(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VnApPgkyVVSAXiDdRcoDQKtQMdhSAwpKQPeOWjHfczwaQexWa GetVnApPgkyVVSAXiDdRcoDQKtQMdhSAwpKQPeOWjHfczwaQexWa(){
        var clasx = new VnApPgkyVVSAXiDdRcoDQKtQMdhSAwpKQPeOWjHfczwaQexWa();
        return  clasx;
    }

    public string RandomStringVnApPgkyVVSAXiDdRcoDQKtQMdhSAwpKQPeOWjHfczwaQexWa(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class TRgBSvPqumsTQjxVcWKjtPbaGixbVPZsvyBHzgHsndNBDWJ
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

        public TRgBSvPqumsTQjxVcWKjtPbaGixbVPZsvyBHzgHsndNBDWJ()
        {
            
        }
        public TRgBSvPqumsTQjxVcWKjtPbaGixbVPZsvyBHzgHsndNBDWJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public TRgBSvPqumsTQjxVcWKjtPbaGixbVPZsvyBHzgHsndNBDWJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public TRgBSvPqumsTQjxVcWKjtPbaGixbVPZsvyBHzgHsndNBDWJ GetTRgBSvPqumsTQjxVcWKjtPbaGixbVPZsvyBHzgHsndNBDWJ(){
        var clasx = new TRgBSvPqumsTQjxVcWKjtPbaGixbVPZsvyBHzgHsndNBDWJ();
        return  clasx;
    }

    public string RandomStringTRgBSvPqumsTQjxVcWKjtPbaGixbVPZsvyBHzgHsndNBDWJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class erPMlyuYPsCFRHaaHFKkzRxzzWJHArwbVNCqvTrvmHzzCbZ
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

        public erPMlyuYPsCFRHaaHFKkzRxzzWJHArwbVNCqvTrvmHzzCbZ()
        {
            
        }
        public erPMlyuYPsCFRHaaHFKkzRxzzWJHArwbVNCqvTrvmHzzCbZ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public erPMlyuYPsCFRHaaHFKkzRxzzWJHArwbVNCqvTrvmHzzCbZ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public erPMlyuYPsCFRHaaHFKkzRxzzWJHArwbVNCqvTrvmHzzCbZ GeterPMlyuYPsCFRHaaHFKkzRxzzWJHArwbVNCqvTrvmHzzCbZ(){
        var clasx = new erPMlyuYPsCFRHaaHFKkzRxzzWJHArwbVNCqvTrvmHzzCbZ();
        return  clasx;
    }

    public string RandomStringerPMlyuYPsCFRHaaHFKkzRxzzWJHArwbVNCqvTrvmHzzCbZ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class NjrvyMbMtiOtBgQcIaGBWOXthHoQdDzFKgZDEQqhggHyzv
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

        public NjrvyMbMtiOtBgQcIaGBWOXthHoQdDzFKgZDEQqhggHyzv()
        {
            
        }
        public NjrvyMbMtiOtBgQcIaGBWOXthHoQdDzFKgZDEQqhggHyzv(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public NjrvyMbMtiOtBgQcIaGBWOXthHoQdDzFKgZDEQqhggHyzv(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public NjrvyMbMtiOtBgQcIaGBWOXthHoQdDzFKgZDEQqhggHyzv GetNjrvyMbMtiOtBgQcIaGBWOXthHoQdDzFKgZDEQqhggHyzv(){
        var clasx = new NjrvyMbMtiOtBgQcIaGBWOXthHoQdDzFKgZDEQqhggHyzv();
        return  clasx;
    }

    public string RandomStringNjrvyMbMtiOtBgQcIaGBWOXthHoQdDzFKgZDEQqhggHyzv(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class zCLUQGRjKyCHygvXVBjODubjddnuuZLmxSKWt
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

        public zCLUQGRjKyCHygvXVBjODubjddnuuZLmxSKWt()
        {
            
        }
        public zCLUQGRjKyCHygvXVBjODubjddnuuZLmxSKWt(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public zCLUQGRjKyCHygvXVBjODubjddnuuZLmxSKWt(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public zCLUQGRjKyCHygvXVBjODubjddnuuZLmxSKWt GetzCLUQGRjKyCHygvXVBjODubjddnuuZLmxSKWt(){
        var clasx = new zCLUQGRjKyCHygvXVBjODubjddnuuZLmxSKWt();
        return  clasx;
    }

    public string RandomStringzCLUQGRjKyCHygvXVBjODubjddnuuZLmxSKWt(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class vfncHdsZgKQGJNGLAPBXQXdxcqqvcCCJxVrhCeWHZKnnBJQF
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

        public vfncHdsZgKQGJNGLAPBXQXdxcqqvcCCJxVrhCeWHZKnnBJQF()
        {
            
        }
        public vfncHdsZgKQGJNGLAPBXQXdxcqqvcCCJxVrhCeWHZKnnBJQF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public vfncHdsZgKQGJNGLAPBXQXdxcqqvcCCJxVrhCeWHZKnnBJQF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public vfncHdsZgKQGJNGLAPBXQXdxcqqvcCCJxVrhCeWHZKnnBJQF GetvfncHdsZgKQGJNGLAPBXQXdxcqqvcCCJxVrhCeWHZKnnBJQF(){
        var clasx = new vfncHdsZgKQGJNGLAPBXQXdxcqqvcCCJxVrhCeWHZKnnBJQF();
        return  clasx;
    }

    public string RandomStringvfncHdsZgKQGJNGLAPBXQXdxcqqvcCCJxVrhCeWHZKnnBJQF(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CcrZFIIihUbMbjxOPrWCihXINbONsKlp
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

        public CcrZFIIihUbMbjxOPrWCihXINbONsKlp()
        {
            
        }
        public CcrZFIIihUbMbjxOPrWCihXINbONsKlp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CcrZFIIihUbMbjxOPrWCihXINbONsKlp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CcrZFIIihUbMbjxOPrWCihXINbONsKlp GetCcrZFIIihUbMbjxOPrWCihXINbONsKlp(){
        var clasx = new CcrZFIIihUbMbjxOPrWCihXINbONsKlp();
        return  clasx;
    }

    public string RandomStringCcrZFIIihUbMbjxOPrWCihXINbONsKlp(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class YEWfoOwWPNFLDGaPBNCAXksWrlslfKCSSfvWap
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

        public YEWfoOwWPNFLDGaPBNCAXksWrlslfKCSSfvWap()
        {
            
        }
        public YEWfoOwWPNFLDGaPBNCAXksWrlslfKCSSfvWap(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public YEWfoOwWPNFLDGaPBNCAXksWrlslfKCSSfvWap(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public YEWfoOwWPNFLDGaPBNCAXksWrlslfKCSSfvWap GetYEWfoOwWPNFLDGaPBNCAXksWrlslfKCSSfvWap(){
        var clasx = new YEWfoOwWPNFLDGaPBNCAXksWrlslfKCSSfvWap();
        return  clasx;
    }

    public string RandomStringYEWfoOwWPNFLDGaPBNCAXksWrlslfKCSSfvWap(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class YelTkWfxZPGeBYKBwPnPSPVQCfzjPvFfLyHNeaIqMxCSrXOkdzANlhwIJUREWvhdJbTCR
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

        public YelTkWfxZPGeBYKBwPnPSPVQCfzjPvFfLyHNeaIqMxCSrXOkdzANlhwIJUREWvhdJbTCR()
        {
            
        }
        public YelTkWfxZPGeBYKBwPnPSPVQCfzjPvFfLyHNeaIqMxCSrXOkdzANlhwIJUREWvhdJbTCR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public YelTkWfxZPGeBYKBwPnPSPVQCfzjPvFfLyHNeaIqMxCSrXOkdzANlhwIJUREWvhdJbTCR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public YelTkWfxZPGeBYKBwPnPSPVQCfzjPvFfLyHNeaIqMxCSrXOkdzANlhwIJUREWvhdJbTCR GetYelTkWfxZPGeBYKBwPnPSPVQCfzjPvFfLyHNeaIqMxCSrXOkdzANlhwIJUREWvhdJbTCR(){
        var clasx = new YelTkWfxZPGeBYKBwPnPSPVQCfzjPvFfLyHNeaIqMxCSrXOkdzANlhwIJUREWvhdJbTCR();
        return  clasx;
    }

    public string RandomStringYelTkWfxZPGeBYKBwPnPSPVQCfzjPvFfLyHNeaIqMxCSrXOkdzANlhwIJUREWvhdJbTCR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class kXHbAqktpNIHmJUUuoXVssJAGrIJfQm
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

        public kXHbAqktpNIHmJUUuoXVssJAGrIJfQm()
        {
            
        }
        public kXHbAqktpNIHmJUUuoXVssJAGrIJfQm(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public kXHbAqktpNIHmJUUuoXVssJAGrIJfQm(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public kXHbAqktpNIHmJUUuoXVssJAGrIJfQm GetkXHbAqktpNIHmJUUuoXVssJAGrIJfQm(){
        var clasx = new kXHbAqktpNIHmJUUuoXVssJAGrIJfQm();
        return  clasx;
    }

    public string RandomStringkXHbAqktpNIHmJUUuoXVssJAGrIJfQm(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class OvSNTtSijYfvbWCCdUISEnhtOCfnYnGUexkKUayutuJdaaTpAlIXJUjaOYyRO
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

        public OvSNTtSijYfvbWCCdUISEnhtOCfnYnGUexkKUayutuJdaaTpAlIXJUjaOYyRO()
        {
            
        }
        public OvSNTtSijYfvbWCCdUISEnhtOCfnYnGUexkKUayutuJdaaTpAlIXJUjaOYyRO(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OvSNTtSijYfvbWCCdUISEnhtOCfnYnGUexkKUayutuJdaaTpAlIXJUjaOYyRO(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OvSNTtSijYfvbWCCdUISEnhtOCfnYnGUexkKUayutuJdaaTpAlIXJUjaOYyRO GetOvSNTtSijYfvbWCCdUISEnhtOCfnYnGUexkKUayutuJdaaTpAlIXJUjaOYyRO(){
        var clasx = new OvSNTtSijYfvbWCCdUISEnhtOCfnYnGUexkKUayutuJdaaTpAlIXJUjaOYyRO();
        return  clasx;
    }

    public string RandomStringOvSNTtSijYfvbWCCdUISEnhtOCfnYnGUexkKUayutuJdaaTpAlIXJUjaOYyRO(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class BETHOXIGBZroQWwCNmoGAazLpeVNwcvUbzkryCqf
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

        public BETHOXIGBZroQWwCNmoGAazLpeVNwcvUbzkryCqf()
        {
            
        }
        public BETHOXIGBZroQWwCNmoGAazLpeVNwcvUbzkryCqf(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public BETHOXIGBZroQWwCNmoGAazLpeVNwcvUbzkryCqf(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public BETHOXIGBZroQWwCNmoGAazLpeVNwcvUbzkryCqf GetBETHOXIGBZroQWwCNmoGAazLpeVNwcvUbzkryCqf(){
        var clasx = new BETHOXIGBZroQWwCNmoGAazLpeVNwcvUbzkryCqf();
        return  clasx;
    }

    public string RandomStringBETHOXIGBZroQWwCNmoGAazLpeVNwcvUbzkryCqf(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class egzCMlKHADfIEjmjdDoSPdJjSpeyCkLWgYyktQvNoUTIvSKUMPkQX
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

        public egzCMlKHADfIEjmjdDoSPdJjSpeyCkLWgYyktQvNoUTIvSKUMPkQX()
        {
            
        }
        public egzCMlKHADfIEjmjdDoSPdJjSpeyCkLWgYyktQvNoUTIvSKUMPkQX(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public egzCMlKHADfIEjmjdDoSPdJjSpeyCkLWgYyktQvNoUTIvSKUMPkQX(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public egzCMlKHADfIEjmjdDoSPdJjSpeyCkLWgYyktQvNoUTIvSKUMPkQX GetegzCMlKHADfIEjmjdDoSPdJjSpeyCkLWgYyktQvNoUTIvSKUMPkQX(){
        var clasx = new egzCMlKHADfIEjmjdDoSPdJjSpeyCkLWgYyktQvNoUTIvSKUMPkQX();
        return  clasx;
    }

    public string RandomStringegzCMlKHADfIEjmjdDoSPdJjSpeyCkLWgYyktQvNoUTIvSKUMPkQX(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rFNeVHaNgSYemwMFLKoOcwPodAGYQsvW
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

        public rFNeVHaNgSYemwMFLKoOcwPodAGYQsvW()
        {
            
        }
        public rFNeVHaNgSYemwMFLKoOcwPodAGYQsvW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rFNeVHaNgSYemwMFLKoOcwPodAGYQsvW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rFNeVHaNgSYemwMFLKoOcwPodAGYQsvW GetrFNeVHaNgSYemwMFLKoOcwPodAGYQsvW(){
        var clasx = new rFNeVHaNgSYemwMFLKoOcwPodAGYQsvW();
        return  clasx;
    }

    public string RandomStringrFNeVHaNgSYemwMFLKoOcwPodAGYQsvW(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class bLkvarFcTwaqjIdMUydXSPgkgRcyEVziNYxxfhRU
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

        public bLkvarFcTwaqjIdMUydXSPgkgRcyEVziNYxxfhRU()
        {
            
        }
        public bLkvarFcTwaqjIdMUydXSPgkgRcyEVziNYxxfhRU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bLkvarFcTwaqjIdMUydXSPgkgRcyEVziNYxxfhRU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bLkvarFcTwaqjIdMUydXSPgkgRcyEVziNYxxfhRU GetbLkvarFcTwaqjIdMUydXSPgkgRcyEVziNYxxfhRU(){
        var clasx = new bLkvarFcTwaqjIdMUydXSPgkgRcyEVziNYxxfhRU();
        return  clasx;
    }

    public string RandomStringbLkvarFcTwaqjIdMUydXSPgkgRcyEVziNYxxfhRU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class svBuZIQGdvzsrIQCYumddPmjlRTgtsujPRqmuMrVfkJY
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

        public svBuZIQGdvzsrIQCYumddPmjlRTgtsujPRqmuMrVfkJY()
        {
            
        }
        public svBuZIQGdvzsrIQCYumddPmjlRTgtsujPRqmuMrVfkJY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public svBuZIQGdvzsrIQCYumddPmjlRTgtsujPRqmuMrVfkJY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public svBuZIQGdvzsrIQCYumddPmjlRTgtsujPRqmuMrVfkJY GetsvBuZIQGdvzsrIQCYumddPmjlRTgtsujPRqmuMrVfkJY(){
        var clasx = new svBuZIQGdvzsrIQCYumddPmjlRTgtsujPRqmuMrVfkJY();
        return  clasx;
    }

    public string RandomStringsvBuZIQGdvzsrIQCYumddPmjlRTgtsujPRqmuMrVfkJY(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JJAmhRCKIKxHkEFbAPfDZVxrPfOhVpTBeLnegMWSgjKdZQSJnL
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

        public JJAmhRCKIKxHkEFbAPfDZVxrPfOhVpTBeLnegMWSgjKdZQSJnL()
        {
            
        }
        public JJAmhRCKIKxHkEFbAPfDZVxrPfOhVpTBeLnegMWSgjKdZQSJnL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JJAmhRCKIKxHkEFbAPfDZVxrPfOhVpTBeLnegMWSgjKdZQSJnL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JJAmhRCKIKxHkEFbAPfDZVxrPfOhVpTBeLnegMWSgjKdZQSJnL GetJJAmhRCKIKxHkEFbAPfDZVxrPfOhVpTBeLnegMWSgjKdZQSJnL(){
        var clasx = new JJAmhRCKIKxHkEFbAPfDZVxrPfOhVpTBeLnegMWSgjKdZQSJnL();
        return  clasx;
    }

    public string RandomStringJJAmhRCKIKxHkEFbAPfDZVxrPfOhVpTBeLnegMWSgjKdZQSJnL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ClghnUimKGMEBktWsQhFlRbKOuifemEEmouZdpomiudqvBfCP
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

        public ClghnUimKGMEBktWsQhFlRbKOuifemEEmouZdpomiudqvBfCP()
        {
            
        }
        public ClghnUimKGMEBktWsQhFlRbKOuifemEEmouZdpomiudqvBfCP(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ClghnUimKGMEBktWsQhFlRbKOuifemEEmouZdpomiudqvBfCP(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ClghnUimKGMEBktWsQhFlRbKOuifemEEmouZdpomiudqvBfCP GetClghnUimKGMEBktWsQhFlRbKOuifemEEmouZdpomiudqvBfCP(){
        var clasx = new ClghnUimKGMEBktWsQhFlRbKOuifemEEmouZdpomiudqvBfCP();
        return  clasx;
    }

    public string RandomStringClghnUimKGMEBktWsQhFlRbKOuifemEEmouZdpomiudqvBfCP(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class vhgUQCbZAwxFbKGaiAGQHaJQBirMYYDOrPhRVKmwfnvmIlZyZSK
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

        public vhgUQCbZAwxFbKGaiAGQHaJQBirMYYDOrPhRVKmwfnvmIlZyZSK()
        {
            
        }
        public vhgUQCbZAwxFbKGaiAGQHaJQBirMYYDOrPhRVKmwfnvmIlZyZSK(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public vhgUQCbZAwxFbKGaiAGQHaJQBirMYYDOrPhRVKmwfnvmIlZyZSK(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public vhgUQCbZAwxFbKGaiAGQHaJQBirMYYDOrPhRVKmwfnvmIlZyZSK GetvhgUQCbZAwxFbKGaiAGQHaJQBirMYYDOrPhRVKmwfnvmIlZyZSK(){
        var clasx = new vhgUQCbZAwxFbKGaiAGQHaJQBirMYYDOrPhRVKmwfnvmIlZyZSK();
        return  clasx;
    }

    public string RandomStringvhgUQCbZAwxFbKGaiAGQHaJQBirMYYDOrPhRVKmwfnvmIlZyZSK(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class dbqquiRaLJQulsCQFrEuzEaBEqNlBhVuTOCCdOlpjVHWziaVw
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

        public dbqquiRaLJQulsCQFrEuzEaBEqNlBhVuTOCCdOlpjVHWziaVw()
        {
            
        }
        public dbqquiRaLJQulsCQFrEuzEaBEqNlBhVuTOCCdOlpjVHWziaVw(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public dbqquiRaLJQulsCQFrEuzEaBEqNlBhVuTOCCdOlpjVHWziaVw(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public dbqquiRaLJQulsCQFrEuzEaBEqNlBhVuTOCCdOlpjVHWziaVw GetdbqquiRaLJQulsCQFrEuzEaBEqNlBhVuTOCCdOlpjVHWziaVw(){
        var clasx = new dbqquiRaLJQulsCQFrEuzEaBEqNlBhVuTOCCdOlpjVHWziaVw();
        return  clasx;
    }

    public string RandomStringdbqquiRaLJQulsCQFrEuzEaBEqNlBhVuTOCCdOlpjVHWziaVw(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JEepZbcBoikothgNUakgiRrhlCmBcRhVTaGGQYZHljQBlG
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

        public JEepZbcBoikothgNUakgiRrhlCmBcRhVTaGGQYZHljQBlG()
        {
            
        }
        public JEepZbcBoikothgNUakgiRrhlCmBcRhVTaGGQYZHljQBlG(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JEepZbcBoikothgNUakgiRrhlCmBcRhVTaGGQYZHljQBlG(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JEepZbcBoikothgNUakgiRrhlCmBcRhVTaGGQYZHljQBlG GetJEepZbcBoikothgNUakgiRrhlCmBcRhVTaGGQYZHljQBlG(){
        var clasx = new JEepZbcBoikothgNUakgiRrhlCmBcRhVTaGGQYZHljQBlG();
        return  clasx;
    }

    public string RandomStringJEepZbcBoikothgNUakgiRrhlCmBcRhVTaGGQYZHljQBlG(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class tiKWMDWDwOMudxvVHbrmqzEeIHZSPeUcqdmzerriFHHDBibzihoUNBftefN
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

        public tiKWMDWDwOMudxvVHbrmqzEeIHZSPeUcqdmzerriFHHDBibzihoUNBftefN()
        {
            
        }
        public tiKWMDWDwOMudxvVHbrmqzEeIHZSPeUcqdmzerriFHHDBibzihoUNBftefN(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public tiKWMDWDwOMudxvVHbrmqzEeIHZSPeUcqdmzerriFHHDBibzihoUNBftefN(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public tiKWMDWDwOMudxvVHbrmqzEeIHZSPeUcqdmzerriFHHDBibzihoUNBftefN GettiKWMDWDwOMudxvVHbrmqzEeIHZSPeUcqdmzerriFHHDBibzihoUNBftefN(){
        var clasx = new tiKWMDWDwOMudxvVHbrmqzEeIHZSPeUcqdmzerriFHHDBibzihoUNBftefN();
        return  clasx;
    }

    public string RandomStringtiKWMDWDwOMudxvVHbrmqzEeIHZSPeUcqdmzerriFHHDBibzihoUNBftefN(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class uIORLvzmKlrXSXLKkZWHOFapKFGmteFXxqIq
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

        public uIORLvzmKlrXSXLKkZWHOFapKFGmteFXxqIq()
        {
            
        }
        public uIORLvzmKlrXSXLKkZWHOFapKFGmteFXxqIq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public uIORLvzmKlrXSXLKkZWHOFapKFGmteFXxqIq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public uIORLvzmKlrXSXLKkZWHOFapKFGmteFXxqIq GetuIORLvzmKlrXSXLKkZWHOFapKFGmteFXxqIq(){
        var clasx = new uIORLvzmKlrXSXLKkZWHOFapKFGmteFXxqIq();
        return  clasx;
    }

    public string RandomStringuIORLvzmKlrXSXLKkZWHOFapKFGmteFXxqIq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class vRnIGEFmUtIroeUpeAtxHmoQoVuVwXqRStoEYshCwh
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

        public vRnIGEFmUtIroeUpeAtxHmoQoVuVwXqRStoEYshCwh()
        {
            
        }
        public vRnIGEFmUtIroeUpeAtxHmoQoVuVwXqRStoEYshCwh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public vRnIGEFmUtIroeUpeAtxHmoQoVuVwXqRStoEYshCwh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public vRnIGEFmUtIroeUpeAtxHmoQoVuVwXqRStoEYshCwh GetvRnIGEFmUtIroeUpeAtxHmoQoVuVwXqRStoEYshCwh(){
        var clasx = new vRnIGEFmUtIroeUpeAtxHmoQoVuVwXqRStoEYshCwh();
        return  clasx;
    }

    public string RandomStringvRnIGEFmUtIroeUpeAtxHmoQoVuVwXqRStoEYshCwh(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class qoRRhDqLfeYZoNclIediHOXYHLdwZTZOEeRuhblFQiaPXVUuvjhndOJbRs
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

        public qoRRhDqLfeYZoNclIediHOXYHLdwZTZOEeRuhblFQiaPXVUuvjhndOJbRs()
        {
            
        }
        public qoRRhDqLfeYZoNclIediHOXYHLdwZTZOEeRuhblFQiaPXVUuvjhndOJbRs(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qoRRhDqLfeYZoNclIediHOXYHLdwZTZOEeRuhblFQiaPXVUuvjhndOJbRs(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qoRRhDqLfeYZoNclIediHOXYHLdwZTZOEeRuhblFQiaPXVUuvjhndOJbRs GetqoRRhDqLfeYZoNclIediHOXYHLdwZTZOEeRuhblFQiaPXVUuvjhndOJbRs(){
        var clasx = new qoRRhDqLfeYZoNclIediHOXYHLdwZTZOEeRuhblFQiaPXVUuvjhndOJbRs();
        return  clasx;
    }

    public string RandomStringqoRRhDqLfeYZoNclIediHOXYHLdwZTZOEeRuhblFQiaPXVUuvjhndOJbRs(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CpKSZsnZUgbQcZyxBKwlGlwRVtksvPLbGGHDlqaQLhGvxBTQGHbLRzMQttw
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

        public CpKSZsnZUgbQcZyxBKwlGlwRVtksvPLbGGHDlqaQLhGvxBTQGHbLRzMQttw()
        {
            
        }
        public CpKSZsnZUgbQcZyxBKwlGlwRVtksvPLbGGHDlqaQLhGvxBTQGHbLRzMQttw(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CpKSZsnZUgbQcZyxBKwlGlwRVtksvPLbGGHDlqaQLhGvxBTQGHbLRzMQttw(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CpKSZsnZUgbQcZyxBKwlGlwRVtksvPLbGGHDlqaQLhGvxBTQGHbLRzMQttw GetCpKSZsnZUgbQcZyxBKwlGlwRVtksvPLbGGHDlqaQLhGvxBTQGHbLRzMQttw(){
        var clasx = new CpKSZsnZUgbQcZyxBKwlGlwRVtksvPLbGGHDlqaQLhGvxBTQGHbLRzMQttw();
        return  clasx;
    }

    public string RandomStringCpKSZsnZUgbQcZyxBKwlGlwRVtksvPLbGGHDlqaQLhGvxBTQGHbLRzMQttw(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class SgrHEJsbXUmdHMswQFsFRtpvwYhboDxTRvplKEWxrJKsNQNKQAgkTcYYqwLgbRmUXTLM
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

        public SgrHEJsbXUmdHMswQFsFRtpvwYhboDxTRvplKEWxrJKsNQNKQAgkTcYYqwLgbRmUXTLM()
        {
            
        }
        public SgrHEJsbXUmdHMswQFsFRtpvwYhboDxTRvplKEWxrJKsNQNKQAgkTcYYqwLgbRmUXTLM(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public SgrHEJsbXUmdHMswQFsFRtpvwYhboDxTRvplKEWxrJKsNQNKQAgkTcYYqwLgbRmUXTLM(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public SgrHEJsbXUmdHMswQFsFRtpvwYhboDxTRvplKEWxrJKsNQNKQAgkTcYYqwLgbRmUXTLM GetSgrHEJsbXUmdHMswQFsFRtpvwYhboDxTRvplKEWxrJKsNQNKQAgkTcYYqwLgbRmUXTLM(){
        var clasx = new SgrHEJsbXUmdHMswQFsFRtpvwYhboDxTRvplKEWxrJKsNQNKQAgkTcYYqwLgbRmUXTLM();
        return  clasx;
    }

    public string RandomStringSgrHEJsbXUmdHMswQFsFRtpvwYhboDxTRvplKEWxrJKsNQNKQAgkTcYYqwLgbRmUXTLM(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class cWQcvEAJKGZzOdxlOPgiOvvJSWnvsLVAOr
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

        public cWQcvEAJKGZzOdxlOPgiOvvJSWnvsLVAOr()
        {
            
        }
        public cWQcvEAJKGZzOdxlOPgiOvvJSWnvsLVAOr(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public cWQcvEAJKGZzOdxlOPgiOvvJSWnvsLVAOr(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public cWQcvEAJKGZzOdxlOPgiOvvJSWnvsLVAOr GetcWQcvEAJKGZzOdxlOPgiOvvJSWnvsLVAOr(){
        var clasx = new cWQcvEAJKGZzOdxlOPgiOvvJSWnvsLVAOr();
        return  clasx;
    }

    public string RandomStringcWQcvEAJKGZzOdxlOPgiOvvJSWnvsLVAOr(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class DaRegpBIOeTSTFsmtojEVhdJrNnjoDhrExFBrUVGPdVrAhXfxHlvXeJVxImTCSUKx
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

        public DaRegpBIOeTSTFsmtojEVhdJrNnjoDhrExFBrUVGPdVrAhXfxHlvXeJVxImTCSUKx()
        {
            
        }
        public DaRegpBIOeTSTFsmtojEVhdJrNnjoDhrExFBrUVGPdVrAhXfxHlvXeJVxImTCSUKx(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public DaRegpBIOeTSTFsmtojEVhdJrNnjoDhrExFBrUVGPdVrAhXfxHlvXeJVxImTCSUKx(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public DaRegpBIOeTSTFsmtojEVhdJrNnjoDhrExFBrUVGPdVrAhXfxHlvXeJVxImTCSUKx GetDaRegpBIOeTSTFsmtojEVhdJrNnjoDhrExFBrUVGPdVrAhXfxHlvXeJVxImTCSUKx(){
        var clasx = new DaRegpBIOeTSTFsmtojEVhdJrNnjoDhrExFBrUVGPdVrAhXfxHlvXeJVxImTCSUKx();
        return  clasx;
    }

    public string RandomStringDaRegpBIOeTSTFsmtojEVhdJrNnjoDhrExFBrUVGPdVrAhXfxHlvXeJVxImTCSUKx(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MyCRIepdVaqaoDHcsARRUegWqFeeObUoYCZKMMMniJzkXNxPiSNrzJbhSgaDALPtGC
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

        public MyCRIepdVaqaoDHcsARRUegWqFeeObUoYCZKMMMniJzkXNxPiSNrzJbhSgaDALPtGC()
        {
            
        }
        public MyCRIepdVaqaoDHcsARRUegWqFeeObUoYCZKMMMniJzkXNxPiSNrzJbhSgaDALPtGC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MyCRIepdVaqaoDHcsARRUegWqFeeObUoYCZKMMMniJzkXNxPiSNrzJbhSgaDALPtGC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MyCRIepdVaqaoDHcsARRUegWqFeeObUoYCZKMMMniJzkXNxPiSNrzJbhSgaDALPtGC GetMyCRIepdVaqaoDHcsARRUegWqFeeObUoYCZKMMMniJzkXNxPiSNrzJbhSgaDALPtGC(){
        var clasx = new MyCRIepdVaqaoDHcsARRUegWqFeeObUoYCZKMMMniJzkXNxPiSNrzJbhSgaDALPtGC();
        return  clasx;
    }

    public string RandomStringMyCRIepdVaqaoDHcsARRUegWqFeeObUoYCZKMMMniJzkXNxPiSNrzJbhSgaDALPtGC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mTWsANcXSRSlcQuueRmJWovJBWvRAUmmVcPPjoupZVGMaIYZFgS
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

        public mTWsANcXSRSlcQuueRmJWovJBWvRAUmmVcPPjoupZVGMaIYZFgS()
        {
            
        }
        public mTWsANcXSRSlcQuueRmJWovJBWvRAUmmVcPPjoupZVGMaIYZFgS(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mTWsANcXSRSlcQuueRmJWovJBWvRAUmmVcPPjoupZVGMaIYZFgS(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mTWsANcXSRSlcQuueRmJWovJBWvRAUmmVcPPjoupZVGMaIYZFgS GetmTWsANcXSRSlcQuueRmJWovJBWvRAUmmVcPPjoupZVGMaIYZFgS(){
        var clasx = new mTWsANcXSRSlcQuueRmJWovJBWvRAUmmVcPPjoupZVGMaIYZFgS();
        return  clasx;
    }

    public string RandomStringmTWsANcXSRSlcQuueRmJWovJBWvRAUmmVcPPjoupZVGMaIYZFgS(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class uOTRgIsqRcScbrLAmvKQuCSqUODyGuAXmbWLOBHUaVoYVXnjBIDehPVsvdxS
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

        public uOTRgIsqRcScbrLAmvKQuCSqUODyGuAXmbWLOBHUaVoYVXnjBIDehPVsvdxS()
        {
            
        }
        public uOTRgIsqRcScbrLAmvKQuCSqUODyGuAXmbWLOBHUaVoYVXnjBIDehPVsvdxS(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public uOTRgIsqRcScbrLAmvKQuCSqUODyGuAXmbWLOBHUaVoYVXnjBIDehPVsvdxS(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public uOTRgIsqRcScbrLAmvKQuCSqUODyGuAXmbWLOBHUaVoYVXnjBIDehPVsvdxS GetuOTRgIsqRcScbrLAmvKQuCSqUODyGuAXmbWLOBHUaVoYVXnjBIDehPVsvdxS(){
        var clasx = new uOTRgIsqRcScbrLAmvKQuCSqUODyGuAXmbWLOBHUaVoYVXnjBIDehPVsvdxS();
        return  clasx;
    }

    public string RandomStringuOTRgIsqRcScbrLAmvKQuCSqUODyGuAXmbWLOBHUaVoYVXnjBIDehPVsvdxS(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class wrvewphRyoQhXXDFXjhkqaRdszRKtSSNwYnGUsnbJPhfWVRZjrvvq
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

        public wrvewphRyoQhXXDFXjhkqaRdszRKtSSNwYnGUsnbJPhfWVRZjrvvq()
        {
            
        }
        public wrvewphRyoQhXXDFXjhkqaRdszRKtSSNwYnGUsnbJPhfWVRZjrvvq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public wrvewphRyoQhXXDFXjhkqaRdszRKtSSNwYnGUsnbJPhfWVRZjrvvq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public wrvewphRyoQhXXDFXjhkqaRdszRKtSSNwYnGUsnbJPhfWVRZjrvvq GetwrvewphRyoQhXXDFXjhkqaRdszRKtSSNwYnGUsnbJPhfWVRZjrvvq(){
        var clasx = new wrvewphRyoQhXXDFXjhkqaRdszRKtSSNwYnGUsnbJPhfWVRZjrvvq();
        return  clasx;
    }

    public string RandomStringwrvewphRyoQhXXDFXjhkqaRdszRKtSSNwYnGUsnbJPhfWVRZjrvvq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class BERVTIvkxxMOTPXwhlOpzEOClCCGJfbvzds
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

        public BERVTIvkxxMOTPXwhlOpzEOClCCGJfbvzds()
        {
            
        }
        public BERVTIvkxxMOTPXwhlOpzEOClCCGJfbvzds(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public BERVTIvkxxMOTPXwhlOpzEOClCCGJfbvzds(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public BERVTIvkxxMOTPXwhlOpzEOClCCGJfbvzds GetBERVTIvkxxMOTPXwhlOpzEOClCCGJfbvzds(){
        var clasx = new BERVTIvkxxMOTPXwhlOpzEOClCCGJfbvzds();
        return  clasx;
    }

    public string RandomStringBERVTIvkxxMOTPXwhlOpzEOClCCGJfbvzds(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class FYfwTZFGQqDpRsSQKqYOjNuKdLBBISnG
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

        public FYfwTZFGQqDpRsSQKqYOjNuKdLBBISnG()
        {
            
        }
        public FYfwTZFGQqDpRsSQKqYOjNuKdLBBISnG(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public FYfwTZFGQqDpRsSQKqYOjNuKdLBBISnG(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public FYfwTZFGQqDpRsSQKqYOjNuKdLBBISnG GetFYfwTZFGQqDpRsSQKqYOjNuKdLBBISnG(){
        var clasx = new FYfwTZFGQqDpRsSQKqYOjNuKdLBBISnG();
        return  clasx;
    }

    public string RandomStringFYfwTZFGQqDpRsSQKqYOjNuKdLBBISnG(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class YJqZAabImzlAdTptPLBlzHAkitcnPBSFuQEZOSKxMDXAHBsQY
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

        public YJqZAabImzlAdTptPLBlzHAkitcnPBSFuQEZOSKxMDXAHBsQY()
        {
            
        }
        public YJqZAabImzlAdTptPLBlzHAkitcnPBSFuQEZOSKxMDXAHBsQY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public YJqZAabImzlAdTptPLBlzHAkitcnPBSFuQEZOSKxMDXAHBsQY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public YJqZAabImzlAdTptPLBlzHAkitcnPBSFuQEZOSKxMDXAHBsQY GetYJqZAabImzlAdTptPLBlzHAkitcnPBSFuQEZOSKxMDXAHBsQY(){
        var clasx = new YJqZAabImzlAdTptPLBlzHAkitcnPBSFuQEZOSKxMDXAHBsQY();
        return  clasx;
    }

    public string RandomStringYJqZAabImzlAdTptPLBlzHAkitcnPBSFuQEZOSKxMDXAHBsQY(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xEwzeelFcgGSdUBPUkuisDgLmrbbvqCKAge
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

        public xEwzeelFcgGSdUBPUkuisDgLmrbbvqCKAge()
        {
            
        }
        public xEwzeelFcgGSdUBPUkuisDgLmrbbvqCKAge(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xEwzeelFcgGSdUBPUkuisDgLmrbbvqCKAge(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xEwzeelFcgGSdUBPUkuisDgLmrbbvqCKAge GetxEwzeelFcgGSdUBPUkuisDgLmrbbvqCKAge(){
        var clasx = new xEwzeelFcgGSdUBPUkuisDgLmrbbvqCKAge();
        return  clasx;
    }

    public string RandomStringxEwzeelFcgGSdUBPUkuisDgLmrbbvqCKAge(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JMdwIMtDLwPVHTimafzNrDXWUmVVIgcOHOBZWgmtzjdL
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

        public JMdwIMtDLwPVHTimafzNrDXWUmVVIgcOHOBZWgmtzjdL()
        {
            
        }
        public JMdwIMtDLwPVHTimafzNrDXWUmVVIgcOHOBZWgmtzjdL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JMdwIMtDLwPVHTimafzNrDXWUmVVIgcOHOBZWgmtzjdL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JMdwIMtDLwPVHTimafzNrDXWUmVVIgcOHOBZWgmtzjdL GetJMdwIMtDLwPVHTimafzNrDXWUmVVIgcOHOBZWgmtzjdL(){
        var clasx = new JMdwIMtDLwPVHTimafzNrDXWUmVVIgcOHOBZWgmtzjdL();
        return  clasx;
    }

    public string RandomStringJMdwIMtDLwPVHTimafzNrDXWUmVVIgcOHOBZWgmtzjdL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class aEtfOWgpZtPhwAOSLEDTzopNQCvRgzezBsWJHDvVyIsdYpVLlSRuwuKlPgPMaPIZP
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

        public aEtfOWgpZtPhwAOSLEDTzopNQCvRgzezBsWJHDvVyIsdYpVLlSRuwuKlPgPMaPIZP()
        {
            
        }
        public aEtfOWgpZtPhwAOSLEDTzopNQCvRgzezBsWJHDvVyIsdYpVLlSRuwuKlPgPMaPIZP(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public aEtfOWgpZtPhwAOSLEDTzopNQCvRgzezBsWJHDvVyIsdYpVLlSRuwuKlPgPMaPIZP(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public aEtfOWgpZtPhwAOSLEDTzopNQCvRgzezBsWJHDvVyIsdYpVLlSRuwuKlPgPMaPIZP GetaEtfOWgpZtPhwAOSLEDTzopNQCvRgzezBsWJHDvVyIsdYpVLlSRuwuKlPgPMaPIZP(){
        var clasx = new aEtfOWgpZtPhwAOSLEDTzopNQCvRgzezBsWJHDvVyIsdYpVLlSRuwuKlPgPMaPIZP();
        return  clasx;
    }

    public string RandomStringaEtfOWgpZtPhwAOSLEDTzopNQCvRgzezBsWJHDvVyIsdYpVLlSRuwuKlPgPMaPIZP(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class jwwmJYQPWyTwYDusgjDMNCwqiaYPfYLrVNAJtucAadRJRNKhdU
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

        public jwwmJYQPWyTwYDusgjDMNCwqiaYPfYLrVNAJtucAadRJRNKhdU()
        {
            
        }
        public jwwmJYQPWyTwYDusgjDMNCwqiaYPfYLrVNAJtucAadRJRNKhdU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public jwwmJYQPWyTwYDusgjDMNCwqiaYPfYLrVNAJtucAadRJRNKhdU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public jwwmJYQPWyTwYDusgjDMNCwqiaYPfYLrVNAJtucAadRJRNKhdU GetjwwmJYQPWyTwYDusgjDMNCwqiaYPfYLrVNAJtucAadRJRNKhdU(){
        var clasx = new jwwmJYQPWyTwYDusgjDMNCwqiaYPfYLrVNAJtucAadRJRNKhdU();
        return  clasx;
    }

    public string RandomStringjwwmJYQPWyTwYDusgjDMNCwqiaYPfYLrVNAJtucAadRJRNKhdU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class NhhLffUWrSYGcFeIUGYYqZXavuVGatPIvMqrsXSTHmvmZFIIWuYLh
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

        public NhhLffUWrSYGcFeIUGYYqZXavuVGatPIvMqrsXSTHmvmZFIIWuYLh()
        {
            
        }
        public NhhLffUWrSYGcFeIUGYYqZXavuVGatPIvMqrsXSTHmvmZFIIWuYLh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public NhhLffUWrSYGcFeIUGYYqZXavuVGatPIvMqrsXSTHmvmZFIIWuYLh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public NhhLffUWrSYGcFeIUGYYqZXavuVGatPIvMqrsXSTHmvmZFIIWuYLh GetNhhLffUWrSYGcFeIUGYYqZXavuVGatPIvMqrsXSTHmvmZFIIWuYLh(){
        var clasx = new NhhLffUWrSYGcFeIUGYYqZXavuVGatPIvMqrsXSTHmvmZFIIWuYLh();
        return  clasx;
    }

    public string RandomStringNhhLffUWrSYGcFeIUGYYqZXavuVGatPIvMqrsXSTHmvmZFIIWuYLh(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MUmoLJNkKzdpkzTjsYTaTrIwaRYYHZVMFK
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

        public MUmoLJNkKzdpkzTjsYTaTrIwaRYYHZVMFK()
        {
            
        }
        public MUmoLJNkKzdpkzTjsYTaTrIwaRYYHZVMFK(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MUmoLJNkKzdpkzTjsYTaTrIwaRYYHZVMFK(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MUmoLJNkKzdpkzTjsYTaTrIwaRYYHZVMFK GetMUmoLJNkKzdpkzTjsYTaTrIwaRYYHZVMFK(){
        var clasx = new MUmoLJNkKzdpkzTjsYTaTrIwaRYYHZVMFK();
        return  clasx;
    }

    public string RandomStringMUmoLJNkKzdpkzTjsYTaTrIwaRYYHZVMFK(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class aJXjErQqQCgJyaARNUCJfUEVJlNuYjaUMMxPtQl
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

        public aJXjErQqQCgJyaARNUCJfUEVJlNuYjaUMMxPtQl()
        {
            
        }
        public aJXjErQqQCgJyaARNUCJfUEVJlNuYjaUMMxPtQl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public aJXjErQqQCgJyaARNUCJfUEVJlNuYjaUMMxPtQl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public aJXjErQqQCgJyaARNUCJfUEVJlNuYjaUMMxPtQl GetaJXjErQqQCgJyaARNUCJfUEVJlNuYjaUMMxPtQl(){
        var clasx = new aJXjErQqQCgJyaARNUCJfUEVJlNuYjaUMMxPtQl();
        return  clasx;
    }

    public string RandomStringaJXjErQqQCgJyaARNUCJfUEVJlNuYjaUMMxPtQl(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class nzzfZCMiHFoseCUCyeXBEkoGwYAmXRmTNkynwWUEpJqJpbJcPSVgcxoDLtjAC
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

        public nzzfZCMiHFoseCUCyeXBEkoGwYAmXRmTNkynwWUEpJqJpbJcPSVgcxoDLtjAC()
        {
            
        }
        public nzzfZCMiHFoseCUCyeXBEkoGwYAmXRmTNkynwWUEpJqJpbJcPSVgcxoDLtjAC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public nzzfZCMiHFoseCUCyeXBEkoGwYAmXRmTNkynwWUEpJqJpbJcPSVgcxoDLtjAC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public nzzfZCMiHFoseCUCyeXBEkoGwYAmXRmTNkynwWUEpJqJpbJcPSVgcxoDLtjAC GetnzzfZCMiHFoseCUCyeXBEkoGwYAmXRmTNkynwWUEpJqJpbJcPSVgcxoDLtjAC(){
        var clasx = new nzzfZCMiHFoseCUCyeXBEkoGwYAmXRmTNkynwWUEpJqJpbJcPSVgcxoDLtjAC();
        return  clasx;
    }

    public string RandomStringnzzfZCMiHFoseCUCyeXBEkoGwYAmXRmTNkynwWUEpJqJpbJcPSVgcxoDLtjAC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class eMAzZrTLXnqJPFYxoCMlIQnKoqNfOSffWxurTSsoKrBvVBCKODZzyfcNYq
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

        public eMAzZrTLXnqJPFYxoCMlIQnKoqNfOSffWxurTSsoKrBvVBCKODZzyfcNYq()
        {
            
        }
        public eMAzZrTLXnqJPFYxoCMlIQnKoqNfOSffWxurTSsoKrBvVBCKODZzyfcNYq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public eMAzZrTLXnqJPFYxoCMlIQnKoqNfOSffWxurTSsoKrBvVBCKODZzyfcNYq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public eMAzZrTLXnqJPFYxoCMlIQnKoqNfOSffWxurTSsoKrBvVBCKODZzyfcNYq GeteMAzZrTLXnqJPFYxoCMlIQnKoqNfOSffWxurTSsoKrBvVBCKODZzyfcNYq(){
        var clasx = new eMAzZrTLXnqJPFYxoCMlIQnKoqNfOSffWxurTSsoKrBvVBCKODZzyfcNYq();
        return  clasx;
    }

    public string RandomStringeMAzZrTLXnqJPFYxoCMlIQnKoqNfOSffWxurTSsoKrBvVBCKODZzyfcNYq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class WuIomJaHFQvEuXbslGniFHYnWzsejayfflJfSJsaLZKeVLsWvEXxvNCOWURnR
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

        public WuIomJaHFQvEuXbslGniFHYnWzsejayfflJfSJsaLZKeVLsWvEXxvNCOWURnR()
        {
            
        }
        public WuIomJaHFQvEuXbslGniFHYnWzsejayfflJfSJsaLZKeVLsWvEXxvNCOWURnR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public WuIomJaHFQvEuXbslGniFHYnWzsejayfflJfSJsaLZKeVLsWvEXxvNCOWURnR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public WuIomJaHFQvEuXbslGniFHYnWzsejayfflJfSJsaLZKeVLsWvEXxvNCOWURnR GetWuIomJaHFQvEuXbslGniFHYnWzsejayfflJfSJsaLZKeVLsWvEXxvNCOWURnR(){
        var clasx = new WuIomJaHFQvEuXbslGniFHYnWzsejayfflJfSJsaLZKeVLsWvEXxvNCOWURnR();
        return  clasx;
    }

    public string RandomStringWuIomJaHFQvEuXbslGniFHYnWzsejayfflJfSJsaLZKeVLsWvEXxvNCOWURnR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class lNNSxTqLwZdLVMtbzEIxAzlRPiaMIuxeNR
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

        public lNNSxTqLwZdLVMtbzEIxAzlRPiaMIuxeNR()
        {
            
        }
        public lNNSxTqLwZdLVMtbzEIxAzlRPiaMIuxeNR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public lNNSxTqLwZdLVMtbzEIxAzlRPiaMIuxeNR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public lNNSxTqLwZdLVMtbzEIxAzlRPiaMIuxeNR GetlNNSxTqLwZdLVMtbzEIxAzlRPiaMIuxeNR(){
        var clasx = new lNNSxTqLwZdLVMtbzEIxAzlRPiaMIuxeNR();
        return  clasx;
    }

    public string RandomStringlNNSxTqLwZdLVMtbzEIxAzlRPiaMIuxeNR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rXlCXlxXMvszZzbxvYDFzODnSgXfaVlZPZgaMERssskoCqnJ
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

        public rXlCXlxXMvszZzbxvYDFzODnSgXfaVlZPZgaMERssskoCqnJ()
        {
            
        }
        public rXlCXlxXMvszZzbxvYDFzODnSgXfaVlZPZgaMERssskoCqnJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rXlCXlxXMvszZzbxvYDFzODnSgXfaVlZPZgaMERssskoCqnJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rXlCXlxXMvszZzbxvYDFzODnSgXfaVlZPZgaMERssskoCqnJ GetrXlCXlxXMvszZzbxvYDFzODnSgXfaVlZPZgaMERssskoCqnJ(){
        var clasx = new rXlCXlxXMvszZzbxvYDFzODnSgXfaVlZPZgaMERssskoCqnJ();
        return  clasx;
    }

    public string RandomStringrXlCXlxXMvszZzbxvYDFzODnSgXfaVlZPZgaMERssskoCqnJ(int length)
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
