using UnityEngine;

namespace Game.Scripts
{
	public class ANCXUA
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
	public class RotateManger : MonoBehaviour
	{
		// Start is called before the first frame update
		void Start()
		{
        
		}

		// Update is called once per frame
		void Update()
		{
        
		}
		void OnTriggerEnter(Collider other){
			print("yeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
			PlayerController.instance.faceOtherWay();
		}
	}
}
