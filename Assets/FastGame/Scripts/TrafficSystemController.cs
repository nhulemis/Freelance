using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSystemController : MonoBehaviour
{
    [SerializeField]Transform start;
    [SerializeField]Transform end;
    [SerializeField]GameObject[] cars;

    public static TrafficSystemController instance;
    private float lastxPos;

    void Awake(){
    	if(instance==null)instance=this;
    	else if(instance!=this)Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
    	lastxPos=start.position.x;
    	//arrivedToStart();
        //arrivedToEnd();
        respawn(start);
        respawn(end);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void respawn(Transform carforward){
         int randomCarIndex=Random.Range(0,cars.Length);
         Vector3 spawnPos=carforward.position;
         if(spawnPos.x<0)
         spawnPos.x+=10;
         else
          spawnPos.x-=10;

    	GameObject carobj=Instantiate(cars[randomCarIndex],spawnPos,Quaternion.identity);
    	carobj.transform.forward=carforward.right;
    	//lastxPos=end.position.x;
    }
}
