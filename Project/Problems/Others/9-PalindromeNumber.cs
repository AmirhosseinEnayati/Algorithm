namespace Project.Problems.Others;

internal class PalindromeNumber//9
{
    public bool Solution(int x)
    {
        if(x < 0) return false;

        int divisionResult = x;
        int reversedX = 0;
        while (divisionResult > 0)
        {
            var remnant = divisionResult % 10;
            divisionResult = divisionResult / 10;
            reversedX = reversedX * 10 + remnant;
        }
        return reversedX == x;
    }
}