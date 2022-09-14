using UnityEngine;
using UnityEditor;

namespace RayFire
{
    [CanEditMultipleObjects]
    [CustomEditor (typeof(RayfireActivator))]
    public class RayfireActivatorEditor : Editor
    {
        // Draw gizmo
        [DrawGizmo (GizmoType.Selected | GizmoType.NonSelected | GizmoType.Pickable)]
        static void DrawGizmosSelected (RayfireActivator activator, GizmoType gizmoType)
        {
            // Gizmo preview
            if (activator.showGizmo == true)
            {

                Color wireColor = new Color (0.58f, 0.77f, 1f);

                // Gizmo properties
                Gizmos.color  = wireColor;
                Gizmos.matrix = activator.transform.localToWorldMatrix;

                // Box gizmo
                if (activator.gizmoType == RayfireActivator.GizmoType.Box)
                {
                    // Offsets
                    float x = activator.boxSize.x / 2f;
                    float y = activator.boxSize.y / 2f;
                    float z = activator.boxSize.z / 2f;

                    // Get points
                    Vector3 p1 = new Vector3 (-x, -y, -z);
                    Vector3 p2 = new Vector3 (-x, -y, +z);
                    Vector3 p3 = new Vector3 (+x, -y, -z);
                    Vector3 p4 = new Vector3 (+x, -y, +z);
                    Vector3 p5 = new Vector3 (-x, y,  -z);
                    Vector3 p6 = new Vector3 (-x, y,  +z);
                    Vector3 p7 = new Vector3 (+x, y,  -z);
                    Vector3 p8 = new Vector3 (+x, y,  +z);

                    // Gizmo Lines
                    Gizmos.DrawLine (p1, p2);
                    Gizmos.DrawLine (p3, p4);
                    Gizmos.DrawLine (p5, p6);
                    Gizmos.DrawLine (p7, p8);
                    Gizmos.DrawLine (p1, p5);
                    Gizmos.DrawLine (p2, p6);
                    Gizmos.DrawLine (p3, p7);
                    Gizmos.DrawLine (p4, p8);
                    Gizmos.DrawLine (p1, p3);
                    Gizmos.DrawLine (p2, p4);
                    Gizmos.DrawLine (p5, p7);
                    Gizmos.DrawLine (p6, p8);

                    // Selectable sphere
                    float sphereSize = (x + y + z) * 0.03f;
                    if (sphereSize < 0.1f)
                        sphereSize = 0.1f;
                    Gizmos.color = new Color (1.0f, 0.60f, 0f);
                    Gizmos.DrawSphere (new Vector3 (x,  0, 0f), sphereSize);
                    Gizmos.DrawSphere (new Vector3 (-x, 0, 0f), sphereSize);
                    Gizmos.DrawSphere (new Vector3 (0f, 0, z),  sphereSize);
                    Gizmos.DrawSphere (new Vector3 (0f, 0, -z), sphereSize);
                }

                // Sphere gizmo
                if (activator.gizmoType == RayfireActivator.GizmoType.Sphere)
                {
                    // Vars
                    int   size   = 45;
                    float rate   = 0f;
                    float scale  = 1f / size;
                    float radius = activator.sphereRadius;

                    Vector3 previousPoint = Vector3.zero;
                    Vector3 nextPoint     = Vector3.zero;

                    // Draw top eye
                    rate            = 0f;
                    nextPoint.y     = 0f;
                    previousPoint.y = 0f;
                    previousPoint.x = radius * Mathf.Cos (rate);
                    previousPoint.z = radius * Mathf.Sin (rate);
                    for (int i = 0; i < size; i++)
                    {
                        rate        += 2.0f * Mathf.PI * scale;
                        nextPoint.x =  radius * Mathf.Cos (rate);
                        nextPoint.z =  radius * Mathf.Sin (rate);
                        Gizmos.DrawLine (previousPoint, nextPoint);
                        previousPoint = nextPoint;
                    }

                    // Draw top eye
                    rate            = 0f;
                    nextPoint.x     = 0f;
                    previousPoint.x = 0f;
                    previousPoint.y = radius * Mathf.Cos (rate);
                    previousPoint.z = radius * Mathf.Sin (rate);
                    for (int i = 0; i < size; i++)
                    {
                        rate        += 2.0f * Mathf.PI * scale;
                        nextPoint.y =  radius * Mathf.Cos (rate);
                        nextPoint.z =  radius * Mathf.Sin (rate);
                        Gizmos.DrawLine (previousPoint, nextPoint);
                        previousPoint = nextPoint;
                    }

                    // Draw top eye
                    rate            = 0f;
                    nextPoint.z     = 0f;
                    previousPoint.z = 0f;
                    previousPoint.y = radius * Mathf.Cos (rate);
                    previousPoint.x = radius * Mathf.Sin (rate);
                    for (int i = 0; i < size; i++)
                    {
                        rate        += 2.0f * Mathf.PI * scale;
                        nextPoint.y =  radius * Mathf.Cos (rate);
                        nextPoint.x =  radius * Mathf.Sin (rate);
                        Gizmos.DrawLine (previousPoint, nextPoint);
                        previousPoint = nextPoint;
                    }

                    // Selectable sphere
                    float sphereSize = radius * 0.07f;
                    if (sphereSize < 0.1f)
                        sphereSize = 0.1f;
                    Gizmos.color = new Color (1.0f, 0.60f, 0f);
                    Gizmos.DrawSphere (new Vector3 (0f,      radius,  0f),      sphereSize);
                    Gizmos.DrawSphere (new Vector3 (0f,      -radius, 0f),      sphereSize);
                    Gizmos.DrawSphere (new Vector3 (radius,  0f,      0f),      sphereSize);
                    Gizmos.DrawSphere (new Vector3 (-radius, 0f,      0f),      sphereSize);
                    Gizmos.DrawSphere (new Vector3 (0f,      0f,      radius),  sphereSize);
                    Gizmos.DrawSphere (new Vector3 (0f,      0f,      -radius), sphereSize);
                }
            }
        }

