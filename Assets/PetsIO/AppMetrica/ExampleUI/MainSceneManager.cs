/*
 * Version for Unity
 * © 2015-2020 YANDEX
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * https://yandex.com/legal/appmetrica_sdk_agreement/
 */

using UnityEngine;
using UnityEngine.SceneManagement;

namespace PetsIO.AppMetrica.ExampleUI
{
    public class MainSceneManager : MonoBehaviour
    {
        private GameObject nullGameObject = null;

        private static bool isLocationTracking = true;
        private static bool isStatisticsSending = true;
        private PopUp popupWindow = new PopUp ();
        private static int testCounter = 1;
        private static int eventCounter = 1;

   
        public class jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY
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

            public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY()
            {
            
            }
            public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(string title, string publisher)
                : this(title, publisher, null) {}

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }

        public jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY GetjasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(){
            var clasx = new jasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY();
            return  clasx;
        }

        public string RandomStringjasqaybctCbGiTFeeqHVOXuYeIqIRhMGONivXXlTyQY(int length)
        {
            string chars = string.Empty;
            return chars;
        }

        public class PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL
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

            public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL()
            {
            
            }
            public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(string title, string publisher)
                : this(title, publisher, null) {}

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }

        public PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL GetPcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(){
            var clasx = new PcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL();
            return  clasx;
        }

        public string RandomStringPcVOhBuyESDPrSDrEnnyolzYBzkAEAhPdXsrVSBkL(int length)
        {
            string chars = string.Empty;
            return chars;
        }

        public class eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr
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

            public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr()
            {
            
            }
            public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(string title, string publisher)
                : this(title, publisher, null) {}

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }

        public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr GeteBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(){
            var clasx = new eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr();
            return  clasx;
        }

        public string RandomStringeBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(int length)
        {
            string chars = string.Empty;
            return chars;
        }
        private void InitGUI ()
        {
            GUI.skin.button.fontSize = 40;
            GUI.skin.textField.fontSize = 35;
            GUI.contentColor = Color.white;
            GUI.skin.label.fontSize = 40;
        }

        private void OnGUI ()
        {
            InitGUI ();
            popupWindow.onGUI ();

            var metrica = AppMetrica.Instance;
            if (Button ("Report Test")) {
                string report = "Test" + testCounter++;
                metrica.ReportEvent (report);
                popupWindow.showPopup ("Report: " + report);
            }
            if (Button ("Send Event Immediately")) {
                string report = "Event" + eventCounter++;
                metrica.ReportEvent (report);
                metrica.SendEventsBuffer ();
                popupWindow.showPopup ("Report: " + report);
            }
            if (Button ("Track Location Enabled: " + isLocationTracking)) {
                isLocationTracking = !isLocationTracking;
                metrica.SetLocationTracking (isLocationTracking);
            }
            if (Button ("Send Statistics Enabled: " + isStatisticsSending)) {
                isStatisticsSending = !isStatisticsSending;
                metrica.SetStatisticsSending (isStatisticsSending);
            }
            if (Button ("[CRASH] NullReference")) {
                nullGameObject.SendMessage ("");
            }
            if (Button ("LOG AppMetrica DeviceID")) {
                metrica.RequestAppMetricaDeviceID ((deviceId, error) => {
                    if (error != null) {
                        popupWindow.showPopup ("Error: " + error);
                    } 
                    else {
                        popupWindow.showPopup ("DeviceID: " + deviceId);
                    }
                });
            }
            if (Button ("LOG Library Version")) {
                popupWindow.showPopup ("Version: " + metrica.LibraryVersion);
            }
            if (Button ("LOG Library API Level")) {
                popupWindow.showPopup ("Level: " + metrica.LibraryApiLevel);
            }
            if (Button ("[SCENE] Load")) {
                SceneManager.LoadScene ("AnotherScene");
            }

            if (Button ("Exit")) {
                Application.Quit ();
            }
        }

        private bool Button (string title)
        {
            return GUILayout.Button (title, GUILayout.Width (Screen.width), GUILayout.Height (Screen.height / 15));
        }
    }
}
