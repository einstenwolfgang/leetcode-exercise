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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if (p != null && q != null && q.val == p.val)
        {
            if (q.left != null && q.right != null && p.left != null && p.right != null && q.left.val == p.left.val && q.right.val == p.right.val)
            {
                if (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right)) return true;
                return false;
            }
            else if (q.left != null && p.left != null && q.right == null && p.right == null && q.left.val == p.left.val)
            {
                if (IsSameTree(p.left, q.left)) return true;
                return false;
            }
            else if (q.right != null && p.right != null && q.left == null && p.left == null && q.right.val == p.right.val)
            {
                if (IsSameTree(p.right, q.right)) return true;
                return false;
            }
            else if (q.left == null && q.right == null && p.left == null && p.right == null)
                return true;
            return false;

        }
        return false;
    }
}





