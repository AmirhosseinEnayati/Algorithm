namespace Project.Problems.BinaryTree;

public class DeleteNodeinABFT
{
    public class Solution
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
                return null;

            if (key < root.val)
            {
                root.left = DeleteNode(root.left, key);
            }
            else if (key > root.val)
            {
                root.right = DeleteNode(root.right, key);
            }
            else
            {
                // Case 1 & 2
                if (root.left == null)
                    return root.right;

                if (root.right == null)
                    return root.left;

                // Case 3: دو فرزند
                TreeNode successor = FindMin(root.right);
                root.val = successor.val;
                root.right = DeleteNode(root.right, successor.val);
            }

            return root;
        }

        private TreeNode FindMin(TreeNode node)
        {
            while (node.left != null)
                node = node.left;

            return node;
        }
    }
}