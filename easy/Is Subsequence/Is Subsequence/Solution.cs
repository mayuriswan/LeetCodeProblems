using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Subsequence
{
    internal class Solution
    {
        public bool isSubsequence(String s, String t)
        {
            int i = s.Length - 1;
            int j = t.Length - 1;
            while(i>=0 && j>=0)
            {
                if (s[i] == t[j])
                {
                    i--;
                }
                j--;
            }

            return i<0;
        }
    }
}
