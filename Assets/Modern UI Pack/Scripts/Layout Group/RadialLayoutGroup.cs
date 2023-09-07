using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
    [AddComponentMenu("Modern UI Pack/Layout Group/Radial Layout Group")]
    public class RadialLayoutGroup : LayoutGroup
    {
        public enum Direction { Clockwise = 0, Counterclockwise = 1, Bidirectional = 2 }

        public enum ConstraintMode { Interval = 0, Range = 1 }

        [SerializeField] private Direction refLayoutDir;
        public Direction layoutDir { get { return refLayoutDir; } set { SetProperty(ref refLayoutDir, value); } }

        [SerializeField] private float refRadiusStart = 200;
        public float radiusStart { get { return refRadiusStart; } set { SetProperty(ref refRadiusStart, value); } }

        [SerializeField] private float refRadiusDelta;
        public float radiusDelta { get { return refRadiusDelta; } set { SetProperty(ref refRadiusDelta, value); } }

        [SerializeField] private float refRadiusRange;
        public float radiusRange { get { return refRadiusRange; } set { SetProperty(ref refRadiusRange, value); } }

        [SerializeField] private float refAngleDelta;
        public float angleDelta { get { return refAngleDelta; } set { SetProperty(ref refAngleDelta, value); } }

        [SerializeField] private float refAngleStart;
        public float angleStart { get { return refAngleStart; } set { SetProperty(ref refAngleStart, value); } }

        [SerializeField] private float refAngleCenter;
        public float angleCenter { get { return refAngleCenter; } set { SetProperty(ref refAngleCenter, value); } }

        [SerializeField] private float refAngleRange = 200;
        public float angleRange { get { return refAngleRange; } set { SetProperty(ref refAngleRange, value); } }

        [SerializeField] private bool refChildRotate = false;
        public bool childRotate { get { return refChildRotate; } set { SetProperty(ref refChildRotate, value); } }

        public override void CalculateLayoutInputVertical() { }
        public override void CalculateLayoutInputHorizontal() { }
        public override void SetLayoutHorizontal() { CalculateChildrenPositions(); }
        public override void SetLayoutVertical() { CalculateChildrenPositions(); }

        private List<RectTransform> childList = new List<RectTransform>();
        private List<ILayoutIgnorer> ignoreList = new List<ILayoutIgnorer>();

       
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
 private void CalculateChildrenPositions()
        {
            this.m_Tracker.Clear();
            childList.Clear();

            for (int i = 0; i < this.transform.childCount; ++i)
            {
                RectTransform rect = this.transform.GetChild(i) as RectTransform;

                if (!rect.gameObject.activeSelf)
                    continue;

                ignoreList.Clear();
                rect.GetComponents(ignoreList);

                if (ignoreList.Count == 0)
                {
                    childList.Add(rect);
                    continue;
                }

                for (int j = 0; j < ignoreList.Count; j++)
                {
                    if (!ignoreList[j].ignoreLayout)
                    {
                        childList.Add(rect);
                        break;
                    }
                }

                ignoreList.Clear();
            }

            EnsureParameters(childList.Count);

            for (int i = 0; i < childList.Count; ++i)
            {
                var child = childList[i];
                float delta = i * angleDelta;
                float angle = layoutDir == Direction.Clockwise ? angleStart - delta : angleStart + delta;
                ProcessOneChild(child, angle, radiusStart + (i * radiusDelta));
            }

            childList.Clear();
        }

        private void EnsureParameters(int childCount)
        {
            EnsureAngleParameters(childCount);
            EnsureRadiusParameters(childCount);
        }

        private void EnsureAngleParameters(int childCount)
        {
            int intervalCount = childCount - 1;

            switch (layoutDir)
            {
                case Direction.Clockwise:
                    if (intervalCount > 0) { this.angleDelta = this.angleRange / intervalCount; }
                    else { this.angleDelta = 0; }
                    break;

                case Direction.Counterclockwise:
                    if (intervalCount > 0) { this.angleDelta = this.angleRange / intervalCount; }
                    else { this.angleDelta = 0; }
                    break;

                case Direction.Bidirectional:
                    if (intervalCount > 0) { this.angleDelta = this.angleRange / intervalCount; }
                    else { this.angleDelta = 0; }
                    this.angleStart = this.angleCenter - angleRange * 0.5f;
                    break;
            }
        }


        private void EnsureRadiusParameters(int childCount)
        {
            int intervalCount = childCount - 1;

            switch (layoutDir)
            {
                case Direction.Clockwise:
                    if (intervalCount > 0) { this.radiusDelta = radiusRange / intervalCount; }
                    else { this.radiusDelta = 0; }
                    break;

                case Direction.Counterclockwise:

                case Direction.Bidirectional:
                    if (intervalCount > 0) { this.radiusDelta = radiusRange / intervalCount; }
                    else { this.radiusDelta = 0; }
                    break;
            }
        }

        private static readonly Vector2 center = new Vector2(0.5f, 0.5f);

        private void ProcessOneChild(RectTransform child, float angle, float radius)
        {
            Vector3 pos = new Vector3(
                Mathf.Cos(angle * Mathf.Deg2Rad),
                Mathf.Sin(angle * Mathf.Deg2Rad),
                0.0f);
            child.localPosition = pos * radius;

            DrivenTransformProperties drivenProperties =
                DrivenTransformProperties.Anchors | DrivenTransformProperties.AnchoredPosition | DrivenTransformProperties.Rotation | DrivenTransformProperties.Pivot;
            m_Tracker.Add(this, child, drivenProperties);

            child.anchorMin = center;
            child.anchorMax = center;
            child.pivot = center;

            if (this.childRotate) { child.localEulerAngles = new Vector3(0, 0, angle); }
            else { child.localEulerAngles = Vector3.zero; }
        }
    }
}
