using System.Text.Json.Serialization;

namespace SchoolAPI.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LessonCode { get; set; }
        public int TeacherId { get; set; }

        [JsonIgnore]
        public Teacher Teacher { get; set; }
        [JsonIgnore]
        public ICollection<StudentLesson> StudentLessons { get; set; }
    }
}
