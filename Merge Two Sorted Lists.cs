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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode newlist = new ListNode(0);
        ListNode head = newlist;
        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                head.next = l1; l1 = l1.next;
            }
            else
            {
                head.next = l2; l2 = l2.next;
            }
            head = head.next;

        }
        if (l1 == null) head.next = l2;
        if (l2 == null) head.next = l1;
        return newlist.next;
    }
}