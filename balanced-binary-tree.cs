/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsBalanced(TreeNode root) {
        int DFS(TreeNode node)
        {
            if (node == null) return 0;
            return 1 + Math.Max(DFS(node.left), DFS(node.right));
        }
        
        if (root == null) return true;
        int leftDepth = DFS(root.left);
        int rightDepth = DFS(root.right);
        
        return Math.Abs(leftDepth - rightDepth) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
}