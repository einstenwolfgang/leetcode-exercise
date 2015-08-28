/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        if(postorder.Length < 1 || inorder.Length < 1)return null;
        TreeNode root = new TreeNode(postorder[postorder.Length - 1]);
        
        int i = 0;
        for(i = 0;i < postorder.Length;i ++){
            if(root.val == inorder[i])
            break;
        }
        
        int[] preleft,inleft,preright,inright;
        if(i < inorder.Length){
            preleft = new int[i];
            Array.Copy(postorder,0,preleft,0,i);
            inleft = new int[i];
            Array.Copy(inorder,0,inleft,0,i);
            root.left = BuildTree(inleft,preleft);
            
            preright = new int[postorder.Length - i - 1];
            Array.Copy(postorder,i,preright,0,postorder.Length - i - 1);
            inright = new int[postorder.Length - i - 1];
            Array.Copy(inorder,i + 1,inright,0,postorder.Length - i - 1);
            root.right = BuildTree(inright,preright);
        }
        return root;
    }
}