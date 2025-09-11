namespace Project.Problems.Backtracking;

internal class PalindromePartitioning//131
{
    public List<List<string>> Solution(string s)
    {
        var output = new List<List<string>>();

        foreach (var child in BuildChildren(s))
        {
            var palindromeSubstrings = GetPalindromeSubstrings(child, s.Substring(child.Length, s.Length - child.Length));
            if (palindromeSubstrings.Any())
                output.Add(palindromeSubstrings);
        }

        return output;
    }

    private List<string> GetPalindromeSubstrings(string parent, string remnant)
    {
        var output = new List<string>();

        if (!new TwoPointers.IsPalindrome().Solution(parent))
            return output;

        output.Add(parent);

        foreach (var child in BuildChildren(remnant))
        {
            var palindromeSubstrings = GetPalindromeSubstrings(child, remnant.Substring(child.Length, remnant.Length - child.Length));
            output.AddRange(palindromeSubstrings);
        }

        return output;

    }

    private List<string> BuildChildren(string s)
    {
        var result = new List<string>();
        int index = 0;
        while (++index <= s.Length)
        {
            result.Add(s.Substring(0, index));
        }

        return result;
    }
}