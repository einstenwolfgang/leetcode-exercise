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
    public bool IsPalindrome(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        Stack<int> stack = new Stack<int>();
        while (fast != null && fast.next != null)
        {
            stack.Push(slow.val);
            slow = slow.next;
            fast = fast.next.next;
        }
        if (fast != null) slow = slow.next;
        while (slow != null)
        {
            if (slow.val != stack.Pop()) return false;
            slow = slow.next;
        }
        return true;
    }
}