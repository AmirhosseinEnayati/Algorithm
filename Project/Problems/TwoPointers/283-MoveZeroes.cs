namespace Project.Problems.TwoPointers;

public class MoveZeroes
{
    public void Solution(int[] nums)
    {
        if (nums.Length == 1)
            return;

        int l = 0, r = 1;
        while (l < r && r < nums.Length)
        {
            if (nums[l] == 0 && nums[r] != 0)//Switch only when one of them is zero and the other is non-zero.
            {
                (nums[l], nums[r]) = (nums[r], nums[l]);
                l++;
                r++;

                continue;
            }

            if (nums[l] != 0)//Remain at the current position, it may change in the next iteration.
                l++;

            r++;
        }
    }
}