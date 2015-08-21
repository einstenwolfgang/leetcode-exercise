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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null) return null;
        if (root.val == p.val && containTheNode(root, q)) return root;
        if (root.val == q.val && containTheNode(root, p)) return root;
        if (containTheNode(root.left, p) && containTheNode(root.right, q)) return root;
        if (containTheNode(root.left, q) && containTheNode(root.right, p)) return root;
        else
        {
            if (LowestCommonAncestor(root.left, p, q) == null) return LowestCommonAncestor(root.right, p, q);
            return LowestCommonAncestor(root.left, p, q);
        }
        return null;
    }



    bool containTheNode(TreeNode root, TreeNode target)
    {
        if (root == null) return false;
        if (root.val == target.val) return true;
        else
        {
            if (containTheNode(root.left, target))
                return true;
            return containTheNode(root.right, target);
        }
        return false;
    }
}