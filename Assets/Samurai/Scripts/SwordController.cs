using UnityEngine;

namespace Samurai.Scripts
{
	public class SwordController : MonoBehaviour
	{
		// Start is called before the first frame update
		void Start()
		{
        
		}

		// Update is called once per frame
		void Update()
		{
        
		}
		private void OnTriggerEnter(Collider other){
    	
			print("Yoo Sword Slice");
			Handheld.Vibrate();
    	
		}
	}
}
