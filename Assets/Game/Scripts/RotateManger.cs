using UnityEngine;

namespace Game.Scripts
{
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
