using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Demolition support
// Reset

namespace RayFire
{
    // Class to store animation cache
    [Serializable]
    public class RFCache
    {
        // Vars
        public string name;
        public List<bool> act;
        public List<Vector3> pos;
        public List<Quaternion> rot;
        public Transform transform;
        
        // Constructor
        public RFCache(Transform parent, Transform tm)
        {
            act = new List<bool>();
            pos = new List<Vector3>();
            rot = new List<Quaternion>();
            transform = tm;
            name = tm.name;
            if (tm.parent != parent)
            {
                Transform lastParent = tm.parent;
                while (parent != lastParent)
                {
                    name = name.Insert (0, "/");
                    name = name.Insert (0, lastParent.name);
                    lastParent = lastParent.parent;
                }
            }
        }
    }
    
    [SelectionBase]
    [DisallowMultipleComponent]
    [AddComponentMenu("RayFire/Rayfire Recorder")]
    [HelpURL("http://rayfirestudios.com/unity-online-help/unity-recorder-component/")]
    public class RayfireRecorder: MonoBehaviour
    {
        public enum AnimatorType
        {
            None   = 0,
            Record = 2,
            Play   = 8
        }

        [Space(5)]
        public AnimatorType mode;
        
        [Header("Record Properties")]
        public bool recordOnStart = true;
        public string clipName;
        [Range(0, 60)] public float duration = 5f;
        [Range(1, 60)] public int rate = 15;
        
        [Space(5)]
        public bool reduceKeys = true;
        [Range(0f, 0.5f)] public float threshold = 0.1f;

        [Header ("Playback Properties")]
        public bool playOnStart;
        public AnimationClip animationClip;
        public RuntimeAnimatorController controller;
        
        [Header ("Rigid Playback")]
        public bool setToKinematic = true;
        
        [Header("Private")]
        [HideInInspector] 
        public bool recorder;
        [HideInInspector] 
        public  float recordedTime;
        private int stateNameHash;
        private string assetFolder;
        private string clipFolder = "RayFireRecords/";
        private float stepTime;
        private Animator animator;
        private List<Transform> tmList;
        private List<RFCache> cacheList;
        private List<float> timeList;
                
        // //////////////////////////////////////////////////
        // Common
        // //////////////////////////////////////////////////
        
        // Awake
        void Awake()
         {
             // Set vars
             SetVariables();
         }
        
        // Start
     
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
   void Start()
        {
            // Collect rigid
            SetRigid();

            // Start ops
            if (mode == AnimatorType.Record && recordOnStart == true)
                StartRecord();
            else if (mode == AnimatorType.Play && playOnStart == true)
                StartPlay();
        }

        // Set rigid props
        void SetRigid()
        {
            if (mode == AnimatorType.Play)
            {
                List<RayfireRigid> rigidList = gameObject.GetComponentsInChildren<RayfireRigid>().ToList();
                foreach (RayfireRigid rigid in rigidList)
                {
                    if (rigid.physics.exclude == false)
                    {
                        rigid.physics.recorder = true;

                        // Check for kinematic state
                        if (setToKinematic == true)
                            if (rigid.simulationType != SimType.Static || rigid.simulationType == SimType.Kinematic)
                            {
                                rigid.simulationType = SimType.Kinematic;
                                RFPhysic.SetSimulationType (rigid);
                            }
                    }
                }
            }
        }

        // Set vars
        void SetVariables()
        {
            if (mode != AnimatorType.None)
            {
                animator = GetComponent<Animator>();

                // Get list of cached transforms
                tmList = gameObject.GetComponentsInChildren<Transform>(false).ToList();
                tmList.Remove (transform);
                
                // No children
                if (tmList.Count == 0)
                {
                    Debug.Log ("RayFire Record: " + gameObject.name + " Mode set to " + mode.ToString() + " but object has no children. Mode set to None.", gameObject);
                    mode = AnimatorType.None;
                    return;
                }
                
                // Record set
                SetModeRecord();

                // Play set
                SetModePlay();
            }
        }

        // Record set
        void SetModeRecord()
        {
            if (mode == AnimatorType.Record)
            {
                // Null active controller 
                if (animator != null)
                    animator.runtimeAnimatorController = null;
                    
                // Prepare cache list
                cacheList = new List<RFCache>();
                if (tmList.Count > 0)
                    for (int i = 0; i < tmList.Count; i++)
                        cacheList.Add (new RFCache (transform, tmList[i]));

                // Time list
                timeList = new List<float>();

                // Set time step
                stepTime = 1f / rate;

                // Clip folder
                assetFolder = "Assets/" + clipFolder;
            }
        }
        
        // Play set
        void SetModePlay()
        {
            if (mode == AnimatorType.Play)
            {
                // Check for null controller
                if (controller == null)
                {
                    Debug.Log ("RayFire Record: " + gameObject.name + " Mode set to " + mode.ToString() + " but controller is not defined. Mode set to None.", gameObject);
                    mode = AnimatorType.None;
                    return;
                }

                // Check for null controller
                if (animationClip == null)
                {
                    Debug.Log ("RayFire Record: " + gameObject.name + " Mode set to " + mode.ToString() + " but animation clip is not defined. Mode set to None.", gameObject);
                    mode = AnimatorType.None;
                    return;
                }
                    
                // Check for clip in controller
                bool hasClip = false;
                foreach (var anim in controller.animationClips)
                    if (anim == animationClip)
                        hasClip = true;
                if (hasClip == false)
                {
                    Debug.Log ("RayFire Record: " + gameObject.name + " Mode set to " + mode.ToString() + " but animation clip is not defined in controller. Mode set to None.", gameObject);
                    mode = AnimatorType.None;
                    return;
                }
 
                // Create animator
                if (animator == null)
                    animator = gameObject.AddComponent<Animator>();
                animator.updateMode = AnimatorUpdateMode.AnimatePhysics;

                // Set defined controller
                animator.runtimeAnimatorController = controller;
            }
        }

        // Reset
        void Reset()
        {
            clipName = gameObject.name;
        }
        
        // //////////////////////////////////////////////////
        // Record
        // //////////////////////////////////////////////////
         
         // Start record
        public void StartRecord()
        {
            // Stop
            if (cacheList.Count == 0)
                return;
            
            // Start recording cor
            StartCoroutine(RecordCor());
        }
        
        // Record tm every frame
        IEnumerator RecordCor()
        {
            recorder = true;
            while (recorder == true)
            {
                // Save data
                timeList.Add (recordedTime);
                for (int i = 0; i < tmList.Count; i++)
                {
                    if (tmList[i] != null)
                    {
                        cacheList[i].act.Add (tmList[i].gameObject.activeSelf);
                        cacheList[i].pos.Add (tmList[i].localPosition);
                        cacheList[i].rot.Add (tmList[i].localRotation);
                    }
                }

                // Set time
                recordedTime += stepTime;

                // Wait
                yield return new WaitForSeconds (stepTime);
                
                // Temp
                if (duration > 0 && recordedTime > duration)
                    StopRecord();
            }
            
            // Create clip  
            #if UNITY_EDITOR
            RFRecorder.CreateAnimationClip(cacheList, timeList, threshold, rate, assetFolder, clipName, reduceKeys);
            #endif        
        }

        // Stop record
        public void StopRecord()
        {
            recorder = false;
        }
        
        // //////////////////////////////////////////////////
        // Play
        // //////////////////////////////////////////////////

        // Start play
        public void StartPlay()
        {
            if (mode == AnimatorType.Play)
                animator.Play (animationClip.name);
        }
    }
}



