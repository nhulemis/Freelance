/// Credit Ziboo
/// Sourced from - http://forum.unity3d.com/threads/free-reorderable-list.364600/

namespace UnityEngine.UI.Extensions
{
    public class ReorderableListDebug : MonoBehaviour
    {
        public Text DebugLabel;

        void Awake()
        {
            foreach (var list in FindObjectsOfType<ReorderableList>())
            {
                list.OnElementDropped.AddListener(ElementDropped);
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
 private void ElementDropped(ReorderableList.ReorderableListEventStruct droppedStruct)
        {
            DebugLabel.text = "";
            DebugLabel.text += "Dropped Object: " + droppedStruct.DroppedObject.name + "\n";
            DebugLabel.text += "Is Clone ?: " + droppedStruct.IsAClone + "\n";
            if (droppedStruct.IsAClone)
                DebugLabel.text += "Source Object: " + droppedStruct.SourceObject.name + "\n";
            DebugLabel.text += string.Format("From {0} at Index {1} \n", droppedStruct.FromList.name, droppedStruct.FromIndex);
            DebugLabel.text += string.Format("To {0} at Index {1} \n", droppedStruct.ToList.name, droppedStruct.ToIndex);
        }
    }
}