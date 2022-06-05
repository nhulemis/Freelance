using UnityEngine;

namespace PrivateHalley.Scripts
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
        public class Student  
        {  
            public int id;   
            public string name;  
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
