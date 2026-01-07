namespace Project.Problems.HashMapAndDifference;

public class FindTheDifferenceOfTwoArrays
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var dictionary = new Dictionary<int, int>();
        //value = 1 => just in num1
        //value = 2 => just in num2
        //value = 3 => common

        foreach (var num1 in nums1)
        {
            dictionary.TryAdd(num1, 1);
        }

        foreach (var num2 in nums2)
        {
            if (dictionary.TryGetValue(num2, out int value) && value == 1)
            {
                dictionary[num2] = 3;
            }
            else
            {
                dictionary.TryAdd(num2, 2);
            }
        }

        IList<int> listNums1 = [];
        IList<int> listNums2 = [];

        foreach (var item in dictionary)
        {
            if (item.Value == 1)
            {
                listNums1.Add(item.Key);
            }
            else if (item.Value == 2)
            {
                listNums2.Add(item.Key);
            }
        }

        return [listNums1, listNums2];
    }
}