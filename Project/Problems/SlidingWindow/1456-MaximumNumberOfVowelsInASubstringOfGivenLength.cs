namespace Project.Problems.SlidingWindow;

public class MaximumNumberOfVowelsInASubstringOfGivenLength
{
    public int MaxVowels(string s, int k)
    {
        int maxVowelCount = 0, windowVowelCount=0, index=0;

        while (index < s.Length)
        {
            if (index < k)
            {
                if(IsVowel(s[index]))
                {
                    windowVowelCount++;
                    maxVowelCount = windowVowelCount;
                }
            }
            else
            {
                if (IsVowel(s[index]))
                    windowVowelCount++;
                if (IsVowel(s[index - k]))
                    windowVowelCount--;
                if (windowVowelCount > maxVowelCount)
                    maxVowelCount = windowVowelCount;
            }

            index++;
        }

        return maxVowelCount;
    }

    public bool IsVowel(char letter) => letter switch
    {
        'a' or 'e' or 'i' or 'o' or 'u' => true,
        _ => false,
    };
}