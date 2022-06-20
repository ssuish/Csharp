namespace leetcode;

public class Week1
{
    /*
        Day 1 - Basic Data Type
        !!OPTIMAL SOLUTIONS MATTER!!

        Given two non-negative integers low and high. 
        Return the count of odd numbers between low and high (inclusive).
    */
    public int CountOdds(int low, int high)
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
    /*
        You are given an array of unique integers salary where salary[i] 
        is the salary of the ith employee.
        Return the average salary of employees excluding the minimum 
        and maximum salary. Answers within 10-5 of the actual answer 
        will be accepted.
    */
    public double Average(int[] salary)
    {
        int low = salary[0];
        int high = salary[0];
        int sum = 0;

        foreach (int i in salary)
        {
            if (i >= high)
            {
                high = i;
            }
            else if (i <= low)
            {
                low = i;
            }
            sum += i;
        }
        return (sum - high - low) / (salary.Length - 2);
    }

    /*
        Write a function that takes an unsigned 
        integer and returns the number of '1' bits 
        it has (also known as the Hamming weight).
    */
    public int HammingWeight(uint n)
    {
        Int32 weight = 0;
        string bin = n.ToString();
        foreach (char i in bin)
        {
            if (i == '1')
                weight++;
        }
        return weight;
    }

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

    /*
        You are given two integers, x and y, which represent your current location 
        on a Cartesian grid: (x, y). You are also given an array points where each 
        points[i] = [ai, bi] represents that a point exists at (ai, bi). A point 
        is valid if it shares the same x-coordinate or the same y-coordinate as 
        your location.

        Return the index (0-indexed) of the valid point with the smallest Manhattan 
        distance from your current location. If there are multiple, return the valid 
        point with the smallest index. If there are no valid points, return -1.

        The Manhattan distance between two points (x1, y1) and (x2, y2) is 
        abs(x1 - x2) + abs(y1 - y2).
    */
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        return 0;
    }
}