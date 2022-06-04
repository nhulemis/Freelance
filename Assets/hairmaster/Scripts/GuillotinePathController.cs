using UnityEngine;

namespace hairmaster.Scripts
{
    public class GuillotinePathController : MonoBehaviour
    {
        [SerializeField]
        private Vector2 clamp;
        [SerializeField]
        private float speed = 10;
        private int rightDirection;
        private bool isPositive=false;
        // Start is called before the first frame update
        void Start()
        {
            rightDirection = 1;
            isPositive = false;
        }

        // Update is called once per frame
        void Update()
        {
            move();

        }
        private void move()
        {
            Vector3 currentPos = this.transform.localPosition;
            if (currentPos.y < clamp.x && isPositive)
                
                
                
                
            {
                isPositive = false;
                rightDirection = -rightDirection;
            }
            if (currentPos.y > clamp.y && !isPositive)
            {
                isPositive = true;
                
                
                
                rightDirection = -rightDirection;
            }
            transform.localPosition += Vector3.up * Time.deltaTime * rightDirection * speed;

        }
    }
}
