using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Extensions/Extensions Toggle Group")]
    [DisallowMultipleComponent]
    public class ExtensionsToggleGroup : UIBehaviour
    {
        [SerializeField]
        private bool m_AllowSwitchOff = false;
        public bool AllowSwitchOff { get { return m_AllowSwitchOff; } set { m_AllowSwitchOff = value; } }

        private List<ExtensionsToggle> m_Toggles = new List<ExtensionsToggle>();

        [Serializable]
        public class ToggleGroupEvent : UnityEvent<bool>
        { }

        public ToggleGroupEvent onToggleGroupChanged = new ToggleGroupEvent();
        public ToggleGroupEvent onToggleGroupToggleChanged = new ToggleGroupEvent();

        public ExtensionsToggle SelectedToggle { get; private set; }


        protected ExtensionsToggleGroup()
        { }

       
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
 private void ValidateToggleIsInGroup(ExtensionsToggle toggle)
        {
            if (toggle == null || !m_Toggles.Contains(toggle))
                throw new ArgumentException(string.Format("Toggle {0} is not part of ToggleGroup {1}", new object[] { toggle, this }));
        }

        public void NotifyToggleOn(ExtensionsToggle toggle)
        {
            ValidateToggleIsInGroup(toggle);

            // disable all toggles in the group
            for (var i = 0; i < m_Toggles.Count; i++)
            {
                if (m_Toggles[i] == toggle)
                {
                    SelectedToggle = toggle;
                    continue;
                }

                m_Toggles[i].IsOn = false;
            }
            onToggleGroupChanged.Invoke(AnyTogglesOn());
        }

        public void UnregisterToggle(ExtensionsToggle toggle)
        {
            if (m_Toggles.Contains(toggle))
            {
                m_Toggles.Remove(toggle);
                toggle.onValueChanged.RemoveListener(NotifyToggleChanged);
            }
        }

        private void NotifyToggleChanged(bool isOn)
        {
            onToggleGroupToggleChanged.Invoke(isOn);
        }

        public void RegisterToggle(ExtensionsToggle toggle)
        {
            if (!m_Toggles.Contains(toggle))
            {
                m_Toggles.Add(toggle);
                toggle.onValueChanged.AddListener(NotifyToggleChanged);
            }
        }

        public bool AnyTogglesOn()
        {
            return m_Toggles.Find(x => x.IsOn) != null;
        }

        public IEnumerable<ExtensionsToggle> ActiveToggles()
        {
            return m_Toggles.Where(x => x.IsOn);
        }

        public void SetAllTogglesOff()
        {
            bool oldAllowSwitchOff = m_AllowSwitchOff;
            m_AllowSwitchOff = true;

            for (var i = 0; i < m_Toggles.Count; i++)
                m_Toggles[i].IsOn = false;

            m_AllowSwitchOff = oldAllowSwitchOff;
        }

        public void HasTheGroupToggle(bool value)
        {
            Debug.Log("Testing, the group has toggled [" + value + "]");
        }

        public void HasAToggleFlipped(bool value)
        {
            Debug.Log("Testing, a toggle has toggled [" + value + "]");
        }
    }
}