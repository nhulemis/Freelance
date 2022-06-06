namespace privaxpika.Scripts
{
    public class hwua
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
        }  
        public class FactorialExample  
        {  
            public static void Main(string[] args)  
            {  
                int i,fact=1,number;      
                number= 1;     
                for(i=1;i<=number;i++){      
                    fact=fact*i;      
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
        }
        public class PrintExample  
        {  
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
        }  }
}