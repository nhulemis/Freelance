using UnityEngine;

namespace Samurai.Scripts
{
	public class SpeedPlancheController : MonoBehaviour
	{
		// Start is called before the first frame update
		void Start()
		{
        
		}

		// Update is called once per frame
		void Update()
		{
        
		}
		public void OnCollisionEnter(Collision other){
			if(other.gameObject.CompareTag("Player")){
				print("add sPEED TO PLAYER");
				CharacterManager.instance.upgradeJumpForce(900,50);
			}
		}
	}
}
