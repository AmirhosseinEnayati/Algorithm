namespace Project.Problems.Others;

public class UniqueNumberOfOccurrences
{
    public bool UniqueOccurrences(int[] arr)
    {
        var numbersFrequncy = new Dictionary<int, int>();
        var seenNumbersFrequency = new HashSet<int>();

        foreach (var number in arr)
        {
            if(numbersFrequncy.ContainsKey(number))
            {
                numbersFrequncy[number]++;
            }
            else
            {
                numbersFrequncy.Add(number, 1);
            }
        }

        foreach (var frequency in numbersFrequncy.Values)
        {
            if (seenNumbersFrequency.Contains(frequency))
                return false;
            seenNumbersFrequency.Add(frequency);
        }

        return true;
    }
}