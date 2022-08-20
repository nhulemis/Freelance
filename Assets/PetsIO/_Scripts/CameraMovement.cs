using UnityEngine;

namespace PetsIO._Scripts
{
    public class CameraMovement : MonoBehaviour
    {
        // Start is called before the first frame update
        public float speed;

        //public float minZ;
    
        private GameObject hero;
    
        private float view;
        //private bool doview;
        //private int correct;
        void Start()
        {
            hero = GameObject.Find("Hero");
            view = 45;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            if (hero) transform.position = Vector3.Lerp(transform.position, hero.transform.position + new Vector3(0, 18f, -15.5f), Time.deltaTime*speed);

            /* if (doview)
          {
              Camera.main.fieldOfView += Time.deltaTime*correct;
              if (correct == 1)
              {
                  if (Camera.main.fieldOfView > view)
                  {
                      Camera.main.fieldOfView = view;
                      doview = false;
                  }
              }
              else
              {
                  if (Camera.main.fieldOfView < view)
                  {
                      Camera.main.fieldOfView = view;
                      doview = false;
                  }
              }
          }*/
          
        }

        void FieldView(float f)
        {

            if (view < f)
            {
                //correct = 1;
            }
            else
            {
                //correct = -1;
            }
            view = f;
            // doview = true;

            if (view > 47) view = 47;
            view = 45;
        }
    }
}
