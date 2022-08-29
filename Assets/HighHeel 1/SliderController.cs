using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        endpos=GameObject.FindGameObjectWithTag("Finish").transform.position;
        endpos += Vector3.forward * 20;
        print(GameObject.FindGameObjectWithTag("Finish").name);
    	distance=(endpos-startPos).magnitude;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        imgSlider.fillAmount=((playerTrans.position).magnitude/distance);
    }
}
