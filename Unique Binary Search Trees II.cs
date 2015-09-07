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
    public IList<TreeNode> GenerateTrees(int n)
    {
        return creatTree(1, n);
    }

    List<TreeNode> creatTree(int start, int end)
    {
        List<TreeNode> result = new List<TreeNode>();
        if (start > end)
        {
            result.Add(null);
            return result;
        }
        for (int k = start; k <= end; k++)
        {
            List<TreeNode> left = creatTree(start, k - 1);
            List<TreeNode> right = creatTree(k + 1, end);
            for (int i = 0; i < left.Count; i++)
            {
                for (int j = 0; j < right.Count; j++)
                {
                    TreeNode root = new TreeNode(k);
                    root.left = left[i];
                    root.right = right[j];
                    result.Add(root);
                }
            }
        }
        return result;
    }
}