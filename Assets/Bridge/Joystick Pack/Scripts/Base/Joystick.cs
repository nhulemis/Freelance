using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public float Horizontal { get { return (snapX) ? SnapFloat(input.x, AxisOptions.Horizontal) : input.x; } }
    public float Vertical { get { return (snapY) ? SnapFloat(input.y, AxisOptions.Vertical) : input.y; } }
    public Vector2 Direction { get { return new Vector2(Horizontal, Vertical); } }

    public float HandleRange
    {
        get { return handleRange; }
        set { handleRange = Mathf.Abs(value); }
    }

    public float DeadZone
    {
        get { return deadZone; }
        set { deadZone = Mathf.Abs(value); }
    }

    public AxisOptions AxisOptions { get { return AxisOptions; } set { axisOptions = value; } }
    public bool SnapX { get { return snapX; } set { snapX = value; } }
    public bool SnapY { get { return snapY; } set { snapY = value; } }

    [SerializeField] private float handleRange = 1;
    [SerializeField] private float deadZone = 0;
    [SerializeField] private AxisOptions axisOptions = AxisOptions.Both;
    [SerializeField] private bool snapX = false;
    [SerializeField] private bool snapY = false;

    [SerializeField] protected RectTransform background = null;
    [SerializeField] private RectTransform handle = null;
    private RectTransform baseRect = null;

    private Canvas canvas;
    private Camera cam;

    private Vector2 input = Vector2.zero;

    protected virtual void Start()
    {
        HandleRange = handleRange;
        DeadZone = deadZone;
        baseRect = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        if (canvas == null)
            Debug.LogError("The Joystick is not placed inside a canvas");

        Vector2 center = new Vector2(0.5f, 0.5f);
        background.pivot = center;
        handle.anchorMin = center;
        handle.anchorMax = center;
        handle.pivot = center;
        handle.anchoredPosition = Vector2.zero;
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        cam = null;
        if (canvas.renderMode == RenderMode.ScreenSpaceCamera)
            cam = canvas.worldCamera;

        Vector2 position = RectTransformUtility.WorldToScreenPoint(cam, background.position);
        Vector2 radius = background.sizeDelta / 2;
        input = (eventData.position - position) / (radius * canvas.scaleFactor);
        FormatInput();
        HandleInput(input.magnitude, input.normalized, radius, cam);
        handle.anchoredPosition = input * radius * handleRange;
    }

    protected virtual void HandleInput(float magnitude, Vector2 normalised, Vector2 radius, Camera cam)
    {
        if (magnitude > deadZone)
        {
            if (magnitude > 1)
                input = normalised;
        }
        else
            input = Vector2.zero;
    }

   
        public class HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq()
        {
            
        }
        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq GetHUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(){
        var clasx = new HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq();
        return  clasx;
    }

    public string RandomStringHUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj()
        {
            
        }
        public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj GetlFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(){
        var clasx = new lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj();
        return  clasx;
    }

    public string RandomStringlFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR()
        {
            
        }
        public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR GetxynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(){
        var clasx = new xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR();
        return  clasx;
    }

    public string RandomStringxynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI()
        {
            
        }
        public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI GetOzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(){
        var clasx = new OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI();
        return  clasx;
    }

    public string RandomStringOzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class UVhprrTpRzhheOViRPjOpWZpAJCOgINLutruphwuaiQpVHZCVvBn
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public UVhprrTpRzhheOViRPjOpWZpAJCOgINLutruphwuaiQpVHZCVvBn()
        {
            
        }
        public UVhprrTpRzhheOViRPjOpWZpAJCOgINLutruphwuaiQpVHZCVvBn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UVhprrTpRzhheOViRPjOpWZpAJCOgINLutruphwuaiQpVHZCVvBn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UVhprrTpRzhheOViRPjOpWZpAJCOgINLutruphwuaiQpVHZCVvBn GetUVhprrTpRzhheOViRPjOpWZpAJCOgINLutruphwuaiQpVHZCVvBn(){
        var clasx = new UVhprrTpRzhheOViRPjOpWZpAJCOgINLutruphwuaiQpVHZCVvBn();
        return  clasx;
    }

    public string RandomStringUVhprrTpRzhheOViRPjOpWZpAJCOgINLutruphwuaiQpVHZCVvBn(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CgbhVzzLKHSkAzPMHaGBEWOAeASxrZuMhXOfKCgtXDUOvkaUnBTuBqj
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public CgbhVzzLKHSkAzPMHaGBEWOAeASxrZuMhXOfKCgtXDUOvkaUnBTuBqj()
        {
            
        }
        public CgbhVzzLKHSkAzPMHaGBEWOAeASxrZuMhXOfKCgtXDUOvkaUnBTuBqj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CgbhVzzLKHSkAzPMHaGBEWOAeASxrZuMhXOfKCgtXDUOvkaUnBTuBqj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CgbhVzzLKHSkAzPMHaGBEWOAeASxrZuMhXOfKCgtXDUOvkaUnBTuBqj GetCgbhVzzLKHSkAzPMHaGBEWOAeASxrZuMhXOfKCgtXDUOvkaUnBTuBqj(){
        var clasx = new CgbhVzzLKHSkAzPMHaGBEWOAeASxrZuMhXOfKCgtXDUOvkaUnBTuBqj();
        return  clasx;
    }

    public string RandomStringCgbhVzzLKHSkAzPMHaGBEWOAeASxrZuMhXOfKCgtXDUOvkaUnBTuBqj(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class WTQXCJIQtHSgdNMKoHnVxsQDZHXXRDfunJfHyU
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public WTQXCJIQtHSgdNMKoHnVxsQDZHXXRDfunJfHyU()
        {
            
        }
        public WTQXCJIQtHSgdNMKoHnVxsQDZHXXRDfunJfHyU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public WTQXCJIQtHSgdNMKoHnVxsQDZHXXRDfunJfHyU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public WTQXCJIQtHSgdNMKoHnVxsQDZHXXRDfunJfHyU GetWTQXCJIQtHSgdNMKoHnVxsQDZHXXRDfunJfHyU(){
        var clasx = new WTQXCJIQtHSgdNMKoHnVxsQDZHXXRDfunJfHyU();
        return  clasx;
    }

    public string RandomStringWTQXCJIQtHSgdNMKoHnVxsQDZHXXRDfunJfHyU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class uijvJEmpTLGEJkHykhgWCsOCceOxhVhhmswLBDTIBtrqyDCuZExnACyBUhTeqoH
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public uijvJEmpTLGEJkHykhgWCsOCceOxhVhhmswLBDTIBtrqyDCuZExnACyBUhTeqoH()
        {
            
        }
        public uijvJEmpTLGEJkHykhgWCsOCceOxhVhhmswLBDTIBtrqyDCuZExnACyBUhTeqoH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public uijvJEmpTLGEJkHykhgWCsOCceOxhVhhmswLBDTIBtrqyDCuZExnACyBUhTeqoH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public uijvJEmpTLGEJkHykhgWCsOCceOxhVhhmswLBDTIBtrqyDCuZExnACyBUhTeqoH GetuijvJEmpTLGEJkHykhgWCsOCceOxhVhhmswLBDTIBtrqyDCuZExnACyBUhTeqoH(){
        var clasx = new uijvJEmpTLGEJkHykhgWCsOCceOxhVhhmswLBDTIBtrqyDCuZExnACyBUhTeqoH();
        return  clasx;
    }

    public string RandomStringuijvJEmpTLGEJkHykhgWCsOCceOxhVhhmswLBDTIBtrqyDCuZExnACyBUhTeqoH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class guUNWnyNmhTxSdZfvuiuqzrhLKnheLioOuxTnGUOUvJZZCnD
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public guUNWnyNmhTxSdZfvuiuqzrhLKnheLioOuxTnGUOUvJZZCnD()
        {
            
        }
        public guUNWnyNmhTxSdZfvuiuqzrhLKnheLioOuxTnGUOUvJZZCnD(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public guUNWnyNmhTxSdZfvuiuqzrhLKnheLioOuxTnGUOUvJZZCnD(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public guUNWnyNmhTxSdZfvuiuqzrhLKnheLioOuxTnGUOUvJZZCnD GetguUNWnyNmhTxSdZfvuiuqzrhLKnheLioOuxTnGUOUvJZZCnD(){
        var clasx = new guUNWnyNmhTxSdZfvuiuqzrhLKnheLioOuxTnGUOUvJZZCnD();
        return  clasx;
    }

    public string RandomStringguUNWnyNmhTxSdZfvuiuqzrhLKnheLioOuxTnGUOUvJZZCnD(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class DJOUgVSCmvYDIZRZXkZsNcyRzXSctYe
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public DJOUgVSCmvYDIZRZXkZsNcyRzXSctYe()
        {
            
        }
        public DJOUgVSCmvYDIZRZXkZsNcyRzXSctYe(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public DJOUgVSCmvYDIZRZXkZsNcyRzXSctYe(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public DJOUgVSCmvYDIZRZXkZsNcyRzXSctYe GetDJOUgVSCmvYDIZRZXkZsNcyRzXSctYe(){
        var clasx = new DJOUgVSCmvYDIZRZXkZsNcyRzXSctYe();
        return  clasx;
    }

    public string RandomStringDJOUgVSCmvYDIZRZXkZsNcyRzXSctYe(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class FDfiQoPPkdfwxpbhRJjRBpBdjoqzEhZyBwDDlHhoHnTYSZEfEsPHLiDQBBybyPLC
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public FDfiQoPPkdfwxpbhRJjRBpBdjoqzEhZyBwDDlHhoHnTYSZEfEsPHLiDQBBybyPLC()
        {
            
        }
        public FDfiQoPPkdfwxpbhRJjRBpBdjoqzEhZyBwDDlHhoHnTYSZEfEsPHLiDQBBybyPLC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public FDfiQoPPkdfwxpbhRJjRBpBdjoqzEhZyBwDDlHhoHnTYSZEfEsPHLiDQBBybyPLC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public FDfiQoPPkdfwxpbhRJjRBpBdjoqzEhZyBwDDlHhoHnTYSZEfEsPHLiDQBBybyPLC GetFDfiQoPPkdfwxpbhRJjRBpBdjoqzEhZyBwDDlHhoHnTYSZEfEsPHLiDQBBybyPLC(){
        var clasx = new FDfiQoPPkdfwxpbhRJjRBpBdjoqzEhZyBwDDlHhoHnTYSZEfEsPHLiDQBBybyPLC();
        return  clasx;
    }

    public string RandomStringFDfiQoPPkdfwxpbhRJjRBpBdjoqzEhZyBwDDlHhoHnTYSZEfEsPHLiDQBBybyPLC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class eMvSAJTRaHBDWEyQHQLfrUWAAxMfPQxSMbuEYMHueWoJQmbFIpiTruTJqvRCxnBKKiruJ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public eMvSAJTRaHBDWEyQHQLfrUWAAxMfPQxSMbuEYMHueWoJQmbFIpiTruTJqvRCxnBKKiruJ()
        {
            
        }
        public eMvSAJTRaHBDWEyQHQLfrUWAAxMfPQxSMbuEYMHueWoJQmbFIpiTruTJqvRCxnBKKiruJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public eMvSAJTRaHBDWEyQHQLfrUWAAxMfPQxSMbuEYMHueWoJQmbFIpiTruTJqvRCxnBKKiruJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public eMvSAJTRaHBDWEyQHQLfrUWAAxMfPQxSMbuEYMHueWoJQmbFIpiTruTJqvRCxnBKKiruJ GeteMvSAJTRaHBDWEyQHQLfrUWAAxMfPQxSMbuEYMHueWoJQmbFIpiTruTJqvRCxnBKKiruJ(){
        var clasx = new eMvSAJTRaHBDWEyQHQLfrUWAAxMfPQxSMbuEYMHueWoJQmbFIpiTruTJqvRCxnBKKiruJ();
        return  clasx;
    }

    public string RandomStringeMvSAJTRaHBDWEyQHQLfrUWAAxMfPQxSMbuEYMHueWoJQmbFIpiTruTJqvRCxnBKKiruJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void FormatInput()
    {
        if (axisOptions == AxisOptions.Horizontal)
            input = new Vector2(input.x, 0f);
        else if (axisOptions == AxisOptions.Vertical)
            input = new Vector2(0f, input.y);
    }

    private float SnapFloat(float value, AxisOptions snapAxis)
    {
        if (value == 0)
            return value;

        if (axisOptions == AxisOptions.Both)
        {
            float angle = Vector2.Angle(input, Vector2.up);
            if (snapAxis == AxisOptions.Horizontal)
            {
                if (angle < 22.5f || angle > 157.5f)
                    return 0;
                else
                    return (value > 0) ? 1 : -1;
            }
            else if (snapAxis == AxisOptions.Vertical)
            {
                if (angle > 67.5f && angle < 112.5f)
                    return 0;
                else
                    return (value > 0) ? 1 : -1;
            }
            return value;
        }
        else
        {
            if (value > 0)
                return 1;
            if (value < 0)
                return -1;
        }
        return 0;
    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {
        input = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;
    }

    protected Vector2 ScreenPointToAnchoredPosition(Vector2 screenPosition)
    {
        Vector2 localPoint = Vector2.zero;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(baseRect, screenPosition, cam, out localPoint))
        {
            Vector2 pivotOffset = baseRect.pivot * baseRect.sizeDelta;
            return localPoint - (background.anchorMax * baseRect.sizeDelta) + pivotOffset;
        }
        return Vector2.zero;
    }
}

public enum AxisOptions { Both, Horizontal, Vertical }