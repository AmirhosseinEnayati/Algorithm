namespace Project.Problems.SlidingWindow;

public class MaxAveSubArray //643
{
    public double Solution(int[] nums, int k)
    {
        int windowSum = 0;
        int i = 0;

        for (; i < k; i++)
        {
            windowSum += nums[i];
        }

        int max = windowSum;

        for (; i < nums.Length; i++)
        {
            windowSum += nums[i];
            windowSum -= nums[i - k];
            if (windowSum > max)
                max = windowSum;
        }

        return (double)max / k;
    }
}