namespace Project.Problems.HashMapAndDifference;

/// <summary>
/// Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
/// A subarray is a contiguous non-empty sequence of elements within an array.

/// Example 1:
/// Input: nums = [1,1,1], k = 2
/// Output: 2
/// Example 2:

/// Input: nums = [1,2,3], k = 3
/// Output: 2
/// </summary>
public class SubArraySumEqualsK//560
{
    public int Solution(int[] nums, int k)
    {
        var output = 0;
        var seenPrefixSums = new Dictionary<int, int>() { { 0, 1 } };
        var prefixSum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];
            output += seenPrefixSums.GetValueOrDefault(prefixSum - k, 0);
            seenPrefixSums[prefixSum] = seenPrefixSums.GetValueOrDefault(prefixSum, 0) + 1;
        }
        return output;
    }
}