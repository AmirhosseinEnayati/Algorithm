namespace Project.Problems.TwoPointers;

public class MaxNumberOfKSumPairs
{
    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);

        int left = 0, right = nums.Length - 1, count = 0;

        while (left < right)
        {
            var sum = nums[left] + nums[right];

            if (sum == k)
            {
                count++;
                left++;
                right--;
            }
            else if (sum < k)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return count;
    }
}