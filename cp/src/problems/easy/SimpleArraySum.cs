class SimpleArraySum
{
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