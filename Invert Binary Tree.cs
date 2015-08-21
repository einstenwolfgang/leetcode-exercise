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
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;
        if (root.left != null || root.right != null)
            invert(root);
        InvertTree(root.left); InvertTree(root.right);
        return root;
    }

    void invert(TreeNode node)
    {
        TreeNode temp = node.left;
        node.left = node.right;
        node.right = temp;
    }
}