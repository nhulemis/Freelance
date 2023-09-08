using System.Collections;
using _towerStack.Code.Saving;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _towerStack.Code
{
    public class SettingMenu : Menu
    {
        [Header("Inherit References :")]
        [SerializeField] private Button _adsButton;
        [SerializeField] private Button _policyButton;
        [SerializeField] private Button _closeButton;
        [SerializeField] private Button _toggleMusicButton;
        [SerializeField] private Button _toggleSFXButton;
        [SerializeField] private Button _toggleVibrateButton;

        [Space]
        [SerializeField] private RectTransform _panel;


        [Header("SFX Image Toggle")]
        [SerializeField] Sprite _sfxTrue;
        [SerializeField] Sprite _sfxFalse;

        [Header("Music Image Toggle")]
        [SerializeField] Sprite _musicTrue;
        [SerializeField] Sprite _musicFalse;

        [Header("Vibrate Image Toggle")]
        [SerializeField] Sprite _vibrateTrue;
        [SerializeField] Sprite _vibrateFalse;

        private Image _musicImage;
        private Image _sfxImage;
        private Image _vibrateImage;

        public override void SetEnable()
        {
            base.SetEnable();
            _adsButton.interactable = true;
            _policyButton.interactable = true;
            _closeButton.interactable = true;

            SetIconToggle();
        }

   
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
 private void Start()
        {
        

            _musicImage = _toggleMusicButton.GetComponent<Image>();
            _sfxImage = _toggleSFXButton.GetComponent<Image>();
            _vibrateImage = _toggleVibrateButton.GetComponent<Image>();

            OnButtonPressed(_adsButton, AdsButtonListener);
            OnButtonPressed(_policyButton, PolicyButtonListener);
            OnButtonPressed(_closeButton, CloseButtonListener);
            OnButtonPressed(_toggleMusicButton, ToggleMusicButtonListener);
            OnButtonPressed(_toggleSFXButton, ToggleSFXButtonListener);
            OnButtonPressed(_toggleVibrateButton, ToggleVibrateButtonListener);

            SetIconToggle();
        }

        private void SetIconToggle()
        {
            _musicImage.sprite = SaveData.GetMusicState() ? _musicTrue : _musicFalse;
            _sfxImage.sprite = SaveData.GetSfxState() ? _sfxTrue : _sfxFalse;
            _vibrateImage.sprite = SaveData.GetVibrateState() ? _vibrateTrue : _vibrateFalse;
        }

        private void ToggleMusicButtonListener()
        {
            SoundManager.Instance.ToggleMusic();
            _musicImage.sprite = SaveData.GetMusicState() ? _musicTrue : _musicFalse;
        }

        private void ToggleSFXButtonListener()
        {
            SoundManager.Instance.ToggleFX();
            _sfxImage.sprite = SaveData.GetSfxState() ? _sfxTrue : _sfxFalse;
        }

        private void ToggleVibrateButtonListener()
        {
            VibrationManager.Instance.ToggleVibration();
            _vibrateImage.sprite = SaveData.GetVibrateState() ? _vibrateTrue : _vibrateFalse;

            VibrationManager.Instance.StartVibration();
        }

        private void CloseButtonListener()
        {
            _closeButton.interactable = false;
            MenuManager.Instance.CloseMenu();
        }

        private void AdsButtonListener()
        {
            _adsButton.interactable = false;

            PlayerPrefs.SetInt("npa", -1);

            SoundManager.Instance.DestroyObject();

            //load gdpr scene
            StartCoroutine(LoadGDPRAsyncScene());
        }

        IEnumerator LoadGDPRAsyncScene()
        {
            yield return SceneManager.LoadSceneAsync(0);
            MenuManager.Instance.DestroyObject();
        }

        private void PolicyButtonListener()
        {
            Application.OpenURL("https://www.freeprivacypolicy.com/live/7358c13e-6f0a-4d98-bcd2-029abf2fb4b8");
        }
    }
}
