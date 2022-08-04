class CountOdds
{
    /*
        Given two non-negative integers low and high. 
        Return the count of odd numbers between low and high (inclusive).
    */
    public int CountOdd(int low, int high)
    {
        int num = 0;
        while (high >= low)
        {
            if (low % 2 != 0)
            {
                num++;
            }
            low++;
        }
        return num;
    }
}