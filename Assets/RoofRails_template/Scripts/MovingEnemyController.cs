using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemyController : MonoBehaviour
{
    public float rotationSpeed;
    public bool move=false;
    [SerializeField]
    Transform start;
    [SerializeField]
    Transform end;
    Vector3 nextPos;
    bool canchange=true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if(move){
        if(Vector3.Distance(this.transform.position,start.position)<=1 ){
            
            //nextPos=-Vector3.right;
            nextPos=end.position;
            print("right right");
        } else if(Vector3.Distance(this.transform.position,end.position)<=1 ){
            
            nextPos=start.position;
            print("Left ledt");
        }
      
            transform.position=Vector3.Lerp(this.transform.position,nextPos,.02f);
        }
    transform.Rotate(Vector3.up*rotationSpeed);
    }
    void OnTriggerEnter(Collider other){
           move=false;

    }
}
