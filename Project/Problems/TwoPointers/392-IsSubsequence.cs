namespace Project.Problems.TwoPointers;

public class IsSubsequence
{
    public bool Solution(string s, string t)
    {
        if (s.Length == 0)
            return true;

        if (t.Length == 0)
            return false;

        int i = 0, j = 0;

        while (j < t.Length)
        {
            if (t[j] == s[i])
            {
                i++;
            }

            if (i == s.Length)
            {
                return true;
            }

            j++;
        }

        return false;
    }
}