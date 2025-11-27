using System.Text;

namespace Project.Problems.TwoPointers;

public class ReverseVowelsOfAString
{
    private readonly HashSet<char> vowelLetters = new HashSet<char>()
    {
        'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'
    };
    public string ReverseVowels(string s)
    {
        var stringBuilder = new StringBuilder(s);
        int i = 0, j = s.Length - 1;

        while (i < j)
        {
            var isVowelFromFirst = IsVowel(stringBuilder[i]);
            var isVowelFromLast = IsVowel(stringBuilder[j]);
            if (!isVowelFromFirst)
            {
                i++;
            }

            if (!isVowelFromLast)
            {
                j--;
            }

            if (!isVowelFromFirst || !isVowelFromLast)
                continue;

            (stringBuilder[j], stringBuilder[i]) = (stringBuilder[i], stringBuilder[j]);
            i++;
            j--;
        }

        return stringBuilder.ToString();
    }

    private bool IsVowel(char character)
    {
        return vowelLetters.Contains(character);
    }
}