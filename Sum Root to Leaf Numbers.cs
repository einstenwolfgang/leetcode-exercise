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
    int sum = 0;
    public int SumNumbers(TreeNode root)
    {
        if (root == null) return 0;
        dfs(root, root.val);
        return sum;
    }
    void dfs(TreeNode root, int num)
    {
        if (root.left == null && root.right == null) sum += num;
        if (root.left != null) dfs(root.left, num * 10 + root.left.val);
        if (root.right != null) dfs(root.right, num * 10 + root.right.val);
    }
}