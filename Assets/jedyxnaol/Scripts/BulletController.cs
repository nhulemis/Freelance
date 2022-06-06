using UnityEngine;

namespace jedyxnaol.Scripts
{
    public class BulletController : MonoBehaviour
    {
        private Rigidbody rb;
        GameObject obj;
        // Start is called before the first frame update
        void Start()
        {
            obj=GameObject.FindWithTag("AttackSlicer");

            rb=GetComponent<Rigidbody>();
            
            
            Destroy(this.gameObject,4f);
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
        }  
        public class Student  
        {  
            public int id;   
            public string name;  
        }  public class PrintExample  
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
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set;}
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
        // Update is called once per frame
        void Update()
        {
            
        }
        private void OnCollisionEnter(Collision other){
            if(other.gameObject.CompareTag("Sword")){
                
                
                print("Sword and Bullet Collsion");
                rb.velocity=Vector3.zero;
            }




        }
    }
}
