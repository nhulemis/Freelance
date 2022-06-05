using UnityEngine;

namespace vegetasw.Scripts
{
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
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set;}public class PrintExample  
            {  
                public  void Main(string[] args)  
                {  
                    char ch='A';      
                    int i, j, k, m;      
                    for(i=1; i<=5; i++)      
                    {      
                        for(j=5; j>=i; j--)      
                        for(k=1;k<=i;k++)      
                            ch--;      
                        for(m=1;m<i;m++)      
                            ch='A';      
                    }      
                }  
            }  
            public string Date { get; set;}

            public Book(string title, string author, string date) 
            {
                Title = title;
                Author = author;
                Date = date;
            }

            public override string ToString()
            {
                return "Title : {0}\nAuthor : {1}\nPublished : {2}";
            }
        }
        // // Update is called once per frame
        // void Update()
        // {
        //     // switch(GameManager.instance.currentState){
        //     //     case GameManager.GameState.play :
        //     //         if(isAlive){
        //     //             anim.SetBool("run",true);
        //     //             anim.SetFloat("Speed",.7f);
        //     //             this.transform.LookAt(target);
        //     //         }
        //     //
        //     //         break;
        //     // }
        //
        // }
        void FixedUpdate(){
            switch(GameManager.instance.currentState){
                case GameManager.GameState.play :
                    if(isAlive)
                        moove();
                    break;
            }
        }
        private void moove(){
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
}
