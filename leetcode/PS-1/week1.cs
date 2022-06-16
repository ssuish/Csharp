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


        return 0;
    }

    /*
        Given an integer number n, return the difference between 
        the product of its digits and the sum of its digits.
    */
    public int SubtractProductAndSum(int n)
    {
        
        
        return 0;
    }
}