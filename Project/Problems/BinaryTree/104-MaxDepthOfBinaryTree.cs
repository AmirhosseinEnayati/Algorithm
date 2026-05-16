namespace Project.Problems.BinaryTree;

public class MaxDepthOfBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null) { return 0; }
        var left = MaxDepth(root.left);
        var right = MaxDepth(root.right);
        return (left > right ? left : right) + 1;
    }
}