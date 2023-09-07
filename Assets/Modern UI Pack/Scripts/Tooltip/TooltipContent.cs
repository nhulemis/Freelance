using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

namespace Michsky.MUIP
{
    [AddComponentMenu("Modern UI Pack/Tooltip/Tooltip Content")]
    public class TooltipContent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Header("Content")]
        [TextArea] public string description;
        public float delay;

        [Header("Resources")]
        public GameObject tooltipRect;
        public TextMeshProUGUI descriptionText;

        [Header("Settings")]
        public bool forceToUpdate = false;
        public bool useIn3D = false;

        TooltipManager tpManager;
        [HideInInspector] public Animator tooltipAnimator;

     
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
            if (tooltipRect == null || descriptionText == null)
            {
                try
                {
                    tooltipRect = GameObject.Find("Tooltip Rect");
                    descriptionText = tooltipRect.transform.GetComponentInChildren<TextMeshProUGUI>();
                }

                catch { Debug.LogError("<b>[Tooltip Content]</b> Tooltip Rect is missing.", this); return; }
            }

            if (tooltipRect != null)
            {
                tpManager = tooltipRect.GetComponentInParent<TooltipManager>();
                tooltipAnimator = tooltipRect.GetComponentInParent<Animator>();
            }

            if (tpManager.contentLE == null)
                tpManager.contentLE = descriptionText.GetComponent<LayoutElement>();
        }

        public void ProcessEnter()
        {
            if (tooltipRect == null)
                return;

            descriptionText.text = description;
          
            tpManager.allowUpdate = true;
            tpManager.currentTooltip = this;
         
            CheckForContentWidth();

            StopCoroutine("DisableAnimator");
            tooltipAnimator.gameObject.SetActive(false);
            tooltipAnimator.gameObject.SetActive(true);

            if (delay == 0) { tooltipAnimator.Play("In"); }
            else { StartCoroutine("ShowTooltip"); }

            if (forceToUpdate == true)
                StartCoroutine("UpdateLayoutPosition");
        }

        public void ProcessExit()
        {
            if (tooltipRect == null)
                return;

            if (delay != 0)
            {
                StopCoroutine("ShowTooltip");

                if (tooltipAnimator.GetCurrentAnimatorStateInfo(0).IsName("In"))
                    tooltipAnimator.Play("Out");
            }

            else { tooltipAnimator.Play("Out"); }

            tpManager.allowUpdate = false;
        }

        public void OnPointerEnter(PointerEventData eventData) { ProcessEnter(); }
        public void OnPointerExit(PointerEventData eventData) { ProcessExit(); }
        public void OnMouseEnter() { if (useIn3D == true) { ProcessEnter(); } }
        public void OnMouseExit() { if (useIn3D == true) { ProcessExit(); } }

        public void CheckForContentWidth() { LayoutElementCreator(); StartCoroutine("CalculateContentWidth"); }

       
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
 private void LayoutElementCreator()
        {
            if (tpManager.contentLE == null)
            {
                descriptionText.gameObject.AddComponent<LayoutElement>();
                tpManager.contentLE = descriptionText.GetComponent<LayoutElement>();
            }

            tpManager.contentLE.preferredWidth = tpManager.preferredWidth;
            tpManager.contentLE.enabled = false;
        }

        IEnumerator CalculateContentWidth()
        {
            yield return new WaitForSecondsRealtime(0.05f);
            float tempWidth = descriptionText.GetComponent<RectTransform>().sizeDelta.x;
     
            if (tempWidth >= tpManager.preferredWidth + 1)
                tpManager.contentLE.enabled = true;

            LayoutRebuilder.ForceRebuildLayoutImmediate(tpManager.contentLE.gameObject.GetComponent<RectTransform>());
            tpManager.contentLE.preferredWidth = tpManager.preferredWidth;
        }

        IEnumerator ShowTooltip()
        {
            yield return new WaitForSeconds(delay);
            tooltipAnimator.Play("In");
            StopCoroutine("ShowTooltip");
        }

        IEnumerator UpdateLayoutPosition()
        {
            yield return new WaitForSecondsRealtime(0.05f);
            LayoutRebuilder.ForceRebuildLayoutImmediate(tooltipAnimator.gameObject.GetComponent<RectTransform>());
        }
    }
}