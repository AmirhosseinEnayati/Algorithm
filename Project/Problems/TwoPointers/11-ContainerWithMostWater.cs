namespace Project.Problems.TwoPointers;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var maxArea = 0;
        var leftPointer = 0;
        var rightPointer = height.Length - 1;

        while (leftPointer < rightPointer)
        {
            var leftBarHeight = height[leftPointer];
            var rightBarHeight = height[rightPointer];

            var currentArea = (rightPointer - leftPointer) * (leftBarHeight < rightBarHeight ? leftBarHeight : rightBarHeight);

            if (currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            if (leftBarHeight > rightBarHeight)
            {
                rightPointer--;
            }
            else
            {
                leftPointer++;
            }
        }

        return maxArea;
    }
}