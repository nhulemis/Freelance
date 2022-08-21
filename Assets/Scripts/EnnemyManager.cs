using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyManager : MonoBehaviour
{
	public Transform right;
	public Transform left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setWingsHolder(){
    	EnemyHolder.instance.setWings(ref right,ref left);

    }
}
