using Project.Problems.HashMapAndDifference;
using Project.Problems.SlidingWindow;
using Project.Problems.TwoPointers;

Console.WriteLine("---- Start -----");

//TwoPointers();
//SlidingWindow();
HashMapAndDifference();

Console.WriteLine("---- End -----");





static void TwoPointers()
{
    #region TwoSum
    int[] input = [2, 7, 11, 15];
    var target = 9;
    var TwoSum_Output = new FirstTwoSum().Solution(input, target);
    Console.WriteLine($"Two sum indexes: {TwoSum_Output[0]}, {TwoSum_Output[1]}");
    #endregion TwoSum

    #region IsPalindrome
    var IsPalindrome_Output = new Palindrome().IsPalindrome("A man, a plan, a canal: Panama");
    Console.WriteLine($"IsPalindrome: {IsPalindrome_Output}");
    #endregion

    #region MergeSortedArray
    int[] nums1 = [1, 2, 3, 0, 0, 0], nums2 = [2, 5, 6];
    int m = 3, n = 3;
    new MergeSortedArray().Merge(nums1, m, nums2, n);
    Console.WriteLine($"Merge output: {string.Join(", ", nums1)}");
    #endregion
}

static void SlidingWindow()
{
    #region MaxAveSubArray
    int[] nums = [0,1,1,3,3];
    var k = 4;
    var maxAve = new MaxAveSubArray().Solution(nums, k);
    Console.WriteLine($"MaxAve: {maxAve:F5}");
    #endregion MaxAveSubArray
}

static void HashMapAndDifference()
{
    #region TwoSum
    var TwoSum_Output = new TwoSum().Solution([-3,4,3,90], 0);
    Console.WriteLine($"TwoSum: {string.Join(", ", TwoSum_Output)}");
    #endregion TwoSum

    #region SubArraySumEqualsK
    var SubArraySumEqualsK_Output = new SubArraySumEqualsK().Solution([-1, -1, -3, 1, 1, 3, 5], 5);
    Console.WriteLine($"SubArraySumEqualsK_Output: {SubArraySumEqualsK_Output}");
    #endregion
}