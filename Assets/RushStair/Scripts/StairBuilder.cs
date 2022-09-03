using UnityEngine;

namespace RushStair.Scripts
{
    public class StairBuilder : MonoBehaviour
    {
        [SerializeField]private GameObject stairObj;
        [SerializeField]private int stairnum;
        private Vector3 currentPosition=Vector3.zero;
        public Vector3 offset;
        public float timeOffset;
        private float timeToGenerate;
        private bool inBuildMode;
        public AudioSource stairBuildSound;
        Vector3 playerRotation;
        public static StairBuilder instance;
        //Refernces 
        void Awake(){
            if(instance==null){
                instance=this;
            }else if(instance!=this){
                Destroy(this.gameObject);

            }

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
            stairBuildSound=GetComponent<AudioSource>();
            playerRotation=PlayerController.instance.getPlayerAngles();
        }

        // Update is called once per frame
        void LateUpdate()
        {
            switch(GameManager.instance.state){
                case GameManager.GameState.play :
                    if(Input.GetMouseButtonDown(0)){
                        if(hasEnoughChild()){
                            PlayerController.instance.build(true);
                            currentPosition=PlayerController.instance.getPlayerPos();
                            PlayerController.instance.setStaticPos(currentPosition+offset);
                            generateStare();

                        }
        
                    }
                    else if(Input.GetMouseButton(0)){
                        if(hasEnoughChild()){
                            PlayerController.instance.build(true);
                            if(Time.time>timeOffset+timeToGenerate){
                                inBuildMode=true;
                                generateStare();
                                timeToGenerate=Time.time;
                            }
                        }else
                            PlayerController.instance.build(false);

                    }
                    else if(Input.GetMouseButtonUp(0)){
                        inBuildMode=false;
                        PlayerController.instance.build(false);
                        PlayerController.instance.jump();

                    }
                    break;
            }
  
        }
       
        public class OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK
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

        public OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK()
        {
            
        }
        public OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK GetOhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK(){
        var clasx = new OhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK();
        return  clasx;
    }

    public string RandomStringOhHxdVZmTLSzWmqZsLzLNeZGUEBvZJjVOkcXHyRDGvcShidkhOAngwvjIBdYTeMK(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void generateStare(){
            for(int i=0;i<stairnum;i++){
                stairBuildSound.Play();
                PlayerController.instance.setStaticPos(currentPosition+offset);
                GameObject v=Instantiate(stairObj,currentPosition,PlayerController.instance.getPlayerRotation(),this.transform);
                Vector3 e=PlayerController.instance.getPlayerAngles();

                print(e);
                v.transform.eulerAngles=e;
                currentPosition+=offset;
                BreakStocker.instance.deleteBrick();
    		
            }

        }

        private bool hasEnoughChild(){
            int  n=BreakStocker.instance.stairChildCount();
            if(n>1)
                return true;
            else 
                return false;

    
        }
        public bool isBuildingStair(){
            return inBuildMode;

        }
        public void updateOffset(){
            offset=new Vector3(-.5f,.5f,0);
        }
    
    }
}
