using LibraryAPI.Datas;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly AppDbContext _context;

    public BookController(AppDbContext context)
    {
        _context = context;
    }

    // GET all books
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var books = await _context.Books.ToListAsync();
        return Ok(books);
    }

    // GET one book
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var book = await _context.Books.Where(book => book.Id.Equals(id)).ToListAsync();
        if (book == null) return NotFound();
        return Ok(book);
    }

    // CREATE
    [HttpPost]
    public async Task<IActionResult> Create(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
    }
}
