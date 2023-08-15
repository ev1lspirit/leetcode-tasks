class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        result = []
        def traverse(root):
            if root is None:
                return 
            traverse(root.left);
            result.append(root.val)
            traverse(root.right)
        traverse(root)
        return result