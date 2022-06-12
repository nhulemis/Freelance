using UnityEngine;

namespace hairmaster.Scripts
{
    public class CameraController : MonoBehaviour
    {
        private Transform camTarget;
        private Transform camEndLookTarget;
        private Transform finishCamTraget;
        private Vector3 offset;
        private bool playerReachedGoalLine;
        public Transform[] camEndTargets;
        private int currentEndTragetReachedIndex=0;
        //References
        public static CameraController instance;

        // Start is called before the first frame update
        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);
       
        }
        class Powscq
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class HCWIoajciw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class PowscqCHUW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Owicuaow
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class OwicuaowScuwa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class IWUCOASWkdkow
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        private void Start()
        {
            camTarget = GameObject.FindWithTag("Player").transform;
            offset = camTarget.position - this.transform.position;
        }
        void Update()
        {
            if (!playerReachedGoalLine && canplay())
                
                
                followTarget();
            else if(playerReachedGoalLine)
                finishCamPos();

        }
        private void followTarget()
        {
            Vector3 newCamPos = (camTarget.position - offset);
            this.transform.position = newCamPos;
        }class Book
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            public Book(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public Book(string title, string publisher)
                : this(title, publisher, null) { }

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchuwaciotchx
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchcuwaxhua
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class BookxchuwaciotchxCHUW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        private void finishCamPos()
        {
            //  Vector3 newCamPos = camTarget.position - this.transform.position;

            this.transform.LookAt(camEndLookTarget.position);
            Vector3 newCamPos=camEndTargets[currentEndTragetReachedIndex].position;
            
            
            if (Vector3.Distance(newCamPos, this.transform.position) < 1f)
            {
                switchEndTarget();
            }
            newCamPos = camEndTargets[currentEndTragetReachedIndex].position;
            // newCamPos =this.transform.position+(newCamPos - transform.position)*Time.deltaTime*10;
            this.transform.position = Vector3.MoveTowards(this.transform.position, Vector3.Slerp(this.transform.position, newCamPos, 1f), 1f);  
        }
        public void setCamEndTarget(Transform[] newCamTarget,Transform endLookTraget)
        {
            playerReachedGoalLine = true;
            camEndLookTarget = endLookTraget;
            camEndTargets = newCamTarget;
        }
        private void switchEndTarget()
        {
            if(currentEndTragetReachedIndex<camEndTargets.Length-1)
                currentEndTragetReachedIndex++;

        }
        public void setTarget(Transform nTarget)
        {
            camTarget = nTarget;
            offset = camTarget.position - this.transform.position;

        }
        private bool canplay()
        {
            return GameManager.instance.currentGameState == GameManager.GameState.play;
        }

    }
}
