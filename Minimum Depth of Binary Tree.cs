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
    public int MinDepth(TreeNode root)
    {
        if (root == null) return 0;
        int lef = MinDepth(root.left);
        int rig = MinDepth(root.right);

        if (lef == 0 && rig == 0) return 1;
        if (lef == 0) lef = int.MaxValue;
        if (rig == 0) rig = int.MaxValue;

        return Math.Min(lef, rig) + 1;
    }
}