namespace Project.Problems.BinaryTree;

public class LeafSimilarTrees
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var leaves1 = new List<int>();
        var leaves2 = new List<int>();

        GetLeavesDFS(root1, leaves1);
        GetLeavesDFS(root2, leaves2);

        return leaves1.SequenceEqual(leaves2);
    }

    private void GetLeavesDFS(TreeNode? node, List<int> leaves)
    {
        if (node is null) return;

        if (node.left is null && node.right is null)
        {
            leaves.Add(node.val);
        }

        GetLeavesDFS(node.left, leaves);
        GetLeavesDFS(node.right, leaves);
    }
}