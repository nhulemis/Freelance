using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace RayFire
{
    [CanEditMultipleObjects]
    [CustomEditor (typeof(RayfireBomb))]
    public class RayfireBombEditor : Editor
    {
        // Draw gizmo
        [DrawGizmo (GizmoType.Selected | GizmoType.NonSelected | GizmoType.Pickable)]
        static void DrawGizmosSelected (RayfireBomb bomb, GizmoType gizmoType)
        {
            if (bomb.showGizmo == true)
            {
                // Vars
                float       rate          = 0f;
                const int   size          = 45;
                const float scale         = 1f / size;
                Vector3     previousPoint = Vector3.zero;
                Vector3     nextPoint     = Vector3.zero;
                Color       wireColor     = new Color (0.58f, 0.77f, 1f);

                // Gizmo properties
                Gizmos.color  = wireColor;
                Gizmos.matrix = bomb.transform.localToWorldMatrix;

                // Draw top eye
                rate            = 0f;
                nextPoint.y     = 0f;
                previousPoint.y = 0f;
                previousPoint.x = bomb.range * Mathf.Cos (rate);
                previousPoint.z = bomb.range * Mathf.Sin (rate);
                for (int i = 0; i < size; i++)
                {
                    rate        += 2.0f * Mathf.PI * scale;
                    nextPoint.x =  bomb.range * Mathf.Cos (rate);
                    nextPoint.z =  bomb.range * Mathf.Sin (rate);
                    Gizmos.DrawLine (previousPoint, nextPoint);
                    previousPoint = nextPoint;
                }

                // Draw top eye
                rate            = 0f;
                nextPoint.x     = 0f;
                previousPoint.x = 0f;
                previousPoint.y = bomb.range * Mathf.Cos (rate);
                previousPoint.z = bomb.range * Mathf.Sin (rate);
                for (int i = 0; i < size; i++)
                {
                    rate        += 2.0f * Mathf.PI * scale;
                    nextPoint.y =  bomb.range * Mathf.Cos (rate);
                    nextPoint.z =  bomb.range * Mathf.Sin (rate);
                    Gizmos.DrawLine (previousPoint, nextPoint);
                    previousPoint = nextPoint;
                }

                // Draw top eye
                rate            = 0f;
                nextPoint.z     = 0f;
                previousPoint.z = 0f;
                previousPoint.y = bomb.range * Mathf.Cos (rate);
                previousPoint.x = bomb.range * Mathf.Sin (rate);
                for (int i = 0; i < size; i++)
                {
                    rate        += 2.0f * Mathf.PI * scale;
                    nextPoint.y =  bomb.range * Mathf.Cos (rate);
                    nextPoint.x =  bomb.range * Mathf.Sin (rate);
                    Gizmos.DrawLine (previousPoint, nextPoint);
                    previousPoint = nextPoint;
                }

                // Selectable sphere
                float sphereSize = bomb.range * 0.07f;
                if (sphereSize < 0.1f)
                    sphereSize = 0.1f;
                Gizmos.color = new Color (1.0f, 0.60f, 0f);
                Gizmos.DrawSphere (new Vector3 (0f,          bomb.range,  0f),          sphereSize);
                Gizmos.DrawSphere (new Vector3 (0f,          -bomb.range, 0f),          sphereSize);
                Gizmos.DrawSphere (new Vector3 (bomb.range,  0f,          0f),          sphereSize);
                Gizmos.DrawSphere (new Vector3 (-bomb.range, 0f,          0f),          sphereSize);
                Gizmos.DrawSphere (new Vector3 (0f,          0f,          bomb.range),  sphereSize);
                Gizmos.DrawSphere (new Vector3 (0f,          0f,          -bomb.range), sphereSize);

                Gizmos.color = Color.red;
                Gizmos.DrawSphere (new Vector3 (0f, 0f, 0f), sphereSize / 3f);

            }
        }

       
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
 private void OnSceneGUI()
        {
            var bomb      = target as RayfireBomb;
            var transform = bomb.transform;

            // Draw handles
            EditorGUI.BeginChangeCheck();
            bomb.range = Handles.RadiusHandle (transform.rotation, transform.position, bomb.range);
            if (EditorGUI.EndChangeCheck() == true)
            {
                Undo.RecordObject (bomb, "Change Range");
            }
        }

        // Inspector editing
        public override void OnInspectorGUI()
        {
            // Get target
            RayfireBomb bomb = target as RayfireBomb;

            // Space
            GUILayout.Space (8);

            // Cache UI Begin
            GUILayout.BeginHorizontal();

            // Explode
            if (GUILayout.Button ("Explode", GUILayout.Height (25)))
                bomb.Explode (bomb.delay);

            // Restore
            if (GUILayout.Button ("Restore", GUILayout.Height (25)))
                bomb.Restore();

            // Cache UI End
            EditorGUILayout.EndHorizontal();

            // Space
            GUILayout.Space (1);

            // Fragmentation section Begin
            GUILayout.BeginHorizontal();

            // Show gizmo
            bomb.showGizmo = GUILayout.Toggle (bomb.showGizmo, "Show Gizmo", "Button");

            // Show gizmo
            //vortex.topHandle = GUILayout.Toggle(vortex.topHandle, "Top Handle", "Button");

            // Fragmentation section End
            EditorGUILayout.EndHorizontal();

            // Space
            GUILayout.Space (3);

            // Draw script UI
            DrawDefaultInspector();

            // Space
            GUILayout.Space (5);

            // Label
            GUILayout.Label ("  Filters", EditorStyles.boldLabel);

            // Tag filter
            bomb.tagFilter = EditorGUILayout.TagField ("Tag", bomb.tagFilter);

            // Layer mask
            List<string> layerNames = new List<string>();
            for (int i = 0; i <= 31; i++)
                layerNames.Add (i + ". " + LayerMask.LayerToName (i));
            bomb.mask = EditorGUILayout.MaskField ("Layer", bomb.mask, layerNames.ToArray());
        }
    }
}