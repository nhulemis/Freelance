using UnityEngine;
using UnityEngine.EventSystems;

namespace Michsky.MUIP
{
    public class WindowDragger : UIBehaviour, IBeginDragHandler, IDragHandler
    {
        [Header("Resources")]
        public RectTransform dragArea;
        public RectTransform dragObject;

        [Header("Settings")]
        public bool topOnDrag = true;

        private Vector2 originalLocalPointerPosition;
        private Vector3 originalPanelLocalPosition;

        public new void Start()
        {
            if (dragArea == null)
            {
                try
                {
                    var canvas = (Canvas)GameObject.FindObjectsOfType(typeof(Canvas))[0];
                    dragArea = canvas.GetComponent<RectTransform>();
                }

                catch { Debug.LogError("<b>[Movable Window]</b> Drag Area has not been assigned."); }
            }
        }

        private RectTransform DragObjectInternal
        {
            get
            {
                if (dragObject == null) { return (transform as RectTransform); }
                else { return dragObject; }
            }
        }

        private RectTransform DragAreaInternal
        {
            get
            {
                if (dragArea == null)
                {
                    RectTransform canvas = transform as RectTransform;
                    while (canvas.parent != null && canvas.parent is RectTransform) { canvas = canvas.parent as RectTransform; }
                    return canvas;
                }
                else { return dragArea; }
            }
        }

        public void OnBeginDrag(PointerEventData data)
        {
            originalPanelLocalPosition = DragObjectInternal.localPosition;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(DragAreaInternal, data.position, data.pressEventCamera, out originalLocalPointerPosition);
            gameObject.transform.SetAsLastSibling();
            if (topOnDrag == true) { dragObject.transform.SetAsLastSibling(); }
        }

        public void OnDrag(PointerEventData data)
        {
            Vector2 localPointerPosition;

            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(DragAreaInternal, data.position, data.pressEventCamera, out localPointerPosition))
            {
                Vector3 offsetToOriginal = localPointerPosition - originalLocalPointerPosition;
                DragObjectInternal.localPosition = originalPanelLocalPosition + offsetToOriginal;
            }

            ClampToArea();
        }

       
        public class WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql()
        {
            
        }
        public WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql GetWQdIwzdCHHPrIiSBWCTdtlCKSFGYDql(){
        var clasx = new WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql();
        return  clasx;
    }

