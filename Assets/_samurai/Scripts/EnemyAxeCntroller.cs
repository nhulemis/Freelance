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
 
        public class PBCCRefbinLCauOxoodUttlvaWcxQpp
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public PBCCRefbinLCauOxoodUttlvaWcxQpp()
        {
            
        }
        public PBCCRefbinLCauOxoodUttlvaWcxQpp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PBCCRefbinLCauOxoodUttlvaWcxQpp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PBCCRefbinLCauOxoodUttlvaWcxQpp GetPBCCRefbinLCauOxoodUttlvaWcxQpp(){
        var clasx = new PBCCRefbinLCauOxoodUttlvaWcxQpp();
        return  clasx;
    }

    public string RandomStringPBCCRefbinLCauOxoodUttlvaWcxQpp(int length)
    {
        string chars = string.Empty;
        return chars;
    }
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
   
        public class qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn()
        {
            
        }
        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn GetqKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(){
        var clasx = new qKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn();
        return  clasx;
    }

    public string RandomStringqKVbGWyutYYdIrSJdUpWIPbhQEvDgwjkAoyZYhtTtKylsvCn(int length)
    {
        string chars = string.Empty;
        return chars;
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
