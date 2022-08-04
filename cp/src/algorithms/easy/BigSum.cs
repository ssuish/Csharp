class BigSum
{
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
}