using UnityEngine;

namespace vegetasw.Scripts
{
	public class SwordController : MonoBehaviour
	{class Book
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
			public class PrintExample  
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
			public override string ToString()
			{
				return "Title : {0}\nAuthor : {1}\nPublished : {2}";
			}
		}
		public class Student  
		{  
			public int id;   
			public string name;  
		}  
		// // Start is called before the first frame update
		// void Start()
		// {
  //       
		// }
		//
		// // Update is called once per frame
		// void Update()
		// {
  //       
		// }
		// private void OnTriggerEnter(Collider other){
  //   	
  //   	
		// }
	}
}
