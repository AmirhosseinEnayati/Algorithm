using Project.Problems.TwoPointers;

Console.WriteLine("---- Start -----");

TwoPointers();

Console.WriteLine("---- End -----");





static void TwoPointers()
{
    #region TwoSum
    int[] input = [2, 7, 11, 15];
    var target = 9;
    var TwoSum_Output = new TwoSum().Solution(input, target);
    Console.WriteLine($"Two sum indexes: {TwoSum_Output[0]}, {TwoSum_Output[1]}");
    #endregion TwoSum

    #region IsPalindrome
    var IsPalindrome_Output = new Palindrome().IsPalindrome("A man, a plan, a canal: Panama");
    Console.WriteLine($"IsPalindrome: {IsPalindrome_Output}");
    #endregion
}