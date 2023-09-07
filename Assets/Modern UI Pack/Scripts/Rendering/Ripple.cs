using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
    public class Ripple : MonoBehaviour
    {
        public bool unscaledTime = false;
        public float speed;
        public float maxSize;
        public Color startColor;
        public Color transitionColor;
        Image colorImg;

     
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
   void Start()
        {
            transform.localScale = new Vector3(0f, 0f, 0f);
            colorImg = GetComponent<Image>();
            colorImg.raycastTarget = false;
            colorImg.color = new Color(startColor.r, startColor.g, startColor.b, startColor.a);
        }

        void Update()
        {
            if (unscaledTime == false)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(maxSize, maxSize, maxSize), Time.deltaTime * speed);
                colorImg.color = Color.Lerp(colorImg.color, new Color(transitionColor.r, transitionColor.g, transitionColor.b, transitionColor.a), Time.deltaTime * speed);

                if (transform.localScale.x >= maxSize * 0.998)
                {
                    if (transform.parent.childCount == 1) { transform.parent.gameObject.SetActive(false); }
                    Destroy(gameObject);
                }
            }

            else
            {
                transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(maxSize, maxSize, maxSize), Time.unscaledDeltaTime * speed);
                colorImg.color = Color.Lerp(colorImg.color, new Color(transitionColor.r, transitionColor.g, transitionColor.b, transitionColor.a), Time.unscaledDeltaTime * speed);

                if (transform.localScale.x >= maxSize * 0.998)
                {
                    if (transform.parent.childCount == 1) { transform.parent.gameObject.SetActive(false); }
                    Destroy(gameObject);
                }
            }
        }
    }
}