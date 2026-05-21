namespace Project.Problems.BinaryTree;

public class BinaryTreeRightSideView
{
    private List<int> result = new List<int>();
    public IList<int> RightSideView(TreeNode root)
    {
        DFS(root, 0);
        return result;
    }

    private void DFS(TreeNode node, int depth)
    {
        if (node == null) return;

        if (depth == result.Count)
            result.Add(node.val);

        DFS(node.right, depth + 1);
        DFS(node.left, depth + 1);
    }
}