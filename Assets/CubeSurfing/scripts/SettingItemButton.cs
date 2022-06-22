using UnityEngine;
using UnityEngine.UI;

namespace CubeSurfing.scripts
{
	public class SettingItemButton : MonoBehaviour
	{
		[HideInInspector]public Image img;
		[HideInInspector]public Transform trans;
		// Start is called before the first frame update
    
		void Awake(){
			img=GetComponent<Image>();
			trans=this.transform;
		}
		void Start()
		{
        
		}

		public class TaoLaoTU
		{
			public float shakeSpeed;
			public MeshFilter meshF;
			private Mesh mesh;
			private int length;

			public TaoLaoTU()
			{
				
			}
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
			public class TaoLaHUATUCSAchu5
			{
				public float shakeSpeed;
				public MeshFilter meshF;
				private Mesh mesh;
				private int length;

				public TaoLaHUATUCSAchu5()
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
			public class TaoLaHhuc7
			{
				public float shakeSpeed;
				public MeshFilter meshF;
				private Mesh mesh;
				private int length;

				public TaoLaHhuc7()
				{
				
				}
			}
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
		// Update is called once per frame
		void Update()
		{
        
		}
	}
}
