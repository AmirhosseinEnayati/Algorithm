namespace Project.Problems.Others;

public class Dota2Senate
{
    public string PredictPartyVictory(string senate)
    {
        var r_senators_position = new List<int>();
        var d_senators_position = new List<int>();

        //### Separate senators based on their parties and store their positions
        for (var index = 0; index < senate.Length; index++)
        {
            if (senate[index] == 'R')
            {
                r_senators_position.Add(index);
            }
            else
            {
                d_senators_position.Add(index);
            }
        }

        var r_index = 0;
        var d_index = 0;

        //### Each party does not have the seat is looser
        while (r_index < r_senators_position.Count && d_index < d_senators_position.Count)
        {
            var r_senator_position = r_senators_position[r_index];
            var d_senator_position = d_senators_position[d_index];
            /*
             position + senate.Length:
             - Simulate the behavior of rotating queue
             - To define next seat for the party in the next round, using adding length to current index instead of using loop
             - Only winner will be added to list
             */
            if (r_senator_position < d_senator_position)
            {
                r_senators_position.Add(r_senator_position + senate.Length);
            }
            else
            {
                d_senators_position.Add(d_senator_position + senate.Length);
            }

            r_index++;
            d_index++;
        }

        return (r_index == r_senators_position.Count) ? "Dire" : "Radiant";
    }
}