char  CheckGrade(int grade)
{
    if (grade >= 90) return 'A';
    else if (grade >= 80) return 'B';
    else if (grade >= 70) return 'C';
    else if (grade >= 60) return 'D';
    else return 'F';
}
int grade = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CheckGrade(grade));