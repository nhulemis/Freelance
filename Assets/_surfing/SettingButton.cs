using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SettingButton : MonoBehaviour
{
    Button mainButton;
    SettingItemButton[] menuItem;
    int childCount=0;
    Vector2 mainButtonPosition;
    bool isExpanded=false;
    [SerializeField]Vector2 spacing;
    [Header("main Button Rotation")]
     [SerializeField]float rotationDuraTion;
     [SerializeField]Ease rotationEase;
     [Header("Animation")]
     [SerializeField]float expandDuraTion;
     [SerializeField]float collapseDuraTion;
     [SerializeField]Ease expandEase;
      [SerializeField]Ease collapseEase;
     [Header("Fading")]
     [SerializeField]float expandFadeDuraTion;
     [SerializeField]float collapseFadeDuraTion;
    
    // Start is called before the first frame update
 
        public class gTnLAGjIoJSOIevWHmAaEWWXlnbUTd
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

        public gTnLAGjIoJSOIevWHmAaEWWXlnbUTd()
        {
            
        }
        public gTnLAGjIoJSOIevWHmAaEWWXlnbUTd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public gTnLAGjIoJSOIevWHmAaEWWXlnbUTd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public gTnLAGjIoJSOIevWHmAaEWWXlnbUTd GetgTnLAGjIoJSOIevWHmAaEWWXlnbUTd(){
        var clasx = new gTnLAGjIoJSOIevWHmAaEWWXlnbUTd();
        return  clasx;
    }

    public string RandomStringgTnLAGjIoJSOIevWHmAaEWWXlnbUTd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH
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

        public qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH()
        {
            
        }
        public qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH GetqFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH(){
        var clasx = new qFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH();
        return  clasx;
    }

    public string RandomStringqFHhYwxBbptYDpQUfbezKlMnsfMiXXiMHSFGUDwbBOkAlELbLMfgiWvEtUoskPeEH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH
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

        public JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH()
        {
            
        }
        public JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH GetJYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH(){
        var clasx = new JYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH();
        return  clasx;
    }

    public string RandomStringJYYhjnuJTejfNVnulPdZvrArDItlcWtaJFsubwdOztuRveFGlYclMbsSYgdbtIhxlJWH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA
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

        public mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA()
        {
            
        }
        public mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA GetmLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA(){
        var clasx = new mLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA();
        return  clasx;
    }

    public string RandomStringmLSxcyXbeXjwsMWMfOQGgULWfXxjPnKyyGWxvhlZRncQqmEesYpA(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ
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

        public QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ()
        {
            
        }
        public QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ GetQghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ(){
        var clasx = new QghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ();
        return  clasx;
    }

    public string RandomStringQghkezQQHDCvvRBWGZAhvoihXOvpClzaUTfSXgpuVyJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh
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

        public ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh()
        {
            
        }
        public ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh GetejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh(){
        var clasx = new ejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh();
        return  clasx;
    }

    public string RandomStringejFISwDJVBXrOrPMeThmvOOqGvKOSkwIFTyNAh(int length)
    {
        string chars = string.Empty;
        return chars;
    }
   void Start()
    {
        

        childCount=this.transform.childCount-1;
        menuItem=new SettingItemButton[childCount];
        for(int i=0;i<childCount;i++){
        	menuItem[i]=this.transform.GetChild(i+1).GetComponent<SettingItemButton>();
        }
        mainButton=this.transform.GetChild(0).GetComponent<Button>();
      mainButton.transform.SetAsLastSibling(); 
        mainButton.onClick.AddListener(toogleMenu);
          
        mainButtonPosition=mainButton.transform.position;
       
      // mainButton.transform.SetAsLastSibling();
        resetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
        public class KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd
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

        public KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd()
        {
            
        }
        public KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd GetKDMbcIcFcJHWbVrvkTIrOZPkGJekSEd(){
        var clasx = new KDMbcIcFcJHWbVrvkTIrOZPkGJekSEd();
        return  clasx;
    }

    public string RandomStringKDMbcIcFcJHWbVrvkTIrOZPkGJekSEd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF
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

        public fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF()
        {
            
        }
        public fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF GetfSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF(){
        var clasx = new fSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF();
        return  clasx;
    }

    public string RandomStringfSBbkcwQvCyZwBRVudKDhqZdXvLbkUYzPLpecPQbgKIMVF(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn
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

        public GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn()
        {
            
        }
        public GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn GetGXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn(){
        var clasx = new GXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn();
        return  clasx;
    }

    public string RandomStringGXGtOdfSyEwWNaULvjuQKtCSzdNBtDNwfJSbZSNBqAn(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup
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

        public yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup()
        {
            
        }
        public yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup GetyYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup(){
        var clasx = new yYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup();
        return  clasx;
    }

    public string RandomStringyYlNtLerdplPKQLwmVcnwXppWeaKcovvczxOToyAIZoswJIOfOYpPHnajwrOkUOpup(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy
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

        public UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy()
        {
            
        }
        public UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy GetUeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy(){
        var clasx = new UeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy();
        return  clasx;
    }

    public string RandomStringUeIWOKBAzQrrbCaMNAcWtuTKGidQVAzbjYzfRvyFQTtlPRAvtHFKYxZZKy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA
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

        public RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA()
        {
            
        }
        public RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA GetRjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA(){
        var clasx = new RjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA();
        return  clasx;
    }

    public string RandomStringRjUMSUtDJyhzmxCJDvurvaUcxGqaWXDTkvqGzpdJunVA(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void resetPosition(){

    	for(int i=0;i<childCount;i++){
    		// menuItem[i].trans.DOMove(mainButtonPosition,collapseDuraTion).SetEase(collapseEase);
    		//  menuItem[i].img.DOFade(0f,collapseFadeDuraTion);
    	}      
    }
    private void toogleMenu(){
    	isExpanded=!isExpanded;
    	print("expand");
    	if(isExpanded){
    		
    		for(int i=0;i<childCount;i++){
               // menuItem[i].trans.position=mainButtonPosition+spacing*(i+1);
                   menuItem[i].trans.DOMove(mainButtonPosition+spacing*(i+1),expandDuraTion).SetEase(expandEase);
                   //menuItem[i].img.DOFade(1f,expandFadeDuraTion).From(0f);
    		}
    	}else {
    		resetPosition();
    	}
    	mainButton.transform.DORotate(Vector3.up*180f,rotationDuraTion)
    	.From(Vector3.zero)
    	.SetEase(rotationEase);

    }
    private void OnDestroy(){
    	mainButton.onClick.RemoveListener(toogleMenu);
    }
}
