int count = GetStudentCount();

string[] firstNames = new string[count];
string[] lastNames = new string[count];
int[] midterms = new int[count];
int[] finals = new int[count];
string[] letterGrades = new string[count];
DateTime[] date = new DateTime[count];

GetStudentData(firstNames, lastNames, midterms, finals);
CalculateLetterGrade(midterms, finals, letterGrades);
Display();
int GetStudentCount()
{
    Console.Write("Enter student count: ");
    int studentCount = int.Parse(Console.ReadLine());
    return studentCount;
}

void GetStudentData(string[] firstName,
    string[] lastName,
    int[] midterm,
    int[] final)
{
    for (int i = 0; i < firstName.Length; i++)
    {
        Console.Write($"{i}. student firstname: ");
        firstName[i] = Console.ReadLine();
        Console.Write($"{i}. student lastname: ");
        lastName[i] = Console.ReadLine();
        Console.Write($"{i}. student midterm: ");
        midterm[i] = int.Parse(Console.ReadLine());
        Console.Write($"{i}. student final: ");
        final[i] = int.Parse(Console.ReadLine());

        date[i] = DateTime.Now;
    }
}

void CalculateLetterGrade(int[] midterm,
    int[] final,
    string[] letterGrade)
{
    for (int i = 0; i < midterm.Length; i++)
    {
        float grade = (0.4f * midterm[i]) + (0.6f * final[i]);

        if (grade > 85)
        {
            letterGrade[i] = "AA";
        }
        else if (grade > 69)
        {
            letterGrade[i] = "BB";
        }
        else if (grade > 49)
        {
            letterGrade[i] = "CC";
        }
        else
        {
            letterGrade[i] = "FF";
        }
    }
}

void Display()
{
    for (int i = 0; i < firstNames.Length; i++)
    {
        Console.WriteLine($"{date[i]} - {firstNames[i]} {lastNames[i]} - {letterGrades[i]}");
    }
}