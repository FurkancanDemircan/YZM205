using Week11.Interfaces;
using Week11.Models;
using Microsoft.AspNetCore.Mvc;

namespace Week11.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParksController : ControllerBase, IController
    {
        private readonly IParkRepository _repository;

        public ParksController(IParkRepository repository)
        {
            _repository = repository;
        }

        // READ - Get All Parks
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var parks = await _repository.GetAllAsync();
            return Ok(parks);
        }

        // READ - Get Park by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var park = await _repository.GetByIdAsync(id);
            return park == null ? NotFound() : Ok(park);
        }

        // CREATE - Add National Park (concrete type)
        [HttpPost("national")]
        public async Task<IActionResult> CreateNationalPark([FromBody] NationalPark park)
        {
            var created = await _repository.AddAsync(park);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // CREATE - Add City Park (concrete type)
        [HttpPost("city")]
        public async Task<IActionResult> CreateCityPark([FromBody] CityPark park)
        {
            var created = await _repository.AddAsync(park);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // UPDATE - Update any park type
        [HttpPut("{id}/national")]
        public async Task<IActionResult> UpdateNationalPark(int id, [FromBody] NationalPark park)
        {
            if (id != park.Id) return BadRequest();
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null) return NotFound();
            var updated = await _repository.UpdateAsync(park);
            return Ok(updated);
        }

        [HttpPut("{id}/city")]
        public async Task<IActionResult> UpdateCityPark(int id, [FromBody] CityPark park)
        {
            if (id != park.Id) return BadRequest();
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null) return NotFound();
            var updated = await _repository.UpdateAsync(park);
            return Ok(updated);
        }

        // DELETE - Delete Park
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _repository.DeleteAsync(id);
            return success ? NoContent() : NotFound();
        }

        // Business Operations
        [HttpPost("{id}/visitors/add/{count}")]
        public async Task<IActionResult> AddVisitors(int id, int count)
        {
            var success = await _repository.AddVisitorsAsync(id, count);
            if (!success)
                return BadRequest("Park is full or doesn't exist");
            var park = await _repository.GetByIdAsync(id);
            return Ok(new { Message = "Visitors added", park.CurrentVisitors });
        }

        [HttpPost("{id}/visitors/remove/{count}")]
        public async Task<IActionResult> RemoveVisitors(int id, int count)
        {
            await _repository.RemoveVisitorsAsync(id, count);
            var park = await _repository.GetByIdAsync(id);
            return Ok(new { Message = "Visitors removed", park?.CurrentVisitors });
        }

        [HttpGet("{id}/fee/{visitors}")]
        public async Task<IActionResult> CalculateFee(int id, int visitors)
        {
            var fee = await _repository.CalculateFeeAsync(id, visitors);
            return Ok(new { ParkId = id, Visitors = visitors, EntryFee = fee });
        }
    }

}
