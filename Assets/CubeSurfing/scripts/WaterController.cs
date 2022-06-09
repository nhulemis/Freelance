using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfing.scripts
{
	public class WaterController : MonoBehaviour
	{
		public float shakeSpeed;
		public MeshFilter meshF;
		private Mesh mesh;
		private List<int> trianglesIndices;
		private List<Vector3> vertices;
		private int length;
		// Start is called before the first frame update
		void Start()
		{
			mesh=meshF.mesh;
			vertices=new List<Vector3>();
			trianglesIndices=new List<int>();
			for(int i=0;i<mesh.vertices.Length;i++){
				vertices.Add(mesh.vertices[i]);
			}
			mesh.GetTriangles(trianglesIndices,0);
			length=vertices.Count;

		}

		public class Timea
		{
			// public methods
			public void DisplayCurrentTime(  )
			{
                    
			}

			// private variables
			int Year;
			int Month;
			int Date;
			int Hour;
			int Minute;
			int Second;


		}class Book
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			public Book(string title, string publisher, string? isbn)
				=> (Title, Publisher, Isbn) = (title, publisher, isbn);

			public Book(string title, string publisher)
				: this(title, publisher, null) { }

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SJIQlakow
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQAOXMA
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQAOXMAh
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQAOXMAhxjuoa
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQAOXMAhxjuoaUQLA
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWU
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQ
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQSS
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQSSƯxaw
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQSSsss
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		class SHUQriaisWUXIQSSsssSUQ
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
		// Update is called once per frame
		void Update()
		{
			Destroy(this.gameObject.GetComponent<MeshCollider>());
			int j=0;
			for(int i=0;i<mesh.vertices.Length;i++){
				j+=3;
				vertices[i]=new Vector3(vertices[i].x ,Mathf.PerlinNoise(j*.01f*Time.time,i*.1f*shakeSpeed*Time.time),vertices[i].z );
			}
			mesh.SetVertices(vertices);
        
			this.gameObject.AddComponent<MeshCollider>();
		}
	}
}
