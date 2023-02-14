using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Subsequence
{
    class Solution1
    {
          public boolean isSubsequence(String s, String t) {
        int mark =-1;
        for(int i=0 ;i<s.length();i++){
              boolean founded = false ;
            for(int j=0;j<t.length();j++){
               
                if(t.charAt(j)==s.charAt(i) && j>mark){
                    founded = true ; 
                    mark=j;
                    break ; 
                } 
                
             }
            if(!founded){
                   return false;
                }
        }
        return true;
    }
    }
}
