using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    internal class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
             ListNode result = new ListNode();
            if(list1== null)
            {
                return list2;
            }
            if(list2== null)
            {
                return list1;
            }
            if (list1.val >= list2.val)
            {
                result= list2;
                list2 = list2.next;
                result.next = this.mergeTwoLists(list1,list2);
            }
            else
            {
                result = list1;
                list1 = list1.next;
                result.next = this.mergeTwoLists(list1, list2);
            }




            return result;
        }
    }
}
