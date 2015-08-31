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
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null) return head;
        ListNode dummy = new ListNode(0);
        ListNode cur = dummy;
        ListNode ret = head;
        while (ret != null && ret.next != null)
        {
            ListNode Next = ret.next.next;
            cur.next = ret.next;
            cur = cur.next;
            cur.next = ret;
            cur = cur.next;
            cur.next = null;
            ret = Next;
        }
        if (ret != null) cur.next = ret;
        return dummy.next;
    }
}