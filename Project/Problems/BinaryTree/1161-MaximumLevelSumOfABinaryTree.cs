namespace Project.Problems.BinaryTree;

public class MaximumLevelSumOfABinaryTree
{
    private List<int> result = new List<int>();
    public int MaxLevelSum(TreeNode root)
    {
        DFS(root, 0);

        int maxSum = int.MinValue, maxLevel = 0;//maxSum inital value should not be zero because all of the nodes' value can be negative.
        for (int i = 0; i < result.Count; i++)
        {
            if (result[i] > maxSum)
            {
                maxSum = result[i];
                maxLevel = i;
            }
        }

        return maxLevel + 1;
    }

    private void DFS(TreeNode node, int level)
    {
        if (node is null)
            return;

        if (level == result.Count)
            result.Add(node.val);
        else
            result[level] += node.val;

        DFS(node.left, level + 1);
        DFS(node.right, level + 1);
    }
}