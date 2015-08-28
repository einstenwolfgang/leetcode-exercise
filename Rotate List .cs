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
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null) return null;
        ListNode p = head;
        int n = 0;
        while (p.next != null)
        {
            p = p.next;
            n++;
        }
        n++;
        k = k % n;
        p.next = head;
        ListNode q = head;
        for (int i = 0; i < n - k - 1; i++)
            q = q.next;
        head = q.next;
        q.next = null;
        return head;
    }
}