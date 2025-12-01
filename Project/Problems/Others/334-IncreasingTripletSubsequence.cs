namespace Project.Problems.Others;

public class IncreasingTripletSubsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
            return false;

        var first = int.MaxValue;
        var mid = int.MaxValue;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (num > mid)
                return true;
            if (first >= num)
                first = num;
            else
                mid = num;
        }

        return false;
    }
}