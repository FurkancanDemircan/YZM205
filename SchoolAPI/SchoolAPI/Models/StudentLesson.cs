using System.Text.Json.Serialization;

namespace SchoolAPI.Models
{
    public class StudentLesson
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }

        [JsonIgnore]
        public Student Student { get; set; }
        [JsonIgnore]
        public Lesson Lesson { get; set; }
    }
}
