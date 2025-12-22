using System.Text.Json.Serialization;

namespace SchoolAPI.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Lesson> Lessons { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
