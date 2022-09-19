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



