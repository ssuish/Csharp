namespace Grade_Calculator
{
    public partial class FormMidtermCalculator : Form
    {
        public FormMidtermCalculator()
        {
            InitializeComponent();
        }

        private double quizAve, asAve, examAve, laAve, midtermGrade;

        private void buttonComputeGrade_Click(object sender, EventArgs e)
        {
            double quiz1, quiz2, as1, as2, exam, la1, la2, la3, la4;
            try
            {
                // Quizzes 25%
                quiz1 = double.Parse(textBoxQuiz1.Text);
                quiz2 = double.Parse(textBoxQuiz2.Text);

                // Assignment 20%
                as1 = double.Parse(textBoxAS1.Text);
                as2 = double.Parse(textBoxAS2.Text);

                // Midterm Exam 30%
                exam = double.Parse(textBoxExam.Text);

                // Lab Activities 25%
                la1 = double.Parse(textBoxLA1.Text);
                la2 = double.Parse(textBoxLA2.Text);
                la3 = double.Parse(textBoxLA3.Text);
                la4 = double.Parse(textBoxLA4.Text);

                quizAve = Math.Round(((quiz1 + quiz2) / 80 * 100) * 0.25);
                asAve = Math.Round(((as1 + as2) / 2) * 0.20);
                examAve = Math.Round(((exam / 40) * 100) * 0.30);
                laAve = Math.Round(((la1 + la2 + la3 + la4) / 4) * 0.25);
                midtermGrade = Math.Round(quizAve + asAve + examAve + laAve);

                if (!checkInputIfInvalid())
                {
                    textBoxQuizAve.Text = quizAve.ToString();
                    textBoxASAverage.Text = asAve.ToString();
                    textBoxExamAverage.Text = examAve.ToString();
                    textBoxLAAverage.Text = laAve.ToString();
                    labelResultMTGrade.Text = midtermGrade.ToString();
                }

                switch (midtermGrade)
                {
                    case < 70:
                        labelLetterGrade.Text = "F";
                        labelGradeRemarks.Text = "5.00";
                        break;

                    case >= 70 when midtermGrade <= 72:
                        labelLetterGrade.Text = "D";
                        labelGradeRemarks.Text = "3.00";
                        break;

                    case >= 73 when midtermGrade <= 75:
                        labelLetterGrade.Text = "C-";
                        labelGradeRemarks.Text = "2.75";
                        break;

                    case >= 76 when midtermGrade <= 78:
                        labelLetterGrade.Text = "C";
                        labelGradeRemarks.Text = "2.50";
                        break;

                    case >= 79 when midtermGrade <= 81:
                        labelLetterGrade.Text = "C+";
                        labelGradeRemarks.Text = "2.25";
                        break;

                    case >= 82 when midtermGrade <= 84:
                        labelLetterGrade.Text = "B-";
                        labelGradeRemarks.Text = "2.00";
                        break;

                    case >= 85 when midtermGrade <= 88:
                        labelLetterGrade.Text = "B";
                        labelGradeRemarks.Text = "1.75";
                        break;

                    case >= 89 when midtermGrade <= 92:
                        labelLetterGrade.Text = "B+";
                        labelGradeRemarks.Text = "1.50";
                        break;

                    case >= 93 when midtermGrade <= 96:
                        labelLetterGrade.Text = "A-";
                        labelGradeRemarks.Text = "1.25";
                        break;

                    case >= 97 when midtermGrade <= 100:
                        labelLetterGrade.Text = "A";
                        labelGradeRemarks.Text = "1.00";
                        break;

                    default:
                        labelLetterGrade.Text = "Error";
                        labelGradeRemarks.Text = "Error";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fatal error occured.\n" + ex);
            }
        }

        private bool checkInputIfInvalid()
        {
            try
            {
                string cap, msg;

                if (!(quizAve >= 0 && quizAve <= 25))
                {
                    cap = "Invalid Input";
                    msg = "Input in quizzes is invalid!";
                    MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else if (!(asAve >= 0 && asAve <= 20))
                {
                    cap = "Invalid Input";
                    msg = "Input in assignment is invalid!";
                    MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else if (!(examAve >= 0 && examAve <= 30))
                {
                    cap = "Invalid Input";
                    msg = "Input in exam is invalid!";
                    MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else if (!(laAve >= 0 && laAve <= 25))
                {
                    cap = "Invalid Input";
                    msg = "Input in laboratory activities is invalid! " + laAve;
                    MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else if (!(midtermGrade >= 0 && midtermGrade <= 100))
                {
                    cap = "Invalid Input";
                    msg = "Midterm grade is less than 0 or more than 100!";
                    MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fatal error occured.\n" + ex);
                return false;
            }

            return false;
        }
    }
}
