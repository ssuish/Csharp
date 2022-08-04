class ProductSum
{
    /*
        Given an integer number n, return the difference between 
        the product of its digits and the sum of its digits.
    */
    public List<int> numl = new List<int>();

    public void ToList(int n)
    {
        string temp = n.ToString();
        for (int i = 0; i < temp.Length; i++)
        {
            numl.Add(temp[i] - '0');
        }
    }

    public int SumNum(int n)
    {
        int sum = 0;
        for (int i = 0; i < numl.Count; i++)
            sum += numl[i];
        return sum;
    }

    public int ProductNum(int n)
    {
        int prod = 1;
        for (int i = 0; i < numl.Count; i++)
            prod *= numl[i];
        return prod;
    }

    public int SubtractProductAndSum(int n)
    {
        ToList(n);
        return ProductNum(n) - SumNum(n);
    }
}