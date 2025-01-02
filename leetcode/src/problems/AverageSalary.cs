class AverageSalary
{
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
}