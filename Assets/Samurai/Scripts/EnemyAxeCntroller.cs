using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAxeCntroller : MonoBehaviour
{
    Transform target;
    [SerializeField]
    Animator anim;
    private Rigidbody rb;
    public float speed=1;
    private Rigidbody[] childRigidBodies;
    public bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        
        isAlive=true;
        childRigidBodies=this.GetComponentsInChildren<Rigidbody>();
        enableRagdoll(true);
        rb=this.GetComponent<Rigidbody>();
        target=GameObject.FindWithTag("Player").transform;
        

    }

    // Update is called once per frame
    void Update()
    {
        switch(GameManager.instance.currentState){
        case GameManager.GameState.play :
        if(isAlive){
            anim.SetBool("run",true);
           anim.SetFloat("Speed",.7f);
           this.transform.LookAt(target);
        }
       
        break;
    }
        
    }
    void FixedUpdate(){
         switch(GameManager.instance.currentState){
        case GameManager.GameState.play :
        if(isAlive)
        move();
        break;
    }
    }
    private void move(){
         rb.MovePosition(this.transform.position+this.transform.forward*Time.deltaTime*speed);
         
    }
    void OnTriggerEnter(Collider other){
       
        if(other.gameObject.CompareTag("Sword")){
             print("swoooooooooooooooord");
             isAlive=false;
            killMe();

        }
    }
    void killMe(){
        enableRagdoll(false);
    }
    void enableRagdoll(bool state ){
        anim.enabled=state;
        foreach(Rigidbody rb in childRigidBodies){
            rb.isKinematic=state;
            rb.useGravity=!state;
        }

    }
}
