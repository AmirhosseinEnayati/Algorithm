namespace Project.Problems.Others;

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];

        //Process the left to right 👉
        int initial = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = initial;
            initial *= nums[i];
        }

        //Process the right to left 👈
        initial = 1;
        for (int j = nums.Length - 1; j >= 0; j--)
        {
            result[j] = result[j] * initial;
            initial *= nums[j];
        }

        return result;
    }
}