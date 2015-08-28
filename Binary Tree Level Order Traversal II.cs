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
    List<IList<int>> res = new List<IList<int>>();
    void solve(int dep, TreeNode root)
    {
        if (root == null) return;
        if (res.Count > dep)
        {
            res[dep].Add(root.val);
        }
        else
        {
            List<int> a = new List<int>();
            a.Add(root.val);
            res.Add(a);
        }

        solve(dep + 1, root.left);
        solve(dep + 1, root.right);
    }

    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        solve(0, root);
        res.Reverse();
        return res;
    }
}