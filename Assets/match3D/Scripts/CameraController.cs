using UnityEngine;

namespace match3D.Scripts
{
	public class CameraController : MonoBehaviour
	{
		public Transform selectedObject;
		public float dragSpeed;
		// Start is called before the first frame update
		void Start()
		{
        
		}

		// Update is called once per frame
		void Update()
		{
			if(Input.GetMouseButtonDown(0))
				selectObject();
			
			
			if(Input.GetMouseButton(0))
				moveObject();
			if(Input.GetMouseButtonUp(0)){
				selectedObject.gameObject.GetComponent<Rigidbody>().useGravity=true;
				selectedObject=null;
			}
		}
		private void selectObject(){
			Ray ray;
			RaycastHit hit;
			Vector3 direction=Input.mousePosition;
			ray=Camera.main.ScreenPointToRay(direction);
			
			
			

			Debug.DrawRay(ray.origin,ray.direction);
			if(Physics.Raycast(ray , out hit)){
				selectedObject=hit.collider.transform;
				selectedObject.position+=Vector3.up*2;
				
				
				selectedObject.gameObject.GetComponent<Rigidbody>().useGravity=false;
				print("Hitted Object Name is : "+selectedObject.name);
				//Vector3 newPos=Camera.main.ScreenToWorldPoint(new Vector3(direction.x,direction.y,-10));
            

			}
		}
		private void moveObject(){
			Vector3 newPos=new Vector3(Input.GetAxis("Mouse X"),0,Input.GetAxis("Mouse Y"));
			newPos*=Time.deltaTime*dragSpeed;
			selectedObject.transform.Translate(newPos,Space.World);
		}
	}
}
