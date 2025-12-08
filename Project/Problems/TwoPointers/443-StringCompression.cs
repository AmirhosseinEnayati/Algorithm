public class StringCompression
{
    public int Compress(char[] chars)
    {
        int seriesStartIndex = 0, currentIndex = 0, seriesLength = 0, compressedLength = 0;

        while (currentIndex < chars.Length)
        {
            if (currentIndex == 0 || chars[currentIndex] != chars[seriesStartIndex])
            {
                //On new series

                seriesStartIndex = compressedLength;
                seriesLength = 1;
                chars[compressedLength] = chars[currentIndex];
                compressedLength++;
            }
            else
            {
                //the rest of a series

                seriesLength++;
                var seriesLengthSize = 0;
                int lengthTemp = seriesLength;
                while (lengthTemp > 0)
                {
                    seriesLengthSize++;
                    lengthTemp = lengthTemp / 10;
                }

                lengthTemp = seriesLength;

                if (seriesLengthSize == compressedLength - seriesStartIndex)
                    compressedLength++;

                while (lengthTemp > 0)
                {
                    chars[seriesStartIndex + seriesLengthSize--] = (char)('0' + lengthTemp % 10);
                    lengthTemp = lengthTemp / 10;
                }


            }

            currentIndex++;
        }

        return compressedLength;
    }
}