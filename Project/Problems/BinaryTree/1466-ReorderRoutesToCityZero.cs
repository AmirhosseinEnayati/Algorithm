namespace Project.Problems.BinaryTree;

public static class ReorderRoutesToCityZero
{
    public static int MinReorder(int n, int[][] connections)
    {
        var count = 0;
        var graph = CreateGraph(n, connections);
        Dfs(0, -1);
        return count;


        void Dfs(int node, int parent)
        {
            foreach (var edge in graph[node])
            {
                if (edge.OtherSideNode != parent)
                {
                    count += edge.Sign;
                    Dfs(edge.OtherSideNode, node);
                }
            }
        }
    }

    private static List<Edge>[] CreateGraph(int n, int[][] connections)
    {
        var graph = new List<Edge>[n];
        for (int i = 0; i < n; i++)//initialize graph
        {
            graph[i] = [];
        }
        foreach (var connection in connections)//set graph values
        {
            int from = connection[0];
            int to = connection[1];

            graph[from].Add(new Edge(to, 1));
            graph[to].Add(new Edge(from, 0));
        }

        return graph;
    }
    record Edge(int OtherSideNode, int Sign);
}