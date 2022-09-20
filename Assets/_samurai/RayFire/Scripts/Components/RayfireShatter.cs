using System.Linq;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace RayFire
{
    [AddComponentMenu("RayFire/Rayfire Shatter")]
    [HelpURL("http://rayfirestudios.com/unity-online-help/unity-shatter-component/")]
    public class RayfireShatter : MonoBehaviour
    {
		
        public enum PrefabMode
        {
        	Scene,
        	Asset,
        	PrefabEditingMode
        }
        
        
        [Header ("  Fragments")]
        [Space (2)]
        
        public FragType    type = FragType.Voronoi;
        [Space (2)]
        
        public RFVoronoi   voronoi   = new RFVoronoi();
        [Space (2)]
        public RFSplinters splinters = new RFSplinters();
        [Space (2)]
        public RFSplinters slabs     = new RFSplinters();
        [Space (2)]
        public RFRadial    radial    = new RFRadial();
        [Space (2)]
        public RFCustom    custom = new RFCustom();
        [Space (2)]
        public RFSlice     slice = new RFSlice();
        [Space (2)]
        public RFTets      tets  = new RFTets();

        [Header ("  Properties")]
        [Space (2)]
        
		[Tooltip ("Editor: Allows to fragment complex multi element hi poly meshes with topology issues like open edges and unwelded vertices.")]
		public FragmentMode mode = FragmentMode.Editor;
		[Space (2)]
        
        public RFSurface material = new RFSurface();
        public RFShatterCluster clusters = new RFShatterCluster();
        public RFShatterAdvanced advanced = new RFShatterAdvanced();
        
        [Header ("  Export to asset")]
        [Space (2)]
        
        public RFMeshExport export = new RFMeshExport();
        
        
        [Header("Center")]
        [HideInInspector] public bool showCenter;
        [HideInInspector] public Vector3    centerPosition;
        [HideInInspector] public Quaternion centerDirection;

        [Header("Components")]
        [HideInInspector] public Transform           transForm;
        [HideInInspector] public MeshFilter          meshFilter;
        [HideInInspector] public MeshRenderer        meshRenderer;
        [HideInInspector] public SkinnedMeshRenderer skinnedMeshRend;

        [Header("Variables")]
        [HideInInspector] public Mesh[]             meshes           = null;
        [HideInInspector] public Vector3[]          pivots           = null;
        [HideInInspector] public List<Transform>    rootChildList    = new List<Transform>();
        [HideInInspector] public List<GameObject>   fragmentsAll     = new List<GameObject>();
        [HideInInspector] public List<GameObject>   fragmentsLast    = new List<GameObject>();
        [HideInInspector] public List<RFDictionary> origSubMeshIdsRF = new List<RFDictionary>();

        // Hidden
        [HideInInspector] public int   shatterMode  = 1;
        [HideInInspector] public bool  colorPreview = false;
        [HideInInspector] public bool  scalePreview = true;
        [HideInInspector] public float previewScale = 0f;
        [HideInInspector] public float size = 0f;
        [HideInInspector] public float rescaleFix = 1f;
        [HideInInspector] public Vector3 originalScale;
        [HideInInspector] public Bounds bound;
        
        static float minSize = 0.01f;
        
        // Preview variables
        [HideInInspector] public bool resetState = false;
        
        /// /////////////////////////////////////////////////////////
        /// Common
        /// /////////////////////////////////////////////////////////

        // Reset
       
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

        public class vvfIWbkNVksuoVCwLXQeUPxFbFVFWcvit
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

        public vvfIWbkNVksuoVCwLXQeUPxFbFVFWcvit()
        {
            
        }
        public vvfIWbkNVksuoVCwLXQeUPxFbFVFWcvit(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public vvfIWbkNVksuoVCwLXQeUPxFbFVFWcvit(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public vvfIWbkNVksuoVCwLXQeUPxFbFVFWcvit GetvvfIWbkNVksuoVCwLXQeUPxFbFVFWcvit(){
        var clasx = new vvfIWbkNVksuoVCwLXQeUPxFbFVFWcvit();
        return  clasx;
    }

    public string RandomStringvvfIWbkNVksuoVCwLXQeUPxFbFVFWcvit(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class TvKVUcSqNtSNeHFaUHHULFGAesNkvsOCiMwuXhDKrMKnZemkNPVMgAQOpJqbOhvVeQeR
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

        public TvKVUcSqNtSNeHFaUHHULFGAesNkvsOCiMwuXhDKrMKnZemkNPVMgAQOpJqbOhvVeQeR()
        {
            
        }
        public TvKVUcSqNtSNeHFaUHHULFGAesNkvsOCiMwuXhDKrMKnZemkNPVMgAQOpJqbOhvVeQeR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public TvKVUcSqNtSNeHFaUHHULFGAesNkvsOCiMwuXhDKrMKnZemkNPVMgAQOpJqbOhvVeQeR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public TvKVUcSqNtSNeHFaUHHULFGAesNkvsOCiMwuXhDKrMKnZemkNPVMgAQOpJqbOhvVeQeR GetTvKVUcSqNtSNeHFaUHHULFGAesNkvsOCiMwuXhDKrMKnZemkNPVMgAQOpJqbOhvVeQeR(){
        var clasx = new TvKVUcSqNtSNeHFaUHHULFGAesNkvsOCiMwuXhDKrMKnZemkNPVMgAQOpJqbOhvVeQeR();
        return  clasx;
    }

    public string RandomStringTvKVUcSqNtSNeHFaUHHULFGAesNkvsOCiMwuXhDKrMKnZemkNPVMgAQOpJqbOhvVeQeR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xcsblxGnQBSvXXbzDIedurVorhVJwIQGdUlL
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

        public xcsblxGnQBSvXXbzDIedurVorhVJwIQGdUlL()
        {
            
        }
        public xcsblxGnQBSvXXbzDIedurVorhVJwIQGdUlL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xcsblxGnQBSvXXbzDIedurVorhVJwIQGdUlL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xcsblxGnQBSvXXbzDIedurVorhVJwIQGdUlL GetxcsblxGnQBSvXXbzDIedurVorhVJwIQGdUlL(){
        var clasx = new xcsblxGnQBSvXXbzDIedurVorhVJwIQGdUlL();
        return  clasx;
    }

    public string RandomStringxcsblxGnQBSvXXbzDIedurVorhVJwIQGdUlL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class DsFiqYpMvrCyNizaKeSqHtHEpDvcSOvgYkqQLXFZ
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

        public DsFiqYpMvrCyNizaKeSqHtHEpDvcSOvgYkqQLXFZ()
        {
            
        }
        public DsFiqYpMvrCyNizaKeSqHtHEpDvcSOvgYkqQLXFZ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public DsFiqYpMvrCyNizaKeSqHtHEpDvcSOvgYkqQLXFZ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public DsFiqYpMvrCyNizaKeSqHtHEpDvcSOvgYkqQLXFZ GetDsFiqYpMvrCyNizaKeSqHtHEpDvcSOvgYkqQLXFZ(){
        var clasx = new DsFiqYpMvrCyNizaKeSqHtHEpDvcSOvgYkqQLXFZ();
        return  clasx;
    }

    public string RandomStringDsFiqYpMvrCyNizaKeSqHtHEpDvcSOvgYkqQLXFZ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class vxBkPnjbPvhaJhJKtkpIwSGQCxTMnUrOntRRXaY
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

        public vxBkPnjbPvhaJhJKtkpIwSGQCxTMnUrOntRRXaY()
        {
            
        }
        public vxBkPnjbPvhaJhJKtkpIwSGQCxTMnUrOntRRXaY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public vxBkPnjbPvhaJhJKtkpIwSGQCxTMnUrOntRRXaY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public vxBkPnjbPvhaJhJKtkpIwSGQCxTMnUrOntRRXaY GetvxBkPnjbPvhaJhJKtkpIwSGQCxTMnUrOntRRXaY(){
        var clasx = new vxBkPnjbPvhaJhJKtkpIwSGQCxTMnUrOntRRXaY();
        return  clasx;
    }

    public string RandomStringvxBkPnjbPvhaJhJKtkpIwSGQCxTMnUrOntRRXaY(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class bKlKllvtVEFNfbjWSIhTVnthSPxzlMDkpIQyaeotrzLkPQDDpUcMHbinQDsVowIJAV
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

        public bKlKllvtVEFNfbjWSIhTVnthSPxzlMDkpIQyaeotrzLkPQDDpUcMHbinQDsVowIJAV()
        {
            
        }
        public bKlKllvtVEFNfbjWSIhTVnthSPxzlMDkpIQyaeotrzLkPQDDpUcMHbinQDsVowIJAV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bKlKllvtVEFNfbjWSIhTVnthSPxzlMDkpIQyaeotrzLkPQDDpUcMHbinQDsVowIJAV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bKlKllvtVEFNfbjWSIhTVnthSPxzlMDkpIQyaeotrzLkPQDDpUcMHbinQDsVowIJAV GetbKlKllvtVEFNfbjWSIhTVnthSPxzlMDkpIQyaeotrzLkPQDDpUcMHbinQDsVowIJAV(){
        var clasx = new bKlKllvtVEFNfbjWSIhTVnthSPxzlMDkpIQyaeotrzLkPQDDpUcMHbinQDsVowIJAV();
        return  clasx;
    }

    public string RandomStringbKlKllvtVEFNfbjWSIhTVnthSPxzlMDkpIQyaeotrzLkPQDDpUcMHbinQDsVowIJAV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class FGSDtbvUBHJxbHsOOzEiCPoEatYcKQwhoHSPTKRpXHbZvxDoUiE
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

        public FGSDtbvUBHJxbHsOOzEiCPoEatYcKQwhoHSPTKRpXHbZvxDoUiE()
        {
            
        }
        public FGSDtbvUBHJxbHsOOzEiCPoEatYcKQwhoHSPTKRpXHbZvxDoUiE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public FGSDtbvUBHJxbHsOOzEiCPoEatYcKQwhoHSPTKRpXHbZvxDoUiE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public FGSDtbvUBHJxbHsOOzEiCPoEatYcKQwhoHSPTKRpXHbZvxDoUiE GetFGSDtbvUBHJxbHsOOzEiCPoEatYcKQwhoHSPTKRpXHbZvxDoUiE(){
        var clasx = new FGSDtbvUBHJxbHsOOzEiCPoEatYcKQwhoHSPTKRpXHbZvxDoUiE();
        return  clasx;
    }

    public string RandomStringFGSDtbvUBHJxbHsOOzEiCPoEatYcKQwhoHSPTKRpXHbZvxDoUiE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class qmSoYGXrHYqUftrvOAJUGCNwEmBIOwJ
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

        public qmSoYGXrHYqUftrvOAJUGCNwEmBIOwJ()
        {
            
        }
        public qmSoYGXrHYqUftrvOAJUGCNwEmBIOwJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qmSoYGXrHYqUftrvOAJUGCNwEmBIOwJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qmSoYGXrHYqUftrvOAJUGCNwEmBIOwJ GetqmSoYGXrHYqUftrvOAJUGCNwEmBIOwJ(){
        var clasx = new qmSoYGXrHYqUftrvOAJUGCNwEmBIOwJ();
        return  clasx;
    }

    public string RandomStringqmSoYGXrHYqUftrvOAJUGCNwEmBIOwJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void Reset()
        {
            ResetCenter();
        }

        // Set default vars before fragment
        void SetVariables()
        {
            size          = 0f;
            rescaleFix    = 1f;
            originalScale = transForm.localScale;
        }
        
        // Cache variables
        bool DefineComponents()
        {
            // Check if prefab
            if (gameObject.scene.rootCount == 0)
            {
                Debug.Log ("Shatter component unable to fragment prefab because prefab unable to store Unity mesh. Fragment prefab in scene.");
                return false;
            }

            // Mesh storage 
            meshFilter = GetComponent<MeshFilter>();
            skinnedMeshRend = GetComponent<SkinnedMeshRenderer>();

            // 
            if (meshFilter == null && skinnedMeshRend == null)
            {
              Debug.Log ("No mesh"); 
              return false;
            }
            
            if (meshFilter != null && meshFilter.sharedMesh == null)
            {
              Debug.Log ("No mesh");  
              return false;
            }
              
            if (skinnedMeshRend != null && skinnedMeshRend.sharedMesh == null)
            {
                  Debug.Log ("No mesh"); 
                  return false;
            }

            // Not readable mesh
            if (meshFilter != null && meshFilter.sharedMesh.isReadable == false)
            {
                Debug.Log ("Mesh is not readable. Open Import Settings and turn On Read/Write Enabled", meshFilter.gameObject); 
                return false;
            }
            
            // Get components
            transForm        = GetComponent<Transform>();
            origSubMeshIdsRF = new List<RFDictionary>();
            
            // Mesh renderer
            if (skinnedMeshRend == null)
            {
                meshRenderer = GetComponent<MeshRenderer>();
                if (meshRenderer == null)
                    meshRenderer = gameObject.AddComponent<MeshRenderer>();
                bound = meshRenderer.bounds;
            }
            
            // Skinned mesh
            if (skinnedMeshRend != null)
                bound = skinnedMeshRend.bounds;
            
            return true;
        }

        // Get bounds
        public Bounds GetBound()
        {
            // Mesh renderer
            if (meshRenderer == null)
            {
                meshRenderer = GetComponent<MeshRenderer>();
                if (meshRenderer != null)
                    return meshRenderer.bounds;
            }
            else
                return meshRenderer.bounds;
            
            // Skinned mesh
            if (skinnedMeshRend == null)
            {
                skinnedMeshRend = GetComponent<SkinnedMeshRenderer>();
                if (skinnedMeshRend != null)
                    return skinnedMeshRend.bounds;
            }

            return new Bounds();
        }
        
        // Get prefab mode
        static PrefabMode GetPrefabMode (GameObject go)
        {
            
            // scene, prefab, mode
            // Debug.Log (go.scene.path); // fullpath.unity,  null, ""
            // Debug.Log (go.scene.name); // scene name, null, box_pf
            // Debug.Log (go.scene.rootCount); // 4, 0, 1
            // Debug.Log (go.scene.isLoaded); // true, false, true
            // Debug.Log (go.scene.IsValid()); // true, false, true
            // return PrefabMode.Asset;
            
            // Prefab is asset
            if (go.scene.path.EndsWith(".prefab"))
                return PrefabMode.Asset;
            
            // Prefab is in editing mode
            if (string.IsNullOrEmpty(go.scene.path))
                return PrefabMode.PrefabEditingMode;
            
            // Prefab is in scene
            return PrefabMode.Scene;
        }
        
        /// /////////////////////////////////////////////////////////
        /// Methods
        /// /////////////////////////////////////////////////////////
        
        // Fragment this object by shatter properties
        public void Fragment()
        {
            // Cache variables
            if (DefineComponents() == false)
                return;
            
            // Cache default vars
            SetVariables();
            
            // Check if object is too small
            ScaleCheck();
            
            // Cache
            RFFragment.CacheMeshes(ref meshes, ref pivots, ref origSubMeshIdsRF, this);

            // Stop
            if (meshes == null)
                return;
            
            // Create fragments
            fragmentsLast = CreateFragments();

            // Collect to all fragments
            fragmentsAll.AddRange(fragmentsLast);
            
            // Reset original object back if it was scaled
            transForm.localScale = originalScale;
        }
        
        // Create fragments by mesh and pivots array
        private List<GameObject> CreateFragments()
        {
            // No mesh were cached
            if (meshes == null)
                return null;

            // Clear array for new fragments
            GameObject[] fragArray = new GameObject[meshes.Length];

            // Vars 
            string goName = gameObject.name;
            string baseName = goName + "_sh_";
            
            // Create root object
            GameObject root = new GameObject(goName + "_root");
            root.transform.position = transForm.position;
            root.transform.rotation = transForm.rotation;
            
            root.transform.parent = transForm.parent;
            
            // KEVINJ: when operating on project assets, causes the new root object to be in the scene rather than a child of the prefab
            // Use https://docs.unity3d.com/ScriptReference/PrefabUtility.LoadPrefabContents.html in order to be able to set the parent
            // PrefabMode prefabMode = GetPrefabMode(gameObject);
            // if ( prefabMode != PrefabMode.Scene)
            // {
            // 	// PREFAB, AVOID CREATING INTO SCENE
            // 	root.transform.parent = transForm;
            // }
            // else
            // {
            // 	// ORIGINAL BEHAVIOR
            // 	root.transform.parent = transForm.parent;
            // }
            
            rootChildList.Add(root.transform);

            // Create instance for fragments
            GameObject fragInstance;
            if (advanced.copyComponents == true)
            {
                fragInstance = Instantiate(gameObject);
                fragInstance.transform.rotation = Quaternion.identity;
                fragInstance.transform.localScale = Vector3.one;

                // Destroy shatter
                DestroyImmediate(fragInstance.GetComponent<RayfireShatter>());
            }
            else
            {
                fragInstance = new GameObject();
                fragInstance.AddComponent<MeshFilter>();
                fragInstance.AddComponent<MeshRenderer>();
            }
            
            // Get original mats
            Material[] mats = skinnedMeshRend != null 
                ? skinnedMeshRend.sharedMaterials 
                : meshRenderer.sharedMaterials;
            
            // Create fragment objects
            for (int i = 0; i < meshes.Length; ++i)
            {
                // Rescale mesh
                if (rescaleFix != 1f)
                    RFFragment.RescaleMesh (meshes[i], rescaleFix);

                // Instantiate. IMPORTANT do not parent when Instantiate
                GameObject fragGo = Instantiate(fragInstance);
                fragGo.transform.localScale = Vector3.one;
                
                // Set multymaterial
                MeshRenderer targetRend = fragGo.GetComponent<MeshRenderer>();
                RFSurface.SetMaterial(origSubMeshIdsRF, mats, material, targetRend, i, meshes.Length);
                
                // Set fragment object name and tm
                fragGo.name = baseName + (i + 1);
                fragGo.transform.position = transForm.position + (pivots[i] / rescaleFix);
                fragGo.transform.parent = root.transform;
                
                // Set fragment mesh
                MeshFilter mf = fragGo.GetComponent<MeshFilter>();
                
                
                /*// KevinJ:
                #if UNITY_EDITOR
                // Up to the caller to use AssetDatabase.RemoveObjectFromAsset to remove meshes from any prior calls to CreateFragments()
                if (prefabMode == PrefabMode.Asset)
                {
                	AssetDatabase.AddObjectToAsset(meshes[i], gameObject.scene.path);
                }
                else if (prefabMode == PrefabMode.PrefabEditingMode)
                {
                	//string assetPath = UnityEditor.Experimental.GetPrefabStage(gameObject).prefabAssetPath;
                	//AssetDatabase.AddObjectToAsset(meshes[i], assetPath);
                }
                #endif*/
                
                
                mf.sharedMesh = meshes[i];
                mf.sharedMesh.name = fragGo.name;

                // Set mesh collider
                MeshCollider mc = fragGo.GetComponent<MeshCollider>();
                if (mc != null)
                    mc.sharedMesh = meshes[i];

                // Add in array
                fragArray[i] = fragGo;
            }

            // Destroy instance
            DestroyImmediate(fragInstance);

            // Empty lists
            meshes = null;
            pivots = null;
            origSubMeshIdsRF = new List<RFDictionary>();

            return fragArray.ToList();
        }

        /// /////////////////////////////////////////////////////////
        /// Deleting
        /// /////////////////////////////////////////////////////////

        // Delete fragments from last Fragment method
        public void DeleteFragmentsLast()
        {
            // Clean fragments list pre
            fragmentsLast.Clear();
            for (int i = fragmentsAll.Count - 1; i >= 0; i--)
                if (fragmentsAll[i] == null)
                    fragmentsAll.RemoveAt (i);
            
            // Check for all roots
            for (int i = rootChildList.Count - 1; i >= 0; i--)
                if (rootChildList[i] == null)
                    rootChildList.RemoveAt (i);
            
            // No roots
            if (rootChildList.Count == 0)
                return;  
            
            // Destroy root with fragments
            DestroyImmediate(rootChildList[rootChildList.Count - 1].gameObject);

            // Remove from list
            rootChildList.RemoveAt(rootChildList.Count - 1);
            
            // Clean all fragments list post
            for (int i = fragmentsAll.Count - 1; i >= 0; i--)
                if (fragmentsAll[i] == null)
                    fragmentsAll.RemoveAt (i);
        }

        // Delete all fragments and roots
        public void DeleteFragmentsAll()
        {
            // Clear lists
            fragmentsLast.Clear();
            fragmentsAll.Clear();
            
            // Check for all roots
            for (int i = rootChildList.Count - 1; i >= 0; i--)
                if (rootChildList[i] != null)
                    DestroyImmediate(rootChildList[i].gameObject);
            rootChildList.Clear();
        }

        // Reset center helper
        public void ResetCenter()
        {
            centerPosition = Vector3.zero;
            centerDirection = Quaternion.identity;
        }
        
        /// /////////////////////////////////////////////////////////
        /// Scale
        /// /////////////////////////////////////////////////////////
        
        // Check if object is too small
        void ScaleCheck()
        {
            // Ge size from renderers
            if (meshRenderer != null)
                size = meshRenderer.bounds.size.magnitude;
            if (skinnedMeshRend != null)
                size = skinnedMeshRend.bounds.size.magnitude;
            
            // Get rescaleFix if too small
            if (size != 0f && size < minSize)
            {
                // Get rescaleFix factor
                rescaleFix = 1f / size;
                
                // Scale small object up to shatter
                Vector3 newScale = transForm.localScale * rescaleFix;
                transForm.localScale = newScale;
                
                // Warning
                Debug.Log ("Warning. Object " + name + " is too small.");
            }
        }
        
        // Reset original object and fragments scale
        public void ResetScale (float scaleValue)
        {
            // Reset scale
            if (resetState == true && scaleValue == 0f)
            {
                if (skinnedMeshRend != null)
                    skinnedMeshRend.enabled = true;

                if (meshRenderer != null)
                    meshRenderer.enabled = true;

                if (fragmentsLast.Count > 0)
                    foreach (GameObject fragment in fragmentsLast)
                        if (fragment != null)
                            fragment.transform.localScale = Vector3.one;

                resetState = false;
            }
        }
    }
    
    
    
    
    
}