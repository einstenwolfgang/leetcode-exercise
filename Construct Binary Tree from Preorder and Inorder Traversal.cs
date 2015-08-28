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
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder.Length < 1 || inorder.Length < 1) return null;
        TreeNode root = new TreeNode(preorder[0]);

        int i = 0;
        for (i = 0; i < preorder.Length; i++)
        {
            if (root.val == inorder[i])
                break;
        }

        int[] preleft, inleft, preright, inright;
        if (i < inorder.Length)
        {
            preleft = new int[i];
            Array.Copy(preorder, 1, preleft, 0, i);
            inleft = new int[i];
            Array.Copy(inorder, 0, inleft, 0, i);
            root.left = BuildTree(preleft, inleft);

            preright = new int[preorder.Length - i - 1];
            Array.Copy(preorder, i + 1, preright, 0, preorder.Length - i - 1);
            inright = new int[preorder.Length - i - 1];
            Array.Copy(inorder, i + 1, inright, 0, preorder.Length - i - 1);
            root.right = BuildTree(preright, inright);
        }
        return root;
    }
}