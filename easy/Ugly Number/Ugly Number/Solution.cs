using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ugly_Number
{
    internal class Solution
    {
        public bool IsUgly(int n)
        {
            if(n<=0) return false;
            if(n==1) return true;
            int[] divesers  = new int[] {2,3,5};
            
                foreach (int i in divesers)
                {
                    while (n % i == 0)
                    {
                        n /= i; continue;
                    }
                    Console.WriteLine(n);
                }
            
            return n==1;
        }
    }
}
