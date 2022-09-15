using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
    [AddComponentMenu ("RayFire/Rayfire Vortex")]
    [HelpURL ("http://rayfirestudios.com/unity-online-help/unity-vortex-component/")]
    public class RayfireVortex : MonoBehaviour
    {
        [Header ("Hidden")]
        [HideInInspector]
        public Transform transForm;
        [HideInInspector]
        public Collider[] colliders;
        [HideInInspector]
        public List<Rigidbody> rigidbodies = new List<Rigidbody>();
        [HideInInspector]
        public List<Rigidbody> myRigidbodies = new List<Rigidbody>(); // TODO custom list
        Vector3 bot;
        Vector3 top;
        Vector3 normal;
        Vector3 direction;

        // Local vars
        Vector3 rbPos;
        Vector3 linePoint;
        Vector3 vectorUp;
        Vector3 centerOutVector;
        Vector3 vectorCenter;
        Vector3 perpend;
        Vector3 vectorSwirl;
        Vector3 forceVector;
        float   distancePerpend;
        float   distanceBottom;
        float   upRateNow;
        float   localRadius;
        float   upRateOwn;
        float   centerRateOwn;
        float   centerRateNow;
        float   upRateDif;
        float   centerRateDif;
        float   maxRadius;
        float   axisDistance;
        Plane   bottomPlane;
        float   torqueVal;

        [Header ("Anchor points")]
        public Vector3 topAnchor = new Vector3 (3, 30, 2);
        public Vector3 bottomAnchor = new Vector3 (0, 0, 0);

        [Header ("Gizmo")]
        [Range (0.1f, 50f)]
        public float topRadius = 15f;
        [Range (0.0f, 50f)]
        public float bottomRadius = 3f;

        [Header ("Eye")]
        [Range (0.05f, 0.9f)]
        public float eye = 0.1f;

        [Header ("Strength")]
        public bool forceByMass = true;
        [Range (1, 10)]
        public float stiffness = 1f;

        //[Range(0, 10)] public float upStr = 1f;
        [Range (-40f, 40)]
        public float swirlStrength = 10f;

        [Header ("Torque")]
        public bool enableTorque = true;
        [Range (-1f, 1f)]
        public float torqueStrength = 0.5f;
        [Range (0f, 1f)]
        public float torqueVariation = 0.5f;

        [Header ("Height bias")]
        public bool enableHeightBias = true;
        [Range (0f, 1f)]
        public float biasSpeed = 0.025f;
        [Range (0f, 1f)]
        public float biasSpread = 1;

        [Header ("Seed")]
        [Range (0, 100)]
        public int seed = 0;

        [Header ("Preview")]
        [Range (2, 10)]
        public int circles = 3;
        [HideInInspector]
        public bool showGizmo = true;
        [HideInInspector]
        public bool topHandle = false;

        [Header ("Filters")]
        [HideInInspector]
        public int mask = -1;
        [HideInInspector]
        public string tagFilter = "Untagged";

        //public Collider[] occluders = null;
        //public Collider[] occluded = null;
        /// /////////////////////////////////////////////////////////
        /// Common
        /// /////////////////////////////////////////////////////////

        // Awake
        void Awake()
        {
            // Cache variables
            DefineComponents();
        }

        // Cache variables
        void DefineComponents()
        {
            // Cache transform
            transForm = GetComponent<Transform>();

            // Set base length
            colliders = new Collider[10];
        }

        // Main vortex force coroutine
        IEnumerator VortexForceCor()
        {
            yield return new WaitForSeconds (Random.Range (0f, 0.95f));

            while (enabled == true)
            {
                // Set force to rigid bodies
                SetForce();

                yield return new WaitForSeconds (0.066f);
            }
        }

        // Set colliders coroutine
        IEnumerator SetCollidersCor()
        {
            // Set collider gizmo info
            SetColliderGizmo();

            yield return new WaitForSeconds (Random.Range (0f, 0.95f));

            while (enabled == true)
            {
                // Get all colliders inside gizmo
                SetColliders();

                // Set rigid bodies by colliders
                SetRigidBodies();

                yield return new WaitForSeconds (0.3f);
            }
        }

        // Enabling
       
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
 private void OnEnable()
        {
            // Set colliders coroutine
            StartCoroutine (SetCollidersCor());

            // Main wind force coroutine
            StartCoroutine (VortexForceCor());
        }

        /// /////////////////////////////////////////////////////////
        /// Setups
        /// /////////////////////////////////////////////////////////

        // Set colliders by range type
        void SetColliders()
        {
            // Get overlaps
            int colAmount = Physics.OverlapCapsuleNonAlloc (bot, top, maxRadius, colliders, mask);

            // Increase array if not enough
            if (colAmount == colliders.Length)
            {
                colliders = new Collider[colAmount + 30];
                Physics.OverlapCapsuleNonAlloc (bot, top, maxRadius, colliders, mask);
            }

            // Decrease array if too much
            if (colliders.Length > colAmount + 50)
            {
                colliders = new Collider[colAmount - 30];
                Physics.OverlapCapsuleNonAlloc (bot, top, maxRadius, colliders, mask);
            }

            // Get overlapped colliders
            // colliders = Physics.OverlapCapsule(bot, top, maxRadius, mask);


            // Occlude
            //if (occluders.Length > 0)
            //{
            //    occluded = Physics.OverlapBox(occluders[0].bounds.center, occluders[0].bounds.extents, occluders[0].transform.rotation);
            //    if (occluded.Length > 0)
            //    {
            //        Debug.Log(occluded.Length);
            //        for (int i = occluded.Length - 1; i >= 0; i--)
            //        {

            //        }
            //    }
            //}
        }

        // Set collider gizmo info
        void SetColliderGizmo()
        {
            bot          = transForm.TransformPoint (bottomAnchor);
            top          = transForm.TransformPoint (topAnchor);
            direction    = top - bot;
            normal       = transform.up;
            axisDistance = topAnchor.y - bottomAnchor.y;
            maxRadius    = topRadius;
            if (bottomRadius > topRadius)
                maxRadius = bottomRadius;
            bottomPlane = new Plane (transform.up, bot);
        }

        // Set rigid bodies by colliders
        void SetRigidBodies()
        {
            rigidbodies.Clear();

            // Collect all rigid bodies in range
            foreach (Collider col in colliders)
            {
                // Missing collider
                if (col == null)
                    continue;

                // Tag filter
                if (tagFilter != "Untagged" && col.tag != tagFilter)
                    continue;

                // Get attached rigid body
                Rigidbody rb = col.attachedRigidbody;

                // Create projectile if rigid body new. Could be several colliders on one object.
                if (rb != null && rb.isKinematic == false && rigidbodies.Contains (rb) == false)
                    rigidbodies.Add (rb);
            }
        }

        // Apply explosion force, vector and rotation to projectiles
        void SetForce()
        {
            // Set collider gizmo info
            SetColliderGizmo();

            // Set forceMode by mass state
            ForceMode forceMode = ForceMode.Impulse;
            if (forceByMass == false)
                forceMode = ForceMode.VelocityChange;

            // Get str for each object by expl type with variation
            foreach (Rigidbody rb in rigidbodies)
            {
                // Null check
                if (rb == null)
                    continue;

                // Instance id for same random values
                int instanceId = rb.GetInstanceID();

                // Set same random state
                Random.InitState (instanceId + seed);

                // Get position
                rbPos = rb.transform.position;

                // Closest point on axis
                linePoint = GetClosetLinePoint (rbPos); // TODO get on same plane

                // Get distance perpendicular to axis
                distancePerpend = Vector3.Distance (linePoint, rbPos);

                // Get distance to bottom plane
                distanceBottom = bottomPlane.GetDistanceToPoint (linePoint);

                // Current height rate for up bias
                upRateNow = distanceBottom / axisDistance;

                // Below vortex
                if (bottomPlane.GetSide (linePoint) == false)
                    upRateNow = -upRateNow;

                // Get local radius
                localRadius = Mathf.Lerp (bottomRadius, topRadius, upRateNow);

                // Object not in range
                if (localRadius < distancePerpend)
                    continue;

                // Get random height and depth rates
                upRateOwn     = Random.Range (0.03f, 0.97f);
                centerRateOwn = Random.Range (eye,   0.90f);

                // Height bias for upRateOwn
                if (enableHeightBias == true)
                    upRateOwn = HeightBias (upRateOwn, centerRateOwn);

                // Get current depth rate for center bias
                centerRateNow = distancePerpend / localRadius;

                // Get rate differences to correct current position
                upRateDif     = (upRateOwn - upRateNow) * stiffness;
                centerRateDif = (centerRateOwn - centerRateNow) * stiffness;

                // Up vector
                vectorUp = upRateDif * (stiffness + 2f) * normal; // upStr;

                // Normalized vector from axis to rigid object
                centerOutVector = (rbPos - linePoint).normalized;

                // Vector to center
                vectorCenter = Mathf.Abs (swirlStrength) * centerRateDif * centerOutVector;

                // Swirl vector parallel to plane
                perpend     = Vector3.Cross (normal, centerOutVector);
                vectorSwirl = swirlStrength * perpend.normalized;

                // Get final force vector
                forceVector = vectorUp + vectorCenter + vectorSwirl;

                // Apply force
                rb.velocity = Vector3.zero;
                rb.AddForce (forceVector, forceMode);

                // Set rotation impulse TODO add variation
                if (enableTorque == true)
                {
                    torqueVal = (torqueStrength + Random.Range (-torqueVariation, torqueVariation)) * 10f;
                    rb.AddTorque (torqueVal * swirlStrength * Random.Range (0.0f, 1f) * transForm.up, forceMode);
                }
            }
        }

        /// /////////////////////////////////////////////////////////
        /// Other
        /// /////////////////////////////////////////////////////////

        // Get Closest Point On Vortex Axis
        Vector3 GetClosetLinePoint (Vector3 worldPos)
        {
            Vector3 vectorToPos = worldPos - bot;
            Vector3 projection  = Vector3.Project (vectorToPos, direction);
            return projection + bot;
        }

        // Get Point On Vortex Axis with same Y as worldPos
        Vector3 GetParallelLinePoint (Vector3 worldPos)
        {
            // Plane with direction of Y axis and position of worldPos
            // Plane bottomPlane = new Plane(transform.up, worldPos);
            // Mathf.PingPong();

            Vector3 vectorToPos = worldPos - bot;
            Vector3 projection  = Vector3.Project (vectorToPos, direction);
            return projection + bot;
        }

        //
        public static bool LinePlaneIntersection (out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
        {
            float   length;
            Vector3 vector;
            intersection = Vector3.zero;

            //calculate the distance between the linePoint and the line-plane intersection point
            float dotNumerator   = Vector3.Dot (planePoint - linePoint, planeNormal);
            float dotDenominator = Vector3.Dot (lineVec,                planeNormal);

            //line and plane are not parallel
            if (dotDenominator != 0.0f)
            {
                length = dotNumerator / dotDenominator;

                //create a vector from the linePoint to the intersection point
                vector = SetVectorLength (lineVec, length);

                //get the coordinates of the line-plane intersection point
                intersection = linePoint + vector;

                return true;
            }

            //output not valid
            return false;
        }

        // Create a vector of direction "vector" with length "size"
        static Vector3 SetVectorLength (Vector3 vector, float size)
        {
            // normalize the vector
            Vector3 vectorNormalized = Vector3.Normalize (vector);

            // scale the vector
            return vectorNormalized *= size;
        }

        // Get height by height bias
        float HeightBias (float upRateOwnLoc, float centerRateOwnLoc)
        {
            if (biasSpread > 0)
            {
                // Get Perlin noise bias
                float perlinVal = Mathf.PerlinNoise (Time.time * biasSpeed * centerRateOwnLoc, upRateOwnLoc) * biasSpread;

                // Get poitive/negative offset
                int biasMult = 1;
                if (Random.value >= 0.5)
                    biasMult = -1;

                // Get local bias
                float biasLocal = perlinVal * biasMult;

                // Adjust up rate
                upRateOwnLoc += biasLocal;

                // Fix upRate
                if (upRateOwnLoc > 1.0f)
                {
                    if (upRateOwnLoc > 2.0f)
                        upRateOwnLoc -= 2f;
                    else
                        upRateOwnLoc = 1f - (upRateOwnLoc - 1.0f);
                }
                else if (upRateOwnLoc < 0.0f)
                {
                    if (upRateOwnLoc < -1.0f)
                        upRateOwnLoc += 2f;
                    else
                        upRateOwnLoc = -upRateOwnLoc;
                }
            }

            return upRateOwnLoc;
        }
    }
}

 
