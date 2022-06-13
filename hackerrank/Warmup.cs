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

        /*
        Calculate and print the sum of the elements in an array.
        WARNING: some of those integers may be quite large.
        */
        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;

            for (int i = 0; i < ar.Count; i++)
                sum += ar[i];

            return sum;
        }

        /*
            Given a square matrix, calculate the absolute difference between the sums of its diagonals.
            Sample:
            11 2 4
            4 5 6
            10 8 -12

            x-diagonal = 11 5 -12 = 4
            y-diagonal = 4 5 10 = 19
            abs-result = |4 - 19| = 15
        */
        public int diagonalDifference(List<List<int>> arr)
        {
            var xdiag = new List<int>();
            var ydiag = new List<int>();
            int j = arr.Count - 1;
            int xtotal = 0;
            int ytotal = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                xdiag.Add(arr[i][i]);
                ydiag.Add(arr[i][j]);
                j--;
            }

            foreach (int sum in xdiag)
                xtotal += sum;
            foreach (int sum in ydiag)
                ytotal += sum;

            return Math.Abs(xtotal - ytotal);
        }

        /*
            Given an array of integers, calculate the ratios of its elements 
            that are positive, negative, and zero. Print the decimal value 
            of each fraction on a new line with 6 places after the decimal.
        */
        public void plusMinus(List<int> arr)
        {
            double pos = 0;
            double neg = 0;
            double zero = 0;
            var ratio = new List<double>(){};

            foreach (int i in arr)
            {
                if (i > 0)
                {
                    pos++;
                }
                else if (0 > i)
                {
                    neg++;
                }
                else if (i == 0)
                {
                    zero++;
                }
            }

            ratio.Add(pos / arr.Count);
            ratio.Add(neg / arr.Count);
            ratio.Add(zero / arr.Count);

            foreach (double i in ratio)
            {
                Console.WriteLine(i.ToString("N6"));
            }
        }
    }
}