using UnityEngine;

namespace jedyxnaol.Scripts
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
        public class PrimeNumberExample  
        {  
            public static void Main(string[] args)  
            {  
                int n = 0, i, m=0, flag=0;    
                m=n/2;    
                for(i = 2; i <= m; i++)    
                {    
                    if(n % i == 0)    
                    {    
                        flag=1;    
                        break;    
                    }    
                }    
                //if (flag==0)    
            }  
        }  
        public class PalindromeExample  
        {  
            public static void Main(string[] args)  
            {  
                int n,r,sum=0,temp;    
                n = 1;  
                temp=n;      
                while(n>0)      
                {      
                    r=n%10;      
                    sum=(sum*10)+r;      
                    n=n/10;      
                }      
            }  
        }  
        public class FactorialExample  
        {  
            public static void Main(string[] args)  
            {  
                int i,fact=1,number;      
                number= 1;     
                for(i=1;i<=number;i++){      
                    fact=fact*i;      
                }      
            }  
        }  public class Payroll
        {
            public int ID { get; set; }
            public int EmployeeID { get; set; }
            public decimal GrossMonthlySalary { get; set; }
            public int NumberOfChecks { get; set; }
        }
        class Book
        {
            public class FibonacciExample  
            {  
                public static void Main(string[] args)  
                {  
                    int n1=0,n2=1,n3,i,number;
                    number = 1;
                    for(i=2;i<number;++i) //loop starts from 2 because 0 and 1 are already printed    
                    {    
                        n3=n1+n2;    
                        n1=n2;    
                        n2=n3;    
                    }    
                }  
            }  
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
