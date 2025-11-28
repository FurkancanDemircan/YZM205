public class VideoLesson : LearningItem
{
    public int DurationMinutes { private get; set; }

    public VideoLesson(string title, DifficultyLevel level, int durationMinutes)
    : base(title, level)
    {
        DurationMinutes = durationMinutes;
    }

    public override int GetDurationMinutes() => DurationMinutes;

    public override void ShowInfo()
    {
        Console.WriteLine($"Video Title: {Title} - Level of Video: {Level} - Duration: {GetDurationMinutes()} min");
    }
}


