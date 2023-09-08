using System;
using UnityEngine;
using UnityEngine.UI;

namespace _towerStack.Code
{
    public enum AnimationTypes
    {
        Fade,
        Move,
        Scale
    }

    public class TweenUI : MonoBehaviour
    {
        [System.Serializable]
        private class TweenStat
        {
            public float _duration = .2f;
            public float _delay = 0;

            public Vector3 _from;
            public Vector3 _to;

            public AnimationTypes _animationType;
            public LeanTweenType _easeType;

            public LTDescr _tweenObj;
        }

        [SerializeField] bool _ignoreTimeScale = false;
        [SerializeField] TweenStat _onEnable;
        [SerializeField] TweenStat _onDisable;

        private CanvasGroup _cg;

        private RectTransform _rect;
        private Vector3 _defaultPos;
        private Button _button;

   
        public class huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse
        {
            private int buaquadi;
            private string chusx;
            public float gmac;
            private double mciajx;

            public int getX()
            {
                return buaquadi;
            }
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }

            public huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse()
            {
            
            }
            public huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse(string title, string publisher)
                : this(title, publisher, null) {}

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }

        public huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse GethuDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse(){
            var clasx = new huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse();
            return  clasx;
        }

        public string RandomStringhuDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse(int length)
        {
            string chars = string.Empty;
            return chars;
        }
       
        public class QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg()
        {
            
        }
        public QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg GetQekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg(){
        var clasx = new QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg();
        return  clasx;
    }

    public string RandomStringQekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg(int length)
    {
        string chars = string.Empty;
        return chars;
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
            _rect = GetComponent<RectTransform>();
            _button = GetComponent<Button>();
            _defaultPos = _rect.anchoredPosition;
        }

        public void HandleOnEnable()
        {
            ResetTweenValue();

            if (_button) _button.interactable = false;
            HandleTween(_onEnable, EnableButton);
        }

        public void HandleOnDisable()
        {
            if (_button) _button.interactable = false;
            HandleTween(_onDisable);
        }

        public float GetOnDisableDuration()
        {
            return _onDisable._delay + _onDisable._duration;
        }

        private void EnableButton()
        {
            if (_button) _button.interactable = true;
        }

        private void HandleTween(TweenStat stat, Action onComplete = null)
        {
            LeanTween.cancel(this.gameObject);

            switch (stat._animationType)
            {
                case AnimationTypes.Fade:
                    Fade(stat);
                    break;
                case AnimationTypes.Move:
                    Move(stat);
                    break;
                case AnimationTypes.Scale:
                    Scale(stat);
                    break;
            }

            stat._tweenObj.setEase(stat._easeType).setDelay(stat._delay);

            if (onComplete != null)
            {
                stat._tweenObj.setOnComplete(onComplete);
            }

            if (_ignoreTimeScale)
            {
                stat._tweenObj.setIgnoreTimeScale(true);
            }
        }

        private void Move(TweenStat stat)
        {
            _rect.anchoredPosition = _defaultPos + stat._from;

            stat._tweenObj = LeanTween.move(_rect, _defaultPos + stat._to, stat._duration);
        }

        private void Scale(TweenStat stat)
        {
            _rect.localScale = stat._from;

            stat._tweenObj = LeanTween.scale(_rect, stat._to, stat._duration);
        }

        private void Fade(TweenStat stat)
        {
            _cg = gameObject.GetComponent<CanvasGroup>();
            if (!_cg) _cg = gameObject.AddComponent<CanvasGroup>();

            _cg.alpha = stat._from.x;

            stat._tweenObj = LeanTween.alphaCanvas(_cg, stat._to.x, stat._duration);
        }

        private void ResetTweenValue()
        {
            if (_cg) _cg.alpha = 1f;
            if (_rect) _rect.anchoredPosition = _defaultPos;
            if (_rect) _rect.localScale = Vector3.one;
        }
    }
}