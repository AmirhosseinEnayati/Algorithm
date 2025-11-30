using System.Text;

namespace Project.Problems.Others;

public static class ReverseWordsInAString
{
    public static string ReverseWords(string s)
    {
        var letterStack = new Stack<string>();
        var word = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            var letter = s[i];
            if (letter == ' ')//Is it a new word?
            {
                if (word.Length == 0)
                    continue;
                letterStack.Push(word.ToString());
                word.Clear();
            }
            else
            {
                word.Append(letter);

                if (i == s.Length - 1)
                {
                    letterStack.Push(word.ToString());
                    word.Clear();
                }
            }
        }

        while (true)
        {
            word.Append(letterStack.Pop());
            if (letterStack.Count > 0)
            {
                word.Append(" ");
            }
            else
                break;
        }
        return word.ToString();
    }
}