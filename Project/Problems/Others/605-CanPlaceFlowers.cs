namespace Project.Problems.Others;

public static class CanPlaceFlowers
{
    public static bool CanPlace(int[] flowerbed, int n)
    {
        for (int i = 0; i < flowerbed.Length && n > 0; i++)
        {
            if (flowerbed[i] == 0)
            {
                var emptyLeft = i == 0 || flowerbed[i - 1] == 0;
                var emptyRight = i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;

                if (emptyLeft && emptyRight)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }

        }

        return n == 0;
    }
}