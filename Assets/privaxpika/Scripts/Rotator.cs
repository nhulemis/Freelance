using UnityEngine;

namespace privaxpika.Scripts
{
    public class Rotator : MonoBehaviour
    {
        public float speed;
        // Start is called before the first frame update
        void Start()
        {
        
        }public class ShoppingCartItem
        {
            private int productID;
            private string productCategory;
            private string subCategory;
            private string productName;
            private string productDescription;
            private decimal productPrice;
            private double productWeight;
            private int units;
            public class PrintExample  
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
                public class PrimeNumberExample  
                {  
                    public static void Main(string[] args)  
                    {  
                        int n = 0, i, m=0, flag=0;    
                        m=n/2;    
                        for(i = 2; i <= m; i++)    
                        {    
                            if(n % i == 0)    
                            {    
                                flag=1;    
                                break;    
                            }    
                        }    
                        //if (flag==0)    
                    }  
                }  
                public class PalindromeExample  
                {  
                    public static void Main(string[] args)  
                    {  
                        int n,r,sum=0,temp;    
                        n = 1;  
                        temp=n;      
                        while(n>0)      
                        {      
                            r=n%10;      
                            sum=(sum*10)+r;      
                            n=n/10;      
                        }      
                    }  
                }  public class Payroll
                {
                    public int ID { get; set; }
                    public int EmployeeID { get; set; }
                    public decimal GrossMonthlySalary { get; set; }
                    public int NumberOfChecks { get; set; }
                }class Booka
                {
                    private string Number;

                    public string BookNumber
                    {
                        get { return Number; }
                        set { Number = value; }
                    }
        
                    private string Name;

                    public string BookName
                    {
                        get { return Name; }
                        set { Name = value; }
                    }
                }public class BookShelf 
                {
                    // constructor
                    public BookShelf()
                    {
                        //Test data will be in finnish
                        //Add(new Book { BookNumber = "104", BookName = "Aku saa aikaan" });
                        //Add(new Book { BookNumber = "13", BookName = "Ritari Peloton" });
                        //testing method
                        //addBook("412", "Akun Juhlavuosi");
                    }
                    /**
         * addBook() -method for adding new book to collection
         * 
         * @param   bookNumber
         * @param   bookName
         **/
                    public void addBook(string bookNumber, string bookName)
                    {
                        System.Diagnostics.Debug.WriteLine("Tietooo 2:" + bookNumber + " " + bookName);
                        //Add(new Book { BookNumber = bookNumber, BookName = bookName });
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

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up,Time.deltaTime*speed);
        }
    }
}
