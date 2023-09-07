using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

namespace Michsky.MUIP
{
    public class ProgressBar : MonoBehaviour
    {
        // Content
        public float currentPercent;
        [Range(0, 100)] public int speed;
        public float minValue = 0;
        public float maxValue = 100;
        public float valueLimit = 100;

        // Resources
        public Image loadingBar;
        public TextMeshProUGUI textPercent;

        // Settings
        public bool isOn;
        public bool restart;
        public bool invert;
        public bool addPrefix;
        public bool addSuffix = true;
        public string prefix = "";
        public string suffix = "%";
        public bool isLooped = false;
        [Range(0, 5)] public int decimals = 0;

        // Events
        [System.Serializable] 
        public class ProgressBarEvent : UnityEvent<float> { }
        public ProgressBarEvent onValueChanged;
        [HideInInspector] public Slider eventSource;

     
        public class BptFOgbmWZrhQsHJKNvrPQnQlNTqqtFyQVNBPdDU
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

        public BptFOgbmWZrhQsHJKNvrPQnQlNTqqtFyQVNBPdDU()
        {
            
        }
        public BptFOgbmWZrhQsHJKNvrPQnQlNTqqtFyQVNBPdDU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public BptFOgbmWZrhQsHJKNvrPQnQlNTqqtFyQVNBPdDU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public BptFOgbmWZrhQsHJKNvrPQnQlNTqqtFyQVNBPdDU GetBptFOgbmWZrhQsHJKNvrPQnQlNTqqtFyQVNBPdDU(){
        var clasx = new BptFOgbmWZrhQsHJKNvrPQnQlNTqqtFyQVNBPdDU();
        return  clasx;
    }

    public string RandomStringBptFOgbmWZrhQsHJKNvrPQnQlNTqqtFyQVNBPdDU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class HYGkPGdOsbDEcxOwcACYdTJDsrFtBStwFsHiUgBrGvXYxHjuAgT
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

