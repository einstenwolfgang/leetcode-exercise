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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null) return null;
        ListNode p = head;
        ListNode q = head;
        for (int i = 0; i < n; i++)
        {
            q = q.next;
        }
        if (q == null)
        {
            head = head.next;
            return head;
        }
        else
        {
            while (q.next != null)
            {
                p = p.next;
                q = q.next;
            }
            p.next = p.next.next;
            return head;
        }
    }
}