using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoystickSetterExample : MonoBehaviour
{
    public VariableJoystick variableJoystick;
    public Text valueText;
    public Image background;
    public Sprite[] axisSprites;

    public void ModeChanged(int index)
    {
        switch(index)
        {
            case 0:
                variableJoystick.SetMode(JoystickType.Fixed);
                break;
            case 1:
                variableJoystick.SetMode(JoystickType.Floating);
                break;
            case 2:
                variableJoystick.SetMode(JoystickType.Dynamic);
                break;
            default:
                break;
        }     
    }

    public void AxisChanged(int index)
    {
        switch (index)
        {
            case 0:
                variableJoystick.AxisOptions = AxisOptions.Both;
                background.sprite = axisSprites[index];
                break;
            case 1:
                variableJoystick.AxisOptions = AxisOptions.Horizontal;
                background.sprite = axisSprites[index];
                break;
            case 2:
                variableJoystick.AxisOptions = AxisOptions.Vertical;
                background.sprite = axisSprites[index];
                break;
            default:
                break;
        }
    }

    public void SnapX(bool value)
    {
        variableJoystick.SnapX = value;
    }

    public void SnapY(bool value)
    {
        variableJoystick.SnapY = value;
    }

   
        public class HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq
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

        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq()
        {
            
        }
        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq GetHUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(){
        var clasx = new HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq();
        return  clasx;
    }

    public string RandomStringHUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj
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

        public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj()
        {
            
        }
        public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj GetlFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(){
        var clasx = new lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj();
        return  clasx;
    }

    public string RandomStringlFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR
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

        public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR()
        {
            
        }
        public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR GetxynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(){
        var clasx = new xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR();
        return  clasx;
    }

    public string RandomStringxynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI
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

        public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI()
        {
            
        }
        public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI GetOzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(){
        var clasx = new OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI();
        return  clasx;
    }

    public string RandomStringOzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void Update()
    {
        valueText.text = "Current Value: " + variableJoystick.Direction;
    }
}