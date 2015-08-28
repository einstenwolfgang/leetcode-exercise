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
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        int depthOfLeft = getDepth(root.left, 1);
        int depthOfRight = getDepth(root.right, 1);

        if (Math.Abs(depthOfRight - depthOfLeft) > 1)
        {
            return false;
        }
        else
        {
            return IsBalanced(root.left) && IsBalanced(root.right);
        }
    }

    private int getDepth(TreeNode tree, int currentDepth)
    {
        if (tree == null)
        {
            return currentDepth;
        }
        return Math.Max(getDepth(tree.left, currentDepth + 1),
                getDepth(tree.right, currentDepth + 1));
    }
}