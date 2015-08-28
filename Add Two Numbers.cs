/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carry = 0;
        ListNode tail = new ListNode(0);
        ListNode ptr = tail;

        while (l1 != null || l2 != null)
        {
            int val1 = 0;
            if (l1 != null)
            {
                val1 = l1.val;
                l1 = l1.next;
            }

            int val2 = 0;
            if (l2 != null)
            {
                val2 = l2.val;
                l2 = l2.next;
            }

            int tmp = val1 + val2 + carry;
            ptr.next = new ListNode(tmp % 10);
            carry = tmp / 10;
            ptr = ptr.next;
        }

        if (carry == 1)
        {
            ptr.next = new ListNode(1);
        }
        return tail.next;
    }
}