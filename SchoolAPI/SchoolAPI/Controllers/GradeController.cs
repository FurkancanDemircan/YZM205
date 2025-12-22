using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Dtos;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GradeController : ControllerBase
    {
        private readonly SchoolAPI.Data.AppContext _context;

        public GradeController(Data.AppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _context.Grades.ToList();
            if (result.Count.Equals(0)) return NotFound();
            return Ok(result);
        }

        [HttpGet("lessons/{id}")]
        public IActionResult GetByLessonId(int id)
        {
            // SELECT SCHOOL FROM GRADES WHERE ID==ID;
            // var query = $"select school from grades where id=={id};";
            var result = _context.Grades.Where(l => l.LessonId.Equals(id)).ToList();
            if (result.Count <= 0) return NotFound();
            return Ok(result);
        }

        [HttpGet("students/{id}")]
        public IActionResult GetByStudentId(int id)
        {
            var result = _context.Grades.Where(s => s.StudentId.Equals(id)).ToList();
            if (result.Count <= 0) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddGrade([FromBody] GradeDto grade)
        {
            var lesson = _context.Lessons.FirstOrDefault(l => l.Id.Equals(grade.LessonId));
            var student = _context.Students.FirstOrDefault(s => s.Id.Equals(grade.StudentId));

            if (lesson == null && student == null) return NotFound();

            var newGrade = new Grade()
            {
                LessonId = lesson.Id,
                StudentId = student.Id,
                Midterm = grade.Midterm,
                Final = grade.Final
            };
            newGrade.CalculateGrade();
            _context.Grades.Add(newGrade);
            _context.SaveChanges();
            return Created();
        }
    }
}
