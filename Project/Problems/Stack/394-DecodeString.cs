using System.Text;

namespace Project.Problems.Stack;

public class DecodeString2
{
    public string Solution(string s)
    {
        int i = 0;
        StringBuilder str = new();

        while (i < s.Length && s[i] != ']')
        {
            if (!char.IsDigit(s[i]))
            {
                str.Append(s[i]);
            }
            else
            {
                int num = 0;

                while (i < s.Length && char.IsDigit(s[i]))
                {
                    num = num * 10 + s[i] - '0';
                    i++;
                }
                i++;

                var st = Solution(s);

                while (num > 0)
                {
                    num--;
                    str.Append(st);
                }
            }
            i++;
        }

        return str.ToString();
    }
}