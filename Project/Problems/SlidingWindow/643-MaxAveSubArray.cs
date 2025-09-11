namespace Project.Problems.SlidingWindow;

public class MaxAveSubArray //643
{
    public double Solution(int[] nums, int k)
    {
        var winSum = nums[..k].Sum();
        var maxWinSum = winSum;
        for (var right = k; right < nums.Length; right++)
        {
            winSum += nums[right] - nums[right - k];
            if (winSum > maxWinSum)
                maxWinSum = winSum;
        }

        return (double)maxWinSum / k;
    }
}