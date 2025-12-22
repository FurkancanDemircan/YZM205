using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Dtos;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly SchoolAPI.Data.AppContext _context;

        public TeacherController(Data.AppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var result = _context.Teachers.ToList();
            if (result.Equals(null)) // result == null
                return NotFound(); // Status Code: 404
            return Ok(result); // Status Code: 200
        }

        [HttpGet("{id}")]
        public ActionResult GetByTeacherId(int id)
        {
            var result = _context.Teachers.FirstOrDefault(t => t.Id == id);
            if (result == null) return NotFound();
            return Ok(result);
            /*
            foreach (var t in _context.Teachers)
            {
                if (t.Id.Equals(id))
                    return Ok(t);
            }

            return NotFound();
            */
        }

        [HttpPost]
        public IActionResult CreateTeacher([FromBody] TeacherDto teacher)
        {
            var newData = new Teacher()
            {
                FirstName = teacher.FirstName,
                LastName = teacher.LastName
            };
            _context.Teachers.Add(newData);
            _context.SaveChanges();
            return Created();
        }
    }
}
