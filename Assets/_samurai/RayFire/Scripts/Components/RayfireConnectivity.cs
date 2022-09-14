using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Fragments from demolition
// Scale support for bound + Unyielding component

namespace RayFire
{
    [AddComponentMenu ("RayFire/Rayfire Connectivity")]
    [HelpURL ("http://rayfirestudios.com/unity-online-help/unity-connectivity-component/")]
    public class RayfireConnectivity : MonoBehaviour
    {
        public enum ConnTargetType
        {
            Gizmo    = 0,
            Children = 1
        }
        
        [Space (2)]
        [Header ("Properties")]
        [Space (1)]
        public ConnTargetType source = ConnTargetType.Gizmo;
        [Space (1)]
        public ConnectivityType connectivityType = ConnectivityType.ByBoundingBox;

        // [Space (2)]
        // [Header ("Check")]
        // [HideInInspector] public bool onActivation = true;
        // [Space (1)]
        // [HideInInspector] public bool onDemolition = true;
                
        [Space (2)]
        [Header ("Connections")]
        [Space (1)]
        public bool showConnections = false;
        [Space(1)]
        [Range(0, 1f)] public float sphereSize = 1f;
        
        [Space (2)]
        [Header ("Gizmo")]
        [Space (1)]
        public bool showGizmo = true;
        public Vector3 size = new Vector3(1f,1f,1f);

        // Hidden
        [HideInInspector] public bool checkConnectivity;
        [HideInInspector] public bool checkNeed;
        
        // Private
        List<RayfireRigid> rigidList;
        [NonSerialized] 
        public RFCluster cluster;

        /// /////////////////////////////////////////////////////////
        /// Common
        /// /////////////////////////////////////////////////////////
                
        // Awake
        void Awake()
        {
            // Set by children.
            SetByChildren();
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
   void Start()
        {
            // Set by gizmo. In start to detect kinematik non convex objects
            SetByGizmo();
            
            // Rigid check
            if (rigidList.Count == 0)
            {
                Debug.Log ("RayFire Connectivity: " + name + " has no objects to check for connectivity. Object Excluded from simulation.", gameObject);
                return;
            }
            
            // Connectivity check cor
            StartCoroutine(ConnectivityCor());
        }

        /// /////////////////////////////////////////////////////////
        /// Connectivity
        /// /////////////////////////////////////////////////////////

        // Gizmo tms
        void SetByGizmo()
        {
            if (source == ConnTargetType.Gizmo)
            {
                // Get box overlap fragments
                Collider[] colliders = Physics.OverlapBox (transform.position, size/2f, transform.rotation);
                
                // Get box cast transforms
                List<Transform> tmList = new List<Transform>();
                foreach (var col in colliders)
                    if (tmList.Contains (col.transform) == false)
                        tmList.Add (col.transform);
                
                SetConnectivity (tmList);
            }
        }

        // Children tms
        void SetByChildren()
        {
            if (source == ConnTargetType.Children)
            {
                List<Transform> tmList = new List<Transform>();
                for (int i = 0; i < transform.childCount; i++)
                    tmList.Add (transform.GetChild (i));

                SetConnectivity (tmList);
            }
        }
        
        // Set connectivity fragments and main node
        void SetConnectivity(List<Transform> tmList)
        {
            // No targets
            if (tmList.Count == 0)
                return;

            // Get rigid with byConnectivity
            rigidList = new List<RayfireRigid>();
            foreach (var tm in tmList)
            {
                RayfireRigid rigid = tm.GetComponent<RayfireRigid>();
                if (rigid != null)
                    if (rigid.simulationType == SimType.Inactive || rigid.simulationType == SimType.Kinematic)
                        if (rigid.activation.byConnectivity == true)
                            rigidList.Add (rigid);
            }
            
            // No targets
            if (rigidList.Count == 0)
                return;
            
            // Set this connectivity as main connectivity node
            foreach (var rigid in rigidList)
            {
                rigid.activation.connect = this;
            }

            // Create Base cluster
            SetCluster ();
        }
        
        // Set cluster
        void SetCluster ()
        {
            cluster = new RFCluster();

            // Set shards for main cluster
            cluster.shards = RFShard.GetShards(rigidList, connectivityType);
            
            // Set shard neibs
            RFShard.SetShardNeibs (cluster.shards, connectivityType);
        }

        // Get not connected groups
        void Check()
        {
            // Get not connected clusters
            RFCluster.ConnectivityCheckUny (cluster);
            
            // TODO turn of if no objs to activate
            
            //  clusters
        }

        // Connectivity check cor
        IEnumerator ConnectivityCor()
        {
            checkConnectivity = true;
            while (checkConnectivity == true)
            {
                if (checkNeed == true)
                {
                    // Reset
                    checkNeed = false;
                    
                    // Get not connected groups
                    CheckConnectivity();
                }
         
                yield return null;
            }
        }
        
        // Check for connectivity
        void CheckConnectivity()
        {
            // Get not connected groups
            Check();
            
            // Stop checking. Everything activated
            if (cluster.shards.Count == 0)
                checkConnectivity = false;

            // Activate not connected
            Activate();
        } 
        
        // Activate not connected
        void Activate()
        {
            // Nothing to activate
            if (cluster.childClusters.Count == 0)
                return;

            // Activate
            foreach (var shard in cluster.childClusters[0].shards)
                shard.rigid.Activate();
        }
        
    }
}