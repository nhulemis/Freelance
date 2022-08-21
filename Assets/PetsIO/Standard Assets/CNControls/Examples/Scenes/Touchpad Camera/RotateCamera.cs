using PetsIO.Standard_Assets.CNControls.Scripts.CnInputSystem;
using UnityEngine;

namespace PetsIO.Standard_Assets.CNControls.Examples.Scenes.Touchpad_Camera
{
    public class RotateCamera : MonoBehaviour
    {
        public float RotationSpeed = 15f;
        public Transform OriginTransform;

        public void Update()
        {
            var horizontalMovement = CnInputManager.GetAxis("Horizontal");

            OriginTransform.Rotate(Vector3.up, horizontalMovement * Time.deltaTime * RotationSpeed);
        }
    }
}