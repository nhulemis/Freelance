using UnityEngine;

namespace bridgrun.Scripts
{
    public class CameraController : MonoBehaviour
    {
        private Transform target;
        private Vector3 offset;
        //References
        public static CameraController instance;
        private bool canZoom;
        private Vector3 endTargetZoom;

        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);

        }
        // Start is called before the first frame update
        void Start()
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;




            offset = target.position - this.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            switch (GameManager.instance.currentGameState)
            {
                case GameManager.GameState.play:
                    Vector3 newPosition = target.position - offset;
                    this.transform.position = Vector3.Lerp(this.transform.position, newPosition, .8f);
                    break;
            }
            if (canZoom)
            {
                this.transform.position =Vector3.MoveTowards(this.transform.position, Vector3.Lerp(this.transform.position, endTargetZoom, .5f),.7f);

            }

        }
        public void zoom(Transform targetToZoomOn)
        {
            canZoom = true;
            endTargetZoom = targetToZoomOn.position;
        }
    }
}
