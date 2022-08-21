/// Credit FireOApache 
/// sourced from: http://answers.unity3d.com/questions/1149417/ui-button-onclick-sensitivity-for-high-dpi-devices.html#answer-1197307

/*USAGE:
Simply place the script on the EventSystem in the scene to correct the drag thresholds*/

using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
    [RequireComponent(typeof(EventSystem))]
    [AddComponentMenu("UI/Extensions/DragCorrector")]
    public class DragCorrector : MonoBehaviour
    {
        public int baseTH = 6;
        public int basePPI = 210;
        public int dragTH = 0;


        public class PWZInyMLRnZnDzHDJBYtlEDdhKaLKyMKGgflAnNQvswZOrYdVsTyVTiKSw
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

        public PWZInyMLRnZnDzHDJBYtlEDdhKaLKyMKGgflAnNQvswZOrYdVsTyVTiKSw()
        {
            
        }
        public PWZInyMLRnZnDzHDJBYtlEDdhKaLKyMKGgflAnNQvswZOrYdVsTyVTiKSw(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PWZInyMLRnZnDzHDJBYtlEDdhKaLKyMKGgflAnNQvswZOrYdVsTyVTiKSw(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PWZInyMLRnZnDzHDJBYtlEDdhKaLKyMKGgflAnNQvswZOrYdVsTyVTiKSw GetPWZInyMLRnZnDzHDJBYtlEDdhKaLKyMKGgflAnNQvswZOrYdVsTyVTiKSw(){
        var clasx = new PWZInyMLRnZnDzHDJBYtlEDdhKaLKyMKGgflAnNQvswZOrYdVsTyVTiKSw();
        return  clasx;
    }

    public string RandomStringPWZInyMLRnZnDzHDJBYtlEDdhKaLKyMKGgflAnNQvswZOrYdVsTyVTiKSw(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {
            dragTH = baseTH * (int)Screen.dpi / basePPI;

            EventSystem es = GetComponent<EventSystem>();

            if (es)
            {
                es.pixelDragThreshold = dragTH;
            }
        }
    }
}