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
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;
        ListNode newlist = new ListNode(head.val);
        newlist.next = head.next;
        ListNode start = newlist;

        ListNode target = head.next;
        while (target != null)
        {
            if (start.val == target.val)
            {
                start.next = target.next;
                target = target.next;
            }
            else
            {
                start = start.next;
                target = target.next;
            }
        }
        return newlist;
    }
}