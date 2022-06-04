using UnityEngine;

namespace Arrow.Script
{
    public class DoorParentController : MonoBehaviour
    {
        public bool patroll;
        public bool rightDirection;
        //Serialized Data
        [SerializeField]
        private Transform right;
        [SerializeField]
        private Transform left;

        private float speed;
   
     
        // Start is called before the first frame update
        void Start()
        {
            speed = 3;

            //rightDirection = true;
        }

        void Update()
        {
            if (patroll)
            {
                if (rightDirection)
                {
                    Vector3 direction = right.localPosition - this.transform.localPosition;
                    this.transform.Translate(direction.normalized * Time.deltaTime * speed);
                    // this.transform.LookAt(right);
                    float distanceToreach = Vector3.Distance(this.transform.localPosition, right.localPosition);
                    if (distanceToreach < .1f)
                    {
                        rightDirection = false;
                    }
                }
                else {

                    Vector3 direction = left.localPosition - this.transform.localPosition;
                    // this.transform.LookAt(right);
                    this.transform.Translate(direction.normalized * Time.deltaTime*speed);
                    if (direction.magnitude < .1f)
                    {
                        rightDirection = true;
                    }


                }


            }
        }
    }
}
