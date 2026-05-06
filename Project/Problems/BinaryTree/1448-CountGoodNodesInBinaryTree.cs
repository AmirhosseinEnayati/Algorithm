namespace Project.Problems.BinaryTree;

public class CountGoodNodesInBinaryTree
{
    int max = 0, goodNodesCount = 0;
    public int GoodNodes(TreeNode root)
    {
        if (root.val >= max)
        {
            max = root.val;
            goodNodesCount++;
        }
        if (root.left is not null)
        {
            GoodNodes(root.left);
        }
        if (root.right is not null)
        {
            GoodNodes(root.right);
        }

        return goodNodesCount;
    }
}