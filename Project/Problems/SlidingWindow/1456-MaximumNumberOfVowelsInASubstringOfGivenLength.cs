namespace Project.Problems.SlidingWindow;

public class MaximumNumberOfVowelsInASubstringOfGivenLength
{
    public int MaxVowels(string s, int k)
    {
        int maxVowelCount = 0;
        int windowVowelCount = 0;
        int i = 0;

        while (i < k)
        {
            if (IsVowel(s[i++]))
                windowVowelCount++;

        }

        maxVowelCount = windowVowelCount;

        while (i < s.Length)
        {
            if (IsVowel(s[i]))
                windowVowelCount++;
            if (IsVowel(s[i - k]))
                windowVowelCount--;
            if (windowVowelCount > maxVowelCount)
                maxVowelCount = windowVowelCount;

            i++;
        }

        return maxVowelCount;
    }

    public bool IsVowel(char c)
    {
        switch (c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }
}