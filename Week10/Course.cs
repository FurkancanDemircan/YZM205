public class Course<T> where T : LearningItem
{
    private List<T> contents;
    public string Name { get; set; }

    public Course(string name)
    {
        contents = new List<T>();
        Name = name;
    }

    public void AddContent(T item)
    {
        contents.Add(item);
    }

    public int GetTotalDuration()
    {
        int total = 0;
        foreach (var item in contents)
        {
            total += item.GetDurationMinutes();
        }
        // contents.Sum(item => item.GetDurationMinutes());
        // contents.ForEach(item => { total += item.GetDurationMinutes(); });
        return total;
    }

    public void ShowCourseDetail()
    {
        Console.WriteLine($"Course Name: {Name} - Total Duration: {GetTotalDuration()}");
        contents.ForEach(item => { item.ShowInfo(); });
    }
}
