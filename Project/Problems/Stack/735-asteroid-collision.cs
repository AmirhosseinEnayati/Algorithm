namespace Project.Problems.Stack;

public class AsteroidCollision
{
    public int[] Solution(int[] asteroids)
    {
        var seenAsteroids = new Stack<int>(asteroids.Length);
        var lastSeenAsteroidSign = false;//true: +, false: -

        foreach (var asteroid in asteroids)
        {
            if (asteroid > 0 || !lastSeenAsteroidSign)//positive asteroid or negative last seen asteroid
            {
                seenAsteroids.Push(asteroid);
                lastSeenAsteroidSign = asteroid > 0;
            }
            else if (lastSeenAsteroidSign)//negative asteroid and positive last seen asteroid
            {
                bool saveCurrentAsteroid = true;
                while (seenAsteroids.Count > 0)
                {
                    var seenAsteroid = seenAsteroids.Pop();

                    if (seenAsteroid < 0)
                    {
                        seenAsteroids.Push(seenAsteroid);
                        saveCurrentAsteroid = true;
                        break;
                    }

                    lastSeenAsteroidSign = true;

                    if (seenAsteroid > Math.Abs(asteroid))
                    {
                        seenAsteroids.Push(seenAsteroid);
                        saveCurrentAsteroid = false;
                        break;
                    }
                    else if (seenAsteroid < Math.Abs(asteroid))
                    {
                        saveCurrentAsteroid = true;
                    }
                    else//equals
                    {
                        saveCurrentAsteroid = false;
                        break;
                    }
                }

                if (saveCurrentAsteroid)
                {
                    seenAsteroids.Push(asteroid);
                    lastSeenAsteroidSign = false;
                }
            }
        }

        //Convert stack to array
        var result = new int[seenAsteroids.Count];
        for (int i = seenAsteroids.Count - 1; i >= 0; i--)
        {
            result[i] = seenAsteroids.Pop();
        }

        return result;
    }
}