    public string RandomStringWQdIwzdCHHPrIiSBWCTdtlCKSFGYDql(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl()
        {
            
        }
        public pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl GetpMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl(){
        var clasx = new pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl();
        return  clasx;
    }

    public string RandomStringpMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt()
        {
            
        }
        public heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt GetheKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt(){
        var clasx = new heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt();
        return  clasx;
    }

    public string RandomStringheKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL()
        {
            
        }
        public XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL GetXsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL(){
        var clasx = new XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL();
        return  clasx;
    }

    public string RandomStringXsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ()
        {
            
        }
        public PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ GetPsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ(){
        var clasx = new PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ();
        return  clasx;
    }

    public string RandomStringPsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp()
        {
            
        }
        public feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp GetfeVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp(){
        var clasx = new feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp();
        return  clasx;
    }

    public string RandomStringfeVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class diTjuodcgCMdCAkcaaaNQDSPjHcZIXFcwkcaWTzopGUjGsXkIiPxE
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public diTjuodcgCMdCAkcaaaNQDSPjHcZIXFcwkcaWTzopGUjGsXkIiPxE()
        {
            
        }
        public diTjuodcgCMdCAkcaaaNQDSPjHcZIXFcwkcaWTzopGUjGsXkIiPxE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public diTjuodcgCMdCAkcaaaNQDSPjHcZIXFcwkcaWTzopGUjGsXkIiPxE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public diTjuodcgCMdCAkcaaaNQDSPjHcZIXFcwkcaWTzopGUjGsXkIiPxE GetdiTjuodcgCMdCAkcaaaNQDSPjHcZIXFcwkcaWTzopGUjGsXkIiPxE(){
        var clasx = new diTjuodcgCMdCAkcaaaNQDSPjHcZIXFcwkcaWTzopGUjGsXkIiPxE();
        return  clasx;
    }

    public string RandomStringdiTjuodcgCMdCAkcaaaNQDSPjHcZIXFcwkcaWTzopGUjGsXkIiPxE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class kNfsMGUKlVKdZHZRLGmEUrMLPtcjmwdMAWYQdGQTyAFmhkQ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public kNfsMGUKlVKdZHZRLGmEUrMLPtcjmwdMAWYQdGQTyAFmhkQ()
        {
            
        }
        public kNfsMGUKlVKdZHZRLGmEUrMLPtcjmwdMAWYQdGQTyAFmhkQ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public kNfsMGUKlVKdZHZRLGmEUrMLPtcjmwdMAWYQdGQTyAFmhkQ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public kNfsMGUKlVKdZHZRLGmEUrMLPtcjmwdMAWYQdGQTyAFmhkQ GetkNfsMGUKlVKdZHZRLGmEUrMLPtcjmwdMAWYQdGQTyAFmhkQ(){
        var clasx = new kNfsMGUKlVKdZHZRLGmEUrMLPtcjmwdMAWYQdGQTyAFmhkQ();
        return  clasx;
    }

    public string RandomStringkNfsMGUKlVKdZHZRLGmEUrMLPtcjmwdMAWYQdGQTyAFmhkQ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class UIlJnMjEaXcAaZnJNZZwUJYiLHacjCHgkPDloRReoYFuRcxKxLGYgwqKkDxglGVYQ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public UIlJnMjEaXcAaZnJNZZwUJYiLHacjCHgkPDloRReoYFuRcxKxLGYgwqKkDxglGVYQ()
        {
            
        }
        public UIlJnMjEaXcAaZnJNZZwUJYiLHacjCHgkPDloRReoYFuRcxKxLGYgwqKkDxglGVYQ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UIlJnMjEaXcAaZnJNZZwUJYiLHacjCHgkPDloRReoYFuRcxKxLGYgwqKkDxglGVYQ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UIlJnMjEaXcAaZnJNZZwUJYiLHacjCHgkPDloRReoYFuRcxKxLGYgwqKkDxglGVYQ GetUIlJnMjEaXcAaZnJNZZwUJYiLHacjCHgkPDloRReoYFuRcxKxLGYgwqKkDxglGVYQ(){
        var clasx = new UIlJnMjEaXcAaZnJNZZwUJYiLHacjCHgkPDloRReoYFuRcxKxLGYgwqKkDxglGVYQ();
        return  clasx;
    }

    public string RandomStringUIlJnMjEaXcAaZnJNZZwUJYiLHacjCHgkPDloRReoYFuRcxKxLGYgwqKkDxglGVYQ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class oEMdRAStibPudqIiGCSywZcnBeBFJSXypyTxjRDuhDFPYYdvkyM
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public oEMdRAStibPudqIiGCSywZcnBeBFJSXypyTxjRDuhDFPYYdvkyM()
        {
            
        }
        public oEMdRAStibPudqIiGCSywZcnBeBFJSXypyTxjRDuhDFPYYdvkyM(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public oEMdRAStibPudqIiGCSywZcnBeBFJSXypyTxjRDuhDFPYYdvkyM(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public oEMdRAStibPudqIiGCSywZcnBeBFJSXypyTxjRDuhDFPYYdvkyM GetoEMdRAStibPudqIiGCSywZcnBeBFJSXypyTxjRDuhDFPYYdvkyM(){
        var clasx = new oEMdRAStibPudqIiGCSywZcnBeBFJSXypyTxjRDuhDFPYYdvkyM();
        return  clasx;
    }

    public string RandomStringoEMdRAStibPudqIiGCSywZcnBeBFJSXypyTxjRDuhDFPYYdvkyM(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void ClampToArea()
        {
            Vector3 pos = DragObjectInternal.localPosition;

            Vector3 minPosition = DragAreaInternal.rect.min - DragObjectInternal.rect.min;
            Vector3 maxPosition = DragAreaInternal.rect.max - DragObjectInternal.rect.max;

            pos.x = Mathf.Clamp(DragObjectInternal.localPosition.x, minPosition.x, maxPosition.x);
            pos.y = Mathf.Clamp(DragObjectInternal.localPosition.y, minPosition.y, maxPosition.y);

            DragObjectInternal.localPosition = pos;
        }
    }
}