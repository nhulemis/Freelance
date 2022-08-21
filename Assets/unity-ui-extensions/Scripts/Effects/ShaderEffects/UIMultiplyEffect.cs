/// Credit 00christian00
/// Sourced from - http://forum.unity3d.com/threads/any-way-to-show-part-of-an-image-without-using-mask.360085/#post-2332030


namespace UnityEngine.UI.Extensions
{
    [AddComponentMenu("UI/Effects/Extensions/UIMultiplyEffect")]
    [ExecuteInEditMode]
    [RequireComponent(typeof(RectTransform))]
    public class UIMultiplyEffect : MonoBehaviour
    {
        MaskableGraphic mGraphic;

        // Use this for initialization

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
            SetMaterial();
        }

        public void SetMaterial()
        {
            mGraphic = this.GetComponent<MaskableGraphic>();
            if (mGraphic != null)
            {
                if (mGraphic.material == null || mGraphic.material.name == "Default UI Material")
                {
                    //Applying default material with UI Image Crop shader
                    mGraphic.material = new Material(Shader.Find("UI Extensions/UIMultiply"));
                }
            }
            else
            {
                Debug.LogError("Please attach component to a Graphical UI component");
            }
        }
        public void OnValidate()
        {
            SetMaterial();
        }
    }
}