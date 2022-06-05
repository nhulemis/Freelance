using UnityEngine;

namespace PrivateHalley.Scripts
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

			public override string ToString()
			{
				return "Title : {0}\nAuthor : {1}\nPublished : {2}";
			}
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
