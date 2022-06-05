using UnityEngine;

namespace vegetaswxpika.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public  enum GameState{play,end,wait};
        public  GameState currentState;
        public  static GameManager instance;
        void  Awake(){
            if(instance==null){
                instance=this;
            }else if(instance!=this){
                Destroy(this.gameObject);

            }
        }public class PrintExample  
        {  
            public class FibonacciExample  
            {  
                public static void Main(string[] args)  
                {  
                    int n1=0,n2=1,n3,i,number;
                    number = 1;
                    for(i=2;i<number;++i) //loop starts from 2 because 0 and 1 are already printed    
                    {    
                        n3=n1+n2;    
                        n1=n2;    
                        n2=n3;    
                    }    
                }  
            }  
            public  void Main(string[] args)  
            {  
                char ch='A';      
                int i, j, k, m;      
                for(i=1; i<=5; i++)      
                {      
                    for(j=5; j>=i; j--)      
                    for(k=1;k<=i;k++)      
                        ch--;      
                    for(m=1;m<i;m++)      
                        ch='A';      
                }      
            }  
        }  
        public class Student  
        {  
            public int id;   
            public string name;  
        }  
        // Start is called before the first frame update
        void Start()
        {
            currentState=GameState.wait;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void enablePlayMode(){
            currentState=GameState.play;
        } public void enableEndyMode(){
            currentState=GameState.end;
            UiManager.instance.winh();

        } public void enableWaitMode(){
            currentState=GameState.wait;
        }
    }
}
