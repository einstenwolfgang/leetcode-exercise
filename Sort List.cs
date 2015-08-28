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
    ListNode getMiddle(ListNode root)
    {
        ListNode slow = root;
        ListNode fast = root;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    ListNode mergeList(ListNode a, ListNode b)
    {
        ListNode dummy = new ListNode(-1);
        ListNode cur = dummy;
        while (a != null && b != null)
        {
            if (a.val <= b.val)
            {
                cur.next = a;
                a = a.next;
            }
            else
            {
                cur.next = b;
                b = b.next;
            }
            cur = cur.next;
        }
        cur.next = a != null ? a : b;
        return dummy.next;
    }

    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null) return head;
        ListNode middle = getMiddle(head);
        ListNode next = middle.next;
        middle.next = null;
        return mergeList(SortList(head), SortList(next));
    }

}