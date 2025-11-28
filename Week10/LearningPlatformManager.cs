public class LearningPlatformManager
{
    public static int TotalCourseCreated { get; private set; } = 0;
    private List<Course<LearningItem>> courses = new List<Course<LearningItem>>();

    public Course<LearningItem> CreateCourse(Course<LearningItem> course)
    {
        // var newCourse = new Course<LearningItem>(name);
        courses.Add(course);
        TotalCourseCreated++;
        return course;
    }

    public void ShowAllCourse() => courses.ForEach(item => item.ShowCourseDetail());
}
