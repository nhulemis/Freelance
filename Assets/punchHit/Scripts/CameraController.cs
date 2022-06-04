using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] float transitionSmoothnesse;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset=target.position-this.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {

    	Vector3 newPos=target.position;
    	newPos.z-=offset.z;
    	newPos.y-=offset.y;
        this.transform.position=Vector3.Lerp(this.transform.position,new Vector3(target.position.x*2,this.transform.position.y,target.position.z),transitionSmoothnesse);

      //this.transform.localEulerAngles=target.localEulerAngles;
    }
}
