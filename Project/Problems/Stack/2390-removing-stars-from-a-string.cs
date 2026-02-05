using System.Text;

namespace Project.Problems.Stack;

public class Removing_stars_from_a_string
{
    public string RemoveStars(string s)
    {
        /*var stack = new Stack<char>();

        foreach (var letter in s)
        {
            if (letter == '*')
            {
                stack.Pop();
            }
            else
            {
                stack.Push(letter);
            }
        }


        var array = stack.ToArray();
        Array.Reverse(array);

        return new string(array);*/


        var stringBuilder = new StringBuilder(s.Length);

        foreach (var letter in s)
        {
            if (letter == '*')
            {
                stringBuilder.Length--;
            }
            else
            {
                stringBuilder.Append(letter);
            }
        }

        return stringBuilder.ToString();
    }
}