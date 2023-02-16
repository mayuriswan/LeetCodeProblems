using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Two_Numbers
{
    internal class Solution
    {
        public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode curr = head;
            int i = 0;
            while (l1 != null || l2 != null || i != 0)
            {
                int a = (l1 == null) ? 0 : l1.val;
                int b = (l2 == null) ? 0 : l2.val;
                int sum = a + b + i;
                i = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;


            }
            return head.next;
        }
    }

}