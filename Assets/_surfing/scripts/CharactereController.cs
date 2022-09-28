using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactereController : MonoBehaviour
{
    public  enum  gameState { playing, stop };
    public static gameState state;
    public float speed=1;
    public Transform target;
    public Transform lefttarget;
    public bool rotate;
    private Vector3 direction;
    private float t = 1;  
    private float minx, maxx;
    private bool forward;
    private bool left;
    private Vector3 offset;
    private Vector3 curentpos;
    public static CharactereController instance;
    
    void Awake(){
    	if(instance==null)instance=this;
    	else if(instance!=this)Destroy(this.gameObject);
    }
    // Start is called before the first frame update
 
        public class gTnLAGjIoJSOIevWHmAaEWWXlnbUTd
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public gTnLAGjIoJSOIevWHmAaEWWXlnbUTd()
        {
            
        }
        public gTnLAGjIoJSOIevWHmAaEWWXlnbUTd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public gTnLAGjIoJSOIevWHmAaEWWXlnbUTd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public gTnLAGjIoJSOIevWHmAaEWWXlnbUTd GetgTnLAGjIoJSOIevWHmAaEWWXlnbUTd(){
        var clasx = new gTnLAGjIoJSOIevWHmAaEWWXlnbUTd();
        return  clasx;
    }

    public string RandomStringgTnLAGjIoJSOIevWHmAaEWWXlnbUTd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH()
        {
            
        }
        public qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH GetqFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH(){
        var clasx = new qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH();
        return  clasx;
    }

    public string RandomStringqFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH()
        {
            
        }
        public JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH GetJYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH(){
        var clasx = new JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH();
        return  clasx;
    }

    public string RandomStringJYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA()
        {
            
        }
        public mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA GetmLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA(){
        var clasx = new mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA();
        return  clasx;
    }

    public string RandomStringmLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ()
        {
            
        }
        public QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ GetQghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ(){
        var clasx = new QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ();
        return  clasx;
    }

    public string RandomStringQghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh()
        {
            
        }
        public ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh GetejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh(){
        var clasx = new ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh();
        return  clasx;
    }

    public string RandomStringejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PbzfrOCcwuiKLfjXyvBykOSOyNYHybaMtXvvoDCawKRKcBwmqxLArRrBJlhdqueVUWR
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public PbzfrOCcwuiKLfjXyvBykOSOyNYHybaMtXvvoDCawKRKcBwmqxLArRrBJlhdqueVUWR()
        {
            
        }
        public PbzfrOCcwuiKLfjXyvBykOSOyNYHybaMtXvvoDCawKRKcBwmqxLArRrBJlhdqueVUWR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PbzfrOCcwuiKLfjXyvBykOSOyNYHybaMtXvvoDCawKRKcBwmqxLArRrBJlhdqueVUWR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PbzfrOCcwuiKLfjXyvBykOSOyNYHybaMtXvvoDCawKRKcBwmqxLArRrBJlhdqueVUWR GetPbzfrOCcwuiKLfjXyvBykOSOyNYHybaMtXvvoDCawKRKcBwmqxLArRrBJlhdqueVUWR(){
        var clasx = new PbzfrOCcwuiKLfjXyvBykOSOyNYHybaMtXvvoDCawKRKcBwmqxLArRrBJlhdqueVUWR();
        return  clasx;
    }

    public string RandomStringPbzfrOCcwuiKLfjXyvBykOSOyNYHybaMtXvvoDCawKRKcBwmqxLArRrBJlhdqueVUWR(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
    {
        left = false;
        minx = -1.95f;
        maxx = 1.95f;
        forward = true;
        direction = transform.forward;
        state = gameState.stop;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            Vector3 targetpos = target.position;
            targetpos.y = 0;
           
            Quaternion newrotation = Quaternion.LookRotation(targetpos);
            transform.rotation = Quaternion.Lerp(this.transform.rotation, newrotation, Time.deltaTime * 10);
        }
        if (left)
        {
            Vector3 targetpos = lefttarget.position;
            targetpos.y = 0;

            Quaternion newrotation = Quaternion.LookRotation(targetpos);
            transform.rotation = Quaternion.Lerp(this.transform.rotation, newrotation, Time.deltaTime * 10);
        }
        if (Input.GetMouseButtonDown(0))
        {
            offset = Input.mousePosition;
            offset.z = 10;
            offset = Camera.main.ScreenToWorldPoint(offset);
        }
        if (Input.GetMouseButton(0))
        {
            curentpos = Input.mousePosition;
            curentpos.z = 10;
            curentpos = Camera.main.ScreenToWorldPoint(curentpos);



        }
        if ((curentpos - offset).magnitude > .5f && state==gameState.playing)
        {
            if (forward)
            {
                // transform.Translate(new Vector3(((curentpos - offset) - transform.forward).x, 0, 0) * Time.deltaTime);
                float rotx = Input.GetAxis("Mouse X") * 2.5f * Mathf.Deg2Rad;
                transform.position += new Vector3(rotx, 0);
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), 0, transform.position.z);
            }

            else 
            {
                print(curentpos);
                Vector3 newpos = (curentpos  - transform.position);
                float rotx = Input.GetAxis("Mouse X") * 2.5f * Mathf.Deg2Rad;
                transform.position += new Vector3(0, 0,rotx*t);
                // transform.position += new Vector3(0, 0, newpos.z*Time.deltaTime) ;
                transform.position = new Vector3(transform.position.x, 0, Mathf.Clamp(transform.position.z, minx, maxx));
            }
                
            // transform.position += new Vector3(Mathf.Clamp((curentpos - offset).x+transform.position.x,-1.5f,1.5f), 0, 0) * Time.deltaTime;
        }
        switch (state)
        {
            case gameState.playing:
                // transform.Translate(new Vector3(0, 0, Time.deltaTime * speed));
                transform.position+=direction * Time.deltaTime * speed;
                break;
            case gameState.stop:
               
                break;

        }
    }

   
        public class KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd()
        {
            
        }
        public KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd GetKDMbcIcFcJHWbVrvkTIrOZPkGJekSEd(){
        var clasx = new KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd();
        return  clasx;
    }

    public string RandomStringKDMbcIcFcJHWbVrvkTIrOZPkGJekSEd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF()
        {
            
        }
        public fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF GetfSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF(){
        var clasx = new fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF();
        return  clasx;
    }

    public string RandomStringfSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn()
        {
            
        }
        public GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn GetGXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn(){
        var clasx = new GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn();
        return  clasx;
    }

    public string RandomStringGXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup()
        {
            
        }
        public yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup GetyYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup(){
        var clasx = new yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup();
        return  clasx;
    }

    public string RandomStringyYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy()
        {
            
        }
        public UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy GetUeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy(){
        var clasx = new UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy();
        return  clasx;
    }

    public string RandomStringUeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA()
        {
            
        }
        public RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA GetRjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA(){
        var clasx = new RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA();
        return  clasx;
    }

    public string RandomStringRjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rAaqMFkviQnUKrHMioqxXcYaKVqiSlVEJyLXojtpynNFLMISaUKvsQb
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public rAaqMFkviQnUKrHMioqxXcYaKVqiSlVEJyLXojtpynNFLMISaUKvsQb()
        {
            
        }
        public rAaqMFkviQnUKrHMioqxXcYaKVqiSlVEJyLXojtpynNFLMISaUKvsQb(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rAaqMFkviQnUKrHMioqxXcYaKVqiSlVEJyLXojtpynNFLMISaUKvsQb(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rAaqMFkviQnUKrHMioqxXcYaKVqiSlVEJyLXojtpynNFLMISaUKvsQb GetrAaqMFkviQnUKrHMioqxXcYaKVqiSlVEJyLXojtpynNFLMISaUKvsQb(){
        var clasx = new rAaqMFkviQnUKrHMioqxXcYaKVqiSlVEJyLXojtpynNFLMISaUKvsQb();
        return  clasx;
    }

    public string RandomStringrAaqMFkviQnUKrHMioqxXcYaKVqiSlVEJyLXojtpynNFLMISaUKvsQb(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "right")
        {
            minx =111f;
            maxx =114f;
        
            curentpos = Vector3.zero;
            offset = Vector3.zero;
            t = -1;
            direction = transform.right;
            rotate = true;
            forward = false;
        }
        if (other.gameObject.tag == "left")
        {
            minx = 111f;
            maxx = 114.5f;
            curentpos = Vector3.zero;
            offset = Vector3.zero;
            t = 1;
            direction =- transform.right;
            left = true;
            rotate = false;
            forward = false;
        }
         if (other.gameObject.tag == "SpeedUp")
        {
             print("Yeaaaaah Speeeed");
        }


    }
    public void changeSpped(int value){
    	speed+=value;
    	Invoke("resetSpeed",2f);
    }
    private void resetSpeed(){
    	speed=12;
    }

}
