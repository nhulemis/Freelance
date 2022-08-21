/// Credit Ziboo
/// Sourced from - http://forum.unity3d.com/threads/free-reorderable-list.364600/

using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
    public class ReorderableListContent : MonoBehaviour
    {
        private List<Transform> _cachedChildren;
        private List<ReorderableListElement> _cachedListElement;
        private ReorderableListElement _ele;
        private ReorderableList _extList;
        private RectTransform _rect;

       
        public class UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU
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

        public UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU()
        {
            
        }
        public UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU GetUmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU(){
        var clasx = new UmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU();
        return  clasx;
    }

    public string RandomStringUmfWsaiCjNJinrUYBASszfHDtPdFCoApTQSMlCoGaMFTAuHZwAPHDONoebcdwczuMU(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void OnEnable()
        {
            if(_rect)StartCoroutine(RefreshChildren());
        }


        public void OnTransformChildrenChanged()
        {
            if(this.isActiveAndEnabled)StartCoroutine(RefreshChildren());
        }

        public void Init(ReorderableList extList)
        {
            _extList = extList;
            _rect = GetComponent<RectTransform>();
            _cachedChildren = new List<Transform>();
            _cachedListElement = new List<ReorderableListElement>();

            StartCoroutine(RefreshChildren());
        }

        private IEnumerator RefreshChildren()
        {
            //Handle new chilren
            for (int i = 0; i < _rect.childCount; i++)
            {
                if (_cachedChildren.Contains(_rect.GetChild(i)))
                    continue;

                //Get or Create ReorderableListElement
                _ele = _rect.GetChild(i).gameObject.GetComponent<ReorderableListElement>() ??
                       _rect.GetChild(i).gameObject.AddComponent<ReorderableListElement>();
                _ele.Init(_extList);

                _cachedChildren.Add(_rect.GetChild(i));
                _cachedListElement.Add(_ele);
            }

            //HACK a little hack, if I don't wait one frame I don't have the right deleted children
            yield return 0;

            //Remove deleted child
            for (int i = _cachedChildren.Count - 1; i >= 0; i--)
            {
                if (_cachedChildren[i] == null)
                {
                    _cachedChildren.RemoveAt(i);
                    _cachedListElement.RemoveAt(i);
                }
            }
        }
    }
}