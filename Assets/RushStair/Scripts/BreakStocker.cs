using UnityEngine;

namespace RushStair.Scripts
{
    public class BreakStocker : MonoBehaviour
    {
        [SerializeField] Vector3 rightPos;
        [SerializeField] Vector3 leftPos;
        public static BreakStocker instance;
        void Awake(){
            if(instance==null)instance=this;
            else if(instance!=this)Destroy(this.gameObject);
        } 
  
        // Start is called before the first frame update
     
        public class bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP()
        {
            
        }
        public bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP GetbwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP(){
        var clasx = new bwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP();
        return  clasx;
    }

    public string RandomStringbwlmJSSuuwFSCGYlbQNLIwpRptPGUsjbiSrkxrbPwFtkrcgBcsxDRBBeGUwP(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
        {
      
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void addBrick(GameObject b){
            int r=Random.Range(0,2);
            if(r==1){
                b.tag="rightBrick";
                rightPos.y+=.002f;
                b.transform.parent=this.transform;
                b.transform.localPosition=rightPos;
                b.transform.localEulerAngles=new Vector3(0,90,0);

            }
    	
            else {
                b.tag="LeftBrick";
                leftPos.y+=.002f;
                b.transform.parent=this.transform;
                b.transform.localPosition=leftPos;
                b.transform.localEulerAngles=new Vector3(0,90,0);
            }

    

   

        }
        public void deleteBrick(){
            int child=this.transform.childCount;
            if(child>1){
                GameObject obj=this.transform.GetChild(child-1).gameObject;
                string objTag=obj.tag;
                if(obj.tag=="LeftBrick"){
                    leftPos.y-=.002f;

                }else{
                    rightPos.y-=.002f;
                }

                Destroy(obj);
    	
            }
    	
        }
        public int stairChildCount(){
            return this.transform.childCount;
        }
    }
}
