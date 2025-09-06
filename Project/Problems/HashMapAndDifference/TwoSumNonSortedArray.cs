namespace Project.Problems.HashMapAndDifference;

/// <summary>
/// Calculate difference between the current item and the target in each iteration and search the difference in already seen items
/// </summary>
public class TwoSumNonSortedArray//1
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var seenItems = new Dictionary<int, int>();

        for (var index = 0; index < numbers.Length; index++)
        {
            var item = numbers[index];
            var difference = target - item;
            if (seenItems.TryGetValue(difference, out int seenIndex))
                return [seenIndex, index];

            seenItems[item] = index;
        }

        return [-1, -1];
    }
}