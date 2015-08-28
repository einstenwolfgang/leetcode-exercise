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
    public bool HasPathSum(TreeNode root, int sum)
    {
        if (root == null) return false;
        int count = root.val;
        if (root.left == null && root.right == null && count == sum) return true;
        else return (find(count, root.left, sum) || find(count, root.right, sum));
    }

    bool find(int count, TreeNode root, int sum)
    {
        if (root == null) return false;
        count += root.val;
        if (root.left == null && root.right == null && count == sum) return true;
        else return find(count, root.left, sum) || find(count, root.right, sum);
    }
}