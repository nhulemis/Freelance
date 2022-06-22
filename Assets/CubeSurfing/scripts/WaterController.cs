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


		}
		
		public class TaoLaoTU
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private List<int> trianglesIndices;
			private List<Vector3> vertices;
			private int length;

			public class TaoLaoTUxu
			{
				public float shakeSpeed;
				public MeshFilter meshF;
				private Mesh mesh;
				private int length;

				public TaoLaoTUxu()
				{
				
				}
			}
			public class TaoLaHUATUCSA
			{
				public float shakeSpeed;
				public MeshFilter meshF;
				private Mesh mesh;
				private int length;

				public TaoLaHUATUCSA()
				{
				
				}
			}
			public class TaoLaHchu9chuw
			{
				public float shakeSpeed;
				public MeshFilter meshF;
				private Mesh mesh;
				private int length;

				public TaoLaHchu9chuw()
				{
				
				}
			}
			public class TaoLaHUAhcu6
			{
				public float shakeSpeed;
				public MeshFilter meshF;
				private Mesh mesh;
				private int length;

				public TaoLaHUAhcu6()
				{
				
				}
			}
			public TaoLaoTU()
			{
				
			}
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
