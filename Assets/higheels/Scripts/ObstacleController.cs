using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HeelStand"))
        {
            Destroy(other.gameObject);
            AudioController.instance.enabledropHeelSound();
            //other.gameObject.transform.parent = null;
            int childIndex = other.gameObject.GetComponent<HeelStand>().childIndex;
            StandsHolder.instance.removeChild(childIndex);
        }
        if (other.gameObject.CompareTag("PlayerHips"))
        {
            
            CharacterManager.instance.loose();
        }

    }
}
