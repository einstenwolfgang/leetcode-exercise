/**
 * Definition for binary tree with next pointer.
 * struct TreeLinkNode {
 *  int val;
 *  TreeLinkNode *left, *right, *next;
 *  TreeLinkNode(int x) : val(x), left(NULL), right(NULL), next(NULL) {}
 * };
 */
class Solution {
    void connect(TreeLinkNode root) {
       if(root == null || root.left == null) {  
            return;  
        }  
        root.left.next = root.right;  
        if(root.next != null) {  
            root.right.next = root.next.left;  
        }  
          
        connect(root.left);  
        connect(root.right);  
          
        return;  
     
    }
};