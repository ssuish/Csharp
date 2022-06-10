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
    }
}