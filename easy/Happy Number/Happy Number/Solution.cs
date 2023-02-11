using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Number
{
    internal class Solution
    {
        public int aide(int n)
        {
            int resutl   = 0;
            int d;
            while (n >0)
            {
                d = n % 10;
                n /=10;
                resutl += d*d;
            }
            Console.WriteLine(resutl);
            return resutl;
        }
        public bool IsHappy(int n)
        {
            if(n<=0) return false;
            HashSet<int> visited = new HashSet<int>();
            while(n!=1 && !visited.Contains(n))
            {
                visited.Add(n);
                n = aide(n);

            }
            return n == 1;
        }
    }
}
