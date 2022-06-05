using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace jedyxnaol.Scripts
{
    public class UiManager : MonoBehaviour
    {
        //win item
        [Header("Ui Panel")]
        public GameObject playUi;
        public GameObject winUi;
        public GameObject nextButton;
        public GameObject happyUi;
        public GameObject collectedCoin;
        public GameObject xCoinButton;
        public Animator totalCollectedCoinAnim;
        public Text winCollectedCoin;
        public Text currentLevelText;
        private  int currentLevel;
        public static UiManager instance;
    
    
    
    
    
        public Text totalCoinText;
        private int totalCoin;
        public GameObject shopNotification;
        public CoinManger coinM;
        public Transform coinSP;
        private void Awake(){
            if(instance==null){
                instance=this;
            }else if(instance!=this){
                Destroy(this.gameObject);
            }
        }
        // Start is called before the first frame update
        void Start()
        {
            currentLevel=PlayerPrefs.GetInt("Current_Level",0);
            //if(SceneManager.GetActiveScene().buildIndex!=currentLevel)
            //  SceneManager.LoadScene(currentLevel);
            totalCoin=PlayerPrefs.GetInt("Total_Coin",0);
            if(totalCoin>1000)
            
            
            
            
                shopNotification.SetActive(true);
            else
                shopNotification.SetActive(false);
            se1tTotalCoinText();

       
            setLevelText();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void dragToPlay(){
            GameManager.instance.enablePlayMode();
            startPlayModel();
        }
        public void startPlayModel(){
            playUi.SetActive(false);

        }
        public void winh(){
        
            winUi.SetActive(true);
            
            
            
            StartCoroutine("paneelsDelay",.5f);
        } 
        IEnumerator paneelsDelay(){
            happyUi.SetActive(true);
            
            
            
            yield return new WaitForSeconds(2f);
            collectedCoin.SetActive(true);
       
        
        
        
        
            StartCoroutine("coinTextIncremetorDelayr");
            xCoinButton.SetActive(true);

        }
        int tempCoin=0;
        IEnumerator coinTextIncremetorDelayr(){
            coinM.animate(coinSP.position,1);
            yield return new WaitForSeconds(.00001f);
            if(tempCoin<200){
                tempCoin++;
                winCollectedCoin.text=tempCoin+"";
                StartCoroutine("coinTextIncremetorDelay");
            }else{
                totalCollectedCoinAnim.enabled=false;
                nextButton.SetActive(true);
                totalCoin+=200;
                PlayerPrefs.SetInt("Total_Coin",totalCoin);
            }
       



        }
        public void levelFail1()
        {

            goooNextLevel();
        }
        public void retry(){
            
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
        }
        public void skipLevel(){      
            goooNextLevel();
        }
        public void goooNextLevel(){
        
            SceneManager.LoadScene("17");
        }
        public void gooShopping(){
        }
        private void setLevelText(){
            currentLevelText.text="level:"+currentLevel;

        }
    
        public class Student  
        {  
            public int id;   
            public string name;  
        }  
        private void se1tTotalCoinText(){
            totalCoinText.text=totalCoin+"";
        }
        public class ShoppingCartItem
        {
            private int productID;
            private string productCategory;
            private string subCategory;
            private string productName;
            private string productDescription;
            private decimal productPrice;
            private double productWeight;
            private int units;

            public int ProductID
            {
                get { return productID; }
            }
            public string ProductCategory
            {
                get { return productCategory; }
            }
            public string SubCategory
            {
                get { return subCategory; }
            }
            public string ProductName
            {
                get { return productName; }
            }
            public string ProductDescription
            {
                get { return productDescription; }
            }
            public decimal ProductPrice
            {
                get { return productPrice; }
            }
            public double ProductWeight
            {
                get { return productWeight; }
                set { productWeight = value; }
            }
            public int Units
            {
                get { return units; }
                set { units = value; }
            }
            public decimal Total
            {
                get { return Units * ProductPrice; }
            }
            public ShoppingCartItem(int productID, string farm, string productCategory, 
                string subCategory, string productName, string productDescription,
                decimal productPrice, double productWeight, int units)
            {
                this.productID = productID;
                this.productCategory = productCategory;
                this.subCategory = productCategory;
                this.productName = productName;
                this.productDescription = productDescription;
                this.productPrice = productPrice;
                this.productWeight = productWeight; 
                this.units = units;
            }
        }
    }
}
