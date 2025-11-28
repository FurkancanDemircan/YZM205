public enum DifficultyLevel
{
    Beginner,
    Intermediate,
    Advance
}

public abstract class LearningItem
{
    private static int _globalId = 0;

    public int Id { get; set; }
    public string Title { get; set; }
    public DifficultyLevel Level { get; set; }

    protected LearningItem(string title, DifficultyLevel level)
    {
        Id = _globalId++;
        Title = title;
        Level = level;
    }

    public abstract int GetDurationMinutes();

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Id: {Id} - Title: {Title} – Level: {Level}");
    }
}