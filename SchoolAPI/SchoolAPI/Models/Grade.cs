using System.Text.Json.Serialization;

namespace SchoolAPI.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public decimal Midterm { get; set; }
        public decimal Final { get; set; }

        public string LetterGrade { get; set; }

        public int StudentId { get; set; }
        public int LessonId { get; set; }


        public Student Student { get; set; }

        public Lesson Lesson { get; set; }

        public void CalculateGrade()
        {
            var WeightedSum = (Midterm * 40) / 100 + (Final * 60) / 100;
            if (WeightedSum > 85) LetterGrade = "AA";
            else if (WeightedSum > 75) LetterGrade = "BB";
            else if (WeightedSum > 60) LetterGrade = "CC";
            else LetterGrade = "FF";
        }
    }
}
