/// Credit Melang 
/// Sourced from - http://forum.unity3d.com/members/melang.593409/
/// Updated ddreaper - reworked to 4.6.1 standards

using UnityEngine.EventSystems;
namespace UnityEngine.UI
{
    [RequireComponent(typeof(InputField))]
    [AddComponentMenu("UI/Extensions/Return Key Trigger")]
    public class ReturnKeyTriggersButton : MonoBehaviour, ISubmitHandler
    {
        private EventSystem _system;

        public Button button;
        private bool highlight = true;
        public float highlightDuration = 0.2f;
        

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
            _system = EventSystem.current;
        }

        void RemoveHighlight()
        {
            button.OnPointerExit(new PointerEventData(_system));
        }

        public void OnSubmit(BaseEventData eventData)
        {
            if (highlight) button.OnPointerEnter(new PointerEventData(_system));
            button.OnPointerClick(new PointerEventData(_system));

            if (highlight) Invoke("RemoveHighlight", highlightDuration);
        }
    }
}
