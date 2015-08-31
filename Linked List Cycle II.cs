/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null) return null;
        ListNode start = head;
        ListNode target = head;
        while (target.next != null && target.next.next != null)
        {
            start = start.next;
            target = target.next.next;
            if (start == target)
            {
                start = head;
                while (start != target)
                {
                    start = start.next;
                    target = target.next;
                }
                return start;
            }
        }
        return null;


    }
}