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
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (head == null || k <= 1) return head;
        ListNode runner = head;
        int i = 1;
        while (runner != null && i < k)
        {
            runner = runner.next;
            i++;
        }
        if (runner == null) return head;
        ListNode preHead = new ListNode(0);
        preHead.next = head;
        ListNode start = head.next;
        i = 1;
        while (i < k)
        {
            ListNode tmp = preHead.next;
            preHead.next = start;
            start = start.next;
            preHead.next.next = tmp;
            i++;
        }

        head.next = ReverseKGroup(start, k);
        return preHead.next;
    }
}