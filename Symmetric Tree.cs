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
    bool mirror(TreeNode left, TreeNode right)
    {
        if (left == null && right == null) return true;
        if ((left == null && right != null) || (left != null && right == null) || (left.val != right.val)) return false;
        else return mirror(left.right, right.left) && mirror(left.left, right.right);
    }

    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        else return mirror(root.left, root.right);
    }
}