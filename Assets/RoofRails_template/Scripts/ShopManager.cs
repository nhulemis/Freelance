using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RoofRails_template.Scripts
{
    public class ShopManager : MonoBehaviour
    {
        public Transform chatctereParent;
        [SerializeField]
        private Text totalCoins;
        string[] unloackedCharactere;
        public GameObject nino;
        public static ShopManager instance; 
        // Start is called before the first frame update
        void Awake(){
            if(instance==null)instance=this;
            else if(instance!=this)Destroy(this.gameObject);
        }

        public class ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh
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

        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh()
        {
            
        }
        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh GetERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(){
        var clasx = new ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh();
        return  clasx;
    }

    public string RandomStringERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy
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

        public PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy()
        {
            
        }
        public PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy GetPDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy(){
        var clasx = new PDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy();
        return  clasx;
    }

    public string RandomStringPDllSiRErKGTOSkEgDZHOJxWOTlhARXKwECZxawKaWZpLyjLjqZQuPlFFOWy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl
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

        public yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl()
        {
            
        }
        public yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl GetyMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl(){
        var clasx = new yMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl();
        return  clasx;
    }

    public string RandomStringyMtJKvgOjpigFYhfPgrpZbyXDqIyLEdRnocLebUurl(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {   
       
            totalCoins.text=PlayerPrefs.GetInt("Total_Coin",0)+"";
            nino.SetActive(true);
            updateUnloackedCharctere();
            unhideUnloacked();

        }
        public void  unhideUnloacked(){
            updateUnloackedCharctere();
            foreach(string n in unloackedCharactere){
            
                childIndexByName(n); 
            }
    	
        }
       
        public class etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV
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

        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV()
        {
            
        }
        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV GetetYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(){
        var clasx = new etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV();
        return  clasx;
    }

    public string RandomStringetYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz
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

        public jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz()
        {
            
        }
        public jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz GetjymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz(){
        var clasx = new jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz();
        return  clasx;
    }

    public string RandomStringjymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class SxOezFDALhNZaNqcFaMFwdPhYbXYlfpXzzPSYOSOtsAxtk
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

        public SxOezFDALhNZaNqcFaMFwdPhYbXYlfpXzzPSYOSOtsAxtk()
        {
            
        }
        public SxOezFDALhNZaNqcFaMFwdPhYbXYlfpXzzPSYOSOtsAxtk(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public SxOezFDALhNZaNqcFaMFwdPhYbXYlfpXzzPSYOSOtsAxtk(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public SxOezFDALhNZaNqcFaMFwdPhYbXYlfpXzzPSYOSOtsAxtk GetSxOezFDALhNZaNqcFaMFwdPhYbXYlfpXzzPSYOSOtsAxtk(){
        var clasx = new SxOezFDALhNZaNqcFaMFwdPhYbXYlfpXzzPSYOSOtsAxtk();
        return  clasx;
    }

    public string RandomStringSxOezFDALhNZaNqcFaMFwdPhYbXYlfpXzzPSYOSOtsAxtk(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void childIndexByName(string n){
            int length=chatctereParent.childCount;
            for(int i=0;i<length;i++){
                GameObject obj=chatctereParent.GetChild(i).gameObject;
                if(n==obj.name){
                    obj.transform.GetChild(2).gameObject.SetActive(false);
                }
            }

        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void selectedItem(int i){

            updateUnloackedCharctere();
            bool isLocked=true;
            string clickedCharactereName=chatctereParent.GetChild(i).gameObject.name;
            foreach(string name in unloackedCharactere){
                if(name==clickedCharactereName){
                    isLocked=false;
                }

            }
            if(!isLocked){
                nino.SetActive(false);
                //print("the chatctere selected is : "+i);
                PlayerPrefs.SetInt("SelectedCharactere",i+1);
                SelectedItemManager.instance.showItem(i);
            }else {
                //print("Charctere is Not Loocked");
            }
    	
        }
        public void gooBack(){
            //print("goooo back");
            int i= PlayerPrefs.GetInt("Current_Level",0);
            SceneManager.LoadScene(i);
        }
        private void updateUnloackedCharctere(){
            string names=PlayerPrefs.GetString("UnloackedCharacters");
            unloackedCharactere=names.Split('+');
        }
        public void ninoSelected(){
            nino.SetActive(true);
            int ii=	PlayerPrefs.GetInt("SelectedCharactere");
            PlayerPrefs.SetInt("SelectedCharactere",0);
            SelectedItemManager.instance.hideItem(ii-1);
    

        }
        public void setTotalCoinText(){
            totalCoins.text=PlayerPrefs.GetInt("Total_Coin",0)+"";
        }
    }
}
