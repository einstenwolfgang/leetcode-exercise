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
    public IList<int> RightSideView(TreeNode root)
    {
        List<int> res = new List<int>();
        if (root == null) return res;
        Queue<TreeNode> qu = new Queue<TreeNode>();
        qu.Enqueue(root);
        while (qu.Count > 0)
        {
            int n = qu.Count;
            for (int i = 0; i < n; i++)
            {
                TreeNode temp = qu.Dequeue();
                if (i == 0) res.Add(temp.val);
                if (temp.right != null) qu.Enqueue(temp.right);
                if (temp.left != null) qu.Enqueue(temp.left);
            }
        }
        return res;
    }
}