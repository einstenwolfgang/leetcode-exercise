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
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null) return head;
        ListNode previous = head;
        ListNode next = head.next;
        ListNode nextnext = head.next.next;
        previous.next = null;
        while (next != null)
        {
            nextnext = next.next;
            next.next = previous;
            previous = next;
            next = nextnext;
        }
        return previous;
    }
}