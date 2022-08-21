///Credit judah4
///Sourced from - http://forum.unity3d.com/threads/color-picker.267043/


namespace UnityEngine.UI.Extensions.ColorPicker
{
    [RequireComponent(typeof(BoxSlider), typeof(RawImage)), ExecuteInEditMode()]
    public class SVBoxSlider : MonoBehaviour
    {
        public ColorPickerControl picker;

        private BoxSlider slider;
        private RawImage image;

        private float lastH = -1;
        private bool listen = true;

        public RectTransform RectTransform
        {
            get
            {
                return transform as RectTransform;
            }
        }

       
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
 private void Awake()
        {
            slider = GetComponent<BoxSlider>();
            image = GetComponent<RawImage>();

            RegenerateSVTexture();
        }

        private void OnEnable()
        {
            if (Application.isPlaying && picker != null)
            {
                slider.OnValueChanged.AddListener(SliderChanged);
                picker.onHSVChanged.AddListener(HSVChanged);
            }
        }

        private void OnDisable()
        {
            if (picker != null)
            {
                slider.OnValueChanged.RemoveListener(SliderChanged);
                picker.onHSVChanged.RemoveListener(HSVChanged);
            }
        }

        private void OnDestroy()
        {
            if (image.texture != null)
                DestroyImmediate(image.texture);
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            image = GetComponent<RawImage>();
            RegenerateSVTexture();
        }
#endif

        private void SliderChanged(float saturation, float value)
        {
            if (listen)
            {
                picker.AssignColor(ColorValues.Saturation, saturation);
                picker.AssignColor(ColorValues.Value, value);
            }
            listen = true;
        }

        private void HSVChanged(float h, float s, float v)
        {
            if (lastH != h)
            {
                lastH = h;
                RegenerateSVTexture();
            }

            if (s != slider.NormalizedValueX)
            {
                listen = false;
                slider.NormalizedValueX = s;
            }

            if (v != slider.NormalizedValueY)
            {
                listen = false;
                slider.NormalizedValueY = v;
            }
        }

        private void RegenerateSVTexture()
        {
            double h = picker != null ? picker.H * 360 : 0;

            if (image.texture != null)
                DestroyImmediate(image.texture);

            Texture2D texture = new Texture2D(100, 100)
            {
                hideFlags = HideFlags.DontSave
            };
            for (int s = 0; s < 100; s++)
            {
                Color32[] colors = new Color32[100];
                for (int v = 0; v < 100; v++)
                {
                    colors[v] = HSVUtil.ConvertHsvToRgb(h, (float)s / 100, (float)v / 100, 1);
                }
                texture.SetPixels32(s, 0, 1, 100, colors);
            }
            texture.Apply();

            image.texture = texture;
        }
    }
}