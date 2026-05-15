namespace Project.Problems.BinaryTree;

/*
 * Each movement depends on the previous one..
 * we change direction whenever the condition is violated.
 */
public class LongestZigZagPathInABinaryTree
{
    private int maxLength = 0;

    public int LongestZigZag(TreeNode root)
    {
        DFS(root, true, 0);
        DFS(root, false, 0);

        return maxLength;
    }

    private void DFS(TreeNode node, bool wentLeft, int length)
    {
        if (node == null)
            return;

        maxLength = Math.Max(maxLength, length);

        if (wentLeft)
        {
            DFS(node.right, false, length + 1);
            DFS(node.left, true, 1);
        }
        else
        {
            DFS(node.left, true, length + 1);
            DFS(node.right, false, 1);
        }
    }
}