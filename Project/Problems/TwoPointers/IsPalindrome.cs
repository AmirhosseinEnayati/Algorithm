namespace Project.Problems.TwoPointers;

public class IsPalindrome
{
    public bool Solution(string s)
    {
        var left = 0;
        var right = s.Length - 1;
        while (left <= right)
        {
            var leftCharacter = s[left];
            var rightChacter = s[right];
            if (!char.IsLetterOrDigit(leftCharacter))
            {
                left++;
                continue;
            }
            if (!char.IsLetterOrDigit(rightChacter))
            {
                right--;
                continue;
            }

            if (char.ToLower(leftCharacter) != char.ToLower(rightChacter))
                return false;

            left++;
            right--;
        }

        return true;
    }
}