class MiniMaxSum
{
    /*
        Given five positive integers, find the minimum and maximum values that 
        can be calculated by summing exactly four of the five integers. Then 
        print the respective minimum and maximum values as a single line of two 
        space-separated long integers.
    */

    private List<int> toSum = new List<int>();

    private double Sum()
    {
        double sum = 0;
        for (int i = 0; i < toSum.Count; i++)
        {
            sum += toSum[i];
        }
        return sum;
    }

    public void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        toSum = arr;
        Console.WriteLine($"{Sum() - arr[arr.Count - 1]} {Sum() - arr[0]}");
    }
}