        // Sphere gizmo radius
       
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
 private void OnSceneGUI()
        {
            RayfireActivator activator = target as RayfireActivator;
            if (activator.gizmoType == RayfireActivator.GizmoType.Sphere)
            {
                var transform = activator.transform;

                // Draw handles
                EditorGUI.BeginChangeCheck();
                activator.sphereRadius = Handles.RadiusHandle (transform.rotation, transform.position, activator.sphereRadius, true);
                if (EditorGUI.EndChangeCheck() == true)
                {
                    Undo.RecordObject (activator, "Change Radius");
                }
            }
        }

        // Inspector
        public override void OnInspectorGUI()
        {
            // Get target
            RayfireActivator activator = target as RayfireActivator;

            // Space
            GUILayout.Space (8);

            // Buttons
            if (Application.isPlaying == true)
            {
                // Begin
                GUILayout.BeginHorizontal();

                // Cache buttons
                if (GUILayout.Button ("   Start   ", GUILayout.Height (25)))
                    foreach (var targ in targets)
                        if (targ as RayfireActivator != null)
                            (targ as RayfireActivator).TriggerAnimation();
                if (GUILayout.Button ("    Stop    ", GUILayout.Height (25)))
                    foreach (var targ in targets)
                        if (targ as RayfireActivator != null)
                            (targ as RayfireActivator).StopAnimation();
                if (GUILayout.Button ("Reset", GUILayout.Height (25)))
                    foreach (var targ in targets)
                        if (targ as RayfireActivator != null)
                            (targ as RayfireActivator).ResetAnimation();

                // End
                EditorGUILayout.EndHorizontal();
            }

            // Space
            GUILayout.Space (1);

            // Begin
            GUILayout.BeginHorizontal();

            // Cache buttons
            if (GUILayout.Button ("Add Position"))
                activator.AddPosition (activator.transform.position);
            if (GUILayout.Button ("Remove Last"))
                if (activator.positionList.Count > 0)
                    activator.positionList.RemoveAt (activator.positionList.Count - 1);
            if (GUILayout.Button ("Clear All"))
                activator.positionList.Clear();

            // End
            EditorGUILayout.EndHorizontal();

            // Space
            GUILayout.Space (3);

            // Positions info
            if (activator.positionList != null && activator.positionList.Count > 0)
            {
                GUILayout.Label ("Positions : " + activator.positionList.Count);

                // Space
                GUILayout.Space (2);
            }

            // Draw script UI
            DrawDefaultInspector();
        }
    }
}