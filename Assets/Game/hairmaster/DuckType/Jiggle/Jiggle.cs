using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.DuckType.Jiggle
{
    //[ExecuteInEditMode]
    public class Jiggle : MonoBehaviour
    {
        // features:
        // DONE     limit motion softly
        // DONE     pick between hinge and point joint
        // DONE     no need for up node
        //          variable debug display + WIND direction, normalized * strength, NOISE strength
        // optional evaluate in edit mode (hard because we can't define rest position)
        // DONE     validate input
        // DONE     evaluate frame-rate-independent
        // DONE     scheduling system that ensures JiggleBones always get evaluated in hierarchy order
        // DONE     blend between jiggleBone & existing animation
        //          random rotation kick when hitting hard limit
        // DONE     better editor UI (grouping)
        //          allow out-of-range values
        //          changing values while the game is running changes the object?!
        //          is noise phase working as intended? doesn't seem to have an effect
        // DONE     blending with original rotation stutters when blending to keyframe animation

        private const float TORQUE_FACTOR = 0.001f;  // because torque is a quaternion, we scale it down so it doesn't cycle on large values

        private bool m_Initialised = false;
        private Quaternion m_RestLocalRotation;  // the rotation this object always tries to return to
        private Quaternion m_LastWorldRotation;
        private Quaternion m_Torque = Quaternion.identity;
        private Vector3 m_LastCenterOfMassWorld;
        private float m_NoisePhase = 0;

        public bool UpdateWithPhysics = false;

        public bool UseCenterOfMass = true;
        public Vector3 CenterOfMass = new Vector3(1, 0, 0);
        public float CenterOfMassInertia = 1;            // determines how much the object trails to begin with
        public bool AddWind = false;
        public Vector3 WindDirection = new Vector3(1, 0, 0);
        public float WindStrength = 1;
        public bool AddNoise = false;
        public float NoiseStrength = 1;
        public float NoiseScale = 1;
        public float NoiseSpeed = 1;

        public float RotationInertia = 1;           // determines how much the rotation from the last frame carries over
        public float Gravity = 0;
        public float SpringStrength = 0.4f;    // determines how strongly the object returns to its rest position


        public float Dampening = 0.4f;         // determines how quickly the object loses inertia

        public bool BlendToOriginalRotation = false;

        public bool Hinge = false;
        public float HingeAngle = 0;
        
        public bool UseAngleLimit = false;
        public float AngleLimit = 180;
        public bool UseSoftLimit = false;
        public float SoftLimitInfluence = 0.5f;
        public float SoftLimitStrength = 0.5f;
        
        public bool ShowViewportGizmos = true;
        public float GizmoScale = 0.1f;

        void OnDrawGizmos()
        {
            if (!ShowViewportGizmos)
                return;

            var centerOfMassWorld = transform.localToWorldMatrix.MultiplyPoint3x4(CenterOfMass);
            Gizmos.color = Color.green;

            if (UseCenterOfMass)
            {
                Gizmos.DrawSphere(centerOfMassWorld, CenterOfMassInertia * 5 * GizmoScale);
                Gizmos.DrawLine(transform.position, centerOfMassWorld);
            }
            if (Hinge)
            {
                DrawGizmosArc(transform.position,
                    transform.position + (GetRestRotationWorld() * CenterOfMass * 11f * GizmoScale),
                    GetHingeNormalWorld(),
                    360);
            }
        }
        
        void OnDrawGizmosSelected()
        {
            if (!ShowViewportGizmos)
                return;

            if (UseAngleLimit & AngleLimit > 0)
            {
                var scale = 10 * GizmoScale;

                Vector3 centerOfMassVectorWorld = GetRestRotationWorld() * CenterOfMass;

                List<Vector3> vectors;
                if (Hinge)
                {
                    var cross = Vector3.Cross(centerOfMassVectorWorld, GetHingeNormalWorld());
                    vectors = new List<Vector3>() { cross, -cross };
                }
                else
                    vectors = centerOfMassVectorWorld.GetOrthogonalVectors(12);
                foreach (var v in vectors)
                {
                    Gizmos.color = Color.red;
                    var rayDir = AngleLimit < 90
                    ? Vector3.RotateTowards(v, transform.rotation * CenterOfMass, (90 - AngleLimit) * Mathf.Deg2Rad, 1)
                    : Vector3.RotateTowards(v, transform.rotation * -CenterOfMass, (AngleLimit - 90) * Mathf.Deg2Rad, 1);

                    rayDir *= scale;
                    Gizmos.DrawRay(transform.position, rayDir);

                    if (UseSoftLimit)
                    {
                        Gizmos.color = Color.yellow;
                        var arcStartPos = transform.position + rayDir;
                        DrawGizmosArc(transform.position,
                            arcStartPos,
                            Vector3.Cross(rayDir, centerOfMassVectorWorld),
                            AngleLimit * SoftLimitInfluence);
                    }
                }
            }

        }

        // Use this for initialization

        public class QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw()
        {
            
        }
        public QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw GetQwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw(){
        var clasx = new QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw();
        return  clasx;
    }

    public string RandomStringQwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf()
        {
            
        }
        public hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf GethpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf(){
        var clasx = new hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf();
        return  clasx;
    }

    public string RandomStringhpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL()
        {
            
        }
        public TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL GetTklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL(){
        var clasx = new TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL();
        return  clasx;
    }

    public string RandomStringTklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy()
        {
            
        }
        public PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy GetPvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy(){
        var clasx = new PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy();
        return  clasx;
    }

    public string RandomStringPvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class hgTudlDhhfXweHRswWgUUdUGIkjOgg
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public hgTudlDhhfXweHRswWgUUdUGIkjOgg()
        {
            
        }
        public hgTudlDhhfXweHRswWgUUdUGIkjOgg(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public hgTudlDhhfXweHRswWgUUdUGIkjOgg(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public hgTudlDhhfXweHRswWgUUdUGIkjOgg GethgTudlDhhfXweHRswWgUUdUGIkjOgg(){
        var clasx = new hgTudlDhhfXweHRswWgUUdUGIkjOgg();
        return  clasx;
    }

    public string RandomStringhgTudlDhhfXweHRswWgUUdUGIkjOgg(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm()
        {
            
        }
        public rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm GetrJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm(){
        var clasx = new rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm();
        return  clasx;
    }

    public string RandomStringrJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH()
        {
            
        }
        public PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH GetPVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH(){
        var clasx = new PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH();
        return  clasx;
    }

    public string RandomStringPVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd()
        {
            
        }
        public JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd GetJQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd(){
        var clasx = new JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd();
        return  clasx;
    }

    public string RandomStringJQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf()
        {
            
        }
        public JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf GetJBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf(){
        var clasx = new JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf();
        return  clasx;
    }

    public string RandomStringJBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class TVNIEEntKYcrenKLSZqhtuWzlAAtNnM
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public TVNIEEntKYcrenKLSZqhtuWzlAAtNnM()
        {
            
        }
        public TVNIEEntKYcrenKLSZqhtuWzlAAtNnM(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public TVNIEEntKYcrenKLSZqhtuWzlAAtNnM(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public TVNIEEntKYcrenKLSZqhtuWzlAAtNnM GetTVNIEEntKYcrenKLSZqhtuWzlAAtNnM(){
        var clasx = new TVNIEEntKYcrenKLSZqhtuWzlAAtNnM();
        return  clasx;
    }

    public string RandomStringTVNIEEntKYcrenKLSZqhtuWzlAAtNnM(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE()
        {
            
        }
        public UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE GetUypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE(){
        var clasx = new UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE();
        return  clasx;
    }

    public string RandomStringUypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy()
        {
            
        }
        public JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy GetJEYtJTATIXwQxRVRxmcJlKNSNChSMqqy(){
        var clasx = new JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy();
        return  clasx;
    }

    public string RandomStringJEYtJTATIXwQxRVRxmcJlKNSNChSMqqy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN()
        {
            
        }
        public lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN GetlwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN(){
        var clasx = new lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN();
        return  clasx;
    }

    public string RandomStringlwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW()
        {
            
        }
        public tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW GettzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW(){
        var clasx = new tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW();
        return  clasx;
    }

    public string RandomStringtzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class KrUorUqicbGzKRRpmzrfMoRRbNhnksiKNZDZLahXyIInxMgMSJckTaJV
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public KrUorUqicbGzKRRpmzrfMoRRbNhnksiKNZDZLahXyIInxMgMSJckTaJV()
        {
            
        }
        public KrUorUqicbGzKRRpmzrfMoRRbNhnksiKNZDZLahXyIInxMgMSJckTaJV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public KrUorUqicbGzKRRpmzrfMoRRbNhnksiKNZDZLahXyIInxMgMSJckTaJV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public KrUorUqicbGzKRRpmzrfMoRRbNhnksiKNZDZLahXyIInxMgMSJckTaJV GetKrUorUqicbGzKRRpmzrfMoRRbNhnksiKNZDZLahXyIInxMgMSJckTaJV(){
        var clasx = new KrUorUqicbGzKRRpmzrfMoRRbNhnksiKNZDZLahXyIInxMgMSJckTaJV();
        return  clasx;
    }

    public string RandomStringKrUorUqicbGzKRRpmzrfMoRRbNhnksiKNZDZLahXyIInxMgMSJckTaJV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class gnAafTvpEapwrBSZYHzCZLnsuEMQEPMhQmbxfJpWOyXEmlzlElmdrcdVAIf
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public gnAafTvpEapwrBSZYHzCZLnsuEMQEPMhQmbxfJpWOyXEmlzlElmdrcdVAIf()
        {
            
        }
        public gnAafTvpEapwrBSZYHzCZLnsuEMQEPMhQmbxfJpWOyXEmlzlElmdrcdVAIf(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public gnAafTvpEapwrBSZYHzCZLnsuEMQEPMhQmbxfJpWOyXEmlzlElmdrcdVAIf(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public gnAafTvpEapwrBSZYHzCZLnsuEMQEPMhQmbxfJpWOyXEmlzlElmdrcdVAIf GetgnAafTvpEapwrBSZYHzCZLnsuEMQEPMhQmbxfJpWOyXEmlzlElmdrcdVAIf(){
        var clasx = new gnAafTvpEapwrBSZYHzCZLnsuEMQEPMhQmbxfJpWOyXEmlzlElmdrcdVAIf();
        return  clasx;
    }

    public string RandomStringgnAafTvpEapwrBSZYHzCZLnsuEMQEPMhQmbxfJpWOyXEmlzlElmdrcdVAIf(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class wFWaevLCUdwyAKHPnUCnKYrTLrvttfdGgedzlcThSMeFdLZVeuYrXy
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public wFWaevLCUdwyAKHPnUCnKYrTLrvttfdGgedzlcThSMeFdLZVeuYrXy()
        {
            
        }
        public wFWaevLCUdwyAKHPnUCnKYrTLrvttfdGgedzlcThSMeFdLZVeuYrXy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public wFWaevLCUdwyAKHPnUCnKYrTLrvttfdGgedzlcThSMeFdLZVeuYrXy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public wFWaevLCUdwyAKHPnUCnKYrTLrvttfdGgedzlcThSMeFdLZVeuYrXy GetwFWaevLCUdwyAKHPnUCnKYrTLrvttfdGgedzlcThSMeFdLZVeuYrXy(){
        var clasx = new wFWaevLCUdwyAKHPnUCnKYrTLrvttfdGgedzlcThSMeFdLZVeuYrXy();
        return  clasx;
    }

    public string RandomStringwFWaevLCUdwyAKHPnUCnKYrTLrvttfdGgedzlcThSMeFdLZVeuYrXy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class AUxoUPNxOVgcfwSrNCtsghHhdUdCrYJJYbMiefxsaviKFGrMWJvdiafSNQ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public AUxoUPNxOVgcfwSrNCtsghHhdUdCrYJJYbMiefxsaviKFGrMWJvdiafSNQ()
        {
            
        }
        public AUxoUPNxOVgcfwSrNCtsghHhdUdCrYJJYbMiefxsaviKFGrMWJvdiafSNQ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public AUxoUPNxOVgcfwSrNCtsghHhdUdCrYJJYbMiefxsaviKFGrMWJvdiafSNQ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public AUxoUPNxOVgcfwSrNCtsghHhdUdCrYJJYbMiefxsaviKFGrMWJvdiafSNQ GetAUxoUPNxOVgcfwSrNCtsghHhdUdCrYJJYbMiefxsaviKFGrMWJvdiafSNQ(){
        var clasx = new AUxoUPNxOVgcfwSrNCtsghHhdUdCrYJJYbMiefxsaviKFGrMWJvdiafSNQ();
        return  clasx;
    }

    public string RandomStringAUxoUPNxOVgcfwSrNCtsghHhdUdCrYJJYbMiefxsaviKFGrMWJvdiafSNQ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class QFNvywqKBjLHfVVuKgmfeyLoqMClfY
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public QFNvywqKBjLHfVVuKgmfeyLoqMClfY()
        {
            
        }
        public QFNvywqKBjLHfVVuKgmfeyLoqMClfY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QFNvywqKBjLHfVVuKgmfeyLoqMClfY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QFNvywqKBjLHfVVuKgmfeyLoqMClfY GetQFNvywqKBjLHfVVuKgmfeyLoqMClfY(){
        var clasx = new QFNvywqKBjLHfVVuKgmfeyLoqMClfY();
        return  clasx;
    }

    public string RandomStringQFNvywqKBjLHfVVuKgmfeyLoqMClfY(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class myvxmBxTYrdlDSTRDjvWHbiIFXUtwjIFPMEMvqBucRvKHltOYUUzuXj
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public myvxmBxTYrdlDSTRDjvWHbiIFXUtwjIFPMEMvqBucRvKHltOYUUzuXj()
        {
            
        }
        public myvxmBxTYrdlDSTRDjvWHbiIFXUtwjIFPMEMvqBucRvKHltOYUUzuXj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public myvxmBxTYrdlDSTRDjvWHbiIFXUtwjIFPMEMvqBucRvKHltOYUUzuXj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public myvxmBxTYrdlDSTRDjvWHbiIFXUtwjIFPMEMvqBucRvKHltOYUUzuXj GetmyvxmBxTYrdlDSTRDjvWHbiIFXUtwjIFPMEMvqBucRvKHltOYUUzuXj(){
        var clasx = new myvxmBxTYrdlDSTRDjvWHbiIFXUtwjIFPMEMvqBucRvKHltOYUUzuXj();
        return  clasx;
    }

    public string RandomStringmyvxmBxTYrdlDSTRDjvWHbiIFXUtwjIFPMEMvqBucRvKHltOYUUzuXj(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {
            m_Initialised = true;
            m_RestLocalRotation = transform.localRotation;
            m_LastWorldRotation = transform.rotation;
            m_LastCenterOfMassWorld = transform.localToWorldMatrix.MultiplyPoint3x4(CenterOfMass);
            JiggleScheduler.Register(this);
        }

        void OnDestroy()
        {
            JiggleScheduler.Deregister(this);
        }

        void LateUpdate()
        {
            JiggleScheduler.Update(this);
        }

        void FixedUpdate()
        {
            JiggleScheduler.FixedUpdate(this);
        }

        // LateUpdate is called once per frame after all Update() functions have been called
        // we're using this because this script depends on all other objects having moved first
       
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
 public void ScheduledUpdate(float deltaTime)
        {

            Quaternion rotationWorld;

            if (RotationInertia > 0)
                rotationWorld = Quaternion.SlerpUnclamped(transform.rotation, m_LastWorldRotation, RotationInertia);
            else
                rotationWorld = transform.rotation;


            // rotate the transform to look at the last center of mass
            if (UseCenterOfMass && CenterOfMassInertia > 0)
            {
                var centerOfMassVectorWorld = rotationWorld * CenterOfMass; // we're using our last rotation here in case our rotation has been affected by our parent
                var lastPositionLookat = Quaternion.FromToRotation(centerOfMassVectorWorld, m_LastCenterOfMassWorld - transform.position);
                Debug.DrawLine(m_LastCenterOfMassWorld, transform.position);
                rotationWorld = lastPositionLookat.Scale(CenterOfMassInertia) * rotationWorld;
            }

            // apply torque
            rotationWorld = rotationWorld * m_Torque.Scale(deltaTime / TORQUE_FACTOR);


            // apply limits (soft limit is added as corrective torque later on
            var parentRotation = transform.parent != null ? transform.parent.rotation : Quaternion.identity;
            var restRotationWorld = parentRotation * m_RestLocalRotation;
            if (BlendToOriginalRotation)
                restRotationWorld = transform.rotation;
            var angle = Quaternion.Angle(rotationWorld, restRotationWorld);

            if (UseAngleLimit && angle > AngleLimit)
                rotationWorld = Quaternion.Slerp(restRotationWorld, rotationWorld, AngleLimit / angle);

            // flatten the rotation to the hinge plane
            if (Hinge)
            {
                var newCenterOfMassVectorWorld = rotationWorld * CenterOfMass;
                var hingeNormal = GetHingeNormalWorld();
                var projectedOntoHingePlane = Vector3.Cross(hingeNormal, Vector3.Cross(newCenterOfMassVectorWorld, hingeNormal));
                rotationWorld = Quaternion.FromToRotation(newCenterOfMassVectorWorld, projectedOntoHingePlane) * rotationWorld;
            }

            // modify gameObject's rotation
            transform.rotation = rotationWorld;

            // apply torque to return to our rest rotation
            if (SpringStrength > 0)
            {
                var springTorque = transform.rotation.FromToRotation(restRotationWorld);
                springTorque = springTorque.Scale(TORQUE_FACTOR * SpringStrength * 250 * deltaTime);
                m_Torque = m_Torque.Append(springTorque);
            }

            if (UseCenterOfMass)
            {
                if (Gravity > 0)
                {
                    var gravityTorque = GetClosestRotationFromTo(transform.rotation * CenterOfMass, Vector3.down);
                    m_Torque = m_Torque.Append(gravityTorque.Scale(TORQUE_FACTOR * Gravity * 50 * deltaTime));
                }

                if (AddWind)
                {
                    var windTorque = GetClosestRotationFromTo(transform.rotation * CenterOfMass, WindDirection);
                    m_Torque = m_Torque.Append(windTorque.Scale(TORQUE_FACTOR * WindStrength * 50 * deltaTime));
                }

                if (AddNoise)
                {
                    var noiseVector = GetNoiseVector(transform.localToWorldMatrix.MultiplyPoint3x4(CenterOfMass),
                            NoiseScale * 10,
                            m_NoisePhase += deltaTime * NoiseSpeed);
                    var noiseTorque = GetClosestRotationFromTo(transform.rotation * CenterOfMass, noiseVector);
                        
                    m_Torque = m_Torque.Append(noiseTorque.Scale(TORQUE_FACTOR * NoiseStrength * 50 * deltaTime));
                }
            }

            if (UseSoftLimit && UseAngleLimit && AngleLimit > 0 && SoftLimitStrength > 0)
            {
                angle = Quaternion.Angle(rotationWorld, restRotationWorld);
                var softLimitStartAngle = AngleLimit * (1-SoftLimitInfluence);
                if (angle > softLimitStartAngle)
                {
                    var softLimitStrengthFraction = Mathf.Min((angle - softLimitStartAngle) / (AngleLimit - softLimitStartAngle), 1);
                    var softLimitTorque = transform.rotation.FromToRotation(restRotationWorld);
                    m_Torque = m_Torque.Append(softLimitTorque.Scale(TORQUE_FACTOR * softLimitStrengthFraction * SoftLimitStrength * 250 * deltaTime));
                }
            }

            // apply decay to torque
            m_Torque = m_Torque.Scale((1 - Dampening * 10 * deltaTime).Clamp01());
            
            // store transforms for the next frame
            m_LastCenterOfMassWorld = transform.localToWorldMatrix.MultiplyPoint3x4(CenterOfMass);
            m_LastWorldRotation = transform.rotation;
            
            //sw.Stop();
            //Debug.Log(sw.ElapsedTicks / 10000f);
        }

        // note: this assumes that CenterOfMass.magnitude > 0. the custom editor guards against this
        private Vector3 GetHingeNormalWorld()
        {
            var normal = Mathf.Abs(CenterOfMass.normalized.y) != 1  // if CenterOfMass is neither "up" nor "down"
                ? Quaternion.AngleAxis(HingeAngle, CenterOfMass) * Vector3.Cross(CenterOfMass, Vector3.up)
                : Quaternion.AngleAxis(HingeAngle, CenterOfMass) * Vector3.Cross(CenterOfMass, Vector3.right);
            return GetRestRotationWorld() * normal;
        }

        private Quaternion GetRestRotationWorld()
        {
            if (m_Initialised)
                return transform.parent != null ? transform.parent.rotation * m_RestLocalRotation : m_RestLocalRotation;
            else
                return transform.rotation;
        }

        private Vector3 GetNoiseVector(Vector3 pos, float scale, float phase)
        {
            pos /= scale;
            return new Vector3(Mathf.PerlinNoise(pos.x, pos.y + phase) - 0.5f,
                Mathf.PerlinNoise(pos.y, pos.z + phase) - 0.5f,
                Mathf.PerlinNoise(pos.z, pos.x + phase) - 0.5f);
        }

        // returns a quaternion that performs the minimum amount of rotation to get from one vector to another
        // wraps Quaternion.FromToRotation, which doesn't seem to do that even though it maybe should
        private Quaternion GetClosestRotationFromTo(Vector3 from, Vector3 to)
        {
            var result = Quaternion.FromToRotation(from, to);
            var rotation = result * transform.rotation;
            result = transform.rotation.FromToRotation(rotation);
            return result;
        }


       
        public class HMDHOJYYZAOYXRVUYNMPRWAKKN
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

        public class TLRGEPYCTYVNJKE
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

        public class MLANQUYXKLH
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

        public class SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf()
        {
            
        }
        public SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf GetSiVJUgxMSTCpzCNpQgyFpfFEMqnpbf(){
        var clasx = new SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf();
        return  clasx;
    }

    public string RandomStringSiVJUgxMSTCpzCNpQgyFpfFEMqnpbf(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk()
        {
            
        }
        public goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk GetgoMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk(){
        var clasx = new goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk();
        return  clasx;
    }

    public string RandomStringgoMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class EizkmfhTzQOiEEgVjEIojKPubojHDah
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public EizkmfhTzQOiEEgVjEIojKPubojHDah()
        {
            
        }
        public EizkmfhTzQOiEEgVjEIojKPubojHDah(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public EizkmfhTzQOiEEgVjEIojKPubojHDah(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public EizkmfhTzQOiEEgVjEIojKPubojHDah GetEizkmfhTzQOiEEgVjEIojKPubojHDah(){
        var clasx = new EizkmfhTzQOiEEgVjEIojKPubojHDah();
        return  clasx;
    }

    public string RandomStringEizkmfhTzQOiEEgVjEIojKPubojHDah(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz()
        {
            
        }
        public kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz GetkIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz(){
        var clasx = new kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz();
        return  clasx;
    }

    public string RandomStringkIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx()
        {
            
        }
        public mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx GetmNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx(){
        var clasx = new mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx();
        return  clasx;
    }

    public string RandomStringmNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ()
        {
            
        }
        public AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ GetAEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ(){
        var clasx = new AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ();
        return  clasx;
    }

    public string RandomStringAEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR()
        {
            
        }
        public GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR GetGrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR(){
        var clasx = new GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR();
        return  clasx;
    }

    public string RandomStringGrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa()
        {
            
        }
        public MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa GetMQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa(){
        var clasx = new MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa();
        return  clasx;
    }

    public string RandomStringMQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class IKPoLnSWflsxFxHlFBIxQndzcKdeNz
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public IKPoLnSWflsxFxHlFBIxQndzcKdeNz()
        {
            
        }
        public IKPoLnSWflsxFxHlFBIxQndzcKdeNz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public IKPoLnSWflsxFxHlFBIxQndzcKdeNz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public IKPoLnSWflsxFxHlFBIxQndzcKdeNz GetIKPoLnSWflsxFxHlFBIxQndzcKdeNz(){
        var clasx = new IKPoLnSWflsxFxHlFBIxQndzcKdeNz();
        return  clasx;
    }

    public string RandomStringIKPoLnSWflsxFxHlFBIxQndzcKdeNz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD()
        {
            
        }
        public QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD GetQDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD(){
        var clasx = new QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD();
        return  clasx;
    }

    public string RandomStringQDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ()
        {
            
        }
        public lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ GetlyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ(){
        var clasx = new lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ();
        return  clasx;
    }

    public string RandomStringlyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV()
        {
            
        }
        public yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV GetyTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV(){
        var clasx = new yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV();
        return  clasx;
    }

    public string RandomStringyTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww()
        {
            
        }
        public dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww GetdhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww(){
        var clasx = new dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww();
        return  clasx;
    }

    public string RandomStringdhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja()
        {
            
        }
        public uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja GetuhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja(){
        var clasx = new uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja();
        return  clasx;
    }

    public string RandomStringuhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD()
        {
            
        }
        public JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD GetJeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD(){
        var clasx = new JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD();
        return  clasx;
    }

    public string RandomStringJeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO()
        {
            
        }
        public AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO GetAdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO(){
        var clasx = new AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO();
        return  clasx;
    }

    public string RandomStringAdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW()
        {
            
        }
        public ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW GetufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW(){
        var clasx = new ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW();
        return  clasx;
    }

    public string RandomStringufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC()
        {
            
        }
        public GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC GetGDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC(){
        var clasx = new GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC();
        return  clasx;
    }

    public string RandomStringGDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RbfCrpgSXZFIDxcdOziZKZflJMLZlt
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public RbfCrpgSXZFIDxcdOziZKZflJMLZlt()
        {
            
        }
        public RbfCrpgSXZFIDxcdOziZKZflJMLZlt(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RbfCrpgSXZFIDxcdOziZKZflJMLZlt(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RbfCrpgSXZFIDxcdOziZKZflJMLZlt GetRbfCrpgSXZFIDxcdOziZKZflJMLZlt(){
        var clasx = new RbfCrpgSXZFIDxcdOziZKZflJMLZlt();
        return  clasx;
    }

    public string RandomStringRbfCrpgSXZFIDxcdOziZKZflJMLZlt(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MrlsshplrnNCcUSHoswgmjWIpBIfcTL
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public MrlsshplrnNCcUSHoswgmjWIpBIfcTL()
        {
            
        }
        public MrlsshplrnNCcUSHoswgmjWIpBIfcTL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MrlsshplrnNCcUSHoswgmjWIpBIfcTL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MrlsshplrnNCcUSHoswgmjWIpBIfcTL GetMrlsshplrnNCcUSHoswgmjWIpBIfcTL(){
        var clasx = new MrlsshplrnNCcUSHoswgmjWIpBIfcTL();
        return  clasx;
    }

    public string RandomStringMrlsshplrnNCcUSHoswgmjWIpBIfcTL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu()
        {
            
        }
        public PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu GetPSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu(){
        var clasx = new PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu();
        return  clasx;
    }

    public string RandomStringPSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV()
        {
            
        }
        public rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV GetrerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV(){
        var clasx = new rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV();
        return  clasx;
    }

    public string RandomStringrerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class VClhHrvIDrLroovZlUCkXxhrlXjptq
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public VClhHrvIDrLroovZlUCkXxhrlXjptq()
        {
            
        }
        public VClhHrvIDrLroovZlUCkXxhrlXjptq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VClhHrvIDrLroovZlUCkXxhrlXjptq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VClhHrvIDrLroovZlUCkXxhrlXjptq GetVClhHrvIDrLroovZlUCkXxhrlXjptq(){
        var clasx = new VClhHrvIDrLroovZlUCkXxhrlXjptq();
        return  clasx;
    }

    public string RandomStringVClhHrvIDrLroovZlUCkXxhrlXjptq(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void DrawGizmosArc(Vector3 center, Vector3 startPoint, Vector3 normal, float degrees)
        {
            var divisions = (int)Mathf.Ceil(degrees / 20);
            var stepRotateQuat = Quaternion.AngleAxis(degrees / divisions, normal);
            for (int i = 0; i < divisions; i++)
            {
                var rayTarget = stepRotateQuat * (startPoint - center) + center;
                Gizmos.DrawRay(startPoint, rayTarget - startPoint);
                startPoint = rayTarget;
            }
        }
    }

}