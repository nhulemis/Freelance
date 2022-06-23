using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Arrow.Script
{
    public enum operatoors { Plus, Minus, Devide, Multiply };

    public class DoorController : MonoBehaviour
    {
        public operatoors operatoor;

        private int value;
        private TextMeshPro  valueText;
        public SpriteRenderer spriteRenderer;
        [SerializeField] Color32 positiveColor;
        
        
        
        class HSUQOXkkoaw1
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class HSUQOXkzkockosa2
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class HSUcjiaojxjsi3
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }
        
        
        
        [SerializeField] Color negativeColor;

        // Start is called before the first frame update
        void Start()
        {
            valueText = this.GetComponentInChildren<TextMeshPro>();
            spriteRenderer = this.GetComponentInChildren<SpriteRenderer>();
            assignValu1e();
        }

        // Update is called once per frame
        void Update()
        {
        }
        private void assignValu1e()
        {
            switch (operatoor)
            {
                case operatoors.Plus:
                    value = Random.Range(5, 60);
                    spriteRenderer.color = positiveColor;
                    
                    
                    
                    
                    
                    
                    
                    valueText.text = "+" + value;
                    break;
                case operatoors.Minus:
                    value = Random.Range(5, 60);
                    spriteRenderer.color = negativeColor;

                    valueText.text = "-" + value;
                    break;
                case operatoors.Devide:
                    value = Random.Range(2, 5);
                    spriteRenderer.color = negativeColor;

                    valueText.text = "/" + value;
                    break;
                case operatoors.Multiply:
                    value = Random.Range(2, 6);
                    spriteRenderer.color = positiveColor;
                    valueText.text = "X" + value;
                    break;
            }
        }
        public int getValue()
        {
            return value;
        }
    }
}