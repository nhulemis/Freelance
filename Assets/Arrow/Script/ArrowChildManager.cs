using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowChildManager : MonoBehaviour
{
    private bool canShoot;
    public Transform target;
    private float speed=15f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot)
        {
            Vector3 direction = target.position - this.transform.position;
            this.transform.position += direction.normalized * Time.deltaTime * speed;
        }
    }
    public void shoot(Transform target)
    {

        this.transform.parent = null;
        this.target = target;
        canShoot = true;
        Destroy(this.gameObject,1f);

    }
    
}
