using System;
using _towerStack.Code.Core;
using _towerStack.Code.DataSO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace _towerStack.Code
{
    public class GameManager : MonoBehaviour
    {
        public static event Action OnGameStart;
        public static event Action OnGameEnd;

        [SerializeField] Material _skybox;
        [SerializeField] GradientDataSO _colorData;
        [SerializeField] Image _gradentImage;

        private int _spawnerIndex;
        private bool _firstSpawn = false;
        private CubeSpawner[] _spawners;
        private CubeSpawner _currentSpawner;

   
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
 private void Awake()
        {
            _spawners = FindObjectsOfType<CubeSpawner>();
        }

        private void Start()
        {
            if (MenuManager.Instance.GetCurrentMenu == MenuType.Gameplay)
                SpawnCube();

            SetBackgroundColor();
        }

        private void SetBackgroundColor()
        {
            int colorIndex = UnityEngine.Random.Range(0, _colorData.GradientList.Length);
            _skybox.SetColor("_Top", _colorData.GradientList[colorIndex].colour[0]);
            _skybox.SetColor("_Bottom", _colorData.GradientList[colorIndex].colour[1]);
            _gradentImage.color = _colorData.GradientList[colorIndex].colour[1];
        }

        private void Update()
        {
#if UNITY_EDITOR
            GetInput();
#endif

#if UNITY_ANDROID
            GetMobileInput();
#endif
        }

        private void GetMobileInput()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.touches[0];
                if (touch.phase == TouchPhase.Began && !EventSystem.current.IsPointerOverGameObject(touch.fingerId))
                {
                    SpawnCube();
                }
            }
        }

        private void GetInput()
        {
            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                SpawnCube();
            }
        }

        private void SpawnCube()
        {
            if (MovingCube.CurrentCube == null) return;

            if (!_firstSpawn)
            {
                _firstSpawn = true;
                OnGameStart?.Invoke();

                if (MenuManager.Instance.GetCurrentMenu != MenuType.Gameplay)
                {
                    MenuManager.Instance.SwitchMenu(MenuType.Gameplay);
                }
            }

            bool isGameOver = MovingCube.CurrentCube.Stop();

            if (!isGameOver)
            {
                _spawnerIndex = _spawnerIndex == 0 ? 1 : 0;
                _currentSpawner = _spawners[_spawnerIndex];
                _currentSpawner.SpawnCube();
            }
            else
            {
                OnGameEnd?.Invoke();
                MenuManager.Instance.SwitchMenu(MenuType.GameOver);

                SoundManager.Instance.PlayAudio(AudioType.GAMEOVER);
                VibrationManager.Instance.StartVibration();
            }
        }
    }
}
