public class Quiz : LearningItem
{
    public int QuestionCount { get; private set; }
    public int QuestionTime { get; private set; }

    public Quiz(string title, DifficultyLevel level, int questionCount, int questionTime) : base(title, level)
    {
        QuestionCount = questionCount;
        QuestionTime = questionTime;
    }

    public override int GetDurationMinutes() => QuestionCount * QuestionTime;

    public override void ShowInfo()
    {
        Console.WriteLine($"Quiz Title: {Title} – Level of Quiz: {Level} – Number of Questions: {QuestionCount} – Total Duration: {GetDurationMinutes()} min");
    }
}


