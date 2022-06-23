using UnityEngine;

namespace hairmaster.Scripts
{
    public class CharacterInputController : MonoBehaviour
    {
        //Serialized Data
        [SerializeField]
        private float dragSpeed;
        //Private Data
        private CharacterMovementController characterMovement;
        private Vector3 newPos;
        private Vector3 startTouchPos=Vector3.zero;
        private Vector3 currentTouchPos=Vector3.zero;
        
        
        
        
        
        
        
        
        
        
        
        private bool canMove=false;
        private float touchesDifference=0;
        private void Awake()
        {
            characterMovement = this.GetComponent<CharacterMovementController>();
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            checkForInput();
        }
        Vector3 currentTouchePosTemp;class Book
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
        class Bookxhuw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

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
        class Bookxchuwaciot
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

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
        class BookxchuwaciotchxCHUW
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
        class HCWIoajciwCHOAW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class HCWIoajciwCHOAWowis
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
        class IWUCOASWkdkowCHOAW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class UCIQOAXS
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        private void checkForInput()
        {
            if (Input.GetMouseButtonDown(0))
            {
                canMove = true;
                characterMovement.updateMovementState(canMove);
                startTouchPos = Input.mousePosition;
            }else if (Input.GetMouseButton(0))
            {
            
                currentTouchPos = Input.mousePosition;
                
                
                
                
                
                
                
                
                
                
                
            
                float distanceBetweenTouches = Vector3.Distance(startTouchPos, currentTouchPos);
                touchesDifference = currentTouchePosTemp.x-currentTouchPos.x;
                if (distanceBetweenTouches > 1f) {
                    float rotX = Input.GetAxis("Mouse X") * Mathf.Deg2Rad * 2.5f;
                    newPos =new Vector3((rotX * dragSpeed), 0, 0);
                }
                currentTouchePosTemp = Input.mousePosition;

            }else if (Input.GetMouseButtonUp(0))
            {
                canMove = false;
                touchesDifference = 0;
                characterMovement.updateMovementState(canMove);
            }
        }
        public Vector3 getNewPos()
        {
            return newPos;
        }
        public bool canPlayerMove()
        {
            return canMove;
        }
        public float getTouchesDiference()
        {
            return touchesDifference;
        }
        class UCIQOAXSCHuaow1
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class TaolaoChaox2
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class TaolaoCXHiakco3
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class TaolaoCoakjsi4
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class TaolaoCoGiDokiki5
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class TaocjoawKosj9
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class Taocjokxoac10cs
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    }
}
