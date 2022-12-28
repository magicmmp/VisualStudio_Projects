using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
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
    //已通过测试
    internal class L2_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode node = new ListNode(0,null);
            ListNode t = node;
            int sum = 0;
            while (l1 != null || l2 != null)
            {
                sum = sum / 10;
                if (l1 != null)
                {
                    sum = sum + l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum = sum + l2.val;
                    l2 = l2.next;
                }
                t.next = new ListNode(sum % 10,null);
                t = t.next;
            }
            if (sum / 10 > 0)
                t.next = new ListNode(1, null);

            return node.next;

        }
    }
}

/**
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode node=new ListNode(0);
		ListNode t=node;
		int sum=0;
		while(l1!=null || l2!=null)
		{
			sum=sum/10;
			if(l1!=null)
			{
				sum=sum+l1.val;
				l1=l1.next;
			}
			if(l2!=null)
			{
				sum=sum+l2.val;
				l2=l2.next;
			}
			t.next=new ListNode(sum%10);
			t=t.next;
		}
		if(sum/10>0)
			t.next=new ListNode(1);
				
		return node.next;
    }
}
*/
