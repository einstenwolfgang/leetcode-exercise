/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{

    Stack<TreeNode> s = new Stack<TreeNode>();

    void pushLeft(TreeNode root)
    {
        if (root != null)
        {
            s.Push(root);
            TreeNode cur = root.left;
            while (cur != null)
            {
                s.Push(cur);
                cur = cur.left;
            }
        }
    }
    public int KthSmallest(TreeNode root, int k)
    {
        pushLeft(root);
        for (int i = 0; i < k - 1; i++)
        {
            TreeNode node = s.Pop();
            pushLeft(node.right);
        }
        return s.Peek().val;
    }
}