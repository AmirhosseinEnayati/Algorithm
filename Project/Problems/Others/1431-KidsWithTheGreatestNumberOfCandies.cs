namespace Project.Problems.Others;

public static class KidsWithTheGreatestNumberOfCandies
{
    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var result = new bool[candies.Length];

        var max = 0;
        for (var i = 0; i < candies.Length; i++)
        {
            if (candies[i] > max)
            {
                max = candies[i];
            }
        }
        for (var i = 0; i < candies.Length; i++)
        {
            result[i] = candies[i] + extraCandies >= max;
        }

        return result;
    }
}