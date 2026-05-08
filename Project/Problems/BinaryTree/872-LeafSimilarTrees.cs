namespace Project.Problems.BinaryTree;

public class LeafSimilarTrees
{
    private int leaves2Count = 0;
    private List<int> leaves1;
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        leaves1 = new List<int>();
        CollectLeaves(root1, leaves1);

        var isSimilar = CompareWithLeaves1(root2);

        // اگر برگ‌های درخت دوم تمام شد ولی درخت اول هنوز برگ دارد → false
        return isSimilar && leaves2Count == leaves1.Count;
    }


    private void CollectLeaves(TreeNode? node, List<int> leaves)
    {
        if (node is null) return;

        if (node.left is null && node.right is null)
        {
            leaves.Add(node.val);
            return;
        }

        CollectLeaves(node.left, leaves);
        CollectLeaves(node.right, leaves);
    }

    private bool CompareWithLeaves1(TreeNode? node)
    {
        if (node is null) return true;

        if (node.left is null && node.right is null)
        {
            if (leaves2Count >= leaves1.Count)
                return false;

            if (node.val != leaves1[leaves2Count])
                return false;

            leaves2Count++;
            return true;
        }

        return CompareWithLeaves1(node.left) && CompareWithLeaves1(node.right);
    }
}