class PlusMinus
{
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
        var ratio = new List<double>() { };

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