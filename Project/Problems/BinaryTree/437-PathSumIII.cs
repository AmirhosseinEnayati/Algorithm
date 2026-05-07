namespace Project.Problems.BinaryTree;

public class PathSumIII
{
    Dictionary<long,int> seenPrefixSums = new Dictionary<long, int>() { { 0, 1 } };
    public int Solution(TreeNode root, int targetSum)
    {
        var output = 0; 

        DFS(root, 0);

        return output;

        void DFS(TreeNode node, long prefixSum)
        {
            if (node == null)
                return;

            prefixSum += node.val;
            output += GetPreviousPrefixSum(targetSum, prefixSum);
            seenPrefixSums[prefixSum] = seenPrefixSums.GetValueOrDefault(prefixSum, 0) + 1;

            DFS(node.left, prefixSum);
            DFS(node.right, prefixSum);

            seenPrefixSums[prefixSum]--;
        }
    }

    private int GetPreviousPrefixSum(int targetSum, long prefixSum) => seenPrefixSums.GetValueOrDefault(prefixSum - targetSum, 0);
}