// Implementation of Algorithms

/*
    Grading System
    Parameters: int[n] of grades before rounding off.
    Returns: int[n] of grades after rounding off.
    Constraints: 1 <= n <= 60; 0 < int[n] < 100.

    Instruction:
    ~ student grades recieves from 0 - 100.
    ~ any grade < 40 is a failing grade.
    ~ if (grades - nearest multiple of 5) < 3, round the
    grade up to next multiple of 5.
    ~ if grades < 38, no rounding off.


class GradeScores
{
    private static List<int> studentGrades = new List<int>();

    private static int GetNearestMultiple(int grade)
    {
        // Find nearest multiple of 5 of grade. 
        const int multiple = 5;
        int nearestMultiple = grade;

        if (grade < multiple)
            return grade;

        nearestMultiple = grade + multiple/2;
        nearestMultiple -= (nearestMultiple % multiple);
        return nearestMultiple;
    }

    public static List<int> gradingStudents(List<int> grades)
    {
        int multiple = 0;

        foreach (int grade in grades)
        {
            multiple = GetNearestMultiple(grade);
            int difference = 0;
            
            if (grade < 38)
            {
                studentGrades.Add(grade);
            }
            else if (grade > multiple) 
            {
                multiple += 5;
                difference = multiple - grade;
                if (difference < 3)
                {
                    studentGrades.Add(multiple);
                }
                else
                {
                    studentGrades.Add(grade);
                }
            }
            else if (grade < multiple)
            {
                difference = multiple - grade;
                if (difference < 3)
                {
                    studentGrades.Add(multiple);
                }
                else
                {
                    studentGrades.Add(grade);
                }
            }
        }

        return studentGrades;
    }
}

============= Unsolved! ================
*/

/*
    Function Squares
    Parameters: int a = lower bound, int b = upper bound.
    Returns: int: number of square integers in the range.

    Instruction:
    It should return an integer representing the number of 
    square integers in the inclusive range from a to b.
*/