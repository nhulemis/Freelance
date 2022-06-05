using UnityEngine;
using UnityEngine.UI;

namespace CubeSurfingawwd.scripts
{
    public class SliderController : MonoBehaviour
    {
        float distance;
        Vector3 startPos;
        Vector3 endpos;
        Transform playerTrans;
        [SerializeField]Image imgSlider;
        // Start is called before the first frame update
        void Start()
        {
            playerTrans=GameObject.FindGameObjectWithTag("Player").transform;
            startPos=playerTrans.position;
            
            
            
            endpos=GameObject.FindGameObjectWithTag("Ending").transform.position;
            distance=(endpos-startPos).magnitude;
        
        }

        // Update is called once per frame
        void LateUpdate()
        {
            imgSlider.fillAmount=((playerTrans.position).magnitude/distance);
        }
    }
}
