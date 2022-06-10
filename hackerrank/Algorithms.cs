namespace hackerrank
{
    public class WarmUp_Algorithms
    {
        static int SolveMeFirst(int a, int b)
        {
            if (1 <= a && a <= 1000)
                if (1 <= b && b <= 1000)
                    return a + b;

            return 0;
        }

        static int simpleArraySum(List<int> ar)
        {
            if (0 < ar.Count() && ar.Count() <= 1000)
            {
                int total = 0;
                foreach (int sum in ar)
                    total += sum;

                return total;
            }

            return 0;
        }

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
}