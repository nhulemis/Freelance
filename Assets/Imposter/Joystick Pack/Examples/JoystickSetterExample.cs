﻿using Imposter.Joystick_Pack.Scripts.Base;
using Imposter.Joystick_Pack.Scripts.Joysticks;
using UnityEngine;
using UnityEngine.UI;

namespace Imposter.Joystick_Pack.Examples
{
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
        private void Update()
        {
            valueText.text = "Current Value: " + variableJoystick.Direction;
        }
    }
}