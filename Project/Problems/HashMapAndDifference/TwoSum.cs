namespace Project.Problems.HashMapAndDifference;

/// <summary>

/// Description:
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
 
/// Examples:
/// Example 1:
/// Input: nums = [2, 7, 11, 15], target = 9
/// Output: [0, 1]
/// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
/// 
/// Example 2:
/// Input: nums = [3, 2, 4], target = 6
/// Output: [1, 2]
/// 
/// Example 3:
/// Input: nums = [3, 3], target = 6
/// Output: [0, 1]

/// Solution:
/// Calculate difference between the current item and the target in each iteration and search the difference in already seen items

/// </summary>
public class TwoSum//1
{
    public int[] Solution(int[] numbers, int target)
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