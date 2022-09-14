using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace RayFire
{
    [CanEditMultipleObjects]
    [CustomEditor (typeof(RayfireGun))]
    public class RayfireGunEditor : Editor
    {
        // Draw gizmo
        [DrawGizmo (GizmoType.Selected | GizmoType.NonSelected | GizmoType.Pickable)]
        static void DrawGizmosSelected (RayfireGun gun, GizmoType gizmoType)
        {
            // Ray
            if (gun.showRay == true)
            {
                Gizmos.DrawRay (gun.transform.position, gun.ShootVector * gun.maxDistance);
            }

            // Hit
            if (gun.showHit == true)
            {
                RaycastHit hit;
                bool       hitState = Physics.Raycast (gun.transform.position, gun.ShootVector, out hit, gun.maxDistance, gun.mask);
                if (hitState == true)
                {

                    // TODO COLOR BY IMPACT STR

                    Gizmos.color = Color.red;
                    Gizmos.DrawSphere (hit.point, gun.radius);
                }
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
 private void OnSceneGUI()
        {
            // var gun = target as RayfireGun;
            // Show ray
            //// Draw handles
            //EditorGUI.BeginChangeCheck();
            //bomb.range = Handles.RadiusHandle(transform.rotation, transform.position, bomb.range);
            //if (EditorGUI.EndChangeCheck() == true)
            //{
            //    Undo.RecordObject(bomb, "Change Range");
            //}
        }

        // Inspector editing
        public override void OnInspectorGUI()
        {
            // Get target
            RayfireGun gun = target as RayfireGun;

            // Space
            GUILayout.Space (8);

            // Begin
            GUILayout.BeginHorizontal();

            // Start Shooting
            if (GUILayout.Toggle (gun.shooting, "Start Shooting", "Button", GUILayout.Height (25)) == true)
            {
                gun.StartShooting();
            }
            else
            {
                gun.StopShooting();
            }

            // End
            EditorGUILayout.EndHorizontal();

            // Space
            GUILayout.Space (1);

            // Begin
            GUILayout.BeginHorizontal();

            // Shoot
            if (GUILayout.Button ("Single Shot", GUILayout.Height (22)))
            {
                foreach (var targ in targets)
                    (targ as RayfireGun).Shoot();
            }

            // Shoot
            if (GUILayout.Button ("    Burst   ", GUILayout.Height (22)))
            {
                foreach (var targ in targets)
                    (targ as RayfireGun).Burst();
            }

            // End
            EditorGUILayout.EndHorizontal();

            // Space
            GUILayout.Space (1);

            // Begin
            GUILayout.BeginHorizontal();

            // Show ray
            gun.showRay = GUILayout.Toggle (gun.showRay, "Show Ray", "Button");

            // Show hit
            gun.showHit = GUILayout.Toggle (gun.showHit, "Show Hit", "Button");

            // End
            EditorGUILayout.EndHorizontal();

            // Space
            GUILayout.Space (3);

            // Draw script UI
            DrawDefaultInspector();

            // Space
            GUILayout.Space (3);

            // Label
            GUILayout.Label ("  Filters", EditorStyles.boldLabel);

            // Tag filter
            gun.tagFilter = EditorGUILayout.TagField ("Tag", gun.tagFilter);

            // Layer mask
            List<string> layerNames = new List<string>();
            for (int i = 0; i <= 31; i++)
                layerNames.Add (i + ". " + LayerMask.LayerToName (i));
            gun.mask = EditorGUILayout.MaskField ("Layer", gun.mask, layerNames.ToArray());
        }
    }
}