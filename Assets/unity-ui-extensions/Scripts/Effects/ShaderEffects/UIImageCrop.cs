/// Credit 00christian00
/// Sourced from - http://forum.unity3d.com/threads/any-way-to-show-part-of-an-image-without-using-mask.360085/#post-2332030


namespace UnityEngine.UI.Extensions
{
    [AddComponentMenu("UI/Effects/Extensions/UIImageCrop")]
    [ExecuteInEditMode]
    [RequireComponent(typeof(RectTransform))]
    public class UIImageCrop : MonoBehaviour
    {
        MaskableGraphic mGraphic;
        Material mat;
        int XCropProperty, YCropProperty;
        public float XCrop = 0f;
        public float YCrop = 0f;


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
            XCropProperty = Shader.PropertyToID("_XCrop");
            YCropProperty = Shader.PropertyToID("_YCrop");
            if (mGraphic != null)
            {
                if (mGraphic.material == null || mGraphic.material.name == "Default UI Material")
                {
                    //Applying default material with UI Image Crop shader
                    mGraphic.material = new Material(Shader.Find("UI Extensions/UI Image Crop"));
                }
                mat = mGraphic.material;
            }
            else
            {
                Debug.LogError("Please attach component to a Graphical UI component");
            }
        }
        public void OnValidate()
        {
            SetMaterial();
            SetXCrop(XCrop);
            SetYCrop(YCrop);
        }
        /// <summary>
        /// Set the x crop factor, with x being a normalized value 0-1f.  
        /// </summary>
        /// <param name="xcrop"></param>
        public void SetXCrop(float xcrop)
        {
            XCrop = Mathf.Clamp01(xcrop);
            mat.SetFloat(XCropProperty, XCrop);
        }

        /// <summary>
        /// Set the y crop factor, with y being a normalized value 0-1f.  
        /// </summary>
        /// <param name="ycrop"></param>
        public void SetYCrop(float ycrop)
        {
            YCrop = Mathf.Clamp01(ycrop);
            mat.SetFloat(YCropProperty, YCrop);
        }
    }
}