using Hackerrank.Algorithms;

var grades = new List<int>(){
    73, 67, 38, 33, 58, 37
};

var finalgrade = GradeScores.gradingStudents(grades);

foreach(int grade in finalgrade)
{
    Console.WriteLine(grade);
}