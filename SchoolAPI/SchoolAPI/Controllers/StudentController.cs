using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Dtos;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly Data.AppContext _context;

        public StudentController(Data.AppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _context.Students.ToList();
            if(result.Count <= 0) return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            var result = _context.Students.FirstOrDefault(x => x.Id == id);
            if(result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] StudentDto student)
        {
            var newData = new Student()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
            };
            _context.Students.Add(newData);
            _context.SaveChanges();
            return Created();
        }
    }
}
