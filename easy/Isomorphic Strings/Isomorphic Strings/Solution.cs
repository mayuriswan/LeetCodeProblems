using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isomorphic_Strings
{
    internal class Solution
    {
        public bool IsIsomorphic(String s, String t)
        {
            Dictionary<char, char > hash = new Dictionary<char, char>();    
            for(int i=0;i<s.Length; i++)
            {
                if (hash.ContainsKey(s[i]))
                {
                    if (hash[s[i]] == t[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }else
                {
                    if (!hash.ContainsValue(t[i]))
                    {
                        hash.Add(s[i], t[i]);   
                    }
                    return false;
                }
            }
            return true;
        }
        }
}
