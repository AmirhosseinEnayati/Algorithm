namespace Project.Problems.SlidingWindow;

public class LongestSubarrayOfOnesAfterDeletingOneElement
{
    public int LongestSubarray(int[] nums)
    {
        int left = 0, right = 0, maxSize = 0, firstZeroIndex = -1;
        while (right < nums.Length)
        {
            if (nums[right] == 0)
            {
                if (firstZeroIndex != -1)
                    left = firstZeroIndex + 1;

                firstZeroIndex = right;
            }

            var winSize = right - left + 1;
            if (winSize > maxSize)
                maxSize = winSize;

            right++;
        }

        return maxSize - 1;//-1: for removing one single element
    }
}