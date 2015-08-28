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
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode dummy = new ListNode(0);
        ListNode p = dummy, q = head;
        dummy.next = head;
        while (q != null)
        {
            if (q.val == val)
            {
                p.next = q.next;
            }
            else
            {
                p = p.next;
            }
            q = q.next;
        }
        return dummy.next;
    }
}