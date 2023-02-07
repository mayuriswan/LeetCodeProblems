using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class1
    {
        
            public bool IsPalindrome(int x)
            {
                int reverse = 0;
                int l = x;
                while(l > 0)
                {
                
                int deg = l% 10;
                l=l/10;
                reverse *= 10;
                reverse += deg;
                Console.WriteLine(reverse + " *********" + deg);


                 }
                 return x == reverse;
             }
        
    }
}
