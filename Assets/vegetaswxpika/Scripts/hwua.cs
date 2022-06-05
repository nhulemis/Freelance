namespace vegetaswxpika.Scripts
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