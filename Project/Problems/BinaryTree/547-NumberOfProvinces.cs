namespace Project.Problems.BinaryTree;

public class NumberOfProvinces
{
    public int FindCircleNum(int[][] isConnected)
    {
        var provinceCount = 0;
        var visitedNodes = new bool[isConnected.Length];

        for (var i = 0; i < isConnected.Length; ++i)
        {
            if (!visitedNodes[i])
            {
                DFS(i);
                provinceCount++;
            }
        }
        return provinceCount;


        void DFS(int node)
        {
            visitedNodes[node] = true;
            for (var i = 0; i < isConnected.Length; ++i)
            {
                if (isConnected[node][i] == 1 && !visitedNodes[i])
                    DFS(i);
            }
        }
    }
}