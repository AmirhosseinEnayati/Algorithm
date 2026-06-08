namespace Project.Problems.BinaryTree;

public class KeysAndRooms
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        HashSet<int> visited = [0];
        DFS(0);

        return rooms.Count == visited.Count;

        void DFS(int room)
        {
            foreach (var keys in rooms[room])
            {
                if (visited.Contains(keys))
                    continue;

                visited.Add(keys);
                DFS(keys);
            }
        }
    }
}