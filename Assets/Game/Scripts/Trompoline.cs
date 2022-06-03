using UnityEngine;

namespace Game.Scripts
{
	public class Trompoline : MonoBehaviour
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
			if(other.gameObject.tag=="Player"){
				print("Playuer");
				PlayerController.instance.jump(35);
			}
		}
	}
}
