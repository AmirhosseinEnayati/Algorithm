using System.Text;

namespace Project.Problems.Others;

public static class MergeStringsAlternately
{
    public static string MergeAlternately(string word1, string word2)
    {
        var stringBuilder = new StringBuilder(word1.Length + word2.Length);

        for (var i = 0; i < Math.Max(word1.Length, word2.Length); i++)
        {
            if (i < word1.Length)
                stringBuilder.Append(word1[i]);

            if (i < word2.Length)
                stringBuilder.Append(word2[i]);
        }

        return stringBuilder.ToString();
    }
}