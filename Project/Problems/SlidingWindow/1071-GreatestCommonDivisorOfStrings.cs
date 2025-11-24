namespace Project.Problems.SlidingWindow;

public static class GreatestCommonDivisorOfStrings
{
    public static string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)//Equal: When both strings have been created on a basic string.
        {
            return "";
        }

        var gcd = FindGreatestCommonDivisor(str1.Length, str2.Length);//Based on Math (Find Greatest Common Divisor
        return str1[..gcd];
    }

    private static int FindGreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            var temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }
}