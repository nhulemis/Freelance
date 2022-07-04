using UnityEngine;

namespace Game.Scripts
{
	public class Trompoline : MonoBehaviour
	{
		public class ANlxclpakcv4kaoxc
		{
			private int buaquadi;
			private string chusx;
			public float gmac;
			private double mciajx;

			public int getX()
			{
				return buaquadi;
			}
		}
	
		public class Kcisjhuwkakxc
		{
			private int buaquadi;
			private string chusx;
			public float gmac;
			private double mciajx;

			public int getX()
			{
				return buaquadi;
			}
		}
		public class OjkcisjKc5
		{
			private int buaquadi;
			private string chusx;
			public float gmac;
			private double mciajx;

			public int getX()
			{
				return buaquadi;
			}
		}
		// Start is called before the first frame update
		void Start()
		{
        
		}

		// Update is called once per frame
		void Update()
		{
        
		}
		void OnTriggerEnter(Collider other){
			if(other.gameObject.tag=="Player"){
				print("Playuer");
				PlayerController.instance.jump(35);
			}
		}
	}
}