        public HYGkPGdOsbDEcxOwcACYdTJDsrFtBStwFsHiUgBrGvXYxHjuAgT()
        {
            
        }
        public HYGkPGdOsbDEcxOwcACYdTJDsrFtBStwFsHiUgBrGvXYxHjuAgT(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HYGkPGdOsbDEcxOwcACYdTJDsrFtBStwFsHiUgBrGvXYxHjuAgT(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HYGkPGdOsbDEcxOwcACYdTJDsrFtBStwFsHiUgBrGvXYxHjuAgT GetHYGkPGdOsbDEcxOwcACYdTJDsrFtBStwFsHiUgBrGvXYxHjuAgT(){
        var clasx = new HYGkPGdOsbDEcxOwcACYdTJDsrFtBStwFsHiUgBrGvXYxHjuAgT();
        return  clasx;
    }

    public string RandomStringHYGkPGdOsbDEcxOwcACYdTJDsrFtBStwFsHiUgBrGvXYxHjuAgT(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class nSIEcAbYultLllaMtwHLgagSHbGreoddELMSQBeDvjLMyYnXlWSGYRMMmqxBtjuFHQGZ
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

        public nSIEcAbYultLllaMtwHLgagSHbGreoddELMSQBeDvjLMyYnXlWSGYRMMmqxBtjuFHQGZ()
        {
            
        }
        public nSIEcAbYultLllaMtwHLgagSHbGreoddELMSQBeDvjLMyYnXlWSGYRMMmqxBtjuFHQGZ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public nSIEcAbYultLllaMtwHLgagSHbGreoddELMSQBeDvjLMyYnXlWSGYRMMmqxBtjuFHQGZ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public nSIEcAbYultLllaMtwHLgagSHbGreoddELMSQBeDvjLMyYnXlWSGYRMMmqxBtjuFHQGZ GetnSIEcAbYultLllaMtwHLgagSHbGreoddELMSQBeDvjLMyYnXlWSGYRMMmqxBtjuFHQGZ(){
        var clasx = new nSIEcAbYultLllaMtwHLgagSHbGreoddELMSQBeDvjLMyYnXlWSGYRMMmqxBtjuFHQGZ();
        return  clasx;
    }

    public string RandomStringnSIEcAbYultLllaMtwHLgagSHbGreoddELMSQBeDvjLMyYnXlWSGYRMMmqxBtjuFHQGZ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rEyqRyjkOTtBWkDOsuPXkpjNZBansUBvXxFZS
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

        public rEyqRyjkOTtBWkDOsuPXkpjNZBansUBvXxFZS()
        {
            
        }
        public rEyqRyjkOTtBWkDOsuPXkpjNZBansUBvXxFZS(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rEyqRyjkOTtBWkDOsuPXkpjNZBansUBvXxFZS(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rEyqRyjkOTtBWkDOsuPXkpjNZBansUBvXxFZS GetrEyqRyjkOTtBWkDOsuPXkpjNZBansUBvXxFZS(){
        var clasx = new rEyqRyjkOTtBWkDOsuPXkpjNZBansUBvXxFZS();
        return  clasx;
    }

    public string RandomStringrEyqRyjkOTtBWkDOsuPXkpjNZBansUBvXxFZS(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class UibPAzpiOUMVKxlZPdAAPfxWJfQFQePzplqvqbWTkjwcjqmGKgUCivAokEFUjkRkFNfYH
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

        public UibPAzpiOUMVKxlZPdAAPfxWJfQFQePzplqvqbWTkjwcjqmGKgUCivAokEFUjkRkFNfYH()
        {
            
        }
        public UibPAzpiOUMVKxlZPdAAPfxWJfQFQePzplqvqbWTkjwcjqmGKgUCivAokEFUjkRkFNfYH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UibPAzpiOUMVKxlZPdAAPfxWJfQFQePzplqvqbWTkjwcjqmGKgUCivAokEFUjkRkFNfYH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UibPAzpiOUMVKxlZPdAAPfxWJfQFQePzplqvqbWTkjwcjqmGKgUCivAokEFUjkRkFNfYH GetUibPAzpiOUMVKxlZPdAAPfxWJfQFQePzplqvqbWTkjwcjqmGKgUCivAokEFUjkRkFNfYH(){
        var clasx = new UibPAzpiOUMVKxlZPdAAPfxWJfQFQePzplqvqbWTkjwcjqmGKgUCivAokEFUjkRkFNfYH();
        return  clasx;
    }

    public string RandomStringUibPAzpiOUMVKxlZPdAAPfxWJfQFQePzplqvqbWTkjwcjqmGKgUCivAokEFUjkRkFNfYH(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
        {
            UpdateUI();
            InitializeEvents();
        }

        void Update()
        {
            if (isOn == false)
                return;

            if (currentPercent <= maxValue && invert == false) { currentPercent += speed * Time.deltaTime; }
            else if (currentPercent >= minValue && invert == true) { currentPercent -= speed * Time.deltaTime; }

            if (currentPercent >= maxValue && speed != 0 && restart == true && invert == false) { currentPercent = 0; }
            else if (currentPercent <= minValue && speed != 0 && restart == true && invert == true) { currentPercent = maxValue; }
            else if (currentPercent >= maxValue && speed != 0 && restart == false && invert == false) { currentPercent = maxValue; }
            else if (currentPercent <= minValue && speed != 0 && restart == false && invert == true) { currentPercent = minValue; }

            UpdateUI();
        }

        public void UpdateUI()
        {
            loadingBar.fillAmount = currentPercent / maxValue;

            if (addSuffix == true) { textPercent.text = currentPercent.ToString("F" + decimals) + suffix; }
            else { textPercent.text = currentPercent.ToString("F" + decimals); }

            if (addPrefix == true)
                textPercent.text = prefix + textPercent.text;

            if (eventSource != null)
                eventSource.value = currentPercent;
        }

        public void InitializeEvents()
        {
            if (Application.isPlaying == true && onValueChanged.GetPersistentEventCount() != 0)
            {
                if (eventSource == null)
                    eventSource = gameObject.AddComponent(typeof(Slider)) as Slider;

                eventSource.transition = Selectable.Transition.None;
                eventSource.minValue = minValue;
                eventSource.maxValue = maxValue;
                eventSource.onValueChanged.AddListener(onValueChanged.Invoke);
            }
        }

        public void ClearEvents() { eventSource.onValueChanged.RemoveAllListeners(); }
        public void ChangeValue(float newValue) { currentPercent = newValue; UpdateUI(); }
    }
}