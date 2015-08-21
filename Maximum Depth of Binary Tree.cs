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
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        int max = 1;
        return dfs(root, max);
    }
    public int dfs(TreeNode node, int max)
    {
        if (node.left == null && node.right == null) return max;
        if (node.left != null && node.right == null) return dfs(node.left, ++max);
        if (node.left == null && node.right != null) return dfs(node.right, ++max);
        return Math.Max(dfs(node.left, max + 1), dfs(node.right, max + 1));
    }
}