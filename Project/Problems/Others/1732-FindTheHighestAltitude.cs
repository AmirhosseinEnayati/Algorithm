namespace Project.Problems.Others;

public class FindTheHighestAltitude
{
    public int LargestAltitude(int[] gain)
    {
        int maxAltitude = 0, altitude = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            altitude += gain[i];
            if (altitude > maxAltitude)
                maxAltitude = altitude;
        }
        return maxAltitude;
    }
}