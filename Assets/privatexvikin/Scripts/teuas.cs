namespace jedyxnaol.Scripts
{
    public class teuas
    {
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
        }
    }
}