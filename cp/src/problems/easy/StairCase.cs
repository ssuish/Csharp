class StairCase
{
    /*
        Its base and height are both equal to n. It is drawn using # symbols and spaces. 
        The last line is not preceded by any spaces.
        Write a program that prints a staircase of size n.

        NOTES: the triangle is right-aligned.
    */
    public void staircase(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j < n - i - 1)
                    Console.Write(" ");
                else
                    Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}