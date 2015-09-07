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
    public int CountNodes(TreeNode root)
    {
        if (root == null) return 0;
        int l = countLeft(root.left);
        int r = countRight(root.right);

        if (l == r)
        {
            return (2 << l) - 1;
        }
        else
        {
            return CountNodes(root.left) + CountNodes(root.right) + 1;
        }
    }
    int countLeft(TreeNode root)
    {
        int count = 0;
        while (root != null)
        {
            root = root.left;
            count++;
        }
        return count;
    }

    int countRight(TreeNode root)
    {
        int count = 0;
        while (root != null)
        {
            root = root.right;
            count++;
        }
        return count;
    }
}