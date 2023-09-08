using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

namespace Michsky.MUIP
{
    public class RadialSlider : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler
    {
        private const string PREFS_UI_SAVE_NAME = "Radial";

        // Content
        public float currentValue = 50.0f;

        // Resources
        public Image sliderImage;
        public Transform indicatorPivot;
        public TextMeshProUGUI valueText;

        // Settings
        public float minValue = 0;
        public float maxValue = 100;
        [Range(0, 8)] public int decimals;
        public bool isPercent;
        public StartPoint startPoint = StartPoint.Left;

        // Saving
        public bool rememberValue;
        public string sliderTag;

        // Events
        [System.Serializable]
        public class SliderEvent : UnityEvent<float> { }
        [SerializeField]
        public SliderEvent onValueChanged = new SliderEvent();
        public UnityEvent onPointerEnter;
        public UnityEvent onPointerExit;

        private GraphicRaycaster graphicRaycaster;
        private RectTransform hitRectTransform;
        private bool isPointerDown;
        private float currentAngle;
        private float currentAngleOnPointerDown;
        private float valueDisplayPrecision;

        public enum StartPoint { Left, Right, Top, Down }

        public float SliderAngle
        {
            get { return currentAngle; }
            set { currentAngle = Mathf.Clamp(value, 0.0f, 360.0f); }
        }

        // Slider value with applied display precision, i.e. the number of decimals to show.
        public float SliderValue
        {
            get { return (long)(SliderValueRaw * valueDisplayPrecision) / valueDisplayPrecision; }
            set { SliderValueRaw = value; }
        }

        // Raw slider value, i.e. without any display precision applied to its value.
        public float SliderValueRaw
        {
            get { return SliderAngle / 360.0f * maxValue; }
            set { SliderAngle = value * 360.0f / maxValue; }
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
 private void Awake()
        {
            graphicRaycaster = GetComponentInParent<GraphicRaycaster>();

            if (graphicRaycaster == null)
                Debug.LogWarning("<b>[Radial Slider]</b> Could not find GraphicRaycaster component in parent.", this);
        }

        private void Start()
        {
            valueDisplayPrecision = Mathf.Pow(10, decimals);

            if (rememberValue == true) { LoadState(); }
            else { SliderAngle = currentValue * 3.6f; }

            SliderValue = currentValue;
            onValueChanged.Invoke(SliderValueRaw);
            UpdateUI();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            hitRectTransform = eventData.pointerCurrentRaycast.gameObject.GetComponent<RectTransform>();
            isPointerDown = true;
            currentAngleOnPointerDown = SliderAngle;
            HandleSliderMouseInput(eventData, true);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (HasValueChanged())
                SaveState();

            hitRectTransform = null;
            isPointerDown = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (currentValue >= minValue) { HandleSliderMouseInput(eventData, false); }
            else if (currentValue <= minValue) { SliderValueRaw = minValue; }
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            onPointerEnter.Invoke();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            onPointerExit.Invoke();
        }

        public void LoadState()
        {
            currentAngle = PlayerPrefs.GetFloat(sliderTag + PREFS_UI_SAVE_NAME);
        }

        public void SaveState()
        {
            if (!rememberValue)
                return;

            PlayerPrefs.SetFloat(sliderTag + PREFS_UI_SAVE_NAME, currentAngle);
        }

        public void UpdateUI()
        {
            if (SliderValueRaw >= minValue)
            {
                float normalizedAngle = SliderAngle / 360.0f;
                indicatorPivot.transform.localEulerAngles = new Vector3(180.0f, 0.0f, SliderAngle);
                sliderImage.fillAmount = normalizedAngle;

                valueText.text = string.Format("{0}{1}", SliderValue, isPercent ? "%" : "");
                currentValue = SliderValue;
            }
        }

        private bool HasValueChanged()
        {
            return SliderAngle != currentAngleOnPointerDown;
        }

        private void HandleSliderMouseInput(PointerEventData eventData, bool allowValueWrap)
        {
            if (!isPointerDown)
                return;

            Vector2 localPos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(hitRectTransform, eventData.position, eventData.pressEventCamera, out localPos);
            float newAngle = Mathf.Atan2(-localPos.y, localPos.x) * Mathf.Rad2Deg + 180f;

            if (!allowValueWrap)
            {
                currentAngle = SliderAngle;
                bool needsClamping = Mathf.Abs(newAngle - currentAngle) >= 180;

                if (needsClamping)
                    newAngle = currentAngle < newAngle ? 0.0f : 360.0f;
            }

            SliderAngle = newAngle;
            UpdateUI();

            if (HasValueChanged())
                onValueChanged.Invoke(SliderValueRaw);
        }
    }
}