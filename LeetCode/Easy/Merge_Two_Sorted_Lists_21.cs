using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Merge_Two_Sorted_Lists_21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode();
            var prev = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }
            if (l1 != null)
            {
                prev.next = l1;
            }
            if (l2 != null)
            {
                prev.next = l2;
            }
            return head.next;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
