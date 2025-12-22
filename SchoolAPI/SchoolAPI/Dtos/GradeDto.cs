namespace SchoolAPI.Dtos
{
    public class GradeDto
    {
        public decimal Midterm { get; set; }
        public decimal Final { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
    }
}
