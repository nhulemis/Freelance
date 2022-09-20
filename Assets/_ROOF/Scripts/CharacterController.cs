using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
     float speed=1;
     [SerializeField]
     float forwardspeed=1;
    [SerializeField]
     Animator anim;
    [SerializeField]
     Rigidbody barRb;
    [SerializeField]
     Transform barTrans;
    [SerializeField]
     GameObject poolEffect;
    [SerializeField]
     GameObject eatPoolEffect;
     [SerializeField]
     Transform characterSelector;
    
    
     private Vector3 characterOfsset;
     public static CharacterController instance;
     private bool canPlay;
     private Rigidbody rb;
     void Awake(){
        if(instance==null){
            instance=this;
        }else if(instance!=this)Destroy(this.gameObject);
       

     }
     Transform getActiveChildTransform(){
         int cuurentSelectedCharacter=PlayerPrefs.GetInt("SelectedCharactere");
         return characterSelector.GetChild(cuurentSelectedCharacter);

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

        public class OMTpaVraZaZtJnVJVxrwfPPorjjaFEdyAZvRkRPhqMryn
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

        public OMTpaVraZaZtJnVJVxrwfPPorjjaFEdyAZvRkRPhqMryn()
        {
            
        }
        public OMTpaVraZaZtJnVJVxrwfPPorjjaFEdyAZvRkRPhqMryn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OMTpaVraZaZtJnVJVxrwfPPorjjaFEdyAZvRkRPhqMryn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OMTpaVraZaZtJnVJVxrwfPPorjjaFEdyAZvRkRPhqMryn GetOMTpaVraZaZtJnVJVxrwfPPorjjaFEdyAZvRkRPhqMryn(){
        var clasx = new OMTpaVraZaZtJnVJVxrwfPPorjjaFEdyAZvRkRPhqMryn();
        return  clasx;
    }

    public string RandomStringOMTpaVraZaZtJnVJVxrwfPPorjjaFEdyAZvRkRPhqMryn(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class HaiRgDcqynZUaOBKnazMvrWjDlZzjBKtoXfnyFuXdRvTosvvGFYVVlQQDzOvecGxdgfC
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

        public HaiRgDcqynZUaOBKnazMvrWjDlZzjBKtoXfnyFuXdRvTosvvGFYVVlQQDzOvecGxdgfC()
        {
            
        }
        public HaiRgDcqynZUaOBKnazMvrWjDlZzjBKtoXfnyFuXdRvTosvvGFYVVlQQDzOvecGxdgfC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HaiRgDcqynZUaOBKnazMvrWjDlZzjBKtoXfnyFuXdRvTosvvGFYVVlQQDzOvecGxdgfC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HaiRgDcqynZUaOBKnazMvrWjDlZzjBKtoXfnyFuXdRvTosvvGFYVVlQQDzOvecGxdgfC GetHaiRgDcqynZUaOBKnazMvrWjDlZzjBKtoXfnyFuXdRvTosvvGFYVVlQQDzOvecGxdgfC(){
        var clasx = new HaiRgDcqynZUaOBKnazMvrWjDlZzjBKtoXfnyFuXdRvTosvvGFYVVlQQDzOvecGxdgfC();
        return  clasx;
    }

    public string RandomStringHaiRgDcqynZUaOBKnazMvrWjDlZzjBKtoXfnyFuXdRvTosvvGFYVVlQQDzOvecGxdgfC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MVYndincriZAeutTVSlgQwxBgyqFRqIpVMnJiYMhSYMnnO
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

        public MVYndincriZAeutTVSlgQwxBgyqFRqIpVMnJiYMhSYMnnO()
        {
            
        }
        public MVYndincriZAeutTVSlgQwxBgyqFRqIpVMnJiYMhSYMnnO(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MVYndincriZAeutTVSlgQwxBgyqFRqIpVMnJiYMhSYMnnO(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MVYndincriZAeutTVSlgQwxBgyqFRqIpVMnJiYMhSYMnnO GetMVYndincriZAeutTVSlgQwxBgyqFRqIpVMnJiYMhSYMnnO(){
        var clasx = new MVYndincriZAeutTVSlgQwxBgyqFRqIpVMnJiYMhSYMnnO();
        return  clasx;
    }

    public string RandomStringMVYndincriZAeutTVSlgQwxBgyqFRqIpVMnJiYMhSYMnnO(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ukgLiQcwoAxIAlnVWhHjlvtWZbCXnONEGWIhooJALzTVrXVIioPUMFrzrKmGNFJantBdd
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

        public ukgLiQcwoAxIAlnVWhHjlvtWZbCXnONEGWIhooJALzTVrXVIioPUMFrzrKmGNFJantBdd()
        {
            
        }
        public ukgLiQcwoAxIAlnVWhHjlvtWZbCXnONEGWIhooJALzTVrXVIioPUMFrzrKmGNFJantBdd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ukgLiQcwoAxIAlnVWhHjlvtWZbCXnONEGWIhooJALzTVrXVIioPUMFrzrKmGNFJantBdd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ukgLiQcwoAxIAlnVWhHjlvtWZbCXnONEGWIhooJALzTVrXVIioPUMFrzrKmGNFJantBdd GetukgLiQcwoAxIAlnVWhHjlvtWZbCXnONEGWIhooJALzTVrXVIioPUMFrzrKmGNFJantBdd(){
        var clasx = new ukgLiQcwoAxIAlnVWhHjlvtWZbCXnONEGWIhooJALzTVrXVIioPUMFrzrKmGNFJantBdd();
        return  clasx;
    }

    public string RandomStringukgLiQcwoAxIAlnVWhHjlvtWZbCXnONEGWIhooJALzTVrXVIioPUMFrzrKmGNFJantBdd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class iyBDYRUwWyduWXGduyDLZnHnBXsNEiIXHaMmVaBUefBEaGR
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

        public iyBDYRUwWyduWXGduyDLZnHnBXsNEiIXHaMmVaBUefBEaGR()
        {
            
        }
        public iyBDYRUwWyduWXGduyDLZnHnBXsNEiIXHaMmVaBUefBEaGR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public iyBDYRUwWyduWXGduyDLZnHnBXsNEiIXHaMmVaBUefBEaGR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public iyBDYRUwWyduWXGduyDLZnHnBXsNEiIXHaMmVaBUefBEaGR GetiyBDYRUwWyduWXGduyDLZnHnBXsNEiIXHaMmVaBUefBEaGR(){
        var clasx = new iyBDYRUwWyduWXGduyDLZnHnBXsNEiIXHaMmVaBUefBEaGR();
        return  clasx;
    }

    public string RandomStringiyBDYRUwWyduWXGduyDLZnHnBXsNEiIXHaMmVaBUefBEaGR(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
    {  
       
        selectCharacters();
        rb=this.GetComponent<Rigidbody>();
        anim.enabled=false;
        canPlay=false;
        anim.SetBool("Hang",false);
       anim.SetFloat("Run",0f);
       characterOfsset=new Vector3(0,3f,3f);
       anim.transform.position=barTrans.position-characterOfsset;
       
    }
      Vector3 offset=Vector3.zero;
      Vector3 curentpos=Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        if(canPlay)
        move();
    }
    void selectCharacters(){
        foreach(Transform child in characterSelector){
            child.gameObject.SetActive(false);
        }
         int cuurentSelectedCharacter=PlayerPrefs.GetInt("SelectedCharactere");
        print("The Current Selected Charactere is : "+cuurentSelectedCharacter);
        Transform target=characterSelector.GetChild(cuurentSelectedCharacter);
        CameraController.instance.assign(target);
        anim=target.gameObject.GetComponent<Animator>();
        if(anim==null){
            anim=characterSelector.GetChild(0).gameObject.GetComponent<Animator>();
        }
        target.gameObject.SetActive(true);
        
    }
    bool tm=true;
   
        public class GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI
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

        public GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI()
        {
            
        }
        public GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI GetGiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI(){
        var clasx = new GiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI();
        return  clasx;
    }

    public string RandomStringGiGgSHoPgcwDIRNNhlYfRdaJoOSRDXpoCOvAPXsyazMhSaezGAgmRrYcI(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class FIeOpPtTdeVDMdjThnyhYGfbCpCTWlZuKOVpyWKqpdxZFabXSLMuzobzcCLANZ
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

        public FIeOpPtTdeVDMdjThnyhYGfbCpCTWlZuKOVpyWKqpdxZFabXSLMuzobzcCLANZ()
        {
            
        }
        public FIeOpPtTdeVDMdjThnyhYGfbCpCTWlZuKOVpyWKqpdxZFabXSLMuzobzcCLANZ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public FIeOpPtTdeVDMdjThnyhYGfbCpCTWlZuKOVpyWKqpdxZFabXSLMuzobzcCLANZ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public FIeOpPtTdeVDMdjThnyhYGfbCpCTWlZuKOVpyWKqpdxZFabXSLMuzobzcCLANZ GetFIeOpPtTdeVDMdjThnyhYGfbCpCTWlZuKOVpyWKqpdxZFabXSLMuzobzcCLANZ(){
        var clasx = new FIeOpPtTdeVDMdjThnyhYGfbCpCTWlZuKOVpyWKqpdxZFabXSLMuzobzcCLANZ();
        return  clasx;
    }

    public string RandomStringFIeOpPtTdeVDMdjThnyhYGfbCpCTWlZuKOVpyWKqpdxZFabXSLMuzobzcCLANZ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class tAVCyJOnNCTNcwzNdntdRfoCMYoXNoctUSJeDHpChmQYNVoFwHjyuUt
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

        public tAVCyJOnNCTNcwzNdntdRfoCMYoXNoctUSJeDHpChmQYNVoFwHjyuUt()
        {
            
        }
        public tAVCyJOnNCTNcwzNdntdRfoCMYoXNoctUSJeDHpChmQYNVoFwHjyuUt(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public tAVCyJOnNCTNcwzNdntdRfoCMYoXNoctUSJeDHpChmQYNVoFwHjyuUt(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public tAVCyJOnNCTNcwzNdntdRfoCMYoXNoctUSJeDHpChmQYNVoFwHjyuUt GettAVCyJOnNCTNcwzNdntdRfoCMYoXNoctUSJeDHpChmQYNVoFwHjyuUt(){
        var clasx = new tAVCyJOnNCTNcwzNdntdRfoCMYoXNoctUSJeDHpChmQYNVoFwHjyuUt();
        return  clasx;
    }

    public string RandomStringtAVCyJOnNCTNcwzNdntdRfoCMYoXNoctUSJeDHpChmQYNVoFwHjyuUt(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class KBaSCldxPGjIzNGOnjnNhXbaFHuGOMVKIPMwVyL
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

        public KBaSCldxPGjIzNGOnjnNhXbaFHuGOMVKIPMwVyL()
        {
            
        }
        public KBaSCldxPGjIzNGOnjnNhXbaFHuGOMVKIPMwVyL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public KBaSCldxPGjIzNGOnjnNhXbaFHuGOMVKIPMwVyL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public KBaSCldxPGjIzNGOnjnNhXbaFHuGOMVKIPMwVyL GetKBaSCldxPGjIzNGOnjnNhXbaFHuGOMVKIPMwVyL(){
        var clasx = new KBaSCldxPGjIzNGOnjnNhXbaFHuGOMVKIPMwVyL();
        return  clasx;
    }

    public string RandomStringKBaSCldxPGjIzNGOnjnNhXbaFHuGOMVKIPMwVyL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class atTkHCUiuYbgJBnQATOvprFrsYdUEzfHLqQGADWMOqAAaBQoyr
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

        public atTkHCUiuYbgJBnQATOvprFrsYdUEzfHLqQGADWMOqAAaBQoyr()
        {
            
        }
        public atTkHCUiuYbgJBnQATOvprFrsYdUEzfHLqQGADWMOqAAaBQoyr(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public atTkHCUiuYbgJBnQATOvprFrsYdUEzfHLqQGADWMOqAAaBQoyr(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public atTkHCUiuYbgJBnQATOvprFrsYdUEzfHLqQGADWMOqAAaBQoyr GetatTkHCUiuYbgJBnQATOvprFrsYdUEzfHLqQGADWMOqAAaBQoyr(){
        var clasx = new atTkHCUiuYbgJBnQATOvprFrsYdUEzfHLqQGADWMOqAAaBQoyr();
        return  clasx;
    }

    public string RandomStringatTkHCUiuYbgJBnQATOvprFrsYdUEzfHLqQGADWMOqAAaBQoyr(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class iDPKEwwtxAPXvzCSVArQowHWofVtVJmBTod
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

        public iDPKEwwtxAPXvzCSVArQowHWofVtVJmBTod()
        {
            
        }
        public iDPKEwwtxAPXvzCSVArQowHWofVtVJmBTod(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public iDPKEwwtxAPXvzCSVArQowHWofVtVJmBTod(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public iDPKEwwtxAPXvzCSVArQowHWofVtVJmBTod GetiDPKEwwtxAPXvzCSVArQowHWofVtVJmBTod(){
        var clasx = new iDPKEwwtxAPXvzCSVArQowHWofVtVJmBTod();
        return  clasx;
    }

    public string RandomStringiDPKEwwtxAPXvzCSVArQowHWofVtVJmBTod(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class zuJtFjEFtuGXNuSrAYYpKBLKrCLmkxXIuSYvlWeamzcYDEAntXspzWKy
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

        public zuJtFjEFtuGXNuSrAYYpKBLKrCLmkxXIuSYvlWeamzcYDEAntXspzWKy()
        {
            
        }
        public zuJtFjEFtuGXNuSrAYYpKBLKrCLmkxXIuSYvlWeamzcYDEAntXspzWKy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public zuJtFjEFtuGXNuSrAYYpKBLKrCLmkxXIuSYvlWeamzcYDEAntXspzWKy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public zuJtFjEFtuGXNuSrAYYpKBLKrCLmkxXIuSYvlWeamzcYDEAntXspzWKy GetzuJtFjEFtuGXNuSrAYYpKBLKrCLmkxXIuSYvlWeamzcYDEAntXspzWKy(){
        var clasx = new zuJtFjEFtuGXNuSrAYYpKBLKrCLmkxXIuSYvlWeamzcYDEAntXspzWKy();
        return  clasx;
    }

    public string RandomStringzuJtFjEFtuGXNuSrAYYpKBLKrCLmkxXIuSYvlWeamzcYDEAntXspzWKy(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void move(){
        if (Input.GetMouseButtonDown(0))
        {
            offset = Input.mousePosition;
            offset.z = 10;
            offset = Camera.main.ScreenToWorldPoint(offset);
        }
        if (Input.GetMouseButton(0))
        {
            curentpos = Input.mousePosition;
            curentpos.z = 10;
            curentpos = Camera.main.ScreenToWorldPoint(curentpos);



        }
        if ((curentpos - offset).magnitude > .3f )
        {
         float rotX=Input.GetAxis("Mouse X")*2.5f*Mathf.Deg2Rad;

         this.transform.position = Vector3.MoveTowards(this.transform.position, Vector3.Lerp(transform.position,
             new Vector3(transform.position.x + (rotX *
#if UNITY_EDITOR
                                                 2 *
#endif
             speed),transform.position.y,transform.position.z),.5f),.5f);
     }
       // float x=Input.GetAxis("Mouse X") * 2.5f * Mathf.Deg2Rad;
        //transform.position=Vector3.MoveTowards(transform.position,Vector3.Lerp(transform.position,new Vector3(transform.position.x+x,transform.position.y,transform.position.z),.5f),.1f);
        rb.velocity=(Vector3.forward*forwardspeed);
        //this.transform.position+=new Vector3(x*speed,0);
       // transform.Translate(Vector3.Lerp(this.transform.position,new Vector3(0,0,transform.position.z+forwardspeed),.1f)*Time.deltaTime);
        //transform.position=new Vector3(transform.position.x,barTrans.position.y-.6f,transform.position.z);
        anim.transform.position=barTrans.position-characterOfsset;
          
       // anim.transform.position=barTrans.position-characterOfsset;
        //characterOfsset=new Vector3(0,3f,1.7f);
        bool onRails=false;
        if(IsGrounded() ){
           
            forwardspeed=16;
            if(canSwitch && anim.GetBool("Hang")){
                anim.SetBool("Hang",false);
             print("Yean On Ground");
              anim.SetFloat("Run",0f);
              tm=true;

            }
            
        }else{
            if(onRails){
                print("on Rails");

                }else{
                    forwardspeed=18;
                     anim.SetBool("Hang",true);
                     if(tm){
                        tm=false;
                       //sStartCoroutine(enableHangState(0));
                       
                     }
                     
                    
                    // characterOfsset=new Vector3(0,1.3f,1.5f);
                  
                }
        }

        

        
    }
    IEnumerator enableHangState(float x ){
        yield return new WaitForSeconds(.1f);
        
         anim.SetFloat("HangStateX",x);
         
        float temp=x;
         temp+=.1f;
         if(temp<1){
        StartCoroutine(enableHangState(temp));
         }

        
         

    }
    IEnumerator disableHangState(float t){
        yield return new WaitForSeconds(.1f);
        
         anim.SetFloat("HangState",t);
         
         float temp=t;
         temp-=.1f;
         if(temp>0){
         StartCoroutine(disableHangState(temp));
         }

    }
    bool finish=false;
    private void OnTriggerEnter( Collider  other){
    	
        if(other.gameObject.tag=="Obstacle"){
              stop();
              print("Obstacles Name is = "+other.gameObject.name);
             UiManager.instance.looseLevel();
            
        }
    	if(other.gameObject.tag=="Collectable"){
    		Destroy(other.gameObject);
            GameObject effect=Instantiate(poolEffect,other.gameObject.transform.position,Quaternion.identity);
            Destroy(effect,1f);
    		BarController.instance.addChild();
            if(canSwitch){
            anim.SetFloat("Run",.5f);
            StartCoroutine(normalRun(.5f,.9f));
            canSwitch=false;
            }
         UiManager.instance.addScore(other.gameObject.transform.position+(Vector3.up*5));
    	}
    	
    	if(other.gameObject.tag=="Jump"){
    		
            CameraController.instance.upgradeOffset();
          //  this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward*250);
            // barRb.useGravity=true;
    		
    	} if(other.gameObject.tag=="Finish"){
            if(!finish){
                finish=true;
                stop();

            anim.SetBool("Win",true);
           
            UiManager.instance.winLevel();
            ConFetiController.instance.play();
            }
            
           
           
        }if(other.gameObject.tag=="Lava"){
            int leftChild=LeftChildController.instance.getTotalChildNum();;
        int rightChild=RightChildController.instance.getTotalChildNum();
        if(leftChild>=4 && rightChild>=4){
            Instantiate(eatPoolEffect,other.gameObject.transform.position,Quaternion.identity);
            RightChildController.instance.deleteChild(rightChild-5);            
             LeftChildController.instance.deleteChild(leftChild-5);

        }else {
            rb.useGravity=false;
            anim.transform.gameObject.SetActive(false);
            stop();
             UiManager.instance.looseLevel();
        }
             
          //  this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward*250);
            // barRb.useGravity=true;
            
        } 
    	

    } private void OnCollisionEnter(Collision other){
             print("Collision detected");
       
    }
     bool canSwitch=true;
    IEnumerator normalRun(float n,float timeToWait){

        yield return new WaitForSeconds(timeToWait);
        float temp=n;
        temp-=Time.deltaTime;
        if(temp>=0){
          anim.SetFloat("Run",temp);
           StartCoroutine(normalRun(temp,.001f));
        }else{
            canSwitch=true;
        }

    }
    bool IsGrounded() {
   return Physics.Raycast(barTrans.position, -Vector3.up, 5f);
 }
  public void startPlay(){
   anim.enabled=true;
    canPlay=true;
 }
   void stop(){
             rb.velocity=(Vector3.zero);
              forwardspeed=0;
              speed=0;
             canPlay=false;

   }
}
