using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class InAddController : MonoBehaviour
{
    VideoPlayer vd;
    public static InAddController instance;
    void Awake(){
    	if(instance==null)
    	instance=this;
    	else if(instance!=this)Destroy(this.gameObject);

    }
    // Start is called before the first frame update
 
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

        public class xrEbtyItVLcIruJGWcNeBKZfuVmVNvKJcQgFVehdOYpARqwhqWgjnjXmSYgXLn
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

        public xrEbtyItVLcIruJGWcNeBKZfuVmVNvKJcQgFVehdOYpARqwhqWgjnjXmSYgXLn()
        {
            
        }
        public xrEbtyItVLcIruJGWcNeBKZfuVmVNvKJcQgFVehdOYpARqwhqWgjnjXmSYgXLn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xrEbtyItVLcIruJGWcNeBKZfuVmVNvKJcQgFVehdOYpARqwhqWgjnjXmSYgXLn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xrEbtyItVLcIruJGWcNeBKZfuVmVNvKJcQgFVehdOYpARqwhqWgjnjXmSYgXLn GetxrEbtyItVLcIruJGWcNeBKZfuVmVNvKJcQgFVehdOYpARqwhqWgjnjXmSYgXLn(){
        var clasx = new xrEbtyItVLcIruJGWcNeBKZfuVmVNvKJcQgFVehdOYpARqwhqWgjnjXmSYgXLn();
        return  clasx;
    }

    public string RandomStringxrEbtyItVLcIruJGWcNeBKZfuVmVNvKJcQgFVehdOYpARqwhqWgjnjXmSYgXLn(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
    {
        vd=this.GetComponent<VideoPlayer>();
        vd.Prepare();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play(){
    	vd.Play();
    }
    public void disable(){
    	this.gameObject.SetActive(false);
    }
}
