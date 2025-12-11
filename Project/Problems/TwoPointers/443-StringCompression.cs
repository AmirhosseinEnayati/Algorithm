public class StringCompression
{
    public int Compress(char[] chars)
    {
        int seriesStartIndex = 0, currentIndex = 0, seriesCharRepeat = 0, compressedLength = 0;

        while (currentIndex < chars.Length)
        {
            if (currentIndex == 0 || chars[currentIndex] != chars[seriesStartIndex])
            {
                //On new series

                seriesStartIndex = compressedLength;//Change series start index to the new series
                seriesCharRepeat = 1;
                chars[compressedLength] = chars[currentIndex];
                compressedLength++;
            }
            else
            {
                //On the rest of a series

                seriesCharRepeat++;

                #region Calculate the length of series repetition number
                //By recurring divisions
                //Like a561, 561 has the length 3. stores in digitsCount

                var digitsCount = 0;
                var lengthTemp = seriesCharRepeat;
                while (lengthTemp > 0)
                {
                    digitsCount++;
                    lengthTemp = lengthTemp / 10;
                }

                #endregion

                if (digitsCount == compressedLength - seriesStartIndex)//When there is transition from a9 to a10 or a99 to a100 for instance
                    compressedLength++;

                #region Replace series repetition number in input chars
                //By recurring divisions
                //Like a561 which has to be stored like:
                //'a', _, _, '1' then
                //'a', _, 6, '1' then
                //'a', 5, 6, '1' 

                lengthTemp = seriesCharRepeat;//For preventing seriesCharRepeat changes

                while (lengthTemp > 0)
                {
                    chars[seriesStartIndex + digitsCount--] = (char)('0' + lengthTemp % 10);
                    lengthTemp = lengthTemp / 10;
                } 

                #endregion
            }

            currentIndex++;
        }

        return compressedLength;
    }
}