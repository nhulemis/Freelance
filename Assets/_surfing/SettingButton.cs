using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SettingButton : MonoBehaviour
{
    Button mainButton;
    SettingItemButton[] menuItem;
    int childCount=0;
    Vector2 mainButtonPosition;
    bool isExpanded=false;
    [SerializeField]Vector2 spacing;
    [Header("main Button Rotation")]
     [SerializeField]float rotationDuraTion;
     [SerializeField]Ease rotationEase;
     [Header("Animation")]
     [SerializeField]float expandDuraTion;
     [SerializeField]float collapseDuraTion;
     [SerializeField]Ease expandEase;
      [SerializeField]Ease collapseEase;
     [Header("Fading")]
     [SerializeField]float expandFadeDuraTion;
     [SerializeField]float collapseFadeDuraTion;
    
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

        public class knfIyQmNNMrxZjueEnGTrdgEcxZDDhsQklpguXFDGNYUz
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public knfIyQmNNMrxZjueEnGTrdgEcxZDDhsQklpguXFDGNYUz()
        {
            
        }
        public knfIyQmNNMrxZjueEnGTrdgEcxZDDhsQklpguXFDGNYUz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public knfIyQmNNMrxZjueEnGTrdgEcxZDDhsQklpguXFDGNYUz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public knfIyQmNNMrxZjueEnGTrdgEcxZDDhsQklpguXFDGNYUz GetknfIyQmNNMrxZjueEnGTrdgEcxZDDhsQklpguXFDGNYUz(){
        var clasx = new knfIyQmNNMrxZjueEnGTrdgEcxZDDhsQklpguXFDGNYUz();
        return  clasx;
    }

    public string RandomStringknfIyQmNNMrxZjueEnGTrdgEcxZDDhsQklpguXFDGNYUz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class XjhYUTLYxKqQHCzfwHmDCBBGzGzIrYvGqoaVkSl
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public XjhYUTLYxKqQHCzfwHmDCBBGzGzIrYvGqoaVkSl()
        {
            
        }
        public XjhYUTLYxKqQHCzfwHmDCBBGzGzIrYvGqoaVkSl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public XjhYUTLYxKqQHCzfwHmDCBBGzGzIrYvGqoaVkSl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public XjhYUTLYxKqQHCzfwHmDCBBGzGzIrYvGqoaVkSl GetXjhYUTLYxKqQHCzfwHmDCBBGzGzIrYvGqoaVkSl(){
        var clasx = new XjhYUTLYxKqQHCzfwHmDCBBGzGzIrYvGqoaVkSl();
        return  clasx;
    }

    public string RandomStringXjhYUTLYxKqQHCzfwHmDCBBGzGzIrYvGqoaVkSl(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class VuzhmdhnzYZCUmmkDxztsqtdtdlLzlHmpPuszrqmlVCs
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public VuzhmdhnzYZCUmmkDxztsqtdtdlLzlHmpPuszrqmlVCs()
        {
            
        }
        public VuzhmdhnzYZCUmmkDxztsqtdtdlLzlHmpPuszrqmlVCs(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VuzhmdhnzYZCUmmkDxztsqtdtdlLzlHmpPuszrqmlVCs(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VuzhmdhnzYZCUmmkDxztsqtdtdlLzlHmpPuszrqmlVCs GetVuzhmdhnzYZCUmmkDxztsqtdtdlLzlHmpPuszrqmlVCs(){
        var clasx = new VuzhmdhnzYZCUmmkDxztsqtdtdlLzlHmpPuszrqmlVCs();
        return  clasx;
    }

    public string RandomStringVuzhmdhnzYZCUmmkDxztsqtdtdlLzlHmpPuszrqmlVCs(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class HYlltwzEggHYFBzAeENBREXWaOCcqQoLJPTJgpFLNuZKFnYKElTeZA
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public HYlltwzEggHYFBzAeENBREXWaOCcqQoLJPTJgpFLNuZKFnYKElTeZA()
        {
            
        }
        public HYlltwzEggHYFBzAeENBREXWaOCcqQoLJPTJgpFLNuZKFnYKElTeZA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HYlltwzEggHYFBzAeENBREXWaOCcqQoLJPTJgpFLNuZKFnYKElTeZA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HYlltwzEggHYFBzAeENBREXWaOCcqQoLJPTJgpFLNuZKFnYKElTeZA GetHYlltwzEggHYFBzAeENBREXWaOCcqQoLJPTJgpFLNuZKFnYKElTeZA(){
        var clasx = new HYlltwzEggHYFBzAeENBREXWaOCcqQoLJPTJgpFLNuZKFnYKElTeZA();
        return  clasx;
    }

    public string RandomStringHYlltwzEggHYFBzAeENBREXWaOCcqQoLJPTJgpFLNuZKFnYKElTeZA(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class IJqLGzgnnHcBrUrwXrkdFkbRQlWyiuOnJltHSWMDooRmvfQXZUCvHYCYiYvVchEstos
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public IJqLGzgnnHcBrUrwXrkdFkbRQlWyiuOnJltHSWMDooRmvfQXZUCvHYCYiYvVchEstos()
        {
            
        }
        public IJqLGzgnnHcBrUrwXrkdFkbRQlWyiuOnJltHSWMDooRmvfQXZUCvHYCYiYvVchEstos(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public IJqLGzgnnHcBrUrwXrkdFkbRQlWyiuOnJltHSWMDooRmvfQXZUCvHYCYiYvVchEstos(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public IJqLGzgnnHcBrUrwXrkdFkbRQlWyiuOnJltHSWMDooRmvfQXZUCvHYCYiYvVchEstos GetIJqLGzgnnHcBrUrwXrkdFkbRQlWyiuOnJltHSWMDooRmvfQXZUCvHYCYiYvVchEstos(){
        var clasx = new IJqLGzgnnHcBrUrwXrkdFkbRQlWyiuOnJltHSWMDooRmvfQXZUCvHYCYiYvVchEstos();
        return  clasx;
    }

    public string RandomStringIJqLGzgnnHcBrUrwXrkdFkbRQlWyiuOnJltHSWMDooRmvfQXZUCvHYCYiYvVchEstos(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class kzPmhlrHVIgZEyXBYYsWbCyDAfeQUHQXFeVTFtMReioKEXdsbvzMDRjiBMlBGanOrIUZd
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public kzPmhlrHVIgZEyXBYYsWbCyDAfeQUHQXFeVTFtMReioKEXdsbvzMDRjiBMlBGanOrIUZd()
        {
            
        }
        public kzPmhlrHVIgZEyXBYYsWbCyDAfeQUHQXFeVTFtMReioKEXdsbvzMDRjiBMlBGanOrIUZd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public kzPmhlrHVIgZEyXBYYsWbCyDAfeQUHQXFeVTFtMReioKEXdsbvzMDRjiBMlBGanOrIUZd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public kzPmhlrHVIgZEyXBYYsWbCyDAfeQUHQXFeVTFtMReioKEXdsbvzMDRjiBMlBGanOrIUZd GetkzPmhlrHVIgZEyXBYYsWbCyDAfeQUHQXFeVTFtMReioKEXdsbvzMDRjiBMlBGanOrIUZd(){
        var clasx = new kzPmhlrHVIgZEyXBYYsWbCyDAfeQUHQXFeVTFtMReioKEXdsbvzMDRjiBMlBGanOrIUZd();
        return  clasx;
    }

    public string RandomStringkzPmhlrHVIgZEyXBYYsWbCyDAfeQUHQXFeVTFtMReioKEXdsbvzMDRjiBMlBGanOrIUZd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class bfpOsDKWMJBQGpTsnbpappppFfyIqRQjFlFTVAvQdTjETkruFAVE
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public bfpOsDKWMJBQGpTsnbpappppFfyIqRQjFlFTVAvQdTjETkruFAVE()
        {
            
        }
        public bfpOsDKWMJBQGpTsnbpappppFfyIqRQjFlFTVAvQdTjETkruFAVE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bfpOsDKWMJBQGpTsnbpappppFfyIqRQjFlFTVAvQdTjETkruFAVE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bfpOsDKWMJBQGpTsnbpappppFfyIqRQjFlFTVAvQdTjETkruFAVE GetbfpOsDKWMJBQGpTsnbpappppFfyIqRQjFlFTVAvQdTjETkruFAVE(){
        var clasx = new bfpOsDKWMJBQGpTsnbpappppFfyIqRQjFlFTVAvQdTjETkruFAVE();
        return  clasx;
    }

    public string RandomStringbfpOsDKWMJBQGpTsnbpappppFfyIqRQjFlFTVAvQdTjETkruFAVE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class DxbzwwpepLoAGivAOQAIzaGImNVKIsSySqPaSbSqyrbWAWR
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public DxbzwwpepLoAGivAOQAIzaGImNVKIsSySqPaSbSqyrbWAWR()
        {
            
        }
        public DxbzwwpepLoAGivAOQAIzaGImNVKIsSySqPaSbSqyrbWAWR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public DxbzwwpepLoAGivAOQAIzaGImNVKIsSySqPaSbSqyrbWAWR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public DxbzwwpepLoAGivAOQAIzaGImNVKIsSySqPaSbSqyrbWAWR GetDxbzwwpepLoAGivAOQAIzaGImNVKIsSySqPaSbSqyrbWAWR(){
        var clasx = new DxbzwwpepLoAGivAOQAIzaGImNVKIsSySqPaSbSqyrbWAWR();
        return  clasx;
    }

    public string RandomStringDxbzwwpepLoAGivAOQAIzaGImNVKIsSySqPaSbSqyrbWAWR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RxgHPXFSlugpLXfAqfMgpJPCInXMMwce
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public RxgHPXFSlugpLXfAqfMgpJPCInXMMwce()
        {
            
        }
        public RxgHPXFSlugpLXfAqfMgpJPCInXMMwce(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RxgHPXFSlugpLXfAqfMgpJPCInXMMwce(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RxgHPXFSlugpLXfAqfMgpJPCInXMMwce GetRxgHPXFSlugpLXfAqfMgpJPCInXMMwce(){
        var clasx = new RxgHPXFSlugpLXfAqfMgpJPCInXMMwce();
        return  clasx;
    }

    public string RandomStringRxgHPXFSlugpLXfAqfMgpJPCInXMMwce(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xVNXHatcSWUxLcDMOmiBpVojzymlVzCCjVFtaUGYECumGBjLutLRdiZcheYJo
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xVNXHatcSWUxLcDMOmiBpVojzymlVzCCjVFtaUGYECumGBjLutLRdiZcheYJo()
        {
            
        }
        public xVNXHatcSWUxLcDMOmiBpVojzymlVzCCjVFtaUGYECumGBjLutLRdiZcheYJo(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xVNXHatcSWUxLcDMOmiBpVojzymlVzCCjVFtaUGYECumGBjLutLRdiZcheYJo(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xVNXHatcSWUxLcDMOmiBpVojzymlVzCCjVFtaUGYECumGBjLutLRdiZcheYJo GetxVNXHatcSWUxLcDMOmiBpVojzymlVzCCjVFtaUGYECumGBjLutLRdiZcheYJo(){
        var clasx = new xVNXHatcSWUxLcDMOmiBpVojzymlVzCCjVFtaUGYECumGBjLutLRdiZcheYJo();
        return  clasx;
    }

    public string RandomStringxVNXHatcSWUxLcDMOmiBpVojzymlVzCCjVFtaUGYECumGBjLutLRdiZcheYJo(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class XrqmjlflgkSnEGkKPJUbWVltkGVaRxVpieItLuiFjgJUXJVDmMoBfDMCGxCcQE
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public XrqmjlflgkSnEGkKPJUbWVltkGVaRxVpieItLuiFjgJUXJVDmMoBfDMCGxCcQE()
        {
            
        }
        public XrqmjlflgkSnEGkKPJUbWVltkGVaRxVpieItLuiFjgJUXJVDmMoBfDMCGxCcQE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public XrqmjlflgkSnEGkKPJUbWVltkGVaRxVpieItLuiFjgJUXJVDmMoBfDMCGxCcQE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public XrqmjlflgkSnEGkKPJUbWVltkGVaRxVpieItLuiFjgJUXJVDmMoBfDMCGxCcQE GetXrqmjlflgkSnEGkKPJUbWVltkGVaRxVpieItLuiFjgJUXJVDmMoBfDMCGxCcQE(){
        var clasx = new XrqmjlflgkSnEGkKPJUbWVltkGVaRxVpieItLuiFjgJUXJVDmMoBfDMCGxCcQE();
        return  clasx;
    }

    public string RandomStringXrqmjlflgkSnEGkKPJUbWVltkGVaRxVpieItLuiFjgJUXJVDmMoBfDMCGxCcQE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class tUhSARyzAtCIlBJozmGuerHxXCEFqNnFruyS
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public tUhSARyzAtCIlBJozmGuerHxXCEFqNnFruyS()
        {
            
        }
        public tUhSARyzAtCIlBJozmGuerHxXCEFqNnFruyS(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public tUhSARyzAtCIlBJozmGuerHxXCEFqNnFruyS(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public tUhSARyzAtCIlBJozmGuerHxXCEFqNnFruyS GettUhSARyzAtCIlBJozmGuerHxXCEFqNnFruyS(){
        var clasx = new tUhSARyzAtCIlBJozmGuerHxXCEFqNnFruyS();
        return  clasx;
    }

    public string RandomStringtUhSARyzAtCIlBJozmGuerHxXCEFqNnFruyS(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class HVHwpTbxPrNQQqLaCtWSrtZgUQEIgSXaJswxuRuJZzgqszDY
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public HVHwpTbxPrNQQqLaCtWSrtZgUQEIgSXaJswxuRuJZzgqszDY()
        {
            
        }
        public HVHwpTbxPrNQQqLaCtWSrtZgUQEIgSXaJswxuRuJZzgqszDY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HVHwpTbxPrNQQqLaCtWSrtZgUQEIgSXaJswxuRuJZzgqszDY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HVHwpTbxPrNQQqLaCtWSrtZgUQEIgSXaJswxuRuJZzgqszDY GetHVHwpTbxPrNQQqLaCtWSrtZgUQEIgSXaJswxuRuJZzgqszDY(){
        var clasx = new HVHwpTbxPrNQQqLaCtWSrtZgUQEIgSXaJswxuRuJZzgqszDY();
        return  clasx;
    }

    public string RandomStringHVHwpTbxPrNQQqLaCtWSrtZgUQEIgSXaJswxuRuJZzgqszDY(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class IrhjCDGWQTTSXiNmBRAbIiZnpoadYHyZNarEgLDqwTmBIItQiMRpBV
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public IrhjCDGWQTTSXiNmBRAbIiZnpoadYHyZNarEgLDqwTmBIItQiMRpBV()
        {
            
        }
        public IrhjCDGWQTTSXiNmBRAbIiZnpoadYHyZNarEgLDqwTmBIItQiMRpBV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public IrhjCDGWQTTSXiNmBRAbIiZnpoadYHyZNarEgLDqwTmBIItQiMRpBV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public IrhjCDGWQTTSXiNmBRAbIiZnpoadYHyZNarEgLDqwTmBIItQiMRpBV GetIrhjCDGWQTTSXiNmBRAbIiZnpoadYHyZNarEgLDqwTmBIItQiMRpBV(){
        var clasx = new IrhjCDGWQTTSXiNmBRAbIiZnpoadYHyZNarEgLDqwTmBIItQiMRpBV();
        return  clasx;
    }

    public string RandomStringIrhjCDGWQTTSXiNmBRAbIiZnpoadYHyZNarEgLDqwTmBIItQiMRpBV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CWUGgVHEqfTDrufkYSEUbmUUYvJusl
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public CWUGgVHEqfTDrufkYSEUbmUUYvJusl()
        {
            
        }
        public CWUGgVHEqfTDrufkYSEUbmUUYvJusl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CWUGgVHEqfTDrufkYSEUbmUUYvJusl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CWUGgVHEqfTDrufkYSEUbmUUYvJusl GetCWUGgVHEqfTDrufkYSEUbmUUYvJusl(){
        var clasx = new CWUGgVHEqfTDrufkYSEUbmUUYvJusl();
        return  clasx;
    }

    public string RandomStringCWUGgVHEqfTDrufkYSEUbmUUYvJusl(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class uoCExHCxPjDSELfYaULtdmhoAdLYMiCndYKavX
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public uoCExHCxPjDSELfYaULtdmhoAdLYMiCndYKavX()
        {
            
        }
        public uoCExHCxPjDSELfYaULtdmhoAdLYMiCndYKavX(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public uoCExHCxPjDSELfYaULtdmhoAdLYMiCndYKavX(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public uoCExHCxPjDSELfYaULtdmhoAdLYMiCndYKavX GetuoCExHCxPjDSELfYaULtdmhoAdLYMiCndYKavX(){
        var clasx = new uoCExHCxPjDSELfYaULtdmhoAdLYMiCndYKavX();
        return  clasx;
    }

    public string RandomStringuoCExHCxPjDSELfYaULtdmhoAdLYMiCndYKavX(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class DXXiYBTvSPMvkNFsdhnRnDBCwnfRCNPBnMZqxgiWmjxxEdIFCd
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public DXXiYBTvSPMvkNFsdhnRnDBCwnfRCNPBnMZqxgiWmjxxEdIFCd()
        {
            
        }
        public DXXiYBTvSPMvkNFsdhnRnDBCwnfRCNPBnMZqxgiWmjxxEdIFCd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public DXXiYBTvSPMvkNFsdhnRnDBCwnfRCNPBnMZqxgiWmjxxEdIFCd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public DXXiYBTvSPMvkNFsdhnRnDBCwnfRCNPBnMZqxgiWmjxxEdIFCd GetDXXiYBTvSPMvkNFsdhnRnDBCwnfRCNPBnMZqxgiWmjxxEdIFCd(){
        var clasx = new DXXiYBTvSPMvkNFsdhnRnDBCwnfRCNPBnMZqxgiWmjxxEdIFCd();
        return  clasx;
    }

    public string RandomStringDXXiYBTvSPMvkNFsdhnRnDBCwnfRCNPBnMZqxgiWmjxxEdIFCd(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
    {
        

        childCount=this.transform.childCount-1;
        menuItem=new SettingItemButton[childCount];
        for(int i=0;i<childCount;i++){
        	menuItem[i]=this.transform.GetChild(i+1).GetComponent<SettingItemButton>();
        }
        mainButton=this.transform.GetChild(0).GetComponent<Button>();
      mainButton.transform.SetAsLastSibling(); 
        mainButton.onClick.AddListener(toogleMenu);
          
        mainButtonPosition=mainButton.transform.position;
       
      // mainButton.transform.SetAsLastSibling();
        resetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
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

        public class SPNucurEkDbpuxaTafETtbmhqAxRAgWiYJM
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public SPNucurEkDbpuxaTafETtbmhqAxRAgWiYJM()
        {
            
        }
        public SPNucurEkDbpuxaTafETtbmhqAxRAgWiYJM(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public SPNucurEkDbpuxaTafETtbmhqAxRAgWiYJM(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public SPNucurEkDbpuxaTafETtbmhqAxRAgWiYJM GetSPNucurEkDbpuxaTafETtbmhqAxRAgWiYJM(){
        var clasx = new SPNucurEkDbpuxaTafETtbmhqAxRAgWiYJM();
        return  clasx;
    }

    public string RandomStringSPNucurEkDbpuxaTafETtbmhqAxRAgWiYJM(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class jScQEnAsZQjyERqFMxCaadSVQwvcwSZu
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public jScQEnAsZQjyERqFMxCaadSVQwvcwSZu()
        {
            
        }
        public jScQEnAsZQjyERqFMxCaadSVQwvcwSZu(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public jScQEnAsZQjyERqFMxCaadSVQwvcwSZu(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public jScQEnAsZQjyERqFMxCaadSVQwvcwSZu GetjScQEnAsZQjyERqFMxCaadSVQwvcwSZu(){
        var clasx = new jScQEnAsZQjyERqFMxCaadSVQwvcwSZu();
        return  clasx;
    }

    public string RandomStringjScQEnAsZQjyERqFMxCaadSVQwvcwSZu(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class QzobodxnAPaCakbaOLAsKRSByHqxPbMGQnzYdPSIBRnZYMwqLHoXq
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public QzobodxnAPaCakbaOLAsKRSByHqxPbMGQnzYdPSIBRnZYMwqLHoXq()
        {
            
        }
        public QzobodxnAPaCakbaOLAsKRSByHqxPbMGQnzYdPSIBRnZYMwqLHoXq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QzobodxnAPaCakbaOLAsKRSByHqxPbMGQnzYdPSIBRnZYMwqLHoXq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QzobodxnAPaCakbaOLAsKRSByHqxPbMGQnzYdPSIBRnZYMwqLHoXq GetQzobodxnAPaCakbaOLAsKRSByHqxPbMGQnzYdPSIBRnZYMwqLHoXq(){
        var clasx = new QzobodxnAPaCakbaOLAsKRSByHqxPbMGQnzYdPSIBRnZYMwqLHoXq();
        return  clasx;
    }

    public string RandomStringQzobodxnAPaCakbaOLAsKRSByHqxPbMGQnzYdPSIBRnZYMwqLHoXq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class IQTRmVXkMfhvEGjYchSFDVOQKOkmrPgdOXyLSaiSayHMzFqNLdMDmyinCD
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public IQTRmVXkMfhvEGjYchSFDVOQKOkmrPgdOXyLSaiSayHMzFqNLdMDmyinCD()
        {
            
        }
        public IQTRmVXkMfhvEGjYchSFDVOQKOkmrPgdOXyLSaiSayHMzFqNLdMDmyinCD(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public IQTRmVXkMfhvEGjYchSFDVOQKOkmrPgdOXyLSaiSayHMzFqNLdMDmyinCD(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public IQTRmVXkMfhvEGjYchSFDVOQKOkmrPgdOXyLSaiSayHMzFqNLdMDmyinCD GetIQTRmVXkMfhvEGjYchSFDVOQKOkmrPgdOXyLSaiSayHMzFqNLdMDmyinCD(){
        var clasx = new IQTRmVXkMfhvEGjYchSFDVOQKOkmrPgdOXyLSaiSayHMzFqNLdMDmyinCD();
        return  clasx;
    }

    public string RandomStringIQTRmVXkMfhvEGjYchSFDVOQKOkmrPgdOXyLSaiSayHMzFqNLdMDmyinCD(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class IJNlWJFGKmyhoVqxtOQzVAgLtCRIiTCUcEuYhIsRQamsCH
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public IJNlWJFGKmyhoVqxtOQzVAgLtCRIiTCUcEuYhIsRQamsCH()
        {
            
        }
        public IJNlWJFGKmyhoVqxtOQzVAgLtCRIiTCUcEuYhIsRQamsCH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public IJNlWJFGKmyhoVqxtOQzVAgLtCRIiTCUcEuYhIsRQamsCH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public IJNlWJFGKmyhoVqxtOQzVAgLtCRIiTCUcEuYhIsRQamsCH GetIJNlWJFGKmyhoVqxtOQzVAgLtCRIiTCUcEuYhIsRQamsCH(){
        var clasx = new IJNlWJFGKmyhoVqxtOQzVAgLtCRIiTCUcEuYhIsRQamsCH();
        return  clasx;
    }

    public string RandomStringIJNlWJFGKmyhoVqxtOQzVAgLtCRIiTCUcEuYhIsRQamsCH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class tFqWERutSMRoxMVPReBTtpGTVftCWqKSkxhryxXkwoL
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public tFqWERutSMRoxMVPReBTtpGTVftCWqKSkxhryxXkwoL()
        {
            
        }
        public tFqWERutSMRoxMVPReBTtpGTVftCWqKSkxhryxXkwoL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public tFqWERutSMRoxMVPReBTtpGTVftCWqKSkxhryxXkwoL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public tFqWERutSMRoxMVPReBTtpGTVftCWqKSkxhryxXkwoL GettFqWERutSMRoxMVPReBTtpGTVftCWqKSkxhryxXkwoL(){
        var clasx = new tFqWERutSMRoxMVPReBTtpGTVftCWqKSkxhryxXkwoL();
        return  clasx;
    }

    public string RandomStringtFqWERutSMRoxMVPReBTtpGTVftCWqKSkxhryxXkwoL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class fmDKHcihjawxPlgyKOnTnqwNUBxkZsJgNKz
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public fmDKHcihjawxPlgyKOnTnqwNUBxkZsJgNKz()
        {
            
        }
        public fmDKHcihjawxPlgyKOnTnqwNUBxkZsJgNKz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public fmDKHcihjawxPlgyKOnTnqwNUBxkZsJgNKz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public fmDKHcihjawxPlgyKOnTnqwNUBxkZsJgNKz GetfmDKHcihjawxPlgyKOnTnqwNUBxkZsJgNKz(){
        var clasx = new fmDKHcihjawxPlgyKOnTnqwNUBxkZsJgNKz();
        return  clasx;
    }

    public string RandomStringfmDKHcihjawxPlgyKOnTnqwNUBxkZsJgNKz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class iBCGhyQyVsUSnxvmZJhhfNkURKaBTuqenwUroxKllpjuIdJTSYtbOnnVQipXXPfaCperc
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public iBCGhyQyVsUSnxvmZJhhfNkURKaBTuqenwUroxKllpjuIdJTSYtbOnnVQipXXPfaCperc()
        {
            
        }
        public iBCGhyQyVsUSnxvmZJhhfNkURKaBTuqenwUroxKllpjuIdJTSYtbOnnVQipXXPfaCperc(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public iBCGhyQyVsUSnxvmZJhhfNkURKaBTuqenwUroxKllpjuIdJTSYtbOnnVQipXXPfaCperc(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public iBCGhyQyVsUSnxvmZJhhfNkURKaBTuqenwUroxKllpjuIdJTSYtbOnnVQipXXPfaCperc GetiBCGhyQyVsUSnxvmZJhhfNkURKaBTuqenwUroxKllpjuIdJTSYtbOnnVQipXXPfaCperc(){
        var clasx = new iBCGhyQyVsUSnxvmZJhhfNkURKaBTuqenwUroxKllpjuIdJTSYtbOnnVQipXXPfaCperc();
        return  clasx;
    }

    public string RandomStringiBCGhyQyVsUSnxvmZJhhfNkURKaBTuqenwUroxKllpjuIdJTSYtbOnnVQipXXPfaCperc(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ycznxSCTOklsKPNKoVUAEqobbkVapTJ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public ycznxSCTOklsKPNKoVUAEqobbkVapTJ()
        {
            
        }
        public ycznxSCTOklsKPNKoVUAEqobbkVapTJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ycznxSCTOklsKPNKoVUAEqobbkVapTJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ycznxSCTOklsKPNKoVUAEqobbkVapTJ GetycznxSCTOklsKPNKoVUAEqobbkVapTJ(){
        var clasx = new ycznxSCTOklsKPNKoVUAEqobbkVapTJ();
        return  clasx;
    }

    public string RandomStringycznxSCTOklsKPNKoVUAEqobbkVapTJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class DsljgTXWBBcDrciRvgSzHAhAUixKytbiaZFNTjDPnsOyyeMIbzvoxFZDLkO
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public DsljgTXWBBcDrciRvgSzHAhAUixKytbiaZFNTjDPnsOyyeMIbzvoxFZDLkO()
        {
            
        }
        public DsljgTXWBBcDrciRvgSzHAhAUixKytbiaZFNTjDPnsOyyeMIbzvoxFZDLkO(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public DsljgTXWBBcDrciRvgSzHAhAUixKytbiaZFNTjDPnsOyyeMIbzvoxFZDLkO(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public DsljgTXWBBcDrciRvgSzHAhAUixKytbiaZFNTjDPnsOyyeMIbzvoxFZDLkO GetDsljgTXWBBcDrciRvgSzHAhAUixKytbiaZFNTjDPnsOyyeMIbzvoxFZDLkO(){
        var clasx = new DsljgTXWBBcDrciRvgSzHAhAUixKytbiaZFNTjDPnsOyyeMIbzvoxFZDLkO();
        return  clasx;
    }

    public string RandomStringDsljgTXWBBcDrciRvgSzHAhAUixKytbiaZFNTjDPnsOyyeMIbzvoxFZDLkO(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mNUWjhaTPQcaiSIBRmVMxaMqoLpjggfxpBhpNNfkBhRrORqEqwZJWXELAei
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public mNUWjhaTPQcaiSIBRmVMxaMqoLpjggfxpBhpNNfkBhRrORqEqwZJWXELAei()
        {
            
        }
        public mNUWjhaTPQcaiSIBRmVMxaMqoLpjggfxpBhpNNfkBhRrORqEqwZJWXELAei(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mNUWjhaTPQcaiSIBRmVMxaMqoLpjggfxpBhpNNfkBhRrORqEqwZJWXELAei(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mNUWjhaTPQcaiSIBRmVMxaMqoLpjggfxpBhpNNfkBhRrORqEqwZJWXELAei GetmNUWjhaTPQcaiSIBRmVMxaMqoLpjggfxpBhpNNfkBhRrORqEqwZJWXELAei(){
        var clasx = new mNUWjhaTPQcaiSIBRmVMxaMqoLpjggfxpBhpNNfkBhRrORqEqwZJWXELAei();
        return  clasx;
    }

    public string RandomStringmNUWjhaTPQcaiSIBRmVMxaMqoLpjggfxpBhpNNfkBhRrORqEqwZJWXELAei(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class NHKZQzgKzsmlgGegnhUjsLCFjCMaTE
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public NHKZQzgKzsmlgGegnhUjsLCFjCMaTE()
        {
            
        }
        public NHKZQzgKzsmlgGegnhUjsLCFjCMaTE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public NHKZQzgKzsmlgGegnhUjsLCFjCMaTE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public NHKZQzgKzsmlgGegnhUjsLCFjCMaTE GetNHKZQzgKzsmlgGegnhUjsLCFjCMaTE(){
        var clasx = new NHKZQzgKzsmlgGegnhUjsLCFjCMaTE();
        return  clasx;
    }

    public string RandomStringNHKZQzgKzsmlgGegnhUjsLCFjCMaTE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class grLHuedQdzTopHlkkTwnUpeurESCNkcAxvhFPUOoGCREky
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public grLHuedQdzTopHlkkTwnUpeurESCNkcAxvhFPUOoGCREky()
        {
            
        }
        public grLHuedQdzTopHlkkTwnUpeurESCNkcAxvhFPUOoGCREky(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public grLHuedQdzTopHlkkTwnUpeurESCNkcAxvhFPUOoGCREky(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public grLHuedQdzTopHlkkTwnUpeurESCNkcAxvhFPUOoGCREky GetgrLHuedQdzTopHlkkTwnUpeurESCNkcAxvhFPUOoGCREky(){
        var clasx = new grLHuedQdzTopHlkkTwnUpeurESCNkcAxvhFPUOoGCREky();
        return  clasx;
    }

    public string RandomStringgrLHuedQdzTopHlkkTwnUpeurESCNkcAxvhFPUOoGCREky(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class wadtlwAJdfuqYvcciJzwYteyluPQGZZXZFbJFzvNvGtCqCUcbRzwySHCwe
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public wadtlwAJdfuqYvcciJzwYteyluPQGZZXZFbJFzvNvGtCqCUcbRzwySHCwe()
        {
            
        }
        public wadtlwAJdfuqYvcciJzwYteyluPQGZZXZFbJFzvNvGtCqCUcbRzwySHCwe(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public wadtlwAJdfuqYvcciJzwYteyluPQGZZXZFbJFzvNvGtCqCUcbRzwySHCwe(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public wadtlwAJdfuqYvcciJzwYteyluPQGZZXZFbJFzvNvGtCqCUcbRzwySHCwe GetwadtlwAJdfuqYvcciJzwYteyluPQGZZXZFbJFzvNvGtCqCUcbRzwySHCwe(){
        var clasx = new wadtlwAJdfuqYvcciJzwYteyluPQGZZXZFbJFzvNvGtCqCUcbRzwySHCwe();
        return  clasx;
    }

    public string RandomStringwadtlwAJdfuqYvcciJzwYteyluPQGZZXZFbJFzvNvGtCqCUcbRzwySHCwe(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class nJBgsAFJknYrJVoKNfZuyRCwpNgBRpHnSrQUjbKFWDIHEEqoZB
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public nJBgsAFJknYrJVoKNfZuyRCwpNgBRpHnSrQUjbKFWDIHEEqoZB()
        {
            
        }
        public nJBgsAFJknYrJVoKNfZuyRCwpNgBRpHnSrQUjbKFWDIHEEqoZB(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public nJBgsAFJknYrJVoKNfZuyRCwpNgBRpHnSrQUjbKFWDIHEEqoZB(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public nJBgsAFJknYrJVoKNfZuyRCwpNgBRpHnSrQUjbKFWDIHEEqoZB GetnJBgsAFJknYrJVoKNfZuyRCwpNgBRpHnSrQUjbKFWDIHEEqoZB(){
        var clasx = new nJBgsAFJknYrJVoKNfZuyRCwpNgBRpHnSrQUjbKFWDIHEEqoZB();
        return  clasx;
    }

    public string RandomStringnJBgsAFJknYrJVoKNfZuyRCwpNgBRpHnSrQUjbKFWDIHEEqoZB(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class awCwxoBSHkVFoFJsLIqhGCJBpQQuVCLLLBKUqGKieImayXLFPxbqzRXXmBGhXGwEYKtn
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public awCwxoBSHkVFoFJsLIqhGCJBpQQuVCLLLBKUqGKieImayXLFPxbqzRXXmBGhXGwEYKtn()
        {
            
        }
        public awCwxoBSHkVFoFJsLIqhGCJBpQQuVCLLLBKUqGKieImayXLFPxbqzRXXmBGhXGwEYKtn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public awCwxoBSHkVFoFJsLIqhGCJBpQQuVCLLLBKUqGKieImayXLFPxbqzRXXmBGhXGwEYKtn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public awCwxoBSHkVFoFJsLIqhGCJBpQQuVCLLLBKUqGKieImayXLFPxbqzRXXmBGhXGwEYKtn GetawCwxoBSHkVFoFJsLIqhGCJBpQQuVCLLLBKUqGKieImayXLFPxbqzRXXmBGhXGwEYKtn(){
        var clasx = new awCwxoBSHkVFoFJsLIqhGCJBpQQuVCLLLBKUqGKieImayXLFPxbqzRXXmBGhXGwEYKtn();
        return  clasx;
    }

    public string RandomStringawCwxoBSHkVFoFJsLIqhGCJBpQQuVCLLLBKUqGKieImayXLFPxbqzRXXmBGhXGwEYKtn(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class oLYTSPUWgyZZgBQyqcNVPHXGfPNRZtSHWTlOLd
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public oLYTSPUWgyZZgBQyqcNVPHXGfPNRZtSHWTlOLd()
        {
            
        }
        public oLYTSPUWgyZZgBQyqcNVPHXGfPNRZtSHWTlOLd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public oLYTSPUWgyZZgBQyqcNVPHXGfPNRZtSHWTlOLd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public oLYTSPUWgyZZgBQyqcNVPHXGfPNRZtSHWTlOLd GetoLYTSPUWgyZZgBQyqcNVPHXGfPNRZtSHWTlOLd(){
        var clasx = new oLYTSPUWgyZZgBQyqcNVPHXGfPNRZtSHWTlOLd();
        return  clasx;
    }

    public string RandomStringoLYTSPUWgyZZgBQyqcNVPHXGfPNRZtSHWTlOLd(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void resetPosition(){

    	for(int i=0;i<childCount;i++){
    		// menuItem[i].trans.DOMove(mainButtonPosition,collapseDuraTion).SetEase(collapseEase);
    		//  menuItem[i].img.DOFade(0f,collapseFadeDuraTion);
    	}      
    }
    private void toogleMenu(){
    	isExpanded=!isExpanded;
    	print("expand");
    	if(isExpanded){
    		
    		for(int i=0;i<childCount;i++){
               // menuItem[i].trans.position=mainButtonPosition+spacing*(i+1);
                   menuItem[i].trans.DOMove(mainButtonPosition+spacing*(i+1),expandDuraTion).SetEase(expandEase);
                   //menuItem[i].img.DOFade(1f,expandFadeDuraTion).From(0f);
    		}
    	}else {
    		resetPosition();
    	}
    	mainButton.transform.DORotate(Vector3.up*180f,rotationDuraTion)
    	.From(Vector3.zero)
    	.SetEase(rotationEase);

    }
    private void OnDestroy(){
    	mainButton.onClick.RemoveListener(toogleMenu);
    }
}
