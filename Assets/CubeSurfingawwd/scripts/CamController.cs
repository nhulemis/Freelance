using UnityEngine;

namespace CubeSurfingawwd.scripts
{
    public class CamController : MonoBehaviour
    {
        public Vector3 offset;
        public Transform target;
        public float inputSmooth=.1f;
        public GameObject speedEffect;
        private bool  canTurn;
        public static CamController instance;
        void Awake(){
            if(instance==null)instance=this;
            else if(instance!=this)Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            canTurn=false;
            offset = target.position - this.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if(canTurn)
                transform.RotateAround(target.position,Vector3.up,Time.deltaTime*20);
            
            
            
            transform.localPosition = Vector3.Lerp(this.transform.localPosition,new Vector3(transform.localPosition.x,(target.position.y-offset.y)/2 ,transform.localPosition.z),inputSmooth);
  
        }
        public void activateSpeed(){
            if(speedEffect){
                speedEffect.SetActive(true);
                Invoke("desactivateSpeed",1f);
            }

        }
        private void desactivateSpeed(){
            speedEffect.SetActive(false);

        }
        public void startTurning(){
            canTurn=true;
      
        }
    }
}
