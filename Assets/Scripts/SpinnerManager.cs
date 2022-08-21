using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerManager : MonoBehaviour
{
     public Transform rightW;
     public Transform leftW;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void assignToController(){
    	BeybladeController.instance.assignWings(ref rightW,ref leftW);
    }
}
