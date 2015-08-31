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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        if (root == null) return new List<int>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            TreeNode tn = stack.Pop();
            res.Add(tn.val);
            if (tn.right != null)
            {
                stack.Push(tn.right);
            }
            if (tn.left != null)
            {
                stack.Push(tn.left);
            }
        }
        return res;
    }
}