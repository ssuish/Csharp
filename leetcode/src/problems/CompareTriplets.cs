class CompareTriplets
{
    /*
        The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), 
        and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).

        The task is to find their comparison points by comparing 
        a[0] with b[0], a[1] with b[1], and a[2] with b[2].
        => If a[i] > b[i], then Alice is awarded 1 point.
        => If a[i] < b[i], then Bob is awarded 1 point. 
        => If a[i] = b[i], then neither person receives a point.

        Comparison points is the total points a person earned.
        Given a and b, determine their respective comparison points.
    */
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var scores = new List<int>();
        int alice = 0;
        int bob = 0;

        if (1 <= a.Count() && a.Count() <= 100)
            if (1 <= b.Count() && a.Count() <= 100)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] > b[i])
                    {
                        alice++;
                    }
                    else if (b[i] > a[i])
                    {
                        bob++;
                    }
                }

                scores.Add(alice);
                scores.Add(bob);
            }

        return scores;
    }
}