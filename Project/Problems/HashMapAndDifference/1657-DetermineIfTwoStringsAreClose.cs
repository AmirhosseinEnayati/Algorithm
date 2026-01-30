namespace Project.Problems.HashMapAndDifference;

public class DetermineIfTwoStringsAreClose
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;

        var word1Occurance = new Dictionary<char, int>();
        var word2Occurance = new Dictionary<char, int>();

        for (int i = 0; i < word1.Length; i++)
        {
            var character1 = word1[i];
            var character2 = word2[i];
            word1Occurance[character1] = word1Occurance.GetValueOrDefault(character1) + 1;
            word2Occurance[character2] = word2Occurance.GetValueOrDefault(character2) + 1;
        }

        foreach (var item1 in word1Occurance)
        {
            bool keyExist = false, valueExist = false;
            foreach (var item2 in word2Occurance)
            {
                if (item2.Key == item1.Key)
                {
                    keyExist = true;
                }

                if (!valueExist&&item2.Value == item1.Value)
                {
                    word1Occurance[item1.Key] = 0;
                    word2Occurance[item2.Key] = 0;
                    valueExist = true;
                }
            }

            if (!keyExist || !valueExist)
                return false;
        }

        return true;
    }
}