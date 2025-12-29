namespace Project.Problems.SlidingWindow;

public class MaxConsecutiveOnes
{
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0, right = 0, max = 0, zeroCount = 0;

        while (right < nums.Length)
        {
            if (nums[right] == 0) zeroCount++;
            while (zeroCount > k)
            {
                if (nums[left] == 0) zeroCount--;
                left++;
            }
            var winSize = right - left + 1;
            if (winSize > max)
                max = winSize;

            right++;
        }

        return max;
    }
}