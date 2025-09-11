namespace Project.Problems.TwoPointers;

public class FirstTwoSum//167
{
    public int[] Solution(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];

            if (sum == target)
                return [++left, ++right];
            if (sum > target)
                right--;
            else
                left++;
        }
        return [-1, -1];
    }
}