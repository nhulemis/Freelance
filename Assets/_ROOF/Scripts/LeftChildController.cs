using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftChildController : MonoBehaviour
{
    public static LeftChildController instance;
    [SerializeField]
     GameObject obj;
    private Vector3 offset;
    private Vector3 currentPos;
    void Awake(){
    	if(instance==null){
            instance=this;
    	}else if(instance!=this){
    	    Destroy(this.gameObject);
    	}
    }
 
        public class xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX
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

        public xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX()
        {
            
        }
        public xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX GetxsDpXMJnHBuWNyJsZFRQsqOkTLCqDX(){
        var clasx = new xsDpXMJnHBuWNyJsZFRQsqOkTLCqDX();
        return  clasx;
    }

    public string RandomStringxsDpXMJnHBuWNyJsZFRQsqOkTLCqDX(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start(){
    	offset=new Vector3(-.25f,0,0);
    	currentPos=Vector3.zero;
    }
    /*public void addChild(GameObject newChild){
        newChild.transform.parent=this.transform;
    	newChild.transform.localPosition=currentPos;
    	currentPos+=offset;
    }*/
    public void addChild(int num=2){
        Vector3 c=Vector3.zero;
        if(getTotalChildNum()>0){
          c=this.transform.GetChild(getTotalChildNum()-1).localPosition;
        }
        for(int i=0;i<num;i++){
        	GameObject newChild=Instantiate(obj,Vector3.zero,Quaternion.Euler(90,0,90),this.transform);
            newChild.GetComponent<ChildController>().initialize(this.transform.childCount+1,false);
           newChild.transform.localPosition=c;
    	   c+=new Vector3(-.25f,0,0);
        }
         
    }
    public void deleteChild(int start){
    	int end=transform.childCount;
        for(int i=start;i<end;i++){
           

             //this.transform.GetChild(i).transform.parent=null;
             Destroy(this.transform.GetChild(i).gameObject);
            
        	
    	  // c-=offset;
        }
      
        
         BarController.instance.startBalancingChildes();
    	
    }
    


     public void removeChild(int start){
        int end=transform.childCount;
        for(int i=start;i<end;i++){
            this.transform.GetChild(i).parent=null;
            Destroy(this.transform.GetChild(i).gameObject,3f);
           // currentPo-=new Vector3(.25f,0,0);
        }
        BarController.instance.startBalancingChildes();
    }
     public int getTotalChildNum(){
    	return this.transform.childCount;
    }
    
}
