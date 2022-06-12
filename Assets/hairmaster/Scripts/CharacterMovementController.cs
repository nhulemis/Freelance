using UnityEngine;

namespace hairmaster.Scripts
{
    public class CharacterMovementController : MonoBehaviour
    {
        [SerializeField]
        private float speed=1;

        private float gravityModifier=-9.81f;

        //Private Data
        private CharacterInputController characterInputController;
        private Rigidbody rb;
        private Animator anim;
        private bool isRunning;
        private bool reachedGoalLine;
        private Transform endTraget;
        private Transform lookAtEndTraget;
        private bool stretchingHairPhase;
        private Vector3 revivePos;

        //Reference
        public static CharacterMovementController instance;
        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);
            
            characterInputController = this.GetComponent<CharacterInputController>();
            CameraController.instance.setTarget(this.transform);

        }
        // Start is called before the first frame update
        void Start()
        {
            anim = this.GetComponent<Animator>();
            rb = this.GetComponent<Rigidbody>();
            startPlay();
        }

        // Update is called once per frame
        void Update()
        {
            if(canPlay())
                move();
        }
        private void move()
        {
            if (!reachedGoalLine && isRunning)
            {
                Vector3 newPos = this.rb.position + characterInputController.getNewPos();
                this.rb.MovePosition(Vector3.MoveTowards(this.rb.position, Vector3.Slerp(this.rb.position, newPos, .7f), 8f));
            }else if (reachedGoalLine)
            {
                Vector3 directionToEndTraget = endTraget.position - this.transform.position;
                directionToEndTraget *= Time.deltaTime * 2f;
                this.transform.position += directionToEndTraget;
                float distanceToEnd = Vector3.Distance(this.transform.position, endTraget.position);
                if (distanceToEnd < 1f &&  !stretchingHairPhase)
                {
                    stretchingHairPhase = true;
                    anim.SetBool("Run",false);
                    //anim.SetTrigger("Dance0");
                    anim.SetTrigger("Laying");
                    anim.SetTrigger("Dance0");
                    this.rb.isKinematic = true;
                    this.transform.GetComponentInChildren<HairController>().resetHair();
                    this.transform.localEulerAngles = new Vector3(0, 180, 0);
                    Invoke("stretchHair", 3f);
                    // transform.localRotation = Quaternion.Lerp(this.transform.rotation, lookAtEndTraget.rotation, 1);
                }
                this.rb.velocity = Vector3.zero;

            }

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
        class Bookxhuwxccw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchuwa
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
        class Bookxchcuwaxhuachx
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
        class Bookxchcuwa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        void FixedUpdate()
        {
            if (isRunning && canPlay()&& !reachedGoalLine)
                rb.velocity = (Vector3.forward * speed + Vector3.up * gravityModifier);
            else
            {
                rb.velocity = Vector3.zero;

            }

        }
        private void startPlay()
        {
            //anim.SetBool("Run", true);
        }
        public void updateMovementState(bool currentState)
        {
            isRunning = currentState;
            if (isRunning)//Enable Run Animation
                anim.SetBool("Run", true);
            else //Disable Running Animation
                anim.SetBool("Run", false);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Finish"))
            {
                this.rb.velocity = Vector3.zero;
                HairController.instance.resetHair();
                endTraget = other.GetComponent<FinishController>().getFinishTarget();
                lookAtEndTraget= other.GetComponent<FinishController>().getFinishLookAtTarget();
                characterInputController.enabled = false;
                reachedGoalLine = true;
            }
            if (other.gameObject.CompareTag("Fail"))
            {
                if (other.transform.childCount > 0)
                    revivePos = other.transform.GetChild(0).position;
                else
                    revivePos = PlayerPointController.instance.getPos();
                GameManager.instance.endPlay();
                UiManager.instance.playerLoose();
                anim.SetTrigger("Fail");

            }
        }
        private bool canPlay()
        {
            return GameManager.instance.currentGameState == GameManager.GameState.play;
        }
        private void stretchHair()
        {
            HairController.instance.stretchHair();
        }
        public void revive()
        {

            this.transform.position = revivePos;
            anim.SetBool("idle",true);
            GameManager.instance.startPlay();

        }

    }
}
