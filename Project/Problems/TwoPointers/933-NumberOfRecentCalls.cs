namespace Project.Problems.TwoPointers;

public class RecentCounter
{
    int[] recentRequests;
    int start = 0, stop = 0;
    public RecentCounter()
    {
        recentRequests = new int[10000];
    }

    public int Ping(int time)
    {
        var fromTime = time - 3000;
        while (start <= stop)
        {
            var recentRequest = recentRequests[start];
            if (recentRequest >= fromTime || recentRequest == 0)
            {
                /*recentRequest >= fromTime:
                 it's in our frame 


                 recentRequest == 0 is for following situation:      
                 649, 1849, 4921
                 for 4921 we have:
                 649, 1849, 0, ..., 0
                 */
                break;
            }
            start++;//when recentRequest is greater than time-3000, it has to be excluded (recentRequest < fromTime)
        }

        recentRequests[stop++] = time;//change stop when adding new item

        return stop - start;
    }
}