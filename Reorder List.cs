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
    public void ReorderList(ListNode head)
    {
        if (head == null) return;
        List<ListNode> nodes = new List<ListNode>();
        ListNode iter = head;
        while (iter != null)
        {
            nodes.Add(iter);
            iter = iter.next;
        }
        int len = nodes.Count;
        int left = 0;
        int right = len - 1;
        while (left < right)
        {
            nodes[left].next = nodes[right];
            nodes[right--].next = nodes[++left];
        }
        nodes[left].next = null;
    }
}