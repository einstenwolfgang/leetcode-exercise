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
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;
        int count1 = 1, count2 = 1;
        ListNode index1 = headA; ListNode index2 = headB;
        while (index1.next != null)
        {
            count1++;
            index1 = index1.next;
        }
        while (index2.next != null)
        {
            count2++;
            index2 = index2.next;
        }
        if (index2 != index1) return null;
        if (count1 < count2)
        {
            index1 = headB;
            index2 = headA;
        }
        else
        {
            index1 = headA;
            index2 = headB;
        }
        int depth = Math.Abs(count1 - count2);
        while ((depth--) > 0)
        {
            index1 = index1.next;
        }
        while (index1 != index2)
        {
            index1 = index1.next;
            index2 = index2.next;
        }
        return index1;
    }
}