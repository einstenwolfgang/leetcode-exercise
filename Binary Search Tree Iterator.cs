/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class BSTIterator
{

    Stack<TreeNode> s = new Stack<TreeNode>();

    void pushLeft(TreeNode root)
    {
        if (root != null)
        {
            s.Push(root);
            TreeNode cur = root;
            while (cur.left != null)
            {
                s.Push(cur.left);
                cur = cur.left;
            }
        }
    }

    public BSTIterator(TreeNode root)
    {
        pushLeft(root);
    }

    /** @return whether we have a next smallest number */
    public bool HasNext()
    {
        return s.Count > 0;
    }

    /** @return the next smallest number */
    public int Next()
    {
        TreeNode node = s.Pop();
        pushLeft(node.right);
        return node.val;
    }
}

/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */