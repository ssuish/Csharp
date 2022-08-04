class DiagonalDiff
{
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
}