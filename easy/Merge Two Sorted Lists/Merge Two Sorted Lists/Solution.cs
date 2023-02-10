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
            ListNode result = null;
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
                result.val= list2.val;
                list1.next= MergeTwoLists(list1.next, list2.next);
                result.next = list1;
            }
            else
            {
                result.val = list1.val;
                list2.next = MergeTwoLists(list1.next, list2.next);
                result.next = list2;
            }




            return null;
        }
    }
}
