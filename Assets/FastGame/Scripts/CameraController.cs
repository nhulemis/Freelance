using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]Transform target;
    [SerializeField]Transform car;
    public static CameraController instance;
    void Awake(){
    	if(instance==null)instance=this;
    	else if(instance!=this)Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position=new Vector3(target.position.x,1.1f,target.position.z);
        

    }
    public void rotateCamera(Vector3 amount){
        // transform.localEulerAngles=Vector3.Lerp(transform.localEulerAngles,amount,.1f);
    }
}
